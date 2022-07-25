﻿#region Copyright

/////////////////////////////////////////////////////////////////////////////
//    Altaxo:  a data processing and data plotting program
//    Copyright (C) 2014 Dr. Dirk Lellinger
//
//    This program is free software; you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation; either version 2 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program; if not, write to the Free Software
//    Foundation, Inc., 675 Mass Ave, Cambridge, MA 02139, USA.
//
/////////////////////////////////////////////////////////////////////////////

#endregion Copyright

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Altaxo.Collections
{
  /// <summary>
  /// Represents an tokenized concurrent priority queue. Inserted items are associated with a token that can later be used to modify the item in the queue.
  /// There are two function sets to add queue items, depending on whether or not the queue is generating tokens by itself. Use Enqueue... functions, if the tokens are generated by the queue itself, or use Add.. functions if you provide the token.
  /// </summary>
  /// <typeparam name="TKey">The type of the key.</typeparam>
  /// <typeparam name="TValue">The type of the value.</typeparam>
  /// <typeparam name="TToken">The type of the token.</typeparam>
  public class ConcurrentTokenizedPriorityQueue<TKey, TValue, TToken> where TKey : IComparable<TKey> where TToken : notnull
  {
    #region Inner structs

    private struct Item
    {
      internal TKey Key;

      internal TValue Value;

      /// <summary>Designates the current position (index) of this element in the heap, i.e. in the _elements array.</summary>
      internal int HeapPosition;

      internal Item ModifyHeapPosition(int i)
      {
        HeapPosition = i;
        return this;
      }

      internal Item ModifyKey(TKey key)
      {
        Key = key;
        return this;
      }

      internal Item ModifyValue(TValue value)
      {
        Value = value;
        return this;
      }

      /// <summary>
      /// Returns a <see cref="string" /> for debugging purposes.
      /// </summary>
      /// <returns>
      /// A <see cref="string" /> that represents this instance.
      /// </returns>
      public override string ToString()
      {
        return string.Format("HeapPos={0}, Key={1}, Value={2}", HeapPosition, Key, Value);
      }
    }

    #endregion Inner structs

    #region Members

    /// <summary>
    /// The number of elements in this queue.
    /// </summary>
    private int _count;

    /// <summary>Elements of the priority queue organized as binary heap. Each element doesn't hold the item directly. Instead, it holds a token that is used to retrieve the item from <see cref="_tokenToItem"/> dictionary.</summary>
    private TToken[] _heap;

    ///<summary> Dictionary that associated the tokens with the items. The items hold key and value as well as an integer value that designates the position in the <see cref="_heap"/> heap.</summary>
    private Dictionary<TToken, Item> _tokenToItem;

    /// <summary>The next token to give out.</summary>
    [AllowNull]
    private TToken _nextToken;

    /// <summary>Function that creates a new token. Argument is the old token. Return value should be a new token, which is different from all tokens created so far.</summary>
    private Func<TToken, TToken>? _GetNextToken;

    /// <summary>Object used to synchronize this queue.</summary>
    private System.Threading.ReaderWriterLockSlim _syncLock = new System.Threading.ReaderWriterLockSlim();

    #endregion Members

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="ConcurrentTokenizedPriorityQueue{TKey, TValue, TToken}"/> class. This instance is not configured to generate tokens by itself, thus you must
    /// use the TryAdd(..) functions to enqueue items.
    /// </summary>
    public ConcurrentTokenizedPriorityQueue()
      : this(64, default, null)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ConcurrentTokenizedPriorityQueue{TKey, TValue, TToken}"/> class. This instance is not configured to generate tokens by itself, thus you must
    /// use the TryAdd(..) functions to enqueue items.
    /// </summary>
    /// <param name="initialCapacity">The initial capacity of the queue.</param>
    public ConcurrentTokenizedPriorityQueue(int initialCapacity)
      : this(initialCapacity, default, null)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ConcurrentTokenizedPriorityQueue{TKey, TValue, TToken}"/> class. When argument <paramref name="GetNextToken"/> is not null,
    /// the priority queue is generating new tokens by itself. In this case you should only use the Enqueue functions to enqueue items. In contrast, when <paramref name="GetNextToken"/> is null,
    /// the priority queue is not generating tokens by itself, and you have to use the TryAdd(..) functions to enqueue items.
    /// </summary>
    /// <param name="initialToken">The initial token.</param>
    /// <param name="GetNextToken">The function to generate new tokens. Argument is the old token. The return value should be a new token that was not generated before.</param>
    public ConcurrentTokenizedPriorityQueue(TToken initialToken, Func<TToken, TToken> GetNextToken)
      : this(64, initialToken, GetNextToken)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ConcurrentTokenizedPriorityQueue{TKey, TValue, TToken}"/> class. When argument <paramref name="GetNextToken"/> is not null,
    /// the priority queue is generating new tokens by itself. In this case you should only use the Enqueue functions to enqueue items. In contrast, when <paramref name="GetNextToken"/> is null,
    /// the priority queue is not generating tokens by itself, and you have to use the Add functions to enqueue items.
    /// </summary>
    /// <param name="capacity">The inital capacity of the priority queue.</param>
    /// <param name="initialToken">The initial token.</param>
    /// <param name="GetNextToken">The function to generate new tokens. Argument is the old token. The return value should be a new token that was not generated before.</param>
    /// <exception cref="System.ArgumentOutOfRangeException"></exception>
    public ConcurrentTokenizedPriorityQueue(int capacity, [AllowNull] TToken initialToken, Func<TToken, TToken>? GetNextToken)
    {
      if (capacity <= 0)
        throw new ArgumentOutOfRangeException();

      _heap = new TToken[capacity];
      _tokenToItem = new Dictionary<TToken, Item>();

      _nextToken = initialToken;
      _GetNextToken = GetNextToken;
    }

    #endregion Constructors

    #region Properties

    /// <summary>
    /// Gets the number of elements in the priority queue.
    /// </summary>
    /// <value>
    /// Number of elements in the priority queue.
    /// </value>
    public int Count
    {
      get
      {
        return _count;
      }
    }

    /// <summary>
    /// Gets a value indicating whether the priority queue is empty.
    /// </summary>
    /// <value><c>true</c> if the priority queue is empty; otherwise, <c>false</c>.</value>
    public bool IsEmpty
    {
      get
      {
        return _count == 0;
      }
    }

    #endregion Properties

    #region Enqueue / TryAdd

    /// <summary>
    /// Enqueues an item consisting of a key and a value. The priority queue has to be constructed to generate tokens by itself in order to use this function. Otherwise an exception is thrown.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    /// <param name="token">Returns a token associated with the enqueued key/value pair. The token can later be used to manipulate the entry in the queue.</param>
    /// <exception cref="System.InvalidOperationException">This queue is unable to generate tokens by itself. You have to construct the priority queue using a token generating function.</exception>
    public void Enqueue(TKey key, TValue value, out TToken token)
    {
      if (_GetNextToken is null)
        throw new InvalidOperationException("This queue is unable to generate tokens by itself. Use TryAdd(token, key, value) instead!");

      _syncLock.EnterWriteLock();
      try
      {
        token = InternalGetNewTokenNoLock();
        InternalEnqueueNoLock(token, key, value);
      }
      finally
      {
        _syncLock.ExitWriteLock();
      }
    }

    /// <summary>
    /// Tries to add the key/value pair associated with the provided <paramref name="token"/> to the queue. The queue must not be configured to generate tokens by itself.
    /// </summary>
    /// <param name="token">The token.</param>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    /// <returns><c>True</c> if the key/value pair could be added to the queue. False if the token already exists in the queue.</returns>
    /// <exception cref="System.InvalidOperationException">This queue is generating tokens by itself. Use Enqueue(key, value) instead!</exception>
    public bool TryAdd(TToken token, TKey key, TValue value)
    {
      if (!(_GetNextToken is null))
        throw new InvalidOperationException("This queue is generating tokens by itself. Use Enqueue(key, value) instead!");

      _syncLock.EnterWriteLock();
      try
      {
        if (!_tokenToItem.ContainsKey(token))
        {
          InternalEnqueueNoLock(token, key, value);
          return true;
        }
      }
      finally
      {
        _syncLock.ExitWriteLock();
      }
      return false;
    }

    #endregion Enqueue / TryAdd

    #region EnqueueOrUpdate / AddOrUpdate - Simple version

    /// <summary>
    /// Adds a key/value pair associated with a token to the queue (if no such token is already present), or updates the already present key/value pair associated with the provided token.
    /// </summary>
    /// <param name="key">The key that should be enqueued (if token not present in the queue) or updated (if token is already present in the queue).</param>
    /// <param name="value">The value that should be enqueued (if token not present in the queue) or updated (if token is already present in the queue).</param>
    /// <param name="token">The token used to identify key/value pairs in the queue.</param>
    /// <returns><c>True</c> if the key/value pair was freshly enqueued, or <c>false</c> if the token was already present in the queue, and therefore the key/value pair was updated.</returns>
    /// <exception cref="System.InvalidOperationException">This queue is generating tokens by itself. Use Enqueue(key, value) instead!</exception>
    public bool EnqueueOrUpdate(TKey key, TValue value, ref TToken token)
    {
      if (_GetNextToken is null)
        throw new InvalidOperationException("This queue is unable to generate tokens by itself. Use TryAdd(token, key, value) instead!");
      if (token is null)
        throw new ArgumentNullException(nameof(token));

      _syncLock.EnterWriteLock();
      try
      {
        if (_tokenToItem.TryGetValue(token, out var item))
        {
          // element exists already, thus update item
          InternalUpdateKeyNoLock(token, key); // meanwhile the item members probably have changed, especially ElementIndex
          _tokenToItem[token] = _tokenToItem[token].ModifyValue(value); // that's why we must re-read the item and change the value
          return false;
        }
        else
        {
          // element don't exist, thus add
          token = InternalGetNewTokenNoLock();
          InternalEnqueueNoLock(token, key, value);
          return false;
        }
      }
      finally
      {
        _syncLock.ExitWriteLock();
      }
    }

    /// <summary>
    /// Adds a key/value pair associated with a token to the queue (if no such token is already present), or updates the already present key/value pair associated with the provided token.
    /// </summary>
    /// <param name="token">The token.</param>
    /// <param name="key">The key that should be added or updated</param>
    /// <param name="value">The value that should be added or updated</param>
    /// <returns>True if the item was not present and therefore was added to the queue, false if the item was already present and therefore updated.</returns>
    /// <exception cref="System.InvalidOperationException">This queue is generating tokens by itself. Use Enqueue(key, value) instead!</exception>
    public bool AddOrUpdate(TToken token, TKey key, TValue value)
    {
      if (!(_GetNextToken is null))
        throw new InvalidOperationException("This queue is generating tokens by itself. Use Enqueue(key, value) instead!");

      _syncLock.EnterWriteLock();
      try
      {
        if (_tokenToItem.TryGetValue(token, out var item))
        {
          // element exists already, thus update item
          InternalUpdateKeyNoLock(token, key); // meanwhile the item members probably have changed, especially ElementIndex
          _tokenToItem[token] = _tokenToItem[token].ModifyValue(value); // that's why we must re-read the item and change the value
          return false;
        }
        else
        {
          // element don't exist, thus add
          InternalEnqueueNoLock(token, key, value);
          return true;
        }
      }
      finally
      {
        _syncLock.ExitWriteLock();
      }
    }

    #endregion EnqueueOrUpdate / AddOrUpdate - Simple version

    #region EnqueueOrUpdate / AddOrUpdate - Advanced version

    /// <summary>
    /// Adds a key/value pair associated with a token to the queue (if no such token is already present), or updates the already present key/value pair associated with the provided token.
    /// </summary>
    /// <param name="addValue">The key/value pair that should be enqueued if the provided <paramref name="token"/> is not present in the queue.</param>
    /// <param name="token">The token. On return, if the token was not in the queue, contains a new token that was freshly generated.</param>
    /// <param name="updateFactory">A function that generates a new key/value pair that should be used to update the key/value pair associated with the provided <paramref name="token"/> if it is already present in the queue.</param>
    /// <returns>The key/value pair that was used. Either the <paramref name="addValue"/>, or the key/value pair used for update.</returns>
    /// <exception cref="System.InvalidOperationException">This queue is generating tokens by itself. Use Enqueue(key, value) instead!</exception>
    public KeyValuePair<TKey, TValue> EnqueueOrUpdate(KeyValuePair<TKey, TValue> addValue, ref TToken token, Func<TToken, KeyValuePair<TKey, TValue>, KeyValuePair<TKey, TValue>> updateFactory)
    {
      if (_GetNextToken is null)
        throw new InvalidOperationException("This queue is unable to generate tokens by itself. Use TryAdd(token, key, value) instead!");

      _syncLock.EnterWriteLock();
      try
      {
        if (_tokenToItem.TryGetValue(token, out var item))
        {
          // element exists already, thus update item
          var newKeyValue = updateFactory(token, new KeyValuePair<TKey, TValue>(item.Key, item.Value));
          InternalUpdateKeyNoLock(token, newKeyValue.Key); // meanwhile the item members probably have changed, especially ElementIndex
          _tokenToItem[token] = _tokenToItem[token].ModifyValue(newKeyValue.Value); // that's why we must re-read the item and change the value
          return newKeyValue;
        }
        else
        {
          // element don't exist, thus add
          token = InternalGetNewTokenNoLock();
          InternalEnqueueNoLock(token, addValue.Key, addValue.Value);
          return addValue;
        }
      }
      finally
      {
        _syncLock.ExitWriteLock();
      }
    }

    /// <summary>
    /// Adds a key/value pair associated with a token to the queue (if no such token is already present), or updates the already present key/value pair associated with the provided token.
    /// </summary>
    /// <param name="token">The token.</param>
    /// <param name="addValue">The key/value pair that should be added if the provided <paramref name="token"/> is not present in the queue.</param>
    /// <param name="updateFactory">A function that generates a new key/value pair that should be used to update the key/value pair associated with the provided <paramref name="token"/> if it is already present in the queue.</param>
    /// <returns>The key/value pair that was used. Either the <paramref name="addValue"/>, or the key/value pair used for update.</returns>
    /// <exception cref="System.InvalidOperationException">This queue is generating tokens by itself. Use Enqueue(key, value) instead!</exception>
    public KeyValuePair<TKey, TValue> AddOrUpdate(TToken token, KeyValuePair<TKey, TValue> addValue, Func<TToken, KeyValuePair<TKey, TValue>, KeyValuePair<TKey, TValue>> updateFactory)
    {
      if (!(_GetNextToken is null))
        throw new InvalidOperationException("This queue is generating tokens by itself. Use Enqueue(key, value) instead!");

      _syncLock.EnterWriteLock();
      try
      {
        if (_tokenToItem.TryGetValue(token, out var item))
        {
          // element exists already, thus update item
          var newKeyValue = updateFactory(token, new KeyValuePair<TKey, TValue>(item.Key, item.Value));
          InternalUpdateKeyNoLock(token, newKeyValue.Key); // meanwhile the item members probably have changed, especially ElementIndex
          _tokenToItem[token] = _tokenToItem[token].ModifyValue(newKeyValue.Value); // that's why we must re-read the item and change the value
          return newKeyValue;
        }
        else
        {
          // element don't exist, thus add
          InternalEnqueueNoLock(token, addValue.Key, addValue.Value);
          return addValue;
        }
      }
      finally
      {
        _syncLock.ExitWriteLock();
      }
    }

    #endregion EnqueueOrUpdate / AddOrUpdate - Advanced version

    #region Peek functions

    /// <summary>
    /// Tries to retrieve the element with minimum key.
    /// </summary>
    /// <param name="key">On successfull return, contains the minimum key.</param>
    /// <param name="value">On successfull return, contains the value associated with the minimum key.</param>
    /// <param name="token">On successfull return, contains the token associated with the minimum key.</param>
    /// <returns><c>True</c> if the queue contained at least one element that could be Peek'd; otherwise <c>false</c>.</returns>
    public bool TryPeek([MaybeNullWhen(false)] out TKey key, [MaybeNullWhen(false)] out TValue value, [MaybeNullWhen(false)] out TToken token)
    {
      _syncLock.EnterReadLock();
      try
      {
        if (_count > 0)
        {
          token = _heap[0];
          var item = _tokenToItem[token];
          key = item.Key;
          value = item.Value;
          return true;
        }
      }
      finally
      {
        _syncLock.ExitReadLock();
      }

      key = default;
      value = default;
      token = default;
      return false;
    }

    /// <summary>
    /// Tries to retrieve the element with minimum key.
    /// </summary>
    /// <param name="key">On successfull return, contains the minimum key.</param>
    /// <param name="value">On successfull return, contains the value associated with the minimum key.</param>
    /// <returns><c>True</c> if the queue contained at least one element that could be Peek'd; otherwise <c>false</c>.</returns>
    public bool TryPeek([MaybeNullWhen(false)] out TKey key, [MaybeNullWhen(false)] out TValue value)
    {
      return TryPeek(out key, out value, out _);
    }

    /// <summary>
    /// Tries to retrieve the element with minimum key.
    /// </summary>
    /// <param name="key">On successfull return, contains the minimum key.</param>
    /// <returns><c>True</c> if the queue contained at least one element that could be Peek'd; otherwise <c>false</c>.</returns>
    public bool TryPeek([MaybeNullWhen(false)] out TKey key)
    {
      return TryPeek(out key, out _, out _);
    }

    public bool TryPeekKey([MaybeNullWhen(false)] out TKey key)
    {
      return TryPeek(out key, out _);
    }

    /// <summary>
    /// Determines whether an item with the specified associated token exists in the queue.
    /// </summary>
    /// <param name="token">The token.</param>
    /// <returns><c>True</c> if the provided token exists in the queue; otherwise <c>false</c>.</returns>
    public bool ContainsToken(TToken token)
    {
      _syncLock.EnterReadLock();
      try
      {
        return _tokenToItem.ContainsKey(token);
      }
      finally
      {
        _syncLock.ExitReadLock();
      }
    }

    #endregion Peek functions

    #region Dequeue functions

    /// <summary>
    /// Tries to dequeue the item with minimum key.
    /// </summary>
    /// <param name="key">On sucessfull return, contains the minimum key value.</param>
    /// <param name="value">On sucessfull return, contains value belonging to the minimum key value.</param>
    /// <param name="token">On successfull return, contains the token associated with the key/value pair with minimum key.</param>
    /// <returns><c>True if an item could be successfully retrieved from the queue; <c>false</c> if the queue contains no items.</c></returns>
    public bool TryDequeue([MaybeNullWhen(false)] out TKey key, [MaybeNullWhen(false)] out TValue value, [MaybeNullWhen(false)] out TToken token)
    {
      _syncLock.EnterUpgradeableReadLock();
      try
      {
        if (_count > 0)
        {
          _syncLock.EnterWriteLock();
          try
          {
            token = _heap[0];
            var item = _tokenToItem[token];
            key = item.Key;
            value = item.Value;

            Exchange(0, --_count);

            _tokenToItem.Remove(token);

            if (_count > 0)
              DownHeap(0);

            return true;
          }
          finally
          {
            _syncLock.ExitWriteLock();
          }
        }
      }
      finally
      {
        _syncLock.ExitUpgradeableReadLock();
      }

      token = default;
      key = default;
      value = default;
      return false;
    }

    /// <summary>
    /// Dequeues the item with minimum key. If the queue is empty, an exception will be thrown.
    /// </summary>
    /// <returns>The key/value pair with minimum key value.</returns>
    /// <exception cref="System.InvalidOperationException">Queue is empty.</exception>
    public (TKey Key, TValue Value) Dequeue()
    {
      if (TryDequeue(out var key, out var value, out var _))
        return (key, value);
      else
        throw new InvalidOperationException("Queue is empty");
    }

    #endregion Dequeue functions

    #region Get queue items by token

    /// <summary>
    /// Tries to get the key/value pair that is associated with the provided <paramref name="token"/>.
    /// </summary>
    /// <param name="token">The token.</param>
    /// <param name="key">On sucessfull return, contains the key of the key/value pair associated with the token.</param>
    /// <param name="value">On sucessfull return, contains the value of the key/value pair associated with the token.</param>
    /// <returns><c>True</c> if the key/value pair associated with the token existed in the queue. <c>False</c> if the a key/value pair associated with the provided token is not in the queue.</returns>
    public bool TryGet(TToken token, [MaybeNullWhen(false)] out TKey key, [MaybeNullWhen(false)] out TValue value)
    {
      _syncLock.EnterReadLock();
      try
      {
        if (_tokenToItem.TryGetValue(token, out var item))
        {
          key = item.Key;
          value = item.Value;
          return true;
        }
      }
      finally
      {
        _syncLock.ExitReadLock();
      }

      key = default;
      value = default;
      return false;
    }

    /// <summary>
    /// Tries to get the key/value pair that is associated with the provided <paramref name="token"/>.
    /// </summary>
    /// <param name="token">The token.</param>
    /// <param name="key">On sucessfull return, contains the key of the key/value pair associated with the token.</param>
    /// <returns><c>True</c> if the key/value pair associated with the token existed in the queue. <c>False</c> if the a key/value pair associated with the provided token is not in the queue.</returns>
    public bool TryGet(TToken token, [MaybeNullWhen(false)] out TKey key)
    {
      return TryGet(token, out key, out _);
    }

    #endregion Get queue items by token

    #region Change the key of queue items

    /// <summary>
    /// Tries to update the key associated with the provided <paramref name="token"/>. The value is left as is.
    /// </summary>
    /// <param name="token">The token associated with the key.</param>
    /// <param name="key">The new key.</param>
    /// <returns><c>True</c> if the key/value pair associated with the token still existed in the queue; otherwise <c>false</c>.</returns>
    public bool TryUpdateKey(TToken token, TKey key)
    {
      _syncLock.EnterUpgradeableReadLock();
      try
      {
        if (_tokenToItem.ContainsKey(token))
        {
          _syncLock.EnterWriteLock();
          try
          {
            InternalUpdateKeyNoLock(token, key);
          }
          finally
          {
            _syncLock.ExitWriteLock();
          }
          return true;
        }
      }
      finally
      {
        _syncLock.ExitUpgradeableReadLock();
      }
      return false;
    }

    /// <summary>
    /// Tries to change the key associated with the provided <paramref name="token"/>. The new key value has to be less than the existing one; otherwise an exception is thrown.
    /// </summary>
    /// <param name="token">The token associated with the key.</param>
    /// <param name="key">The new key.</param>
    /// <returns><c>True</c> if the item associated with the token still existed in the queue; otherwise <c>false</c>.</returns>
    /// <exception cref="System.InvalidOperationException">The new key was equal to or greater than the existing one.</exception>
    public bool TryDecreaseKey(TToken token, TKey key)
    {
      _syncLock.EnterUpgradeableReadLock();
      try
      {
        if (_tokenToItem.TryGetValue(token, out var item))
        {
          if (item.Key.CompareTo(key) <= 0)
            throw new InvalidOperationException("Calling decreaseKey() with given argument would not strictly decrease the key");

          _syncLock.EnterWriteLock();
          try
          {
            item.Key = key;
            _tokenToItem[token] = item;
            UpHeap(item.HeapPosition);
            return true;
          }
          finally
          {
            _syncLock.ExitWriteLock();
          }
        }
      }
      finally
      {
        _syncLock.ExitUpgradeableReadLock();
      }
      return false;
    }

    /// <summary>
    /// Tries to change the key associated with the provided <paramref name="token"/>. The new key value has to be greater than the existing one; otherwise an exception is thrown.
    /// </summary>
    /// <param name="token">The token.</param>
    /// <param name="key">The new key.</param>
    /// <returns><c>True</c> if the item associated with the token still existed in the queue; otherwise <c>false</c>.</returns>
    /// <exception cref="System.InvalidOperationException">The new key was equal to or less than the existing one.</exception>
    public bool TryIncreaseKey(TToken token, TKey key)
    {
      _syncLock.EnterUpgradeableReadLock();
      try
      {
        if (_tokenToItem.TryGetValue(token, out var item))
        {
          if (item.Key.CompareTo(key) >= 0)
            throw new InvalidOperationException("Calling increaseKey() with given argument would not strictly increase the key");

          _syncLock.EnterWriteLock();
          try
          {
            item.Key = key;
            _tokenToItem[token] = item;
            DownHeap(item.HeapPosition);
            return true;
          }
          finally
          {
            _syncLock.ExitWriteLock();
          }
        }
      }
      finally
      {
        _syncLock.ExitUpgradeableReadLock();
      }
      return false;
    }

    #endregion Change the key of queue items

    #region Remove queue items before they are enqueued

    /// <summary>
    /// Tries to remove the key/value pair associated with the provided <paramref name="token"/> from the queue (independently on the current position of the key/value pair in the queue).
    /// </summary>
    /// <param name="token">The token associated with the key/value pair to remove.</param>
    /// <param name="key">On successfull return, contains the key of the removed key/value pair.</param>
    /// <param name="value">On successfull return, contains the value of the removed key/value pair.</param>
    /// <returns><c>True</c> if the item still existed in the queue and could be successfully removed; otherwise <c>false</c>.</returns>
    public bool TryRemove(TToken token, [MaybeNullWhen(false)] out TKey key, [MaybeNullWhen(false)] out TValue value)
    {
      _syncLock.EnterUpgradeableReadLock();
      try
      {
        if (_tokenToItem.TryGetValue(token, out var item))
        {
          key = item.Key;
          value = item.Value;

          _syncLock.EnterWriteLock();
          try
          {
            int index = item.HeapPosition;
            Exchange(index, --_count);
            UpHeap(index);
            DownHeap(index);

            _tokenToItem.Remove(token);
            return true;
          }
          finally
          {
            _syncLock.ExitWriteLock();
          }
        }
      }
      finally
      {
        _syncLock.ExitUpgradeableReadLock();
      }

      key = default;
      value = default;
      return false;
    }

    /// <summary>
    /// Tries to remove the key/value pair associated with the provided <paramref name="token"/> from the queue (independently on the current position of the key/value pair in the queue).
    /// </summary>
    /// <param name="token">The token associated with the key/value pair to remove.</param>
    /// <param name="key">On successfull return, contains the key of the removed key/value pair.</param>
    /// <returns><c>True</c> if the item still existed in the queue and could be successfully removed; otherwise <c>false</c>.</returns>
    public bool TryRemove(TToken token, [MaybeNullWhen(false)] out TKey key)
    {
      return TryRemove(token, out key, out _);
    }

    /// <summary>
    /// Tries to remove the key/value pair associated with the provided <paramref name="token"/> from the queue (independently on the current position of the key/value pair in the queue).
    /// </summary>
    /// <param name="token">The token associated with the key/value pair to remove.</param>
    /// <returns><c>True</c> if the item still existed in the queue and could be successfully removed; otherwise <c>false</c>.</returns>
    public bool TryRemove(TToken token)
    {
      return TryRemove(token, out var _, out var _);
    }



    #endregion Remove queue items before they are enqueued

    #region Clear

    /// <summary>
    /// Removes all elements from this queue, resulting in an empty queue.
    /// </summary>
    public void Clear()
    {
      _syncLock.EnterWriteLock();
      try
      {
        _count = 0;
        _tokenToItem.Clear();
        Array.Clear(_heap, 0, _heap.Length);
      }
      finally
      {
        _syncLock.ExitWriteLock();
      }
    }

    #endregion Clear

    #region Helper functions (not locked)

    private TToken InternalGetNewTokenNoLock()
    {
      if (_GetNextToken is null)
        throw new InvalidOperationException("No token creation function was provided.");

      var result = _nextToken;
      _nextToken = _GetNextToken(_nextToken);
      return result;
    }

    /// <summary>
    /// Enqueues key value token pair with no locking. The provided token must not be already present (should be tested beforehand).
    /// </summary>
    /// <param name="token">The token.</param>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    private void InternalEnqueueNoLock(TToken token, TKey key, TValue value)
    {
      if (_count == _heap.Length)
        InternalResizeNoLock(_heap.Length * 2);

      _heap[_count] = token;
      _tokenToItem[token] = new Item { Key = key, Value = value, HeapPosition = _count };

      UpHeap(_count);
      ++_count;
    }

    /// <summary>
    /// Changes a key of an existing item with no lock. The presumptions are not checked; thus make sure that the provided token exists in the queue.
    /// </summary>
    /// <param name="token">The token of the key to change.</param>
    /// <param name="newKey">The new key.</param>
    private void InternalUpdateKeyNoLock(TToken token, TKey newKey)
    {
      var item = _tokenToItem[token].ModifyKey(newKey);
      _tokenToItem[token] = item;
      UpHeap(item.HeapPosition);
      DownHeap(item.HeapPosition);
    }

    /// <summary>
    /// Compares the two elements with index i and j on the heap. Since the heap contains only the tokens, the keys must be retrieved from the <see cref="_tokenToItem"/> dictionary.
    /// </summary>
    /// <param name="i">Index i.</param>
    /// <param name="j">Index j.</param>
    /// <returns></returns>
    private bool Greater(int i, int j)
    {
      return _tokenToItem[_heap[i]].Key.CompareTo(_tokenToItem[_heap[j]].Key) > 0;
    }

    /// <summary>
    /// Exchanges of the elements with index i and j on the heap. In the two corresponding items, the ElementIndex is changed, too.
    /// </summary>
    /// <param name="i">Index i.</param>
    /// <param name="j">Index j.</param>
    private void Exchange(int i, int j)
    {
      // Exchange tokens i and j in the heap
      var element_j = _heap[i];
      var element_i = _heap[j];
      _heap[i] = element_i;
      _heap[j] = element_j;

      // also, change the cached positions of the elements
      _tokenToItem[element_i] = _tokenToItem[element_i].ModifyHeapPosition(i);
      _tokenToItem[element_j] = _tokenToItem[element_j].ModifyHeapPosition(j);
    }

    private void InternalResizeNoLock(int newCapacity)
    {
      var newArray = new TToken[newCapacity];
      Array.Copy(_heap, newArray, _count);
      _heap = newArray;
    }

    private void UpHeap(int k)
    {
      int km1_2;
      while (k > 0 && Greater(km1_2 = ((k - 1) / 2), k))
      {
        Exchange(k, km1_2);
        k = km1_2;
      }
    }

    private void DownHeap(int k)
    {
      int j, jp1;
      while ((j = (2 * k + 1)) < _count)
      {
        jp1 = j + 1;
        if (jp1 < _count && Greater(j, jp1))
          j = jp1;
        if (!Greater(k, j))
          break;
        Exchange(k, j);
        k = j;
      }
    }

    #endregion Helper functions (not locked)
  }
}