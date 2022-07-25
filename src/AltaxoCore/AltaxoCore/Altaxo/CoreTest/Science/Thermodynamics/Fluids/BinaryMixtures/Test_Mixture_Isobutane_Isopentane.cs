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
  /// Tests and test data for <see cref="Mixture_Isobutane_Isopentane"/>.
  /// </summary>
  /// <remarks>
  /// <para>Reference:</para>
  /// <para>The test data was created automatically using calls into the TREND.DLL of the following software:</para>
  /// <para>TREND 3.0.: Span, R.; Eckermann, T.; Herrig, S.; Hielscher, S.; Jäger, A.; Thol, M. (2016): TREND.Thermodynamic Reference and Engineering Data 3.0.Lehrstuhl für Thermodynamik, Ruhr-Universität Bochum.</para>
  /// </remarks>
  
  public class Test_Mixture_Isobutane_Isopentane : MixtureTestBase
  {

    public Test_Mixture_Isobutane_Isopentane()
    {
      _mixture = MixtureOfFluids.FromCASRegistryNumbersAndMoleFractions(new[] { ("75-28-5", 0.5), ("78-78-4", 0.5) });

      // TestData for 1 Permille to 999 Permille Molefraction contains:
      // 0. Temperature (Kelvin)
      // 1. Mole density (mol/m³)
      // 2. Pressure (Pa)
      // 3. delta*AlphaR_delta
      // 4. Isochoric heat capacity (J/mol K)
      // 5. Phasetype (1: liquid, 2: gas)
      _testData_001_999 = new (double temperature, double moleDensity, double pressure, double deltaPhiR_delta, double cv, int phase)[]
      {
      ( 150, 10436.1625419078, 1000.00983958964, -0.999923168819732, 88.5422159999673, 1 ),
      ( 150, 10436.219246674, 9999.99999449421, -0.999231699932548, 88.542721355611, 1 ),
      ( 150, 10436.7861288104, 100000.000008152, -0.992317416628982, 88.5477744878132, 1 ),
      ( 150, 10442.4384779237, 1000000.00000338, -0.923215751068761, 88.5982627066726, 1 ),
      ( 150, 10497.3905891838, 10000000.0012112, -0.236177039774851, 89.0987270007617, 1 ),
      ( 250, 0.481475694634306, 999.999998963065, -0.000803399458769878, 94.0166655567949, 2 ),
      ( 250, 4.85014855902798, 9999.99990329388, -0.00809455306868877, 94.3542607758876, 2 ),
      ( 300, 0.401076042578897, 999.999842957775, -0.000420480823285976, 111.201822992881, 2 ),
      ( 300, 4.0260651552572, 9999.99849794866, -0.00422029309008641, 111.34492202565, 2 ),
      ( 300, 8516.57170902076, 999999.999999743, -0.952926199477299, 123.460351632342, 1 ),
      ( 300, 8680.47389966925, 10000000.0000003, -0.538150333263375, 123.797936337552, 1 ),
      ( 350, 0.343720639344301, 999.999975812444, -0.000249408851268621, 128.139629841829, 2 ),
      ( 350, 3.44495886648219, 9999.99999998968, -0.00249922947731039, 128.209225617078, 2 ),
      ( 350, 35.2640097361747, 100000.00165352, -0.025536475316695, 128.92719234155, 2 ),
      ( 350, 7751.51872999786, 1000000.00478322, -0.955668698486309, 138.361525317397, 1 ),
      ( 350, 8020.15154216107, 10000000.0054183, -0.571535636522233, 138.525129079977, 1 ),
      ( 400, 0.300728840187595, 999.999994998971, -0.000160582741132374, 144.546597434951, 2 ),
      ( 400, 3.01164755362617, 9999.99999999977, -0.00160778121571095, 144.583975588524, 2 ),
      ( 400, 30.5656326945962, 100000.000155683, -0.0162789976496644, 144.964339469745, 2 ),
      ( 400, 372.284401064744, 999999.99859665, -0.192336429910503, 150.261798567785, 2 ),
      ( 400, 7275.06855999737, 9999999.99999981, -0.586697299350768, 153.484062828648, 1 ),
      ( 500, 0.240563013186356, 999.999999634032, -7.72127245013155E-05, 174.90283847281, 2 ),
      ( 500, 2.40730386581987, 9999.99623876712, -0.000772431988947011, 174.916227387478, 2 ),
      ( 500, 24.2424471051694, 99999.9999036838, -0.00775512619721736, 175.05121631183, 2 ),
      ( 500, 261.73383914182, 1000000.00000351, -0.0809578178759275, 176.524941784835, 2 ),
      ( 500, 5268.41761414509, 10000000.001032, -0.543421846378811, 183.109145731464, 1 ),
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
      ( 150, 11229.9617398411, 1000000.00015546, -0.928600398294998, 80.1027608220425, 1 ),
      ( 150, 11292.9469166781, 9999999.99999642, -0.289986217558821, 80.7068867672281, 1 ),
      ( 250, 0.481378509124323, 999.996725318379, -0.000601669680603838, 84.8360329508596, 2 ),
      ( 250, 4.84019168122699, 10000.0000891749, -0.00605408008315671, 85.043004901396, 2 ),
      ( 250, 9781.47935888376, 1000000.00821247, -0.950816347575782, 98.4806985187719, 1 ),
      ( 250, 9915.84743290841, 10000000.0000034, -0.514828278095688, 98.9596564425742, 1 ),
      ( 300, 0.401037530578557, 999.999982203936, -0.000324490349415494, 100.027645006943, 2 ),
      ( 300, 4.02216417116954, 9999.99999712491, -0.00325451495823871, 100.117693425594, 2 ),
      ( 300, 41.4840957080227, 99999.9999999997, -0.0335877137360867, 101.080224950472, 2 ),
      ( 300, 8978.07254302907, 1000000.01635018, -0.955345938409159, 110.833964741067, 1 ),
      ( 300, 9189.91401976784, 10000000.0005316, -0.563752830632125, 111.233448912939, 1 ),
      ( 350, 0.343702210822786, 999.999997075099, -0.000195804530955112, 115.368814962765, 2 ),
      ( 350, 3.44310162813631, 9999.99999999989, -0.00196116906680921, 115.413855122695, 2 ),
      ( 350, 35.0625111245595, 100000.000653398, -0.019936389880584, 115.878658705642, 2 ),
      ( 350, 8011.70848226238, 1000000.00571517, -0.957108410136999, 124.493049040373, 1 ),
      ( 350, 8393.045616093, 9999999.99999997, -0.590571851876515, 124.584318010917, 1 ),
      ( 400, 0.300718768150238, 999.999999375167, -0.000127094908608862, 130.349700586263, 2 ),
      ( 400, 3.01063530959334, 9999.99348969972, -0.0012720982263973, 130.3746312163, 2 ),
      ( 400, 30.4591031475524, 99999.9992783324, -0.012838470549517, 130.628380362882, 2 ),
      ( 400, 351.077340865723, 999999.999999442, -0.143548975321272, 133.819373987641, 2 ),
      ( 400, 7465.75872843161, 10000000.0003709, -0.597253863574533, 138.388112013959, 1 ),
      ( 500, 0.240559123986253, 999.999999953897, -6.10466371940825E-05, 157.936266778779, 2 ),
      ( 500, 2.40691409756196, 9999.99953227735, -0.000610620415456632, 157.945794455907, 2 ),
      ( 500, 24.2026052301803, 99999.9999991503, -0.00612171134406964, 158.041700648992, 2 ),
      ( 500, 256.681564559825, 999999.999999998, -0.0628682699780615, 159.067627070859, 2 ),
      ( 500, 4808.35659856009, 10000000.0001285, -0.499736690215962, 165.887519197963, 1 ),
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
      ( 150, 12146.3128328001, 100000.000001181, -0.993398697972597, 72.7416699289398, 1 ),
      ( 150, 12153.8849903318, 1000000.00005187, -0.934028107375274, 72.8123121073735, 1 ),
      ( 150, 12227.501812536, 10000000.0000023, -0.344252973479259, 73.487908223138, 1 ),
      ( 200, 0.60193608665559, 999.999999992738, -0.000955234312263761, 63.5686759582695, 2 ),
      ( 200, 11315.4131943218, 100000.000003316, -0.994685469410653, 79.2228090775558, 1 ),
      ( 200, 11326.9316634626, 1000000.0018033, -0.946908737908803, 79.2851068313931, 1 ),
      ( 200, 11436.6923340662, 9999999.99999867, -0.474182675302803, 79.877014966316, 1 ),
      ( 250, 0.481305669970702, 999.99999999726, -0.00045042612801876, 75.6603188412529, 2 ),
      ( 250, 4.83276511740222, 9999.99997096564, -0.00452667230901906, 75.7815435268615, 2 ),
      ( 250, 10430.5482375825, 100000.000000742, -0.99538769330592, 87.6051104494531, 1 ),
      ( 250, 10449.002783643, 1000000.00000229, -0.953958393249044, 87.6627885706957, 1 ),
      ( 250, 10618.6047478247, 10000000.0000501, -0.546937767488704, 88.2147995456206, 1 ),
      ( 300, 0.40100740528728, 999.999999999555, -0.000249390704879552, 88.8554720190804, 2 ),
      ( 300, 4.0191201446191, 9999.99999537078, -0.00249959358321007, 88.9105147063619, 2 ),
      ( 300, 41.1437764322618, 99999.9999999995, -0.0255940690620437, 89.4971256442884, 2 ),
      ( 300, 9456.53006759746, 999999.999999663, -0.957605232056383, 98.2953177869034, 1 ),
      ( 300, 9743.17390782484, 10000000.0022862, -0.588524846577021, 98.7350768347595, 1 ),
      ( 350, 0.343687299241836, 999.999999999953, -0.000152425968433775, 102.598905054045, 2 ),
      ( 350, 3.4416012183109, 9999.99999949565, -0.00152606134497302, 102.627531008806, 2 ),
      ( 350, 34.9025898080976, 99999.9921354608, -0.0154458030433799, 102.922617260934, 2 ),
      ( 350, 419.482439850821, 999999.99991941, -0.180812163430229, 107.106475972191, 2 ),
      ( 350, 8757.07160710778, 9999999.99999973, -0.607591523982385, 110.720657348271, 1 ),
      ( 400, 0.300710420434983, 999.997803484583, -9.9338238632146E-05, 116.153264555076, 2 ),
      ( 400, 3.00979729415019, 9999.99999996465, -0.000994024048334522, 116.169896601629, 2 ),
      ( 400, 30.3719317959995, 99999.9994126786, -0.010005190233391, 116.338900549458, 2 ),
      ( 400, 337.004148784132, 999999.999429828, -0.107783837577851, 118.356103915931, 2 ),
      ( 400, 7554.94532792289, 10000000.0000024, -0.602008306778062, 123.5151881316, 1 ),
      ( 500, 0.240555826056414, 999.997822430538, -4.73377474000601E-05, 140.969834101132, 2 ),
      ( 500, 2.40658377833703, 9999.99999999887, -0.000473447772881058, 140.976752955359, 2 ),
      ( 500, 24.1690394886381, 99999.99998642, -0.00474142226843394, 141.04623038398, 2 ),
      ( 500, 252.705496659981, 999999.999999987, -0.0481234407641592, 141.770834842104, 2 ),
      ( 500, 4101.36178216425, 10000000, -0.413501048098825, 147.8968635312, 1 ),
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
