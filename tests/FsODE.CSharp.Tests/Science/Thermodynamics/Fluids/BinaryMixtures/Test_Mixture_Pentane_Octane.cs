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
  /// Tests and test data for <see cref="Mixture_Pentane_Octane"/>.
  /// </summary>
  /// <remarks>
  /// <para>Reference:</para>
  /// <para>The test data was created automatically using calls into the TREND.DLL of the following software:</para>
  /// <para>TREND 3.0.: Span, R.; Eckermann, T.; Herrig, S.; Hielscher, S.; Jäger, A.; Thol, M. (2016): TREND.Thermodynamic Reference and Engineering Data 3.0.Lehrstuhl für Thermodynamik, Ruhr-Universität Bochum.</para>
  /// </remarks>
  
  public class Test_Mixture_Pentane_Octane : MixtureTestBase
  {

    public Test_Mixture_Pentane_Octane()
    {
      _mixture = MixtureOfFluids.FromCASRegistryNumbersAndMoleFractions(new[] { ("109-66-0", 0.5), ("111-65-9", 0.5) });

      // TestData for 1 Permille to 999 Permille Molefraction contains:
      // 0. Temperature (Kelvin)
      // 1. Mole density (mol/m³)
      // 2. Pressure (Pa)
      // 3. delta*AlphaR_delta
      // 4. Isochoric heat capacity (J/mol K)
      // 5. Phasetype (1: liquid, 2: gas)
      _testData_001_999 = new (double temperature, double moleDensity, double pressure, double deltaPhiR_delta, double cv, int phase)[]
      {
      ( 250, 6451.16107077148, 99999.9999990267, -0.992542634212542, 188.987129714864, 1 ),
      ( 250, 6456.61046640274, 1000000.00000584, -0.925489282480973, 189.04757644899, 1 ),
      ( 250, 6508.76605685412, 9999999.99999948, -0.260863465831969, 189.644931666094, 1 ),
      ( 250, 6890.23928030313, 100000000, 5.98214762968691, 194.932514990113, 1 ),
      ( 300, 0.401540693796589, 999.99999193989, -0.0015817283518766, 180.409508496414, 2 ),
      ( 300, 6101.06020186803, 99999.9999996122, -0.993428919692239, 206.759962789442, 1 ),
      ( 300, 6108.50584672313, 1000000.00489172, -0.934369291360369, 206.815391113416, 1 ),
      ( 300, 6178.47322633269, 10000000.0000052, -0.351125187764923, 207.366053418731, 1 ),
      ( 300, 6646.65692030946, 100000000, 5.03168736250387, 212.235964862172, 1 ),
      ( 350, 0.343928085368218, 999.999975831714, -0.000856991690620966, 205.863514939866, 2 ),
      ( 350, 3.46627244069421, 9999.98549992885, -0.00863722585474473, 206.273708236708, 2 ),
      ( 350, 5740.15704245894, 100000.000001313, -0.994013520199667, 227.938110112578, 1 ),
      ( 350, 5750.70808781734, 1000000.00000039, -0.940245038245323, 227.98659058336, 1 ),
      ( 350, 5846.98397187879, 10000000.0000838, -0.412289577847389, 228.481357044735, 1 ),
      ( 400, 0.300833141395235, 999.999996013605, -0.000511802906421757, 231.368183929386, 2 ),
      ( 400, 3.02233131558092, 9999.99999999949, -0.00514158531600407, 231.588716864272, 2 ),
      ( 400, 31.7856752395588, 99999.9905964865, -0.0540418802990234, 233.927551550917, 2 ),
      ( 400, 5366.20688892363, 1000000.00000007, -0.943968024278164, 250.280922271888, 1 ),
      ( 400, 5504.62920997567, 10000000.0009268, -0.453770340068384, 250.669815730922, 1 ),
      ( 500, 0.240596563114311, 999.999999786561, -0.000221216042372194, 278.38623578121, 2 ),
      ( 500, 2.41077625805642, 9999.99777059852, -0.00221624213018284, 278.465046125524, 2 ),
      ( 500, 24.610195535216, 99999.999855511, -0.0225866391073622, 279.271616415546, 2 ),
      ( 500, 4355.61205656507, 1000000.00234317, -0.944773929197313, 294.049207811149, 1 ),
      ( 500, 4744.81485566917, 10000000.0000021, -0.49303956716628, 293.316707162879, 1 ),
      ( 600, 0.200475177057971, 999.999999980055, -0.000111706160497571, 318.352943289981, 2 ),
      ( 600, 2.00677118159836, 9999.99979638269, -0.00111789232175073, 318.387291325739, 2 ),
      ( 600, 20.2736258803102, 99999.9999996586, -0.011263283692923, 318.734828921701, 2 ),
      ( 600, 228.462154298404, 999999.999720305, -0.122599612308168, 322.679163470418, 2 ),
      ( 600, 3797.04251853936, 9999999.99995946, -0.472081806380245, 331.43497962398, 1 ),
      ( 600, 5450.02495593632, 100000000, 2.67801586903039, 333.187435096544, 1 ),
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
      ( 250, 7374.87859303697, 100000.000000151, -0.993476683412216, 151.51581811471, 1 ),
      ( 250, 7382.25666987226, 1000000.00083886, -0.934832030298261, 151.567889352177, 1 ),
      ( 250, 7452.37945519711, 10000000.0000007, -0.354452250476684, 152.083444354697, 1 ),
      ( 300, 0.401273498012178, 999.999999996766, -0.000916912087653911, 146.383709590198, 2 ),
      ( 300, 6929.72275729037, 100000.000000123, -0.994214695457057, 165.904588533138, 1 ),
      ( 300, 6940.20907159681, 1000000.01499604, -0.942234366809772, 165.951496467072, 1 ),
      ( 300, 7037.45006501792, 10000000.0000223, -0.430325527302768, 166.422619565753, 1 ),
      ( 300, 7653.24973373908, 99999999.9999999, 4.23837035840806, 170.6453421742, 1 ),
      ( 350, 0.343810268088336, 999.9999963319, -0.000514604287265963, 167.048880365975, 2 ),
      ( 350, 3.45419033945645, 9999.99999609319, -0.00516964008937931, 167.254662291417, 2 ),
      ( 350, 6470.20362951026, 1000000.00000028, -0.946889872169947, 183.306522381682, 1 ),
      ( 350, 6610.88643684066, 10000000.0003847, -0.480200809459272, 183.702965020969, 1 ),
      ( 350, 7376.80084747573, 100000000, 3.65829766798432, 187.656486760885, 1 ),
      ( 400, 0.300774542921257, 999.999999335358, -0.000317077375519363, 187.841708733736, 2 ),
      ( 400, 3.01638203123424, 9999.99292423512, -0.00317939940097009, 187.952401003879, 2 ),
      ( 400, 31.0848459990836, 100000.003568292, -0.0327146103524382, 189.09987955835, 2 ),
      ( 400, 5938.39585201822, 1000000.00001987, -0.949366936523397, 201.796800831892, 1 ),
      ( 400, 6157.8827997118, 10000000.0026928, -0.511716633822871, 202.005848227, 1 ),
      ( 500, 0.240577951192227, 999.999999958878, -0.000143869782143252, 226.404234727186, 2 ),
      ( 500, 2.40890272231815, 9999.99957769547, -0.00144021142484762, 226.443831260233, 2 ),
      ( 500, 24.4096641525427, 99999.9999978131, -0.0145569478185366, 226.845800112818, 2 ),
      ( 500, 288.404275956046, 1000000, -0.165950856666368, 231.720924032494, 2 ),
      ( 500, 5092.55716787117, 10000000.0000013, -0.527657066252684, 237.683951079692, 1 ),
      ( 600, 0.20046780679505, 999.999999995782, -7.49449481408713E-05, 259.472740292672, 2 ),
      ( 600, 2.00603174600036, 9999.99995727959, -0.000749698273770959, 259.490068555886, 2 ),
      ( 600, 20.1972031017656, 99999.9999999916, -0.00752207247217874, 259.664748558672, 2 ),
      ( 600, 217.395669354387, 1000000.0047466, -0.0779357139117731, 261.557615198658, 2 ),
      ( 600, 3685.76554251498, 10000000.0000256, -0.456143424117093, 270.014444139892, 1 ),
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
      ( 250, 0.481520298859032, 999.999978690628, -0.000900523324026993, 97.8676867979981, 2 ),
      ( 250, 9231.06542851177, 100000.000001886, -0.994788394946667, 114.520186715033, 1 ),
      ( 250, 9241.7969001673, 1000000.00334577, -0.947944465253541, 114.56207586384, 1 ),
      ( 250, 9343.05519051929, 10000000.0000017, -0.485086335503423, 114.978865055862, 1 ),
      ( 300, 0.401092358788697, 999.999997967382, -0.000465711432502173, 112.375778200625, 2 ),
      ( 300, 4.02789106171177, 9999.99999999989, -0.00467624531700972, 112.544202616342, 2 ),
      ( 300, 8574.58875956814, 100000.000002607, -0.995324492208979, 125.598424763195, 1 ),
      ( 300, 8590.98602349901, 1000000.00000017, -0.953334161597421, 125.633737184342, 1 ),
      ( 300, 8740.32015061104, 10000000.0000967, -0.541314781860994, 125.999547741498, 1 ),
      ( 350, 0.343727397618315, 999.999999696515, -0.000273634773439701, 128.243018612767, 2 ),
      ( 350, 3.44578386087352, 9999.99680456407, -0.00274260943694421, 128.325001836528, 2 ),
      ( 350, 35.3566046793993, 99999.9964666544, -0.0280929254196844, 129.173365318637, 2 ),
      ( 350, 7857.3178298314, 1000000.00266617, -0.956265821212214, 139.231527155884, 1 ),
      ( 350, 8096.34279328621, 10000000.0022002, -0.575569673007101, 139.464719642908, 1 ),
      ( 350, 9235.62805786704, 100000000, 2.72073604200507, 142.662792492518, 1 ),
      ( 400, 0.300731783103866, 999.999999938808, -0.000174936565802063, 144.319978237884, 2 ),
      ( 400, 3.0120680752774, 9999.99936818618, -0.00175173124359093, 144.36404240399, 2 ),
      ( 400, 30.6116308515049, 99999.9999931753, -0.0177616619726954, 144.813139392287, 2 ),
      ( 400, 383.368245509513, 999999.997414548, -0.215690976173752, 151.366296086896, 2 ),
      ( 400, 7375.89934375821, 10000000.000001, -0.592349135875134, 153.929937037542, 1 ),
      ( 500, 0.240563404911204, 999.999999995625, -8.34109261625407E-05, 174.423937069719, 2 ),
      ( 500, 2.40744237483022, 9999.99995559741, -0.000834488041759283, 174.439724788292, 2 ),
      ( 500, 24.2576903610485, 99999.9999999895, -0.00838317356852156, 174.59899397838, 2 ),
      ( 500, 263.789624487048, 1000000, -0.0881243348272405, 176.351513650089, 2 ),
      ( 500, 5457.87134380636, 9999999.99999997, -0.55927260988339, 183.099849065657, 1 ),
      ( 600, 0.200461703303655, 999.999999999516, -4.45000608201288E-05, 200.593276591082, 2 ),
      ( 600, 2.00542026638751, 9999.9999951374, -0.000445013419552006, 200.60025461638, 2 ),
      ( 600, 20.1349070156358, 100000, -0.00445141070912666, 200.67038233561, 2 ),
      ( 600, 209.817056585846, 999999.98795447, -0.0446306600591853, 201.405513790611, 2 ),
      ( 600, 3079.11728255651, 10000000.0001491, -0.348992700340961, 207.666736185977, 1 ),
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
