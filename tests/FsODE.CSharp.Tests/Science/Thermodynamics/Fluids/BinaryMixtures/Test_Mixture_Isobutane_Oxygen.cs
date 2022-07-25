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
  /// Tests and test data for <see cref="Mixture_Isobutane_Oxygen"/>.
  /// </summary>
  /// <remarks>
  /// <para>Reference:</para>
  /// <para>The test data was created automatically using calls into the TREND.DLL of the following software:</para>
  /// <para>TREND 3.0.: Span, R.; Eckermann, T.; Herrig, S.; Hielscher, S.; Jäger, A.; Thol, M. (2016): TREND.Thermodynamic Reference and Engineering Data 3.0.Lehrstuhl für Thermodynamik, Ruhr-Universität Bochum.</para>
  /// </remarks>
  
  public class Test_Mixture_Isobutane_Oxygen : MixtureTestBase
  {

    public Test_Mixture_Isobutane_Oxygen()
    {
      _mixture = MixtureOfFluids.FromCASRegistryNumbersAndMoleFractions(new[] { ("75-28-5", 0.5), ("7782-44-7", 0.5) });

      // TestData for 1 Permille to 999 Permille Molefraction contains:
      // 0. Temperature (Kelvin)
      // 1. Mole density (mol/m³)
      // 2. Pressure (Pa)
      // 3. delta*AlphaR_delta
      // 4. Isochoric heat capacity (J/mol K)
      // 5. Phasetype (1: liquid, 2: gas)
      _testData_001_999 = new (double temperature, double moleDensity, double pressure, double deltaPhiR_delta, double cv, int phase)[]
      {
      ( 150, 0.80188554292783, 999.99609116245, -7.23671050148988E-05, 20.8297976797864, 2 ),
      ( 150, 8.02408476522137, 9999.99999999464, -0.000724025198364754, 20.8367268871575, 2 ),
      ( 150, 25478.4682958676, 9999999.99999988, -0.685292104982727, 25.9682226863626, 1 ),
      ( 200, 0.601388668724279, 999.993376339976, -2.99875629409694E-05, 20.8552727642422, 2 ),
      ( 200, 6.01551044865579, 9999.99999999341, -0.000299908782216267, 20.8577033993847, 2 ),
      ( 200, 60.3181506679977, 99999.9999335684, -0.00300220121337142, 20.8820800667041, 2 ),
      ( 200, 620.180281059914, 999999.999999992, -0.0303293206992954, 21.133010640957, 2 ),
      ( 200, 8699.82532046617, 9999999.99994919, -0.308755506836843, 24.0860482609022, 2 ),
      ( 250, 0.481103129110201, 999.996582705558, -1.37632614655558E-05, 20.9413721872403, 2 ),
      ( 250, 4.81162728092833, 9999.99999999919, -0.000137626107658934, 20.942539352296, 2 ),
      ( 250, 48.1759193978402, 99999.9999919476, -0.00137555535414149, 20.9542148563788, 2 ),
      ( 250, 487.767592726446, 1000000, -0.0136767700161094, 21.0713030309676, 2 ),
      ( 250, 5458.84586736969, 9999999.9925063, -0.118684573142628, 22.1994990104277, 2 ),
      ( 300, 0.400916259489608, 999.998450571101, -6.24370507340922E-06, 21.1385043247851, 2 ),
      ( 300, 4.00938785676245, 9999.99999999993, -6.24269696345937E-05, 21.1392087495211, 2 ),
      ( 300, 40.1163780905166, 99999.9999992581, -0.00062324824473259, 21.146249654757, 2 ),
      ( 300, 403.385158042742, 999999.993606404, -0.00612665508125758, 21.2163034569893, 2 ),
      ( 300, 4207.15847934023, 9999999.99999996, -0.0470676152287043, 21.8605865942136, 2 ),
      ( 350, 0.343641186109188, 999.999494227966, -2.34964072381219E-06, 21.4610130707831, 2 ),
      ( 350, 3.43648434178882, 10000, -2.34881056484942E-05, 21.4614962752009, 2 ),
      ( 350, 34.3720809775865, 99999.9999999627, -0.000234048231653697, 21.4663247514928, 2 ),
      ( 350, 344.417238583655, 999999.999739707, -0.00225562477041568, 21.5142453938571, 2 ),
      ( 350, 3480.56765561852, 9999999.99999999, -0.0126887435346055, 21.9509297108446, 1 ),
      ( 400, 0.300685374958286, 999.999954348826, -1.88285457970125E-07, 21.8866409919246, 2 ),
      ( 400, 3.00685881500666, 9999.99556162843, -1.87667036133397E-06, 21.8869971922085, 2 ),
      ( 400, 30.0690774043316, 100000, -1.81476508515508E-05, 21.8905562429432, 2 ),
      ( 400, 300.721063216959, 1000000, -0.000118867645790658, 21.9258489062226, 1 ),
      ( 400, 2989.98395810283, 9999999.99999999, 0.00564190786803189, 22.2472580747483, 1 ),
      ( 500, 0.240547810164087, 1000.00041909164, 1.8079868672306E-06, 22.8967165428544, 1 ),
      ( 500, 2.405439039682, 10000, 1.80831916178461E-05, 22.8969344687231, 1 ),
      ( 500, 24.0504682720662, 100000.000000016, 0.000181165075676471, 22.8991118270205, 1 ),
      ( 500, 240.105227383754, 1000000.00018125, 0.00184513427934323, 22.9206954045821, 1 ),
      ( 500, 2353.89228503703, 10000000.0000001, 0.0219169980665617, 23.1177511580827, 1 ),
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
      ( 200, 0.601486907695347, 999.999999978336, -0.000201230350917352, 42.1694936502458, 2 ),
      ( 250, 0.481141755102526, 999.999620925159, -0.000101963432479761, 48.2589171860617, 2 ),
      ( 250, 4.81584082757628, 9999.99999999992, -0.00102035460898834, 48.2728759449436, 2 ),
      ( 250, 48.6088088703597, 99999.9999979403, -0.0102767224521618, 48.4149842192024, 2 ),
      ( 300, 0.40093369476049, 999.990273280494, -5.76513109228088E-05, 54.9493398491521, 2 ),
      ( 300, 4.01141912889686, 9999.99999997269, -0.000576685456390981, 54.9562449517623, 2 ),
      ( 300, 40.3242788940683, 99999.999731588, -0.00578363407845487, 55.02577822957, 2 ),
      ( 350, 0.3436495513726, 999.991379902691, -3.46606401721791E-05, 61.9750672429139, 2 ),
      ( 350, 3.43756798402491, 9999.99999998707, -0.000346635314746038, 61.978947326403, 2 ),
      ( 350, 34.4833846562648, 99999.9998684725, -0.00346893558632151, 62.0178482706236, 2 ),
      ( 350, 356.077356022874, 999999.99999996, -0.0349354309000111, 62.416876512119, 2 ),
      ( 400, 0.300689394558542, 999.998725366416, -2.14820126930002E-05, 68.9575178925658, 2 ),
      ( 400, 3.00747537763177, 9999.99999999749, -0.000214806833463997, 68.9599515724535, 2 ),
      ( 400, 30.1329798733865, 99999.9999697882, -0.00214669640665306, 68.9843035444229, 2 ),
      ( 400, 307.231178764421, 999999.999999998, -0.021313734022173, 69.229124913251, 2 ),
      ( 500, 0.240548313205367, 999.997929028679, -8.16921863457218E-06, 81.8564681577372, 2 ),
      ( 500, 2.40565994695733, 9999.99999999986, -8.16681768474801E-05, 81.8576884101316, 2 ),
      ( 500, 24.0742374872678, 99999.9999984401, -0.000814259488880473, 81.869882816814, 2 ),
      ( 500, 242.460808720955, 999999.988024475, -0.00789595885766481, 81.99093647423, 2 ),
      ( 500, 2532.41694437361, 10000000, -0.0501313433241403, 83.0405608647277, 1 ),
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
      ( 200, 0.601933905980995, 999.999999988976, -0.000951599131243273, 63.5125880239118, 2 ),
      ( 200, 11445.4642456295, 9999999.99999862, -0.474585658309922, 79.7986680116519, 1 ),
      ( 250, 0.481304937231222, 999.999999997193, -0.000448888543189995, 75.5871303590565, 2 ),
      ( 250, 4.8326897385359, 9999.99997016044, -0.00451112940581253, 75.7076610606339, 2 ),
      ( 250, 10455.4692645617, 1000000.00000011, -0.953986868253543, 87.5710886229337, 1 ),
      ( 250, 10625.6529664559, 10000000.0000523, -0.547238285988574, 88.1230773920893, 1 ),
      ( 300, 0.401007088520395, 999.999999999588, -0.00024858510150253, 88.7653025013675, 2 ),
      ( 300, 4.01908758172963, 9999.99999571396, -0.00249149593862697, 88.8200656926655, 2 ),
      ( 300, 41.1401679000488, 99999.9999999994, -0.02550858541315, 89.4035655955837, 2 ),
      ( 300, 9460.22162864911, 999999.999999187, -0.95762177464023, 98.1909113654277, 1 ),
      ( 300, 9748.15969368308, 10000000.0022362, -0.588735292798347, 98.6297189968231, 1 ),
      ( 350, 0.343687139490878, 999.980036998751, -0.000151942317025039, 102.49211104275, 2 ),
      ( 350, 3.44158466127922, 9999.99999968164, -0.00152124196047624, 102.52060197114, 2 ),
      ( 350, 34.9008331260188, 99999.994929377, -0.0153962317652398, 102.814259522798, 2 ),
      ( 350, 419.103481326179, 999999.999923722, -0.180071430692748, 106.970161743109, 2 ),
      ( 350, 8759.28530169113, 9999999.99999964, -0.607690689374607, 110.602765072282, 1 ),
      ( 400, 0.300710331279146, 999.998337530388, -9.90259631829455E-05, 116.030476169876, 2 ),
      ( 400, 3.00978791727216, 9999.99999997975, -0.000990895823597523, 116.047033604842, 2 ),
      ( 400, 30.3709570950301, 99999.9996560615, -0.00997340244851278, 116.215266864625, 2 ),
      ( 400, 336.858870670829, 999999.999542891, -0.107399034738946, 118.221366040948, 2 ),
      ( 400, 7552.82486921811, 10000000, -0.601896564125457, 123.388342138237, 1 ),
      ( 500, 0.2405557925513, 999.9984248959, -4.7182625482051E-05, 140.817672306231, 2 ),
      ( 500, 2.40658007885542, 9999.99999999939, -0.00047189539621259, 140.824563167886, 2 ),
      ( 500, 24.1686607681385, 99999.9999927732, -0.00472581086556321, 140.893757552011, 2 ),
      ( 500, 252.661558169858, 999999.999999996, -0.0479578918853872, 141.615194172475, 2 ),
      ( 500, 4091.6327588845, 10000000.0136083, -0.412106470355468, 147.723234302644, 1 ),
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
