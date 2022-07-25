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
  /// Tests and test data for <see cref="Mixture_Cl2_Argon"/>.
  /// </summary>
  /// <remarks>
  /// <para>Reference:</para>
  /// <para>The test data was created automatically using calls into the TREND.DLL of the following software:</para>
  /// <para>TREND 3.0.: Span, R.; Eckermann, T.; Herrig, S.; Hielscher, S.; Jäger, A.; Thol, M. (2016): TREND.Thermodynamic Reference and Engineering Data 3.0.Lehrstuhl für Thermodynamik, Ruhr-Universität Bochum.</para>
  /// </remarks>
  
  public class Test_Mixture_Cl2_Argon : MixtureTestBase
  {

    public Test_Mixture_Cl2_Argon()
    {
      _mixture = MixtureOfFluids.FromCASRegistryNumbersAndMoleFractions(new[] { ("7782-50-5", 0.5), ("7440-37-1", 0.5) });

      // TestData for 1 Permille to 999 Permille Molefraction contains:
      // 0. Temperature (Kelvin)
      // 1. Mole density (mol/m³)
      // 2. Pressure (Pa)
      // 3. delta*AlphaR_delta
      // 4. Isochoric heat capacity (J/mol K)
      // 5. Phasetype (1: liquid, 2: gas)
      _testData_001_999 = new (double temperature, double moleDensity, double pressure, double deltaPhiR_delta, double cv, int phase)[]
      {
      ( 200, 0.601375776289971, 999.999999993354, -2.89745434175148E-05, 12.4829213926888, 2 ),
      ( 200, 6.01532656707553, 9999.9999330292, -0.000289768149755492, 12.4851615572038, 2 ),
      ( 200, 60.3107333785174, 99999.9999999929, -0.00289995160534213, 12.5076113069447, 2 ),
      ( 200, 619.461454971898, 1000000.0000702, -0.0292239381909068, 12.7370494963676, 2 ),
      ( 200, 8477.29957734459, 9999999.99999868, -0.290625102705376, 15.2723940313931, 2 ),
      ( 250, 0.481093115691525, 999.999999999573, -1.33743971188962E-05, 12.4840721614145, 2 ),
      ( 250, 4.81151027616559, 9999.99999573211, -0.000133734008020968, 12.485187517007, 2 ),
      ( 250, 48.1730435743298, 100000, -0.00133633736662511, 12.4963407867372, 2 ),
      ( 250, 487.549871769944, 999999.999392453, -0.0132564703205567, 12.6078097094596, 2 ),
      ( 250, 5424.39056112231, 10000000, -0.113104641083204, 13.6550884746536, 2 ),
      ( 300, 0.400908025891637, 999.999999999971, -6.13130824086282E-06, 12.4850216565529, 2 ),
      ( 300, 4.00930145275642, 9999.99999971074, -6.13011393050056E-05, 12.4856832310981, 2 ),
      ( 300, 40.1150997722691, 99999.9972253779, -0.00061181429515927, 12.4922951354801, 2 ),
      ( 300, 403.323753972068, 999999.999999322, -0.00599564526620765, 12.558016567399, 2 ),
      ( 300, 4197.44770691844, 10000000.0001168, -0.044882519584372, 13.1602726156647, 2 ),
      ( 350, 0.343634174913863, 999.999999999998, -2.37109783212485E-06, 12.4857511959616, 2 ),
      ( 350, 3.43641488592734, 9999.99999998759, -2.37013387936745E-05, 12.4861920624387, 2 ),
      ( 350, 34.3714477125744, 99999.999885946, -0.000236048527663432, 12.4905978380021, 2 ),
      ( 350, 344.412746127317, 999999.999999999, -0.00226298912020101, 12.5343624048791, 2 ),
      ( 350, 3478.07585423811, 10000000.0000266, -0.0120015829710406, 12.9386496365178, 1 ),
      ( 400, 0.300679260376611, 999.996695893401, -2.75606654279205E-07, 12.4863067382412, 2 ),
      ( 400, 3.00680002366828, 9999.99999999999, -2.74882302100217E-06, 12.4866254828928, 2 ),
      ( 400, 30.0687223039285, 99999.9999999184, -2.67626555217344E-05, 12.4898110663587, 2 ),
      ( 400, 300.737748783557, 999999.999648112, -0.000194764152709832, 12.5214793872287, 2 ),
      ( 400, 2990.18602775614, 10000000.0000763, 0.00555341058957537, 12.8183016871631, 1 ),
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
      ( 200, 0.601445323915839, 999.999999832392, -0.000141731016642621, 17.9283142759943, 2 ),
      ( 200, 6.02214678104822, 9999.99999875152, -0.00141909135866164, 17.9535345577335, 2 ),
      ( 250, 0.481122519464074, 999.999999966973, -7.16139772917712E-05, 18.5646632492647, 2 ),
      ( 250, 4.8143301993035, 9999.99966332544, -0.000716518264273962, 18.5763707772831, 2 ),
      ( 250, 48.4578751108453, 99999.9984770294, -0.00720354873814028, 18.6947476171597, 2 ),
      ( 300, 0.40092316420645, 999.9999999956, -4.10150926100317E-05, 19.0639396747726, 2 ),
      ( 300, 4.01071257913319, 9999.99995554229, -0.000410245320736383, 19.0695378656694, 2 ),
      ( 300, 40.2562039819608, 99999.9999999953, -0.0041119612494181, 19.1258645769872, 2 ),
      ( 300, 418.545786471278, 1000000.00260222, -0.0421436955834083, 19.7261831448074, 2 ),
      ( 350, 0.343643035432091, 999.999999999225, -2.53278564042585E-05, 19.4406464304277, 2 ),
      ( 350, 3.43721396430555, 9999.99999218571, -0.000253300320419109, 19.4433264729393, 2 ),
      ( 350, 34.4507723704619, 100000, -0.00253518848131404, 19.4702140346958, 2 ),
      ( 350, 352.655243785441, 999999.982384937, -0.0255799739071972, 19.7480796985959, 2 ),
      ( 400, 0.300684941292879, 999.999999999992, -1.62996642005806E-05, 19.7250593221912, 2 ),
      ( 400, 3.0072905822795, 9999.99999868585, -0.000162997213926526, 19.7264551284567, 2 ),
      ( 400, 30.1170957917514, 99999.9839293264, -0.00163002970952276, 19.7404323694576, 2 ),
      ( 400, 305.664358496931, 999999.999721028, -0.0163065078661562, 19.882120685313, 2 ),
      ( 400, 3583.97447020093, 9999999.99999997, -0.161043018778945, 21.4424028920935, 2 ),
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
      ( 200, 0.601631205925934, 999.999999991083, -0.000447777139112073, 23.3699058576638, 2 ),
      ( 200, 6.04078751958876, 9999.99999999617, -0.00449766311622067, 23.3841526128654, 2 ),
      ( 200, 23554.849502883, 100000.000001173, -0.997446972399057, 36.7282218200353, 1 ),
      ( 200, 23570.3814645481, 1000000.00008336, -0.974486547441994, 36.7460142009031, 1 ),
      ( 200, 23721.192086952, 10000000.0000705, -0.74648752599562, 36.9225605108977, 1 ),
      ( 250, 0.48119517045642, 999.999999998148, -0.000219709345241352, 24.6475489198032, 2 ),
      ( 250, 4.821509960102, 9999.99998087815, -0.0022016933187461, 24.6909235111815, 2 ),
      ( 250, 49.21623611812, 99999.999999992, -0.0224984978006835, 25.1386584456203, 2 ),
      ( 250, 21652.7991697183, 1000000.00009282, -0.977781651063182, 35.0385122257195, 1 ),
      ( 250, 21876.3181849889, 9999999.99999932, -0.780086647436755, 35.1733294177227, 1 ),
      ( 300, 0.400956285916372, 999.999999999587, -0.000120744083378205, 25.6447068616367, 2 ),
      ( 300, 4.01393051488272, 9999.99999578341, -0.0012087370944074, 25.6722621595102, 2 ),
      ( 300, 40.5867650095127, 99999.9999999997, -0.0122201834059289, 25.9523262498274, 2 ),
      ( 300, 19567.469011236, 1000000.00000155, -0.979511511040973, 34.4389194727279, 1 ),
      ( 300, 19931.7756547192, 9999999.99999969, -0.798859931116197, 34.4210676358236, 1 ),
      ( 350, 0.343660414083714, 999.999999999896, -7.30212882383533E-05, 26.3968192580873, 2 ),
      ( 350, 3.43886576032683, 9999.99999893285, -0.000730637636303726, 26.4136113926395, 2 ),
      ( 350, 34.6179554739784, 99999.9883108102, -0.00734946596298881, 26.5831862668989, 2 ),
      ( 350, 372.927290724936, 999999.993984461, -0.0785460643537215, 28.469991584532, 2 ),
      ( 350, 17696.2590266009, 10000000.0000001, -0.805814709741215, 34.0094107002813, 1 ),
      ( 400, 0.300695177806323, 999.991643346722, -4.74669207578464E-05, 26.9646368799559, 2 ),
      ( 400, 3.00823742979758, 9999.99999976189, -0.000474824112843275, 26.9749159546896, 2 ),
      ( 400, 30.2120046475472, 99999.9969640039, -0.00476347673362435, 27.0784234411898, 2 ),
      ( 400, 316.278302352772, 999999.99991228, -0.0493154213313202, 28.1915130943108, 2 ),
      ( 400, 14638.3744151504, 10000000.0000568, -0.794594060729086, 35.3075313372004, 1 ),
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
