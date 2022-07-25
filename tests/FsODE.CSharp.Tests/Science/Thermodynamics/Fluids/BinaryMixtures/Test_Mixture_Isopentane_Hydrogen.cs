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
  /// Tests and test data for <see cref="Mixture_Isopentane_Hydrogen"/>.
  /// </summary>
  /// <remarks>
  /// <para>Reference:</para>
  /// <para>The test data was created automatically using calls into the TREND.DLL of the following software:</para>
  /// <para>TREND 3.0.: Span, R.; Eckermann, T.; Herrig, S.; Hielscher, S.; Jäger, A.; Thol, M. (2016): TREND.Thermodynamic Reference and Engineering Data 3.0.Lehrstuhl für Thermodynamik, Ruhr-Universität Bochum.</para>
  /// </remarks>
  
  public class Test_Mixture_Isopentane_Hydrogen : MixtureTestBase
  {

    public Test_Mixture_Isopentane_Hydrogen()
    {
      _mixture = MixtureOfFluids.FromCASRegistryNumbersAndMoleFractions(new[] { ("78-78-4", 0.5), ("1333-74-0", 0.5) });

      // TestData for 1 Permille to 999 Permille Molefraction contains:
      // 0. Temperature (Kelvin)
      // 1. Mole density (mol/m³)
      // 2. Pressure (Pa)
      // 3. delta*AlphaR_delta
      // 4. Isochoric heat capacity (J/mol K)
      // 5. Phasetype (1: liquid, 2: gas)
      _testData_001_999 = new (double temperature, double moleDensity, double pressure, double deltaPhiR_delta, double cv, int phase)[]
      {
      ( 200, 0.601357087458691, 1000.00000000456, 6.66690908020401E-06, 19.0210214427542, 1 ),
      ( 200, 6.01321003808167, 10000.0000388664, 6.66746104872066E-05, 19.0212520243917, 1 ),
      ( 200, 60.0960074965822, 100000.000000001, 0.00066730171032216, 19.0235576002685, 1 ),
      ( 250, 0.481085804536482, 1000.00000000262, 6.3871867819355E-06, 20.0822139351182, 1 ),
      ( 250, 4.81058150116024, 10000.0000263973, 6.38742019521879E-05, 20.0823947850291, 1 ),
      ( 250, 48.0781669001826, 100000, 0.000638976773305226, 20.084203215847, 1 ),
      ( 250, 478.0226009406, 1000000.00822249, 0.00641450090448749, 20.1022797633327, 1 ),
      ( 250, 4508.10331500791, 10000000, 0.0671647114203948, 20.2815034386899, 1 ),
      ( 300, 0.400905056347241, 1000.00000000142, 5.84033684355611E-06, 20.6235256509521, 1 ),
      ( 300, 4.0088398439159, 10000.0000142204, 5.84043692601008E-05, 20.6236754771425, 1 ),
      ( 300, 40.0673346682985, 100000, 0.000584144382820691, 20.6251736684803, 1 ),
      ( 300, 398.574901664825, 1000000.00550583, 0.00585208975701835, 20.6401479182858, 1 ),
      ( 300, 3782.6079674823, 10000000.0002658, 0.0598703360614784, 20.7886218725949, 1 ),
      ( 350, 0.343633097342124, 1000.00000000078, 5.28188437104046E-06, 20.8793753186471, 1 ),
      ( 350, 3.43616762797083, 10000.0000078281, 5.2819237319783E-05, 20.8795034089721, 1 ),
      ( 350, 34.3453489230996, 100000, 0.000528232052061494, 20.8807842265152, 1 ),
      ( 350, 341.827807945205, 1000000.00181862, 0.00528659277625729, 20.8935834631128, 1 ),
      ( 350, 3261.96174291581, 10000000.0000128, 0.0534608908848324, 21.0203752049729, 1 ),
      ( 400, 0.300679112325392, 1000.00000000044, 4.77585707631003E-06, 20.9950959132198, 1 ),
      ( 400, 3.00666188907746, 10000.0000044588, 4.77586727361125E-05, 20.9952077187757, 1 ),
      ( 400, 30.0537012717412, 100000, 0.000477597109063451, 20.9963256810918, 1 ),
      ( 400, 299.250970495996, 1000000.00048179, 0.00477718692632417, 21.0074957580498, 1 ),
      ( 400, 2869.08738551707, 10000000.0000009, 0.0480006633596195, 21.118055946007, 1 ),
      ( 500, 0.240543469468735, 1000, 3.95017189749687E-06, 21.094394147525, 1 ),
      ( 500, 2.40534937143221, 10000.0000000335, 3.95016107796005E-05, 21.0944829525821, 1 ),
      ( 500, 24.0449459908893, 100000.000333655, 0.000395005054881998, 21.0953709127743, 1 ),
      ( 500, 239.598260418268, 1000000.00000002, 0.00394901965398554, 21.1042413939982, 1 ),
      ( 500, 2314.17666054358, 10000000.0000527, 0.0394385301778686, 21.1919641976683, 1 ),
      ( 500, 17329.7407057911, 100000000.000002, 0.38804407258272, 21.9610162429287, 1 ),
      ( 500, 60285.359236276, 999999999.999999, 2.99009712653097, 25.4812141329334, 1 ),
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
      ( 250, 0.481137482472215, 999.989160656618, -0.000101020240006337, 57.0043802164815, 2 ),
      ( 250, 4.81575681899168, 9999.9999989633, -0.00101085788992506, 57.0160214955996, 2 ),
      ( 300, 0.400930645759652, 999.999999726486, -5.79850706837301E-05, 65.8712154774879, 2 ),
      ( 300, 4.01140054492313, 9999.9999999902, -0.000579988764221814, 65.8767070117013, 2 ),
      ( 300, 40.3251796497747, 99999.9988651351, -0.00581373401814885, 65.9319223186873, 2 ),
      ( 350, 0.343647021406089, 999.999999954489, -3.5236835834402E-05, 74.4650740391695, 2 ),
      ( 350, 3.4375604255605, 9999.99954198382, -0.000352372505768949, 74.468082014746, 2 ),
      ( 350, 34.4850201795861, 99999.9998812921, -0.00352410818569248, 74.4982475121311, 2 ),
      ( 400, 0.300687160428367, 999.999999991565, -2.19899728946854E-05, 82.7213464862111, 2 ),
      ( 400, 3.00746672883653, 9999.99991578968, -0.000219867959312032, 82.7231913596136, 2 ),
      ( 400, 30.1342138583993, 99999.9999999931, -0.00219547873593539, 82.7416684676079, 2 ),
      ( 400, 307.321670208142, 999999.999999782, -0.0216096765248739, 82.9289212902135, 2 ),
      ( 500, 0.240546450118317, 999.999999999784, -8.36203414764878E-06, 97.9379698385262, 2 ),
      ( 500, 2.40564546061125, 9999.99999786655, -8.35842220418231E-05, 97.9388610507254, 2 ),
      ( 500, 24.0744792684549, 99999.9816577313, -0.000832225632085826, 97.9477774924113, 2 ),
      ( 500, 242.473613699402, 999999.999999887, -0.00795622662472153, 98.0372637063772, 2 ),
      ( 500, 2505.65552296261, 10000000.0001619, -0.0399939797937716, 98.8637836453365, 1 ),
      ( 500, 11041.1186750268, 99999999.9999999, 1.1786237947497, 101.38890485712, 1 ),
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
      ( 250, 0.481474456322157, 999.999963622577, -0.000800829580122558, 93.960888815317, 2 ),
      ( 250, 4.85002081340074, 9999.99987147885, -0.00806842705655242, 94.2970360416607, 2 ),
      ( 300, 0.401075542618512, 999.999844005754, -0.000419234798900614, 111.133461310829, 2 ),
      ( 300, 4.02601438098894, 9999.99851973633, -0.00420773477909226, 111.275947141199, 2 ),
      ( 300, 8682.25777448329, 9999999.99999997, -0.538245225860431, 123.702621704497, 1 ),
      ( 300, 9619.07535498805, 99999999.9999992, 3.16783716700915, 127.077691805923, 1 ),
      ( 300, 12125.5585889272, 1000000000.0001, 32.0630044651261, 142.934690426599, 1 ),
      ( 350, 0.343720399849518, 999.999975961113, -0.000248712253007717, 128.057798582214, 2 ),
      ( 350, 3.44493470126878, 9999.99999998984, -0.00249223230000692, 128.127095146643, 2 ),
      ( 350, 35.2613534885627, 100000.001625293, -0.0254630686983874, 128.841872680009, 2 ),
      ( 350, 8020.80093832849, 10000000.0055468, -0.571570326707747, 138.42275308118, 1 ),
      ( 350, 9231.35995890274, 100000000.000963, 2.72247332901621, 141.522569307576, 1 ),
      ( 350, 11945.7188835947, 1000000000.00006, 27.7663652326882, 156.011709464255, 1 ),
      ( 400, 0.300728710561262, 999.99999502811, -0.000160151769590761, 144.451328073664, 2 ),
      ( 400, 3.0116345173646, 9999.99999999978, -0.00160345954187644, 144.488545806241, 2 ),
      ( 400, 30.5642509824361, 100000.000153221, -0.0162345267648259, 144.867253948976, 2 ),
      ( 400, 371.967437020549, 999999.998696527, -0.191648196811661, 150.12995667087, 2 ),
      ( 400, 7274.16192800072, 10000000.0000002, -0.586645786412706, 153.37381468332, 1 ),
      ( 400, 8861.11138672727, 100000000.000225, 2.39326000096154, 156.061037223932, 1 ),
      ( 400, 11779.4794536339, 1000000000.00006, 24.5257925029831, 169.501020015032, 1 ),
      ( 500, 0.240562964621344, 999.999999636099, -7.70108594198663E-05, 174.782837509313, 2 ),
      ( 500, 2.40729899681513, 9999.99626035534, -0.000770410952953149, 174.796169762364, 2 ),
      ( 500, 24.2419474120831, 99999.9999052917, -0.00773467330731202, 174.930584487072, 2 ),
      ( 500, 261.667440136094, 1000000.0000033, -0.0807246077864876, 176.397584173606, 2 ),
      ( 500, 5262.12243757498, 10000000.0010773, -0.542875633299254, 182.982665641252, 1 ),
      ( 500, 8169.68556155078, 99999999.9999999, 1.94435369449796, 183.80175708635, 1 ),
      ( 500, 11478.061717661, 1000000000.00006, 19.9568866745663, 195.699764249476, 1 ),
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
