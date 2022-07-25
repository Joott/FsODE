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
  /// Tests and test data for <see cref="Mixture_Methane_Octane"/>.
  /// </summary>
  /// <remarks>
  /// <para>Reference:</para>
  /// <para>The test data was created automatically using calls into the TREND.DLL of the following software:</para>
  /// <para>TREND 3.0.: Span, R.; Eckermann, T.; Herrig, S.; Hielscher, S.; Jäger, A.; Thol, M. (2016): TREND.Thermodynamic Reference and Engineering Data 3.0.Lehrstuhl für Thermodynamik, Ruhr-Universität Bochum.</para>
  /// </remarks>
  
  public class Test_Mixture_Methane_Octane : MixtureTestBase
  {

    public Test_Mixture_Methane_Octane()
    {
      _mixture = MixtureOfFluids.FromCASRegistryNumbersAndMoleFractions(new[] { ("74-82-8", 0.5), ("111-65-9", 0.5) });

      // TestData for 1 Permille to 999 Permille Molefraction contains:
      // 0. Temperature (Kelvin)
      // 1. Mole density (mol/m³)
      // 2. Pressure (Pa)
      // 3. delta*AlphaR_delta
      // 4. Isochoric heat capacity (J/mol K)
      // 5. Phasetype (1: liquid, 2: gas)
      _testData_001_999 = new (double temperature, double moleDensity, double pressure, double deltaPhiR_delta, double cv, int phase)[]
      {
      ( 250, 6454.43812873413, 100000.000000432, -0.992546420478485, 188.894884649781, 1 ),
      ( 250, 6459.89382628882, 999999.999999749, -0.925527153924465, 188.955287791278, 1 ),
      ( 250, 6512.1086635881, 10000000.0000005, -0.261242857957977, 189.552229518539, 1 ),
      ( 250, 6893.97586807533, 100000000.009376, 5.97836325276657, 194.837114074164, 1 ),
      ( 300, 0.40153966306857, 999.999992021137, -0.00157916547273779, 180.324507384899, 2 ),
      ( 300, 6104.03883939705, 100000.00000004, -0.993432126235798, 206.65939420447, 1 ),
      ( 300, 6111.49352177237, 1000000.00464208, -0.93440137571583, 206.714777694228, 1 ),
      ( 300, 6181.54331139251, 10000000.0000032, -0.351447453705215, 207.265019502955, 1 ),
      ( 300, 6650.20667486696, 100000000.014083, 5.02846776265744, 212.132038225193, 1 ),
      ( 350, 0.343927628651752, 999.999975476771, -0.000855664884867706, 205.764920871901, 2 ),
      ( 350, 3.46622534433467, 9999.98557198296, -0.00862375607591831, 206.174328436294, 2 ),
      ( 350, 5742.80640483627, 100000.000001181, -0.994016281977322, 227.827236931659, 1 ),
      ( 350, 5753.37161341139, 1000000.00000026, -0.94027270182778, 227.875668900905, 1 ),
      ( 350, 5849.77016436848, 10000000.0000814, -0.412569498992944, 228.370006960573, 1 ),
      ( 350, 6423.38198213451, 100000000.000001, 4.34972609141836, 232.920326432112, 1 ),
      ( 400, 0.300832912407971, 999.999995953543, -0.000511042118402584, 231.25620286315, 2 ),
      ( 400, 3.02230799357456, 9999.99999999948, -0.0051339083704555, 231.476314568837, 2 ),
      ( 400, 31.7828172869145, 99999.9999889134, -0.0539568238832355, 233.810466074102, 2 ),
      ( 400, 5368.48103777909, 999999.999999821, -0.943991760052332, 250.159043331572, 1 ),
      ( 400, 5507.10328878106, 10000000.0009554, -0.454015734996624, 250.547386280326, 1 ),
      ( 400, 6209.54870153893, 99999999.9999984, 3.84220655287139, 254.801508676681, 1 ),
      ( 500, 0.240596488534938, 999.999999783235, -0.000220906133962408, 278.250093704514, 2 ),
      ( 500, 2.41076874140451, 9999.99773574405, -0.00221313108515208, 278.328756061286, 2 ),
      ( 500, 24.6093802481261, 99999.9998509555, -0.022554258262694, 279.133790734084, 2 ),
      ( 500, 4356.33075248769, 1000000.00252265, -0.944783040237261, 293.910002005937, 1 ),
      ( 500, 4746.49932704925, 10000000.0000005, -0.493219480884038, 293.173499808665, 1 ),
      ( 500, 5813.05315932524, 100000000, 3.13798623033277, 296.598231944927, 1 ),
      ( 600, 0.200475146505597, 999.99999997974, -0.000111553777713225, 318.196639244894, 2 ),
      ( 600, 2.00676811480134, 9999.99979316876, -0.00111636580291765, 318.230924618077, 2 ),
      ( 600, 20.2733072313127, 99999.999999648, -0.0112477430643147, 318.577823711798, 2 ),
      ( 600, 228.412327023914, 999999.999730429, -0.122408210774834, 322.514157779301, 2 ),
      ( 600, 3797.55655973739, 9999999.99996325, -0.472153265935506, 331.27467275837, 1 ),
      ( 600, 5452.70343927647, 99999999.9999998, 2.67620914978714, 333.023328209144, 1 ),
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
      ( 250, 10865.0831918493, 100000000.000114, 3.42782323977973, 110.895896094823, 1 ),
      ( 300, 0.401037285077929, 999.999999997494, -0.000328447232951367, 103.935727071407, 2 ),
      ( 300, 10400.8865146604, 100000000.00059, 2.8545326393899, 120.439417143943, 1 ),
      ( 350, 0.343700178550782, 999.999996930614, -0.000194462223282266, 117.777904882617, 2 ),
      ( 350, 3.44303989968068, 9999.99999523608, -0.00194783719347757, 117.829394317839, 2 ),
      ( 350, 9963.28010880867, 99999999.9931808, 2.44899810178923, 131.931689639635, 1 ),
      ( 400, 0.300716535450386, 999.999999376184, -0.000124241029206263, 131.865276157794, 2 ),
      ( 400, 3.01053556761229, 9999.99348985047, -0.00124357407585171, 131.893559640404, 2 ),
      ( 400, 30.4502052497908, 99999.98202309, -0.0125545214825547, 132.181084682127, 2 ),
      ( 400, 9548.04770416639, 99999999.9959191, 2.14911679774955, 144.148797112021, 1 ),
      ( 500, 0.24055731225062, 999.999999957758, -5.80857662944654E-05, 158.338188470003, 2 ),
      ( 500, 2.40683178326631, 9999.99957133306, -0.000581008721916971, 158.348925536624, 2 ),
      ( 500, 24.1952787184944, 99999.9999993176, -0.00582530127844851, 158.457047184109, 2 ),
      ( 500, 255.864483772461, 1000000.00855538, -0.0598799191940762, 159.615060025939, 2 ),
      ( 500, 8779.93218515927, 99999999.9999999, 1.73969472909367, 167.885093584094, 1 ),
      ( 600, 0.200458750828559, 999.999999995919, -2.97721245330313E-05, 181.32283093499, 2 ),
      ( 600, 2.00512475595506, 9999.99995905112, -0.000297701424398142, 181.32789262455, 2 ),
      ( 600, 20.1050915140788, 99999.9999999978, -0.0029750294528853, 181.378678757067, 2 ),
      ( 600, 206.555776159203, 1000000.00000553, -0.0295464669497633, 181.902504354878, 2 ),
      ( 600, 2622.8210851234, 10000000.0000122, -0.23573596429204, 186.739216834774, 1 ),
      ( 600, 8094.19579232323, 99999999.9999998, 1.47650029587598, 189.001078801844, 1 ),
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
      ( 250, 0.481102042686364, 999.999999990195, -3.19352141604869E-05, 26.0840853987855, 2 ),
      ( 250, 4.81240376167313, 9999.99987616905, -0.000319377972880394, 26.0866286663121, 2 ),
      ( 250, 23234.4114325132, 99999999.9999992, 1.07057828853106, 31.5106430862887, 1 ),
      ( 300, 0.400912430525677, 999.999999998932, -1.71235257940323E-05, 27.6160878790866, 2 ),
      ( 300, 4.00974222363133, 9999.99998928775, -0.000171225150890793, 27.6175210050637, 2 ),
      ( 300, 40.159278469055, 99999.9999999999, -0.00171123392903696, 27.6318616339724, 2 ),
      ( 300, 407.840165107142, 999999.995172974, -0.0170032286564255, 27.7761382812694, 2 ),
      ( 300, 4696.9410675541, 9999999.99999997, -0.146453916016237, 29.169483286719, 2 ),
      ( 300, 21227.6011253745, 99999999.9999996, 0.888605137827404, 31.9971296723652, 1 ),
      ( 350, 0.343636527708837, 999.999999999875, -9.27101418698625E-06, 29.8246673627846, 2 ),
      ( 350, 3.43665198032574, 9999.99999873502, -9.2695399590699E-05, 29.8255703534583, 2 ),
      ( 350, 34.395166076301, 99999.9877815383, -0.000925475613964561, 29.8345963758088, 2 ),
      ( 350, 346.790097870317, 999999.99997828, -0.00910278592128954, 29.9244412665926, 2 ),
      ( 350, 3698.4828522005, 10000000.0017639, -0.0708802620446191, 30.7454860756232, 2 ),
      ( 350, 19433.8694801362, 99999999.9999997, 0.76821884185416, 33.424844472379, 1 ),
      ( 400, 0.300680604410001, 999.982135704942, -4.75676159633493E-06, 32.4924721991143, 2 ),
      ( 400, 3.00693473712467, 9999.99999989274, -4.75553851929479E-05, 32.4930833327579, 2 ),
      ( 400, 30.0821837025745, 99999.998780137, -0.000474243847838492, 32.4991897695773, 2 ),
      ( 400, 302.071567465274, 999999.999999938, -0.00460948163272347, 32.5597578895943, 2 ),
      ( 400, 3102.4815618399, 9999999.99999842, -0.0308429941476125, 33.1073716905768, 1 ),
      ( 400, 17855.8387843831, 100000000.000134, 0.683926348963665, 35.4888746580258, 1 ),
      ( 500, 0.240543406068395, 999.996558966659, -2.72154402400521E-07, 38.4326549291998, 2 ),
      ( 500, 2.40543991975715, 9999.99999999999, -2.71335363874543E-06, 38.4329746368793, 2 ),
      ( 500, 24.0549668924733, 99999.9999999239, -2.63131932888421E-05, 38.4361690648392, 2 ),
      ( 500, 240.58682248261, 1000000.00007298, -0.000180738027810902, 38.4678498315208, 1 ),
      ( 500, 2389.45942028863, 10000000.0003496, 0.0066851826505563, 38.7594738143795, 1 ),
      ( 500, 15286.8837053354, 100000000.001678, 0.573527632795857, 40.5651650412442, 1 ),
      ( 600, 0.200452452970949, 1000.01720395844, 1.61291946446214E-06, 44.4517238329691, 1 ),
      ( 600, 2.00449548719774, 10000.0000000025, 1.61338646707832E-05, 44.4519095998619, 1 ),
      ( 600, 20.0420348045552, 100000.000025586, 0.000161833368910229, 44.453766171811, 1 ),
      ( 600, 200.119019822975, 999999.999999999, 0.00166782209287684, 44.4722231736354, 1 ),
      ( 600, 1962.16871318079, 10000000.0001, 0.0215879062752631, 44.6471146116877, 1 ),
      ( 600, 13342.9959050387, 100000000.000051, 0.502307159294061, 46.0092546810589, 1 ),
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
