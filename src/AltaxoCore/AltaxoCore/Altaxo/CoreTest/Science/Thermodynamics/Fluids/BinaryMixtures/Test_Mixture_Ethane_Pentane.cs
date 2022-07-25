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
  /// Tests and test data for <see cref="Mixture_Ethane_Pentane"/>.
  /// </summary>
  /// <remarks>
  /// <para>Reference:</para>
  /// <para>The test data was created automatically using calls into the TREND.DLL of the following software:</para>
  /// <para>TREND 3.0.: Span, R.; Eckermann, T.; Herrig, S.; Hielscher, S.; Jäger, A.; Thol, M. (2016): TREND.Thermodynamic Reference and Engineering Data 3.0.Lehrstuhl für Thermodynamik, Ruhr-Universität Bochum.</para>
  /// </remarks>
  
  public class Test_Mixture_Ethane_Pentane : MixtureTestBase
  {

    public Test_Mixture_Ethane_Pentane()
    {
      _mixture = MixtureOfFluids.FromCASRegistryNumbersAndMoleFractions(new[] { ("74-84-0", 0.5), ("109-66-0", 0.5) });

      // TestData for 1 Permille to 999 Permille Molefraction contains:
      // 0. Temperature (Kelvin)
      // 1. Mole density (mol/m³)
      // 2. Pressure (Pa)
      // 3. delta*AlphaR_delta
      // 4. Isochoric heat capacity (J/mol K)
      // 5. Phasetype (1: liquid, 2: gas)
      _testData_001_999 = new (double temperature, double moleDensity, double pressure, double deltaPhiR_delta, double cv, int phase)[]
      {
      ( 150, 10487.9120473238, 99999.9999999887, -0.99235490236053, 104.024008748273, 1 ),
      ( 150, 10493.2227336502, 1000000.00001155, -0.923587714346989, 104.075336905667, 1 ),
      ( 150, 10544.9635051947, 10000000.0007189, -0.23962644895, 104.583264217047, 1 ),
      ( 150, 10965.5454934254, 100000000.00257, 6.31209528196957, 109.163750136287, 1 ),
      ( 200, 9862.70187329992, 99999.9999978768, -0.993902701838425, 107.216915405399, 1 ),
      ( 200, 9870.16271992624, 999999.999998965, -0.939073106792322, 107.262767864434, 1 ),
      ( 200, 9941.96258917848, 10000000.0000012, -0.395131146847834, 107.716212550235, 1 ),
      ( 200, 10483.9006668596, 100000000.004658, 4.73601725274817, 111.73509604741, 1 ),
      ( 250, 0.48151887779313, 999.999978554545, -0.000897570200038026, 97.7494151091773, 2 ),
      ( 250, 9240.54427796059, 99999.9999996093, -0.994793740930636, 114.377038754905, 1 ),
      ( 250, 9251.29699070474, 1000000.0031666, -0.947997920480545, 114.418888084439, 1 ),
      ( 250, 9352.75084206872, 10000000.0000031, -0.485620125140884, 114.835296897811, 1 ),
      ( 250, 10045.4986331904, 100000000.00782, 3.78907716172722, 118.528161083705, 1 ),
      ( 300, 0.401091797499381, 999.999997951885, -0.000464308112387921, 112.239693762309, 2 ),
      ( 300, 4.02783385250282, 9999.99999999988, -0.00466210371915441, 112.407378870389, 2 ),
      ( 300, 9635.0129920125, 100000000.012212, 3.16092399357835, 129.294798607783, 1 ),
      ( 350, 0.343727134428302, 999.999999693906, -0.000272864719275141, 128.087738013445, 2 ),
      ( 350, 3.44575714523399, 9999.99677721248, -0.00273487293952834, 128.169363184526, 2 ),
      ( 350, 35.3536451109147, 100000.004305936, -0.0280115617389588, 129.013977823645, 2 ),
      ( 350, 7863.86694715562, 1000000.00297088, -0.956302243317914, 139.060333390479, 1 ),
      ( 350, 8103.59153887938, 10000000.0023035, -0.57594932833747, 139.292607078583, 1 ),
      ( 350, 9245.21526519261, 100000000.017864, 2.71687768888376, 142.48802453912, 1 ),
      ( 400, 0.300731643696446, 999.999999938237, -0.000174468516507583, 144.145643584482, 2 ),
      ( 400, 3.01205392465653, 9999.99936231828, -0.00174703691297382, 144.189517281442, 2 ),
      ( 400, 30.6101226725451, 99999.9999930731, -0.0177132620158781, 144.636661474932, 2 ),
      ( 400, 382.980504585379, 999999.999980368, -0.214896915386255, 151.148020156084, 2 ),
      ( 400, 7381.44266647732, 10000000.0000015, -0.592655272040707, 153.742101176975, 1 ),
      ( 400, 8872.82494920388, 99999999.9999994, 2.38876487718584, 156.552623977462, 1 ),
      ( 500, 0.240563355082555, 999.999999995579, -8.31992403342143E-05, 174.215048969033, 2 ),
      ( 500, 2.40743727915515, 9999.99995515038, -0.000832368602758385, 174.230770740088, 2 ),
      ( 500, 24.2571655904068, 99999.9999999891, -0.00836171676187673, 174.389371792928, 2 ),
      ( 500, 263.718472963864, 1000000, -0.0878783056387525, 176.134083208103, 2 ),
      ( 500, 5457.44159134245, 9999999.99999995, -0.559237902287852, 182.886552537888, 1 ),
      ( 500, 8176.85801917399, 99999999.9999995, 1.94175757766744, 183.833366542475, 1 ),
      ( 600, 0.200461681595459, 999.999999999511, -4.43872045189988E-05, 200.355664971877, 2 ),
      ( 600, 2.00541801041398, 9999.99999508822, -0.000443884412566541, 200.362615355959, 2 ),
      ( 600, 20.1346778675986, 99999.9999999999, -0.0044400760546877, 200.432464399091, 2 ),
      ( 600, 209.791156500106, 999999.987812057, -0.0445127091151467, 201.164581426451, 2 ),
      ( 600, 3075.35958093752, 10000000.0001144, -0.348197248530652, 207.40967346856, 1 ),
      ( 600, 7548.11262335334, 99999999.9999998, 1.65566763062805, 208.132071310895, 1 ),
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
      ( 150, 13685.2972253629, 1000000.0009192, -0.941410628476005, 72.3806102116104, 1 ),
      ( 150, 13772.3654641296, 10000000.0000005, -0.417810277159904, 72.7571516593143, 1 ),
      ( 250, 0.481267004652638, 999.999987572991, -0.000372405952824888, 68.2440280891265, 2 ),
      ( 250, 4.82894250683945, 9999.99819901161, -0.00374092753491385, 68.348112606318, 2 ),
      ( 250, 11683.8772029263, 999999.999998378, -0.958824646185689, 79.9499164363482, 1 ),
      ( 250, 11883.337676718, 10000000.0000628, -0.595157698080402, 80.3021640300595, 1 ),
      ( 300, 0.400989375408882, 999.999997247834, -0.000206723135967706, 78.3410254382655, 2 ),
      ( 300, 4.01738526818444, 9999.99999999992, -0.00207111126939898, 78.3863071405166, 2 ),
      ( 300, 40.9553024668399, 99999.9999999894, -0.0211121454857303, 78.8697453693945, 2 ),
      ( 300, 10840.6020298827, 10000000.0000767, -0.630180611257425, 87.9467543656378, 1 ),
      ( 300, 12463.5517015974, 99999999.9978494, 2.21663111140516, 90.9895574700683, 1 ),
      ( 350, 0.343677699868138, 999.999999524369, -0.00012678378279141, 89.40831332205, 2 ),
      ( 350, 3.44070765582301, 9999.9950527996, -0.00126903619931915, 89.431295665767, 2 ),
      ( 350, 34.8094200473247, 99999.9868329157, -0.0128128323072119, 89.667401754581, 2 ),
      ( 350, 9625.19112503176, 10000000.0000041, -0.642984619582548, 97.4630473134221, 1 ),
      ( 350, 11867.6114233267, 99999999.9990901, 1.89556267768836, 100.054411724514, 1 ),
      ( 400, 0.300704774159705, 999.999999896318, -8.2848498707505E-05, 100.674225089508, 2 ),
      ( 400, 3.00929302072869, 9999.99893984552, -0.000828901752166875, 100.687237817979, 2 ),
      ( 400, 30.320593434575, 99999.9999928412, -0.00833121256277544, 100.819017786311, 2 ),
      ( 400, 329.738884690312, 999999.999999861, -0.0881273784163824, 102.323817255607, 2 ),
      ( 400, 8052.29187507108, 9999999.99999997, -0.626590955858971, 108.221928880559, 1 ),
      ( 400, 11299.5709730067, 99999999.9999826, 1.66098475719891, 109.777828713406, 1 ),
      ( 500, 0.240553390469195, 999.999999992523, -3.94984776132968E-05, 121.960155706276, 2 ),
      ( 500, 2.40638945485166, 9999.99992464565, -0.000395017139758707, 121.965431487754, 2 ),
      ( 500, 24.1498631525793, 99999.9999999876, -0.0039534076872218, 122.018385951584, 2 ),
      ( 500, 250.528594188991, 1000000.00036201, -0.0398545533234357, 122.567709503682, 2 ),
      ( 500, 3765.93791639992, 10000000.0003391, -0.361264326937186, 128.015438920236, 1 ),
      ( 500, 10250.2212654307, 99999999.9999978, 1.34671899023025, 128.897534412878, 1 ),
      ( 600, 0.20045727794652, 999.999999999288, -2.01396168892889E-05, 140.666974654373, 2 ),
      ( 600, 2.00493613841762, 9999.99999285256, -0.000201368149438283, 140.669648129323, 2 ),
      ( 600, 20.0857138257626, 100000, -0.00201086925298387, 140.696416152007, 2 ),
      ( 600, 204.505822509009, 999999.997446471, -0.0198164611421692, 140.967090248676, 2 ),
      ( 600, 2364.20695324968, 10000000, -0.152133274382515, 143.485524563811, 1 ),
      ( 600, 9324.51930707018, 100000000.000005, 1.14974342603712, 146.195896775153, 1 ),
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
      ( 150, 19465.580396345, 1000000.0018996, -0.9588085853572, 43.4471582300505, 1 ),
      ( 150, 19650.6319475515, 10000000.0000019, -0.591964882345521, 43.7946192378363, 1 ),
      ( 150, 20999.051755962, 100000000.000001, 2.81833809063981, 46.6483249053686, 1 ),
      ( 200, 0.601509505897863, 999.999987159743, -0.000246732580630108, 34.0600576587419, 2 ),
      ( 200, 6.02854206311763, 9999.9999996499, -0.00247673880503655, 34.0993524241953, 2 ),
      ( 200, 61.7200922361088, 100000.006502199, -0.0256639757860527, 34.6069001284668, 2 ),
      ( 200, 17444.6477220151, 999999.999999526, -0.96552747276003, 43.5035486958252, 1 ),
      ( 200, 17772.2962427873, 10000000.0000124, -0.661630052927385, 43.8484451161393, 1 ),
      ( 200, 19713.8737724249, 100000000.000001, 2.05044610128557, 46.8697767993545, 1 ),
      ( 250, 0.481150136206267, 999.999998861551, -0.000127322178577403, 38.7612519071225, 2 ),
      ( 250, 4.81702860476707, 9999.98795258176, -0.00127461276163859, 38.7770399179824, 2 ),
      ( 250, 48.7369995933901, 100000.000066444, -0.0128877872415146, 38.948627883777, 2 ),
      ( 250, 563.925063730148, 999999.998693398, -0.146892191547321, 41.771998893339, 2 ),
      ( 250, 15609.5099505118, 10000000.0002526, -0.691797579386422, 46.1598597142938, 1 ),
      ( 250, 18497.0042444976, 100000000.000618, 1.60090157717998, 48.9386816977086, 1 ),
      ( 300, 0.400936825281469, 999.999999981937, -7.34014540091219E-05, 44.4519607323663, 2 ),
      ( 300, 4.01202019262929, 9999.99945997131, -0.000734351516954613, 44.4601095231413, 2 ),
      ( 300, 40.3887114370798, 99999.9999981406, -0.00737760204813384, 44.5433349689105, 2 ),
      ( 300, 434.65132572232, 999999.999999797, -0.0776344803060441, 45.5546492884478, 2 ),
      ( 300, 12682.0620580236, 9999999.99999454, -0.683878383419753, 50.8688775542968, 1 ),
      ( 300, 17340.4902596254, 100000000.000004, 1.31197267166677, 52.6611141261452, 1 ),
      ( 350, 0.34365044565625, 999.999999984774, -4.52053956745917E-05, 50.7335548682352, 2 ),
      ( 350, 3.43790354624216, 9999.99984593967, -0.000452147123511534, 50.7384100992065, 2 ),
      ( 350, 34.5198949482551, 99999.9999999359, -0.00453083265912548, 50.7872478976179, 2 ),
      ( 350, 360.314118976653, 1000000.01710842, -0.0462907435171585, 51.306157069918, 2 ),
      ( 350, 7259.02773243001, 10000000.0089842, -0.526610279841394, 57.8963845638524, 1 ),
      ( 350, 16244.3436136998, 99999999.9996441, 1.11541271825267, 57.4906752286338, 1 ),
      ( 400, 0.300689258849354, 999.999999996207, -2.8973092494207E-05, 57.2053365146158, 2 ),
      ( 400, 3.00767694808161, 9999.99996179205, -0.000289751385159184, 57.208519176585, 2 ),
      ( 400, 30.155492165178, 99999.9999999977, -0.00289955373262124, 57.2403923500049, 2 ),
      ( 400, 309.722073017431, 1000000.00002275, -0.0291923852178413, 57.5639438054703, 2 ),
      ( 400, 4203.03724140213, 10000000, -0.284611271130829, 60.9822155269356, 2 ),
      ( 400, 15213.4689733315, 99999999.9999959, 0.976410163117401, 62.8839259518917, 1 ),
      ( 500, 0.240547443444903, 999.999999999707, -1.2496011361743E-05, 69.7062574409153, 2 ),
      ( 500, 2.40574497206147, 9999.99999704828, -0.000124949423860843, 69.7079068864949, 2 ),
      ( 500, 24.084511270079, 100000, -0.00124841702623433, 69.7243900321247, 2 ),
      ( 500, 243.556760840594, 999999.999745853, -0.0123680544449871, 69.8880397585052, 2 ),
      ( 500, 2680.3671780738, 10000000, -0.10256908259047, 71.3347367710954, 2 ),
      ( 500, 13370.1665348737, 100000000.001122, 0.799113249151896, 73.9390177597907, 1 ),
      ( 600, 0.20045472360628, 999.999999999985, -5.11655948110322E-06, 80.9788460565932, 2 ),
      ( 600, 2.00463952473069, 9999.99999985533, -5.11538617253276E-05, 80.979850580936, 2 ),
      ( 600, 20.0556054073565, 99999.9986214384, -0.000510361578771183, 80.9898851591372, 2 ),
      ( 600, 201.457402046387, 999999.99999989, -0.0049822149213869, 81.0891487086434, 2 ),
      ( 600, 2076.02958699186, 10000000.0000004, -0.0344371813206263, 81.9579634265355, 1 ),
      ( 600, 11832.531018675, 100000000.002907, 0.694089773818732, 84.3094255922478, 1 ),
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
