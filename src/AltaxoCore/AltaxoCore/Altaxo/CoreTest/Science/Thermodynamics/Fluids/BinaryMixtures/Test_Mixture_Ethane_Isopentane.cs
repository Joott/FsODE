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
  /// Tests and test data for <see cref="Mixture_Ethane_Isopentane"/>.
  /// </summary>
  /// <remarks>
  /// <para>Reference:</para>
  /// <para>The test data was created automatically using calls into the TREND.DLL of the following software:</para>
  /// <para>TREND 3.0.: Span, R.; Eckermann, T.; Herrig, S.; Hielscher, S.; Jäger, A.; Thol, M. (2016): TREND.Thermodynamic Reference and Engineering Data 3.0.Lehrstuhl für Thermodynamik, Ruhr-Universität Bochum.</para>
  /// </remarks>
  
  public class Test_Mixture_Ethane_Isopentane : MixtureTestBase
  {

    public Test_Mixture_Ethane_Isopentane()
    {
      _mixture = MixtureOfFluids.FromCASRegistryNumbersAndMoleFractions(new[] { ("74-84-0", 0.5), ("78-78-4", 0.5) });

      // TestData for 1 Permille to 999 Permille Molefraction contains:
      // 0. Temperature (Kelvin)
      // 1. Mole density (mol/m³)
      // 2. Pressure (Pa)
      // 3. delta*AlphaR_delta
      // 4. Isochoric heat capacity (J/mol K)
      // 5. Phasetype (1: liquid, 2: gas)
      _testData_001_999 = new (double temperature, double moleDensity, double pressure, double deltaPhiR_delta, double cv, int phase)[]
      {
      ( 150, 10445.5786786097, 999999.999995806, -0.923238834323835, 88.5644061584253, 1 ),
      ( 150, 10500.5703624603, 9999999.99999623, -0.236408340049546, 89.0644001607304, 1 ),
      ( 150, 10941.5930383187, 100000000.000838, 6.328135790956, 93.6098750414117, 1 ),
      ( 200, 9816.08515235775, 1000000.00241453, -0.938737175981283, 97.1636022955853, 1 ),
      ( 200, 9892.93560813224, 10000000.0000007, -0.39213078863893, 97.6064619952021, 1 ),
      ( 200, 10462.2713983632, 99999999.9999989, 4.74790190154794, 101.57814641879, 1 ),
      ( 250, 0.481475272310269, 999.999998966464, -0.000802523017623256, 93.9796828249659, 2 ),
      ( 250, 4.8501052765236, 9999.99990371305, -0.00808570127154579, 94.3167949913243, 2 ),
      ( 250, 9187.16090400032, 1000000.00134899, -0.947634652029221, 109.421705682914, 1 ),
      ( 250, 9296.80376122164, 10000000.0000003, -0.482522284348877, 109.822336809717, 1 ),
      ( 250, 10026.1033246763, 100000000.000026, 3.7983634493117, 113.455749355815, 1 ),
      ( 300, 0.40107587279337, 999.999843298878, -0.000420057676289416, 111.157355620794, 2 ),
      ( 300, 4.02604794030201, 9999.99850259324, -0.00421603524403543, 111.300244175754, 2 ),
      ( 300, 8682.62899561637, 10000000.0000005, -0.538264967937433, 123.74836190953, 1 ),
      ( 350, 0.343720558197047, 999.99997586075, -0.000249172825208029, 128.087703753041, 2 ),
      ( 350, 3.4449506815386, 9999.99999998975, -0.00249685949054818, 128.157196390874, 2 ),
      ( 350, 35.2631128483547, 100000.001644226, -0.0255116906480401, 128.874103141668, 2 ),
      ( 350, 7752.86872417157, 1000000.00467742, -0.955676417826995, 138.306213090494, 1 ),
      ( 350, 8021.84267275493, 10000000.0054484, -0.571625963547201, 138.469199122301, 1 ),
      ( 350, 9230.19253875814, 100000000.000991, 2.72294414155267, 141.572754820085, 1 ),
      ( 400, 0.3007287962857, 999.999995008425, -0.000160436779569503, 144.487586239249, 2 ),
      ( 400, 3.01164313886683, 9999.99999999976, -0.00160631767532535, 144.524909441217, 2 ),
      ( 400, 30.5651651569106, 100000.00015487, -0.0162639502372528, 144.904713900409, 2 ),
      ( 400, 372.17807609781, 999999.998627509, -0.192105694128684, 150.191029870692, 2 ),
      ( 400, 7276.14445327217, 9999999.99999997, -0.58675841270536, 153.422085583052, 1 ),
      ( 400, 8860.04149801776, 100000000.000224, 2.3936697519276, 156.113894549646, 1 ),
      ( 500, 0.240562996705838, 999.999999634705, -7.71442216728078E-05, 174.831502654386, 2 ),
      ( 500, 2.40730221360662, 9999.99624578352, -0.000771746185938081, 174.844872547452, 2 ),
      ( 500, 24.2422776275883, 99999.9999042064, -0.00774818942105182, 174.979668975935, 2 ),
      ( 500, 261.711447273025, 1000000.00000347, -0.0808791851979384, 176.451171367922, 2 ),
      ( 500, 5267.33869501696, 10000000.0010491, -0.543328324595901, 183.037113997614, 1 ),
      ( 500, 8168.77279670132, 100000000, 1.94468269159736, 183.861931950171, 1 ),
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
      ( 150, 13480.1771963046, 1000000.00080392, -0.940518972095736, 64.3463590466767, 1 ),
      ( 150, 13574.0093970732, 9999999.99999709, -0.409301428876969, 64.7375861413583, 1 ),
      ( 200, 12484.6002659682, 1000000.00101381, -0.95183176999044, 69.6029027665012, 1 ),
      ( 200, 12625.2122290121, 10000000.0000022, -0.523682385892921, 69.9878565627386, 1 ),
      ( 200, 13589.7920605101, 100000000.000046, 3.42509417343804, 73.3727513669933, 1 ),
      ( 250, 0.481251946762476, 999.982226277422, -0.000338838196057016, 66.358765540171, 2 ),
      ( 250, 4.82730976946924, 9999.99991468945, -0.00340168683185475, 66.4464738026817, 2 ),
      ( 250, 11415.365398667, 999999.999999032, -0.95785602471777, 77.2457481654747, 1 ),
      ( 250, 11640.3262282871, 10000000.0000088, -0.586704987569251, 77.5941720642129, 1 ),
      ( 250, 12931.2403294067, 99999999.9999964, 2.72036142756794, 80.8815150577176, 1 ),
      ( 300, 0.400983417373075, 999.999997329177, -0.000189582914818724, 77.8000032371809, 2 ),
      ( 300, 4.01670151174974, 9999.99999999991, -0.00189895466311569, 77.8383854475556, 2 ),
      ( 300, 40.8802255103414, 100000.000124097, -0.0193121668166683, 78.244992776851, 2 ),
      ( 300, 10556.4179247015, 10000000.0000108, -0.620224018575949, 86.7443918177737, 1 ),
      ( 300, 12308.6096759549, 100000000.001281, 2.25712983291549, 89.7903572249656, 1 ),
      ( 350, 0.3436750326177, 999.999999164723, -0.000116738899974687, 89.4086815395735, 2 ),
      ( 350, 3.44036871333502, 9999.99126535717, -0.00116835910058742, 89.4282734202915, 2 ),
      ( 350, 34.7732100487584, 99999.9832783651, -0.0117825972935488, 89.6288432977454, 2 ),
      ( 350, 9269.96569843358, 10000000.0000202, -0.629302929965481, 96.9844575156297, 1 ),
      ( 350, 11716.5572191153, 100000000.007297, 1.93290004877749, 99.4974939682717, 1 ),
      ( 400, 0.300703513433554, 999.999999733463, -7.63712649257182E-05, 100.845625043261, 2 ),
      ( 400, 3.00910456982604, 9999.99726221299, -0.00076404321753708, 100.856786856014, 2 ),
      ( 400, 30.3005774192191, 99999.9999500424, -0.00767386642582121, 100.969632956577, 2 ),
      ( 400, 326.999149558592, 1000000.0080726, -0.0804852290684378, 102.236031116236, 2 ),
      ( 400, 7562.60508571926, 10000000.0000052, -0.602411411255944, 108.14764910421, 1 ),
      ( 400, 11153.6424392579, 100000000.000003, 1.69580587654085, 109.475884725849, 1 ),
      ( 500, 0.240553157714201, 999.999999981166, -3.62458493462165E-05, 122.268865022665, 2 ),
      ( 500, 2.40631661338489, 9999.99981027555, -0.000362473814376719, 122.273455368817, 2 ),
      ( 500, 24.1419890544927, 99999.9999999297, -0.00362626244246839, 122.319504023439, 2 ),
      ( 500, 249.631962987469, 1000000.00010084, -0.0364036889304828, 122.794349648843, 2 ),
      ( 500, 3516.349587475, 10000000.0027028, -0.315925698901256, 127.366066637128, 1 ),
      ( 500, 10118.0942352364, 99999999.9999993, 1.37736902887156, 128.856504766897, 1 ),
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
      ( 150, 19464.2390484316, 1000000.0019034, -0.958805746526195, 43.4307455458988, 1 ),
      ( 150, 19649.3554398047, 10000000.0000008, -0.591938372741344, 43.7783129594762, 1 ),
      ( 150, 20998.1021851476, 99999999.9999992, 2.81851078000162, 46.6326004868347, 1 ),
      ( 200, 0.601509462816863, 999.999987147915, -0.000246656407600542, 34.0514777511059, 2 ),
      ( 200, 6.02853742695701, 9999.99999954017, -0.00247596711496366, 34.0907469085647, 2 ),
      ( 200, 61.7195505542886, 100000.004786377, -0.0256554196124964, 34.5979973694379, 2 ),
      ( 200, 17442.946124081, 1000000.00000002, -0.965524109731249, 43.4925665687759, 1 ),
      ( 200, 17770.7596245043, 10000000.0000105, -0.661600792899055, 43.8374775939441, 1 ),
      ( 200, 19712.8955420002, 99999999.9999967, 2.05059749020858, 46.8591675147956, 1 ),
      ( 250, 0.48115012022964, 999.999998860467, -0.000127284407965461, 38.7574840818117, 2 ),
      ( 250, 4.81702679918362, 9999.98794103513, -0.00127423384028019, 38.7732634005186, 2 ),
      ( 250, 48.7368066587455, 100000.00006631, -0.0128838750438925, 38.9447465019116, 2 ),
      ( 250, 563.888080434167, 999999.998717992, -0.146836235523515, 41.7655254284173, 2 ),
      ( 250, 15607.5203820067, 10000000.0002512, -0.691758289877204, 46.1542705098218, 1 ),
      ( 250, 18496.0152874027, 100000000.000617, 1.60104065578151, 48.9331187578235, 1 ),
      ( 300, 0.400936818269625, 999.999999981917, -7.33793966331074E-05, 44.450879923169, 2 ),
      ( 300, 4.01201932423096, 9999.99945941056, -0.000734130659699531, 44.4590247871281, 2 ),
      ( 300, 40.3886205844874, 99999.9999981373, -0.00737536464704754, 44.5422085748263, 2 ),
      ( 300, 434.639141830656, 999999.9999998, -0.0776086201550134, 45.5528815898013, 2 ),
      ( 300, 12678.9396414623, 9999999.99999449, -0.683800531349962, 50.8672155566902, 1 ),
      ( 300, 17339.5070994791, 100000000.000003, 1.31210377243022, 52.6585272286424, 1 ),
      ( 350, 0.343650442324365, 999.999999984759, -4.51911304109557E-05, 50.7335563001325, 2 ),
      ( 350, 3.43790307098488, 9999.99984579458, -0.0004520043772805, 50.7384094474014, 2 ),
      ( 350, 34.5198452782074, 99999.9999999358, -0.00452939574499645, 50.7872259743236, 2 ),
      ( 350, 360.308296311606, 1000000.01703346, -0.0462753269932336, 51.305876043067, 2 ),
      ( 350, 7254.6451345493, 10000000.0068491, -0.52632429855346, 57.8925369679081, 1 ),
      ( 350, 16243.3839666783, 99999999.9996359, 1.11553770492843, 57.4894317119139, 1 ),
      ( 400, 0.300689257250557, 999.999999996204, -2.89632053286936E-05, 57.2056797868135, 2 ),
      ( 400, 3.00767666425762, 9999.99996176, -0.000289652476957328, 57.2088612170554, 2 ),
      ( 400, 30.1554622789404, 99999.9999999976, -0.00289856097708756, 57.2407219695698, 2 ),
      ( 400, 309.718783864434, 1000000.00002272, -0.0291820709935942, 57.5641383095298, 2 ),
      ( 400, 4202.16949707244, 9999999.99999999, -0.284463540713109, 60.9800402110153, 2 ),
      ( 400, 15212.550407713, 99999999.9999945, 0.976529511931122, 62.883236270304, 1 ),
      ( 500, 0.240547443233633, 999.999999999704, -1.24905628006397E-05, 69.7068751911844, 2 ),
      ( 500, 2.40574485194592, 9999.99999704676, -0.000124894931695737, 69.7085241022184, 2 ),
      ( 500, 24.0844982237776, 100000, -0.00124787144910949, 69.7250018926018, 2 ),
      ( 500, 243.555400392792, 999999.999746189, -0.0123625332326578, 69.8885971093797, 2 ),
      ( 500, 2680.18991902773, 9999999.99999999, -0.102509725325931, 71.3347110168306, 2 ),
      ( 500, 13369.3707432739, 100000000.00122, 0.799220346874906, 73.9388972675888, 1 ),
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
