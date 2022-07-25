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
  /// Tests and test data for <see cref="Mixture_Pentane_H2S"/>.
  /// </summary>
  /// <remarks>
  /// <para>Reference:</para>
  /// <para>The test data was created automatically using calls into the TREND.DLL of the following software:</para>
  /// <para>TREND 3.0.: Span, R.; Eckermann, T.; Herrig, S.; Hielscher, S.; Jäger, A.; Thol, M. (2016): TREND.Thermodynamic Reference and Engineering Data 3.0.Lehrstuhl für Thermodynamik, Ruhr-Universität Bochum.</para>
  /// </remarks>
  
  public class Test_Mixture_Pentane_H2S : MixtureTestBase
  {

    public Test_Mixture_Pentane_H2S()
    {
      _mixture = MixtureOfFluids.FromCASRegistryNumbersAndMoleFractions(new[] { ("109-66-0", 0.5), ("7783-06-4", 0.5) });

      // TestData for 1 Permille to 999 Permille Molefraction contains:
      // 0. Temperature (Kelvin)
      // 1. Mole density (mol/m³)
      // 2. Pressure (Pa)
      // 3. delta*AlphaR_delta
      // 4. Isochoric heat capacity (J/mol K)
      // 5. Phasetype (1: liquid, 2: gas)
      _testData_001_999 = new (double temperature, double moleDensity, double pressure, double deltaPhiR_delta, double cv, int phase)[]
      {
      ( 200, 0.601527068849646, 999.999999782604, -0.00027592265570764, 25.1338249876625, 2 ),
      ( 200, 6.03029120170152, 9999.99770798118, -0.0027660784945721, 25.2255297253891, 2 ),
      ( 200, 28451.1866157569, 100000.000001413, -0.997886340906608, 43.1025921746072, 1 ),
      ( 200, 28473.2908884792, 1000000.0016744, -0.978879817679404, 43.1181025849436, 1 ),
      ( 200, 28686.3446804006, 9999999.99999884, -0.790366775342446, 43.2723443652464, 1 ),
      ( 200, 30305.5478919057, 100000000.000002, 0.984326751155386, 44.6888847497775, 1 ),
      ( 250, 0.481152215058659, 999.999999994869, -0.0001316421997935, 25.4097459778346, 2 ),
      ( 250, 4.81723747144281, 9999.9999474114, -0.00131791721261022, 25.4429769810648, 2 ),
      ( 250, 48.7590347936024, 99999.9999999704, -0.0133338833324123, 25.7806278405076, 2 ),
      ( 250, 25810.6301697179, 1000000.00364924, -0.981360824060229, 39.1106906251143, 1 ),
      ( 250, 26165.2919260814, 10000000.0000014, -0.816134719046553, 39.2564229592801, 1 ),
      ( 250, 28479.757647643, 99999999.9999986, 0.689230930525284, 40.6560448063547, 1 ),
      ( 300, 0.400936922736319, 999.999999998385, -7.36445039540075E-05, 25.9033258769866, 2 ),
      ( 300, 4.01203037582973, 9999.99998360004, -0.000736887857852153, 25.9180333544618, 2 ),
      ( 300, 40.3901838404166, 99999.9999999986, -0.00741378758431738, 26.0662400081612, 2 ),
      ( 300, 435.481072059029, 999999.999999985, -0.0793919146933997, 27.7182831564034, 2 ),
      ( 300, 23195.3667077152, 10000000.0016957, -0.827160570016757, 36.8663054006023, 1 ),
      ( 300, 26673.171155022, 100000000.000879, 0.503036116735766, 38.2061209358991, 1 ),
      ( 350, 0.343650477357801, 999.999999999983, -4.52976409082716E-05, 26.5667115374305, 2 ),
      ( 350, 3.43790692392765, 9999.99999784249, -0.000453129169263159, 26.5742127134752, 2 ),
      ( 350, 34.5204445324907, 100000, -0.00454668106888476, 26.6495719381539, 2 ),
      ( 350, 360.631729351686, 999999.990175127, -0.0471306792841709, 27.4426453580889, 2 ),
      ( 350, 18944.3477680157, 10000000.0000003, -0.818608212321598, 35.954676438007, 1 ),
      ( 350, 24870.7792868447, 100000000.01052, 0.38168131713995, 36.7235405256217, 1 ),
      ( 400, 0.300689437940602, 999.999999999945, -2.95686772962407E-05, 27.3382645403926, 2 ),
      ( 400, 3.00769497176266, 9999.99999945352, -0.000295742172823526, 27.3425247659157, 2 ),
      ( 400, 30.1574106414884, 99999.9943043957, -0.00296298452570236, 27.3852567515863, 2 ),
      ( 400, 310.047121937027, 999999.999874768, -0.0302101658795111, 27.8261187398776, 2 ),
      ( 400, 5058.92552490026, 9999999.98807612, -0.40564345958821, 34.8002830789291, 2 ),
      ( 400, 23080.437614223, 100000000.000001, 0.302750632277257, 35.8635146186644, 1 ),
      ( 500, 0.24054778441799, 999.997871322536, -1.39134499104279E-05, 29.0490974952664, 2 ),
      ( 500, 2.40577911240991, 9999.99999999967, -0.000139138624582363, 29.0508440282713, 2 ),
      ( 500, 24.0879686537048, 99999.9999968756, -0.00139176939496832, 29.0683357385698, 2 ),
      ( 500, 243.949026434124, 999999.999999998, -0.0139561486371734, 29.245866143472, 2 ),
      ( 500, 2804.74227436178, 10000000, -0.142365272702083, 31.2310965875019, 2 ),
      ( 500, 19652.0766890016, 100000000.000101, 0.224015361674776, 35.2743861416151, 1 ),
      ( 600, 0.200455076642856, 999.998358552042, -6.87771471082297E-06, 30.8675524143758, 2 ),
      ( 600, 2.00467484683132, 9999.99999999992, -6.87728256292307E-05, 30.8684556992178, 2 ),
      ( 600, 20.0591561472654, 99999.9999992478, -0.000687284668726423, 30.8774960761952, 2 ),
      ( 600, 201.831869528554, 999999.993076622, -0.00682831478694761, 30.9686315084666, 2 ),
      ( 600, 2140.23469464983, 9999999.99999938, -0.0634031937298287, 31.9277292296045, 2 ),
      ( 600, 16662.8012179525, 100000000.000001, 0.20300119617155, 35.5642319505751, 1 ),
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
      ( 200, 14524.341981312, 99999.9999993174, -0.995859642251614, 74.5380978052351, 1 ),
      ( 200, 14537.3041660199, 1000000.00118424, -0.958633339721213, 74.5688026881111, 1 ),
      ( 200, 14661.3357212894, 10000000.0000019, -0.589832922553581, 74.8735196665518, 1 ),
      ( 250, 0.481267484292829, 999.999998868276, -0.000373402204619327, 61.5632807018423, 2 ),
      ( 250, 4.82896899735756, 9999.99996422475, -0.00374639342710474, 61.689695070388, 2 ),
      ( 250, 13417.0828505096, 1000000.0017447, -0.964143638079893, 76.3535951964267, 1 ),
      ( 250, 13606.2545545369, 10000000.0000009, -0.646421595289603, 76.6316146037766, 1 ),
      ( 250, 14814.5471463074, 99999999.9998554, 2.24740117400236, 79.1954852911978, 1 ),
      ( 300, 0.400987482913967, 999.999999876436, -0.000202004526149141, 69.0580894796994, 2 ),
      ( 300, 4.01719355757483, 9999.99871500077, -0.00202348732524761, 69.1126239188229, 2 ),
      ( 300, 40.9337000604683, 100000.000762278, -0.0205955460423076, 69.671450685374, 2 ),
      ( 300, 12467.0563167959, 10000000.0007997, -0.678427311572147, 81.0663433109405, 1 ),
      ( 300, 14098.106367813, 99999999.9988147, 1.84369028835266, 83.4747996284575, 1 ),
      ( 350, 0.343676092334757, 999.999999979968, -0.000122106909454739, 77.3130688575696, 2 ),
      ( 350, 3.44054642856353, 9999.99979491248, -0.00122223532528185, 77.3400484603188, 2 ),
      ( 350, 34.7928119962249, 99999.9999995932, -0.0123416087133118, 77.6133603648727, 2 ),
      ( 350, 11148.7205337877, 9999999.99999907, -0.691772588551533, 87.2796766372127, 1 ),
      ( 350, 13409.7650414506, 99999999.9925403, 1.56256635387838, 89.4109529263152, 1 ),
      ( 400, 0.300703687012938, 999.999999995791, -7.9233455917032E-05, 85.7258444059342, 2 ),
      ( 400, 3.00918419383881, 9999.99995725073, -0.000792766899115178, 85.7406325262416, 2 ),
      ( 400, 30.3095972095079, 99999.9999999906, -0.00797143830849684, 85.8897336948096, 2 ),
      ( 400, 328.512029272879, 999999.999999991, -0.0847219144877968, 87.5311333844124, 2 ),
      ( 400, 9448.52091312212, 10000000.0000003, -0.681770444299876, 94.6571552789839, 1 ),
      ( 400, 12747.2729869538, 100000000.000001, 1.35877792473069, 96.0721882913945, 1 ),
      ( 500, 0.240552970408013, 999.999999999702, -3.77523150532716E-05, 101.611208936752, 2 ),
      ( 500, 2.40634745688894, 9999.99999699313, -0.000377571044933671, 101.616790285354, 2 ),
      ( 500, 24.1456720210094, 100000, -0.00378051698126444, 101.672830848413, 2 ),
      ( 500, 250.124033625183, 999999.995234398, -0.0383015756763379, 102.25611389822, 2 ),
      ( 500, 3978.28269380645, 10000000, -0.395357475850131, 108.841142019702, 1 ),
      ( 500, 11507.4269593855, 100000000, 1.09033600495984, 109.500158031655, 1 ),
      ( 600, 0.200457142803715, 999.999999999971, -1.94654574108314E-05, 115.586191920982, 2 ),
      ( 600, 2.00492263854434, 9999.99999970376, -0.000194636141778251, 115.588833045707, 2 ),
      ( 600, 20.0843784672565, 99999.99702033, -0.00194451547278696, 115.615305651126, 2 ),
      ( 600, 204.389231316743, 999999.999990676, -0.019257328175319, 115.885866897037, 2 ),
      ( 600, 2397.24612018178, 9999999.99999727, -0.163818687091894, 118.701702775057, 2 ),
      ( 600, 10401.9770837965, 100000000.000001, 0.927068663956135, 121.851044645754, 1 ),
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
      ( 200, 9864.32561396684, 99999.9999987901, -0.993903705498931, 107.218271190532, 1 ),
      ( 200, 9871.78601049486, 999999.999998348, -0.939083125450902, 107.26411643446, 1 ),
      ( 200, 9943.58196739285, 10000000.0000012, -0.395229653748819, 107.717489276062, 1 ),
      ( 200, 10485.505299487, 99999999.9999955, 4.73513945021541, 111.735744320001, 1 ),
      ( 250, 0.481518925989837, 999.999983675852, -0.000897670207865848, 97.7360640940643, 2 ),
      ( 250, 9242.10000913276, 100000.009966608, -0.994794616786337, 114.370943492955, 1 ),
      ( 250, 9252.85189677705, 1000000.00576264, -0.948006659094768, 114.412781264532, 1 ),
      ( 250, 9354.29912578459, 10000000.0000048, -0.485705263105025, 114.829073381778, 1 ),
      ( 300, 0.401091808037527, 999.999997988407, -0.000464334373857724, 112.221132420714, 2 ),
      ( 300, 4.02783488145766, 9999.9999999999, -0.00466235798919226, 112.388873555046, 2 ),
      ( 300, 8584.28480437704, 100000.000002218, -0.99532977322551, 125.429471094792, 1 ),
      ( 300, 8600.71974748448, 999999.999999738, -0.95338697468421, 125.464723091046, 1 ),
      ( 300, 8750.3823075643, 10000000.0000969, -0.541842226739657, 125.829991666887, 1 ),
      ( 300, 9636.48426791891, 100000000.000002, 3.1602887129518, 129.280570027712, 1 ),
      ( 350, 0.343727136083273, 999.999999699512, -0.000272869532746046, 128.063549642615, 2 ),
      ( 350, 3.44575730880335, 9999.99683660146, -0.00273492029575807, 128.145201763722, 2 ),
      ( 350, 35.3536602039048, 99999.9965341571, -0.0280119744572752, 128.99003606739, 2 ),
      ( 350, 7865.32365572253, 1000000.00261337, -0.956310336439268, 139.040690364273, 1 ),
      ( 350, 8105.01401854105, 10000000.0022206, -0.576023751834116, 139.272952815398, 1 ),
      ( 350, 9246.62549655132, 100000000.000001, 2.71631081580404, 142.46724353597, 1 ),
      ( 400, 0.300731643289667, 999.999999939393, -0.000174467164112204, 144.115747867435, 2 ),
      ( 400, 3.01205388405627, 9999.99937427333, -0.00174702345935189, 144.159635015775, 2 ),
      ( 400, 30.6101187475483, 99999.9999933393, -0.0177131360617478, 144.606902876587, 2 ),
      ( 400, 382.981911792588, 999999.999983749, -0.21489980012585, 151.119540510603, 2 ),
      ( 400, 7382.80088395096, 10000000.0000011, -0.592730211448685, 153.715956865283, 1 ),
      ( 400, 8874.17347777453, 100000000.000002, 2.38824991697386, 156.525595682679, 1 ),
      ( 500, 0.240563354465685, 999.999999995665, -8.31966762739443E-05, 174.17435132287, 2 ),
      ( 500, 2.40743721761745, 9999.99995600828, -0.000832343062609848, 174.190076762621, 2 ),
      ( 500, 24.2571595925544, 99999.9999999897, -0.00836147156829381, 174.348714156685, 2 ),
      ( 500, 263.718120467981, 1000000, -0.0878770864614674, 176.093762519856, 2 ),
      ( 500, 5458.59723833616, 10000000, -0.559331216626851, 182.848164084, 1 ),
      ( 500, 8178.07963157673, 100000000.000002, 1.94131814839993, 183.794911856314, 1 ),
      ( 600, 0.200461681315271, 999.999999999523, -4.43858068653728E-05, 200.305503409263, 2 ),
      ( 600, 2.00541798247232, 9999.99999518232, -0.00044387048567297, 200.312454784528, 2 ),
      ( 600, 20.1346751524254, 99999.9999999999, -0.00443994180282804, 200.382313857785, 2 ),
      ( 600, 209.790984182527, 999999.988256879, -0.0445119243193022, 201.11454324547, 2 ),
      ( 600, 3075.72397583176, 10000000.0000875, -0.348274470542798, 207.361780447045, 1 ),
      ( 600, 7549.2073785995, 100000000.000003, 1.65528251654594, 208.083744299926, 1 ),
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
