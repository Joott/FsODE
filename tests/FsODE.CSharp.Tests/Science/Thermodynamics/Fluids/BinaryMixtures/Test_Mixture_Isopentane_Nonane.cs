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
  /// Tests and test data for <see cref="Mixture_Isopentane_Nonane"/>.
  /// </summary>
  /// <remarks>
  /// <para>Reference:</para>
  /// <para>The test data was created automatically using calls into the TREND.DLL of the following software:</para>
  /// <para>TREND 3.0.: Span, R.; Eckermann, T.; Herrig, S.; Hielscher, S.; Jäger, A.; Thol, M. (2016): TREND.Thermodynamic Reference and Engineering Data 3.0.Lehrstuhl für Thermodynamik, Ruhr-Universität Bochum.</para>
  /// </remarks>
  
  public class Test_Mixture_Isopentane_Nonane : MixtureTestBase
  {

    public Test_Mixture_Isopentane_Nonane()
    {
      _mixture = MixtureOfFluids.FromCASRegistryNumbersAndMoleFractions(new[] { ("78-78-4", 0.5), ("111-84-2", 0.5) });

      // TestData for 1 Permille to 999 Permille Molefraction contains:
      // 0. Temperature (Kelvin)
      // 1. Mole density (mol/m³)
      // 2. Pressure (Pa)
      // 3. delta*AlphaR_delta
      // 4. Isochoric heat capacity (J/mol K)
      // 5. Phasetype (1: liquid, 2: gas)
      _testData_001_999 = new (double temperature, double moleDensity, double pressure, double deltaPhiR_delta, double cv, int phase)[]
      {
      ( 350, 0.344026572825826, 999.999997040654, -0.00113845988388878, 231.86756110475, 2 ),
      ( 350, 5254.49623509083, 1000000.00012626, -0.934601739802976, 253.831251807604, 1 ),
      ( 350, 5331.28884868837, 10000000.000014, -0.35543745215052, 254.441671611767, 1 ),
      ( 350, 5811.9497793138, 100000000.000026, 4.91255818478625, 259.6814459964, 1 ),
      ( 400, 0.300884053464689, 999.999258517419, -0.000676356840690053, 260.37424784804, 2 ),
      ( 400, 3.02740608911625, 9999.9936042051, -0.00680470072094359, 260.679378080796, 2 ),
      ( 400, 4917.30226171997, 100000.000004925, -0.993885253898639, 279.086347592497, 1 ),
      ( 400, 4929.30981013002, 999999.99999942, -0.939001491174838, 279.138355438602, 1 ),
      ( 400, 5036.07787419251, 10000000.0001539, -0.402946984066389, 279.678906730146, 1 ),
      ( 400, 5619.71338685538, 100000000.000004, 4.35046055959308, 284.627081429931, 1 ),
      ( 500, 0.240614520088463, 999.99996195464, -0.000291260166186211, 313.035412054302, 2 ),
      ( 500, 2.41248798648645, 9999.99999996867, -0.00291964142697538, 313.1437155835, 2 ),
      ( 500, 24.7968343681083, 100000.003030214, -0.0299389234192602, 314.26094697662, 2 ),
      ( 500, 4147.44628832867, 1000000.00000018, -0.942001795338604, 327.957636357945, 1 ),
      ( 500, 4400.42951959113, 10000000.0000016, -0.453361455763998, 327.88180843569, 1 ),
      ( 500, 5264.55329034734, 100000000.00202, 3.56913294250679, 332.089202775603, 1 ),
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
      ( 300, 0.401304028767317, 1000.00000307765, -0.000988355391963967, 157.22706200114, 2 ),
      ( 300, 6641.46960314202, 1000000.00108945, -0.939635740005314, 175.866567637783, 1 ),
      ( 300, 6733.15240852031, 10000000.0000034, -0.404576974582327, 176.366365154374, 1 ),
      ( 300, 7317.25611963073, 100000000.000006, 4.47893077969869, 180.792731061566, 1 ),
      ( 350, 0.343825639167002, 999.999999993833, -0.000554719523072403, 180.057793272229, 2 ),
      ( 350, 3.4556126405092, 10000.0016202091, -0.00557455994214122, 180.280968645253, 2 ),
      ( 350, 6198.21366079195, 1000000.00000103, -0.944559040585641, 195.582472230732, 1 ),
      ( 350, 6329.80199652221, 10000000.0000489, -0.457115858343027, 196.010756839946, 1 ),
      ( 350, 7054.01363855101, 100000000.000001, 3.87148069142379, 200.160560899857, 1 ),
      ( 400, 0.300783447665681, 999.999925815444, -0.000342104371043075, 202.526946869692, 2 ),
      ( 400, 3.0171574267343, 9999.99992874845, -0.00343102527077578, 202.646748390182, 2 ),
      ( 400, 31.1709818444178, 99999.9980495896, -0.03538313278197, 203.893782775236, 2 ),
      ( 400, 5701.63788766607, 1000000.00051769, -0.947264180152297, 215.868295624943, 1 ),
      ( 400, 5903.95085342484, 10000000.0055379, -0.49071298872434, 216.122184834692, 1 ),
      ( 400, 6804.67532688683, 100000000.000016, 3.4187346769964, 219.96957795519, 1 ),
      ( 500, 0.240581929071548, 999.999995418069, -0.00015583219751106, 244.053228477252, 2 ),
      ( 500, 2.40920289747057, 9999.99999999983, -0.00156006406343083, 244.095886230834, 2 ),
      ( 500, 24.4400900966904, 100000.00010524, -0.0157792475194265, 244.529510228663, 2 ),
      ( 500, 294.11631478156, 999999.999999969, -0.182145203880933, 249.943678018006, 2 ),
      ( 500, 4917.94525519922, 10000000.0004425, -0.510884269368455, 254.889560923283, 1 ),
      ( 500, 6341.46426545698, 100000000.00736, 2.79320025472979, 257.693382270606, 1 ),
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
      ( 250, 0.481476686194688, 999.999998955065, -0.000805457219377854, 94.1171856958163, 2 ),
      ( 250, 9177.69910025477, 1000000.00137105, -0.947580665659693, 109.583517685389, 1 ),
      ( 250, 9287.08757814592, 10000000.0000005, -0.481980897376843, 109.984537071623, 1 ),
      ( 250, 10014.9446573792, 100000000.000025, 3.80370979351356, 113.620994179067, 1 ),
      ( 300, 0.401076437893455, 999.999841331554, -0.000421466041965394, 111.316196883104, 2 ),
      ( 300, 4.02610528450168, 9999.99848731797, -0.00423021828075727, 111.459804190725, 2 ),
      ( 300, 8510.55238020052, 1000000.00000047, -0.952892905200754, 123.589472264135, 1 ),
      ( 300, 8674.15956533876, 10000000.0000002, -0.537814130870008, 123.927273274432, 1 ),
      ( 300, 9607.32146895831, 99999999.9999988, 3.17293622434887, 127.308131356484, 1 ),
      ( 350, 0.343720826753152, 999.999975575178, -0.000249953950866943, 128.268995519248, 2 ),
      ( 350, 3.44497777346236, 9999.99999998944, -0.00250470403431938, 128.338835588306, 2 ),
      ( 350, 35.2660845093088, 100000.001671103, -0.0255938049286465, 129.059369003785, 2 ),
      ( 350, 7746.88339383481, 1000000.00505674, -0.955642172905865, 138.502616203176, 1 ),
      ( 350, 8014.8833078242, 10000000.0053717, -0.571254004142861, 138.66702140159, 1 ),
      ( 350, 9220.37052816636, 100000000.000886, 2.72691001219168, 141.773361335301, 1 ),
      ( 400, 0.300728940613096, 999.999994951683, -0.000160916627757292, 144.690945285814, 2 ),
      ( 400, 3.01165765245048, 9999.99999999976, -0.00161112906887286, 144.728452953288, 2 ),
      ( 400, 30.5667021938558, 100000.000157229, -0.0163134170936252, 145.110145868072, 2 ),
      ( 400, 372.525891416911, 999999.998484613, -0.192859998751729, 150.433228228055, 2 ),
      ( 400, 7271.16581517579, 9999999.99999999, -0.586475462163215, 153.638506385079, 1 ),
      ( 400, 8850.85365228913, 100000000.000218, 2.39719263405379, 156.334108285422, 1 ),
      ( 500, 0.240563049956108, 999.999999630694, -7.73655614093204E-05, 175.075069995932, 2 ),
      ( 500, 2.40730755186171, 9999.99620407453, -0.00077396199152691, 175.088503498654, 2 ),
      ( 500, 24.2428249808547, 99999.9999014286, -0.00777059243077009, 175.223943900744, 2 ),
      ( 500, 261.78345710988, 1000000.00000304, -0.0811320114866752, 176.702883389485, 2 ),
      ( 500, 5269.38006725144, 10000000.0009952, -0.543505240452142, 183.285106579277, 1 ),
      ( 500, 8160.76096131039, 100000000, 1.94757363683096, 184.118939959278, 1 ),
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
