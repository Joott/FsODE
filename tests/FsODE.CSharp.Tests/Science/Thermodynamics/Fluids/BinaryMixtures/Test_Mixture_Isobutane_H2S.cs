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
  /// Tests and test data for <see cref="Mixture_Isobutane_H2S"/>.
  /// </summary>
  /// <remarks>
  /// <para>Reference:</para>
  /// <para>The test data was created automatically using calls into the TREND.DLL of the following software:</para>
  /// <para>TREND 3.0.: Span, R.; Eckermann, T.; Herrig, S.; Hielscher, S.; Jäger, A.; Thol, M. (2016): TREND.Thermodynamic Reference and Engineering Data 3.0.Lehrstuhl für Thermodynamik, Ruhr-Universität Bochum.</para>
  /// </remarks>
  
  public class Test_Mixture_Isobutane_H2S : MixtureTestBase
  {

    public Test_Mixture_Isobutane_H2S()
    {
      _mixture = MixtureOfFluids.FromCASRegistryNumbersAndMoleFractions(new[] { ("75-28-5", 0.5), ("7783-06-4", 0.5) });

      // TestData for 1 Permille to 999 Permille Molefraction contains:
      // 0. Temperature (Kelvin)
      // 1. Mole density (mol/m³)
      // 2. Pressure (Pa)
      // 3. delta*AlphaR_delta
      // 4. Isochoric heat capacity (J/mol K)
      // 5. Phasetype (1: liquid, 2: gas)
      _testData_001_999 = new (double temperature, double moleDensity, double pressure, double deltaPhiR_delta, double cv, int phase)[]
      {
      ( 200, 0.601526872406986, 999.999999881332, -0.000275591603385253, 25.1120923524431, 2 ),
      ( 200, 6.03027112779114, 9999.99875199388, -0.00276275457773696, 25.2036271510825, 2 ),
      ( 200, 28466.5432584617, 99999.9999981361, -0.997887481137563, 43.0748660384864, 1 ),
      ( 200, 28488.6600468779, 1000000.00042622, -0.978891211596432, 43.0903850227139, 1 ),
      ( 200, 28701.8349065808, 9999999.99999934, -0.79047991231054, 43.24470223268, 1 ),
      ( 250, 0.481152147995707, 999.999999994902, -0.000131498268471595, 25.3876033746334, 2 ),
      ( 250, 4.81723053611039, 9999.99994776406, -0.00131647485287061, 25.4207759997175, 2 ),
      ( 250, 48.7583061638658, 99999.9999999707, -0.0133191343757033, 25.7578336283813, 2 ),
      ( 250, 25823.6722768403, 1000000.00367218, -0.981370237590445, 39.0837461683162, 1 ),
      ( 250, 26178.6040798198, 10000000.0000008, -0.816228216044809, 39.2295422460518, 1 ),
      ( 300, 0.400936893855758, 999.999999998395, -7.3567906565483E-05, 25.8798615335181, 2 ),
      ( 300, 4.01202731505443, 9999.99998369892, -0.000736120953137945, 25.894544802601, 2 ),
      ( 300, 40.3898680847212, 99999.9999999987, -0.00740602331118623, 26.0425077112451, 2 ),
      ( 300, 435.438513467631, 999999.999999984, -0.079301932722552, 27.6916407666208, 2 ),
      ( 300, 23205.6886200635, 10000000.0017113, -0.827237448369594, 36.8388491701501, 1 ),
      ( 350, 0.343650463058773, 999.999999999985, -4.52514634325679E-05, 26.5411246811058, 2 ),
      ( 350, 3.43790535024103, 9999.99999785563, -0.000452667062639645, 26.5486144022632, 2 ),
      ( 350, 34.5202832772256, 100000, -0.00454202643906841, 26.6238584759039, 2 ),
      ( 350, 360.612682228147, 999999.990327682, -0.047080345537774, 27.4156990687194, 2 ),
      ( 350, 18948.1610307868, 10000000.0000002, -0.818644716067106, 35.9277526506241, 1 ),
      ( 400, 0.300689430252236, 999.999999999947, -2.95385387152499E-05, 27.3101594926748, 2 ),
      ( 400, 3.00769407838512, 9999.99999945689, -0.000295440660954171, 27.3144137245248, 2 ),
      ( 400, 30.1573191974896, 99999.9943398605, -0.00295995672223839, 27.3570854992266, 2 ),
      ( 400, 310.037010747401, 999999.99987659, -0.0301785338395772, 27.7973155979619, 2 ),
      ( 400, 5053.0015370477, 9999999.98332577, -0.404946650754765, 34.7541331344988, 2 ),
      ( 500, 0.240547781971444, 999.99786230403, -1.38987089493628E-05, 29.0157149776896, 2 ),
      ( 500, 2.4057787686906, 9999.99999999969, -0.00013899120238205, 29.017459475045, 2 ),
      ( 500, 24.0879331706354, 99999.9999968518, -0.00139029381705264, 29.0349307543187, 2 ),
      ( 500, 243.945342771553, 999999.999999999, -0.0139412545131102, 29.2122494497903, 2 ),
      ( 500, 2804.21405206512, 10000000, -0.142203718423184, 31.1947753060558, 2 ),
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
      ( 200, 0.601667781830496, 999.999998424233, -0.000509725113327478, 44.3100820639054, 2 ),
      ( 200, 16590.0823616155, 100000.000002472, -0.996375177148042, 60.5486746743713, 1 ),
      ( 200, 16607.228204365, 1000000.00075921, -0.963789195300896, 60.5858728619868, 1 ),
      ( 200, 16770.4404786398, 9999999.99999859, -0.641416039478905, 60.9460079438479, 1 ),
      ( 250, 0.481205802867215, 999.999999896643, -0.000242984488405687, 50.4879071341599, 2 ),
      ( 250, 4.82263400806502, 9999.99891741136, -0.00243543954253459, 50.5490253524526, 2 ),
      ( 250, 49.3397778217899, 99999.9980545336, -0.0249472153985967, 51.193876299365, 2 ),
      ( 250, 15115.2279863294, 999999.999999774, -0.968171907314026, 62.8491906520398, 1 ),
      ( 250, 15383.783040899, 10000000.0000849, -0.687275310600628, 63.1759233287796, 1 ),
      ( 300, 0.400961735490546, 999.999999988067, -0.000135518474517579, 57.3241723579972, 2 ),
      ( 300, 4.01452053839724, 9999.99987762785, -0.00135671510415228, 57.3517389467966, 2 ),
      ( 300, 40.6486107317212, 99999.9999998325, -0.0137242317731589, 57.633934592601, 2 ),
      ( 300, 13824.7934773588, 10000000.0017871, -0.710008400130175, 67.3513166354026, 1 ),
      ( 350, 0.343663466968115, 999.999999998041, -8.30888309326569E-05, 64.5187531309032, 2 ),
      ( 350, 3.43920844886816, 9999.99998008592, -0.000831390472684328, 64.5330472752703, 2 ),
      ( 350, 34.6533604026588, 99999.9999999977, -0.00836482112820653, 64.6777137280086, 2 ),
      ( 350, 377.449715397375, 1000000.01903686, -0.0895875724478803, 66.3353174521864, 2 ),
      ( 350, 11877.9691031986, 10000000.000001, -0.710695566399557, 73.0148676111111, 1 ),
      ( 400, 0.300696815971342, 999.999999999594, -5.40998261996229E-05, 71.6727910609413, 2 ),
      ( 400, 3.00843357024721, 9999.99999588516, -0.000541174318740083, 71.6810124495124, 2 ),
      ( 400, 30.2322000525987, 99999.9999999998, -0.00542948309246237, 71.7637643947176, 2 ),
      ( 400, 318.590174687259, 1000000.00000105, -0.0562152501375798, 72.6499523850199, 2 ),
      ( 400, 8787.03393590605, 9999999.99999686, -0.657813375344829, 80.6178889069089, 1 ),
      ( 500, 0.240550550394014, 999.997926380751, -2.54072195784645E-05, 84.919658616037, 2 ),
      ( 500, 2.40605572508779, 9999.99999999944, -0.00025408325939486, 84.9230895037524, 2 ),
      ( 500, 24.1157433127668, 99999.9999949729, -0.00254188501763804, 84.9574705146588, 2 ),
      ( 500, 246.844427626895, 999999.986390465, -0.0255221028915216, 85.3083963030006, 2 ),
      ( 500, 3204.18322626175, 9999999.99997367, -0.249280014047452, 89.0652303507088, 2 ),
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
      ( 200, 0.601935009255471, 999.999999989273, -0.00095344612760056, 63.516994428307, 2 ),
      ( 200, 11324.9793589995, 100000.000000236, -0.994689958573539, 79.1684363890894, 1 ),
      ( 200, 11336.5115346779, 1000000.00222954, -0.946953602433187, 79.2306954983371, 1 ),
      ( 200, 11446.4011726687, 9999999.99999744, -0.474628673609519, 79.8222337951486, 1 ),
      ( 250, 0.48130528858373, 999.999999997187, -0.000449634083562386, 75.591622474, 2 ),
      ( 250, 4.83272625610918, 9999.9999700774, -0.0045186674314416, 75.7125519194061, 2 ),
      ( 250, 10438.9068338612, 99999.9999992834, -0.995391386452221, 87.5339434492451, 1 ),
      ( 250, 10457.3878399332, 999999.999999701, -0.953995310830335, 87.5915851174057, 1 ),
      ( 250, 10627.2248292463, 10000000.0000489, -0.547305260733345, 88.1432628431863, 1 ),
      ( 300, 0.401007235646024, 999.999999999584, -0.000248967772488536, 88.770064758812, 2 ),
      ( 300, 4.01910302002823, 9999.9999956643, -0.00249534343438194, 88.8249791174337, 2 ),
      ( 300, 41.1418867625225, 99999.9999999996, -0.0255493140557376, 89.4101532833875, 2 ),
      ( 300, 9463.37983599948, 1000000.00000002, -0.957635918169247, 98.2080499502709, 1 ),
      ( 300, 9750.53084626635, 10000000.0022133, -0.588835311458365, 98.64725852604, 1 ),
      ( 350, 0.343687211852277, 999.999999999968, -0.000152171736576309, 102.497204651109, 2 ),
      ( 350, 3.44159243274746, 9999.99999966683, -0.00152351247952677, 102.525766475371, 2 ),
      ( 350, 34.9016620479976, 99999.9947006365, -0.0154196319105939, 102.820174101522, 2 ),
      ( 350, 419.286357918181, 999999.999682461, -0.180429064974491, 106.990608314733, 2 ),
      ( 350, 8762.80584624867, 10000000.0000001, -0.60784830977471, 110.617400571848, 1 ),
      ( 400, 0.300710370706897, 999.998293463384, -9.91729353115312E-05, 116.035910479466, 2 ),
      ( 400, 3.0097923052872, 9999.99999997867, -0.000992368152036071, 116.052506751108, 2 ),
      ( 400, 30.3714163359628, 99999.9996377291, -0.00998838818396597, 116.221141328785, 2 ),
      ( 400, 336.928588251198, 999999.999525852, -0.107583746736003, 118.233049125745, 2 ),
      ( 400, 7558.23438204832, 10000000.0000003, -0.602181497520083, 123.39852811701, 1 ),
      ( 500, 0.240555806558265, 999.998379143276, -4.72567231463787E-05, 140.823800739218, 2 ),
      ( 500, 2.40658182603814, 9999.99999999938, -0.000472636923835225, 140.830706082337, 2 ),
      ( 500, 24.168841747225, 99999.9999923468, -0.00473327939464097, 140.900046998492, 2 ),
      ( 500, 252.68291106178, 999999.999999997, -0.0480383590250976, 141.623136013992, 2 ),
      ( 500, 4098.15361778402, 10000000.0179185, -0.413041918205596, 147.74465423777, 1 ),
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
