﻿#region Copyright

/////////////////////////////////////////////////////////////////////////////
//    Altaxo:  a data processing and data plotting program
//    Copyright (C) 2002-2018 Dr. Dirk Lellinger
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Altaxo.Science.Thermodynamics.Fluids
{

  /// <summary>
  /// Tests and test data for <see cref="Mixture_Oxygen_SO2"/>.
  /// </summary>
  /// <remarks>
  /// <para>Reference:</para>
  /// <para>The test data was created automatically using calls into the TREND.DLL of the following software:</para>
  /// <para>TREND 3.0.: Span, R.; Eckermann, T.; Herrig, S.; Hielscher, S.; Jäger, A.; Thol, M. (2016): TREND.Thermodynamic Reference and Engineering Data 3.0.Lehrstuhl für Thermodynamik, Ruhr-Universität Bochum.</para>
  /// </remarks>
  
  public class Test_Mixture_Oxygen_SO2 : MixtureTestBase
  {

    public Test_Mixture_Oxygen_SO2()
    {
      _mixture = MixtureOfFluids.FromCASRegistryNumbersAndMoleFractions(new[] { ("7782-44-7", 0.5), ("7446-09-5", 0.5) });

      // TestData for 1 Permille to 999 Permille Molefraction contains:
      // 0. Temperature (Kelvin)
      // 1. Mole density (mol/m³)
      // 2. Pressure (Pa)
      // 3. delta*AlphaR_delta
      // 4. Isochoric heat capacity (J/mol K)
      // 5. Phasetype (1: liquid, 2: gas)
      _testData_001_999 = new (double temperature, double moleDensity, double pressure, double deltaPhiR_delta, double cv, int phase)[]
      {
      ( 200, 0.60183511363461, 999.999999998911, -0.000786414920752801, 28.0927564332475, 2 ),
      ( 200, 25338.5807667241, 1000000.00003712, -0.976266949318181, 55.9988051001184, 1 ),
      ( 200, 25468.6510080826, 9999999.99999815, -0.763881557240569, 56.123724828302, 1 ),
      ( 250, 0.481245606534733, 999.999999999462, -0.000324469076755005, 29.8486755945956, 2 ),
      ( 250, 4.82660436941452, 9999.99999447845, -0.00325483424763163, 30.0025110213499, 2 ),
      ( 250, 23367.8347635691, 1000000.00091312, -0.979412322002286, 53.0975699327915, 1 ),
      ( 250, 23556.0530575014, 9999999.99999746, -0.795768223122196, 53.111466511145, 1 ),
      ( 300, 0.400971986909478, 999.999999999849, -0.000159876244060919, 31.6391024006889, 2 ),
      ( 300, 4.01550782684558, 9999.99999847208, -0.00160104698487455, 31.714600894314, 2 ),
      ( 300, 40.7528757068331, 99999.9823395126, -0.0162463991817674, 32.4855659300881, 2 ),
      ( 300, 21273.3343611497, 1000000.01527175, -0.981154440562985, 51.86996814255, 1 ),
      ( 300, 21571.0277145906, 10000000.0000245, -0.814145210734212, 51.6271837108058, 1 ),
      ( 350, 0.343666531671422, 999.999999999956, -9.08004851058061E-05, 33.4255020639702, 2 ),
      ( 350, 3.43947856717939, 9999.99999957545, -0.000908655565480193, 33.4604322921049, 2 ),
      ( 350, 34.6809579523706, 99999.9953884566, -0.00915272508370137, 33.8141415240584, 2 ),
      ( 350, 381.623813842535, 999999.999010971, -0.0995443309335961, 37.8900711184216, 2 ),
      ( 350, 19315.7855140942, 10000000.0032838, -0.822096115924207, 50.8235616299727, 1 ),
      ( 400, 0.300697982603384, 999.995080624342, -5.67737720476017E-05, 35.1493752119895, 2 ),
      ( 400, 3.00851782236171, 9999.99999990134, -0.000567958993662827, 35.1657601057197, 2 ),
      ( 400, 30.2405115512189, 99999.9987493583, -0.00570163872908305, 35.3308920079084, 2 ),
      ( 400, 319.685889611211, 999999.999984305, -0.0594489136612604, 37.1256462217171, 2 ),
      ( 400, 16293.7856178014, 9999999.99999986, -0.815462828704354, 51.1873112156026, 1 ),
      ( 500, 0.240550930808892, 999.992563005776, -2.57831229447106E-05, 38.2245290048351, 2 ),
      ( 500, 2.40606772149923, 9999.99999999284, -0.00025786282250203, 38.2292624453017, 2 ),
      ( 500, 24.1167326367099, 99999.9999273632, -0.00258160077756204, 38.2767123934953, 2 ),
      ( 500, 246.995812460624, 999999.999999989, -0.02611819118638, 38.7632124340104, 2 ),
      ( 500, 3406.11386320334, 10000000.0000038, -0.293785415666748, 45.2810378959431, 2 ),
      };

      // TestData for 500 Permille to 500 Permille Molefraction contains:
      // 0. Temperature (Kelvin)
      // 1. Mole density (mol/m³)
      // 2. Pressure (Pa)
      // 3. delta*AlphaR_delta
      // 4. Isochoric heat capacity (J/mol K)
      // 5. Phasetype (1: liquid, 2: gas)
      _testData_500_500 = new (double temperature, double moleDensity, double pressure, double deltaPhiR_delta, double cv, int phase)[]
      {
      ( 200, 0.601472041732299, 999.999994908854, -0.000175924109298659, 24.4457118460119, 2 ),
      ( 250, 0.481133381778032, 999.988436191324, -8.39656393030123E-05, 25.3657769741483, 2 ),
      ( 250, 4.8149753958021, 9999.99999994347, -0.000840205625274397, 25.3861228478353, 2 ),
      ( 250, 48.5196186056569, 99999.9999980745, -0.00845679227358697, 25.5922190206625, 2 ),
      ( 300, 0.400929508061286, 999.999933377872, -4.66146640864067E-05, 26.3568263682782, 2 ),
      ( 300, 4.01097843261772, 9999.99309431209, -0.000466280908788013, 26.3647412792854, 2 ),
      ( 300, 40.2794429310825, 99999.9999999788, -0.00467635672127171, 26.4443967937463, 2 ),
      ( 350, 0.343647463498505, 999.999991183677, -2.79901859121006E-05, 27.4070943095516, 2 ),
      ( 350, 3.4373406887964, 9999.99915045841, -0.00027993771390934, 27.410816685459, 2 ),
      ( 350, 34.4603759339897, 100000, -0.00280297173250764, 27.4481446198795, 2 ),
      ( 350, 353.680926378107, 999999.999995729, -0.0283958813919707, 27.8322317910548, 2 ),
      ( 400, 0.300688363954942, 999.99999938286, -1.74592910581684E-05, 28.4767895643355, 2 ),
      ( 400, 3.00735622578277, 9999.99977494086, -0.000174599960488829, 28.4789503410524, 2 ),
      ( 400, 30.1209236935817, 99999.9834501199, -0.00174670174282189, 28.5005780893647, 2 ),
      ( 400, 306.049394673756, 999999.999999917, -0.0175340341064912, 28.7188504113401, 2 ),
      ( 400, 3648.26903066416, 9999999.99892512, -0.175819788429709, 31.0460927309705, 2 ),
      ( 500, 0.240548147784595, 999.999970943158, -6.88621027670764E-06, 30.5090651760976, 2 ),
      ( 500, 2.40563055984865, 9999.99708085711, -6.88578740475063E-05, 30.5101534557021, 2 ),
      ( 500, 24.0712138815719, 99999.9999999995, -0.000688155973765962, 30.5210333344636, 2 ),
      ( 500, 242.202503700734, 999999.999994884, -0.00683730490557799, 30.6295206750882, 2 ),
      ( 500, 2563.3586553281, 10000000, -0.0615964300608923, 31.6627581146424, 2 ),
      };

      // TestData for 999 Permille to 1 Permille Molefraction contains:
      // 0. Temperature (Kelvin)
      // 1. Mole density (mol/m³)
      // 2. Pressure (Pa)
      // 3. delta*AlphaR_delta
      // 4. Isochoric heat capacity (J/mol K)
      // 5. Phasetype (1: liquid, 2: gas)
      _testData_999_001 = new (double temperature, double moleDensity, double pressure, double deltaPhiR_delta, double cv, int phase)[]
      {
      ( 200, 0.601388672288631, 999.993352799861, -2.99922982167708E-05, 20.8198208345995, 2 ),
      ( 200, 6.01551074158432, 9999.99999999335, -0.000299956272793278, 20.8222530615694, 2 ),
      ( 200, 60.3181802677538, 99999.9999330634, -0.00300268927989417, 20.846645814769, 2 ),
      ( 200, 620.184324385686, 999999.999999992, -0.0303356413659637, 21.0977557666427, 2 ),
      ( 200, 8705.17579548982, 9999999.99995498, -0.309180366635586, 24.0572788080761, 2 ),
      ( 250, 0.481103132660601, 999.998102801643, -1.37694712821304E-05, 20.895584903405, 2 ),
      ( 250, 4.81162758486362, 9999.99999999929, -0.000137688075249634, 20.8967524946941, 2 ),
      ( 250, 48.1759497300745, 99999.9999920096, -0.00137618291262222, 20.908432303132, 2 ),
      ( 250, 487.771101667795, 1000000, -0.0136838642812363, 21.0255677742557, 2 ),
      ( 250, 5459.95405100227, 9999999.99204948, -0.118863448929947, 22.1548784366938, 2 ),
      ( 300, 0.400916262642091, 999.998449644663, -6.25037749718576E-06, 21.0813195556796, 2 ),
      ( 300, 4.00938812928271, 9999.99999999992, -6.2493745289083E-05, 21.0820241868089, 2 ),
      ( 300, 40.1164051490731, 99999.9999992565, -0.0006239211354068, 21.0890671745392, 2 ),
      ( 300, 403.388101342585, 999999.993582171, -0.0061339056415225, 21.1591437132773, 2 ),
      ( 300, 4207.72744178013, 9999999.99999995, -0.0471964681471671, 21.8038807763322, 2 ),
      ( 350, 0.34364118886883, 999.999493395088, -2.35634645206466E-06, 21.3918777286929, 2 ),
      ( 350, 3.43648457644949, 10000, -2.35551984518514E-05, 21.3923610579962, 2 ),
      ( 350, 34.3721042071489, 99999.9999999626, -0.000234722709062665, 21.3971907942491, 2 ),
      ( 350, 344.419690420227, 999999.999737053, -0.00226272627195473, 21.4451251622214, 2 ),
      ( 350, 3480.94262202405, 9999999.99999999, -0.0127950953195671, 21.8820665752247, 1 ),
      ( 400, 0.30068537732261, 999.99995281017, -1.94827018546349E-07, 21.8056802541784, 2 ),
      ( 400, 3.00685901536028, 9999.99541024643, -1.94211166218436E-06, 21.8060365348511, 2 ),
      ( 400, 30.0690971955383, 100000, -1.88046391329674E-05, 21.8095963969964, 2 ),
      ( 400, 300.723116891422, 999999.999999998, -0.000125694764168322, 21.8448979243984, 1 ),
      ( 400, 2990.25952095245, 10000000, 0.00554923565427307, 22.1664715917364, 1 ),
      ( 500, 0.240547811926878, 1000.00041721439, 1.80196967990367E-06, 22.7940225928751, 1 ),
      ( 500, 2.40543918731965, 10000, 1.80230046543938E-05, 22.7942405538532, 1 ),
      ( 500, 24.0504828097322, 100000.000000015, 0.000180561692473142, 22.796418267352, 1 ),
      ( 500, 240.106709809822, 1000000.00017898, 0.00183895005018066, 22.8180058074229, 1 ),
      ( 500, 2354.06645559792, 10000000, 0.0218413906035375, 23.0151409830635, 1 ),
      };
    }

    [Fact]
    public override void CASNumberAttribute_Test()
    {
      base.CASNumberAttribute_Test();
    }

    [Fact]
    public override void Constants_Test()
    {
      base.Constants_Test();
    }

    [Fact]
    public override void DeltaPhiRDelta_001_999_Test()
    {
      base.DeltaPhiRDelta_001_999_Test();
    }

    [Fact]
    public override void DeltaPhiRDelta_500_500_Test()
    {
      base.DeltaPhiRDelta_500_500_Test();
    }

    [Fact]
    public override void DeltaPhiRDelta_999_001_Test()
    {
      base.DeltaPhiRDelta_999_001_Test();
    }
  }
}
