﻿#region Copyright

/////////////////////////////////////////////////////////////////////////////
//    Altaxo:  a data processing and data plotting program
//    Copyright (C) 2002-2011 Dr. Dirk Lellinger
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
using Altaxo.Calc.Fourier;
using Xunit;

namespace AltaxoTest.Calc.Fourier
{
  
  public class TestFastHartleyConvolutionSplittedComplex
  {
    private const int nLowerLimit = 4;
    private const int nUpperLimit = 128;
    private const double maxTolerableEpsPerN = 1E-15;
    private SplittedComplexConvolutionTests _test;

    public TestFastHartleyConvolutionSplittedComplex()
    {
      _test = new SplittedComplexConvolutionTests(new SplittedComplexConvolutionTests.ConvolutionRoutine(MyConvolution));
    }

    private void MyConvolution(double[] re1, double[] im1, double[] re2, double[] im2, double[] re, double[] im, int n)
    {
      FastHartleyTransform.CyclicConvolution(re1, im1, re2, im2, re, im, null, null, n);
    }

    [Fact]
    public void Test01BothZero()
    {
      for (int i = nLowerLimit; i <= nUpperLimit; i *= 2)
        _test.TestBothZero(i);
    }

    [Fact]
    public void Test02OneZero()
    {
      for (int i = nLowerLimit; i <= nUpperLimit; i *= 2)
        _test.TestOneZero(i);
    }

    [Fact]
    public void Test03ReOne_ZeroPos()
    {
      for (int i = nLowerLimit; i <= nUpperLimit; i *= 2)
        _test.TestReOne_ZeroPos(i);
    }

    [Fact]
    public void Test04OneReOne_OtherRandom()
    {
      for (int i = nLowerLimit; i <= nUpperLimit; i *= 2)
        _test.TestOneReOne_OtherRandom(i);
    }

    [Fact]
    public void Test05OneImOne_OtherRandom()
    {
      for (int i = nLowerLimit; i <= nUpperLimit; i *= 2)
        _test.TestOneImOne_OtherRandom(i);
    }

    [Fact]
    public void Test06ReOne_OnePos_OtherRandom()
    {
      for (int i = nLowerLimit; i <= nUpperLimit; i *= 2)
        _test.TestReOne_OnePos_OtherRandom(i);
    }

    [Fact]
    public void Test07ImOne_OnePos_OtherRandom()
    {
      for (int i = nLowerLimit; i <= nUpperLimit; i *= 2)
        _test.TestImOne_OnePos_OtherRandom(i);
    }

    [Fact]
    public void Test08BothRandom()
    {
      for (int i = nLowerLimit; i <= nUpperLimit; i *= 2)
        _test.TestBothRandom(i);
    }
  }

  
  public class TestFastHartleyDestructiveCyclicRealConvolution
  {
    private const int nLowerLimit = 4;
    private const int nUpperLimit = 128;
    private const double maxTolerableEpsPerN = 1E-15;
    private RealConvolutionTests _test;

    private int[] _testLengths = { 4, 8, 16, 32, 64, 128, 256 };

    public TestFastHartleyDestructiveCyclicRealConvolution()
    {
      _test = new RealConvolutionTests(new RealConvolutionTests.ConvolutionRoutine(MyConvolution));
    }

    private void MyConvolution(double[] re1, double[] re2, double[] re, int n)
    {
      double[] inp1 = new double[n];
      double[] inp2 = new double[n];
      Array.Copy(re1, inp1, n);
      Array.Copy(re2, inp2, n);
      FastHartleyTransform.CyclicDestructiveConvolution(inp1, inp2, re, n);
    }

    [Fact]
    public void Test01BothZero()
    {
      foreach (int i in _testLengths)
        _test.TestBothZero(i);
    }

    [Fact]
    public void Test02OneZero()
    {
      foreach (int i in _testLengths)
        _test.TestOneZero(i);
    }

    [Fact]
    public void Test03ReOne_ZeroPos()
    {
      foreach (int i in _testLengths)
        _test.TestReOne_ZeroPos(i);
    }

    [Fact]
    public void Test04OneReOne_OtherRandom()
    {
      foreach (int i in _testLengths)
        _test.TestOneReOne_OtherRandom(i);
    }

    [Fact]
    public void Test05ReOne_OnePos_OtherRandom()
    {
      foreach (int i in _testLengths)
        _test.TestReOne_OnePos_OtherRandom(i);
    }

    [Fact]
    public void Test06BothRandom()
    {
      foreach (int i in _testLengths)
        _test.TestBothRandom(i);
    }
  }

  
  public class TestFastHartleyRealCyclicConvolution
  {
    private const int nLowerLimit = 4;
    private const int nUpperLimit = 128;
    private const double maxTolerableEpsPerN = 1E-15;
    private RealConvolutionTests _test;

    private int[] _testLengths = { 4, 8, 16, 32, 64, 128, 256 };

    public TestFastHartleyRealCyclicConvolution()
    {
      _test = new RealConvolutionTests(new RealConvolutionTests.ConvolutionRoutine(MyConvolution));
    }

    private void MyConvolution(double[] re1, double[] re2, double[] re, int n)
    {
      FastHartleyTransform.CyclicRealConvolution(re1, re2, re, n);
    }

    [Fact]
    public void Test01BothZero()
    {
      foreach (int i in _testLengths)
        _test.TestBothZero(i);
    }

    [Fact]
    public void Test02OneZero()
    {
      foreach (int i in _testLengths)
        _test.TestOneZero(i);
    }

    [Fact]
    public void Test03ReOne_ZeroPos()
    {
      foreach (int i in _testLengths)
        _test.TestReOne_ZeroPos(i);
    }

    [Fact]
    public void Test04OneReOne_OtherRandom()
    {
      foreach (int i in _testLengths)
        _test.TestOneReOne_OtherRandom(i);
    }

    [Fact]
    public void Test05ReOne_OnePos_OtherRandom()
    {
      foreach (int i in _testLengths)
        _test.TestReOne_OnePos_OtherRandom(i);
    }

    [Fact]
    public void Test06BothRandom()
    {
      foreach (int i in _testLengths)
        _test.TestBothRandom(i);
    }
  }
}
