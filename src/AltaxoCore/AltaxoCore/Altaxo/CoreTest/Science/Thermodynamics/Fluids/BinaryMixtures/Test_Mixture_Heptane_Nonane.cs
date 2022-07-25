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
  /// Tests and test data for <see cref="Mixture_Heptane_Nonane"/>.
  /// </summary>
  /// <remarks>
  /// <para>Reference:</para>
  /// <para>The test data was created automatically using calls into the TREND.DLL of the following software:</para>
  /// <para>TREND 3.0.: Span, R.; Eckermann, T.; Herrig, S.; Hielscher, S.; Jäger, A.; Thol, M. (2016): TREND.Thermodynamic Reference and Engineering Data 3.0.Lehrstuhl für Thermodynamik, Ruhr-Universität Bochum.</para>
  /// </remarks>
  
  public class Test_Mixture_Heptane_Nonane : MixtureTestBase
  {

    public Test_Mixture_Heptane_Nonane()
    {
      _mixture = MixtureOfFluids.FromCASRegistryNumbersAndMoleFractions(new[] { ("142-82-5", 0.5), ("111-84-2", 0.5) });

      // TestData for 1 Permille to 999 Permille Molefraction contains:
      // 0. Temperature (Kelvin)
      // 1. Mole density (mol/m³)
      // 2. Pressure (Pa)
      // 3. delta*AlphaR_delta
      // 4. Isochoric heat capacity (J/mol K)
      // 5. Phasetype (1: liquid, 2: gas)
      _testData_001_999 = new (double temperature, double moleDensity, double pressure, double deltaPhiR_delta, double cv, int phase)[]
      {
      ( 350, 0.344026884198321, 999.999997033501, -0.00113936850048067, 231.919404200819, 2 ),
      ( 350, 5253.89115129153, 1000000.00012651, -0.934594208269516, 253.892365362975, 1 ),
      ( 350, 5330.63930903934, 10000000.0000132, -0.355358914999352, 254.502968594761, 1 ),
      ( 350, 5811.09114314697, 100000000.000036, 4.91343178651117, 259.743952389459, 1 ),
      ( 400, 0.300884205199516, 999.999258095726, -0.000676865362611254, 260.432055359636, 2 ),
      ( 400, 3.02742177046853, 9999.99358876233, -0.00680984977053343, 260.737498650691, 2 ),
      ( 400, 4916.82220689585, 100000.00000479, -0.993884656912255, 279.152022864639, 1 ),
      ( 400, 4928.82100763374, 999999.999997954, -0.938995442091433, 279.204063933723, 1 ),
      ( 400, 5035.51865453856, 10000000.0001541, -0.402880681057371, 279.744872981068, 1 ),
      ( 400, 5618.89105849938, 100000000.000006, 4.35124357851427, 284.694245039841, 1 ),
      ( 500, 0.240614566357808, 999.999961941063, -0.000291456975704946, 313.10427453473, 2 ),
      ( 500, 2.41249276270667, 9999.99999996861, -0.00292161999003321, 313.212688932646, 2 ),
      ( 500, 24.7973690315739, 100000.003045172, -0.0299598436340239, 314.331087475922, 2 ),
      ( 500, 4147.3790692002, 1000000.00000044, -0.942000855591011, 328.031188410911, 1 ),
      ( 500, 4400.10396232036, 10000000.0000012, -0.453321013274393, 327.956590084398, 1 ),
      ( 500, 5263.80021343258, 100000000.002032, 3.56978661446723, 332.16540646319, 1 ),
      ( 600, 0.200483353898455, 999.999996460928, -0.000147922159172325, 357.818010589982, 2 ),
      ( 600, 2.00750945662548, 9999.99999999993, -0.00148067892617945, 357.864882691024, 2 ),
      ( 600, 20.349714592918, 100000.000033931, -0.014955727301112, 358.340936762376, 2 ),
      ( 600, 241.151932439321, 999999.99999534, -0.168765947921659, 364.050994040583, 2 ),
      ( 600, 3646.79326818389, 10000000.0003957, -0.450328869137174, 370.563614136774, 1 ),
      ( 600, 4942.55799229802, 100000000.017366, 3.05566709199381, 373.315632731925, 1 ),
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
      ( 250, 6462.21802848389, 1000000.00009575, -0.925553768825232, 185.26028439825, 1 ),
      ( 250, 6513.35935992275, 10000000.0000001, -0.261383026281148, 185.882033195043, 1 ),
      ( 250, 6890.76263112344, 100000000.00001, 5.98163329237409, 191.288232515442, 1 ),
      ( 300, 0.401532302067806, 999.999999942925, -0.00155858055943244, 180.495642216353, 2 ),
      ( 300, 6102.66763641149, 100000.00000097, -0.993430635605749, 203.857317593616, 1 ),
      ( 300, 6109.95388199667, 1000000.00813221, -0.934384695528007, 203.91624416468, 1 ),
      ( 300, 6178.57772193671, 10000000.0000079, -0.351134679129191, 204.497924084621, 1 ),
      ( 300, 6642.51078571951, 99999999.9999997, 5.03546602422311, 209.510499743672, 1 ),
      ( 350, 0.343925821958616, 999.999999994723, -0.000848133029511531, 205.966831558221, 2 ),
      ( 350, 3.46596440471773, 9999.99990324457, -0.00854686587414144, 206.367118542529, 2 ),
      ( 350, 5737.76440529798, 100000.000001451, -0.994011010262417, 225.519131779829, 1 ),
      ( 350, 5748.08054250367, 999999.999999739, -0.940217586707104, 225.57220772174, 1 ),
      ( 350, 5842.50558653981, 10000000.0000705, -0.411837743220688, 226.105994565537, 1 ),
      ( 350, 6411.11900076977, 99999999.9999938, 4.35997112310636, 230.819031402764, 1 ),
      ( 400, 0.300833020649744, 999.999914427583, -0.000509117701520784, 231.423927373491, 2 ),
      ( 400, 3.02225503951763, 9999.99723484409, -0.00511420205496962, 231.638707670089, 2 ),
      ( 400, 5360.04207329692, 1000000.00169043, -0.943903451201395, 248.162808598455, 1 ),
      ( 400, 5495.76568903571, 10000000.000703, -0.452888135611364, 248.601389391993, 1 ),
      ( 400, 6192.86939088078, 99999999.9986926, 3.8552592060114, 253.028688365402, 1 ),
      ( 500, 0.240597463474788, 999.999995274669, -0.000222672746728362, 278.481997861309, 2 ),
      ( 500, 2.41081674339537, 9999.99999999969, -0.00223071854791251, 278.558398313855, 2 ),
      ( 500, 24.6136571310469, 100000.001145335, -0.0227218668465481, 279.340454367076, 2 ),
      ( 500, 4346.77898239349, 999999.999999922, -0.944661578161535, 292.443977099229, 1 ),
      ( 500, 4728.60063913359, 10000000.0000026, -0.491300054003942, 291.799015677943, 1 ),
      ( 500, 5788.59381779244, 99999999.9999064, 3.15548052856926, 295.388397020625, 1 ),
      ( 600, 0.200476088726648, 999.999999543869, -0.000113968269448569, 318.50258110196, 2 ),
      ( 600, 2.00682112656006, 9999.99528437854, -0.00114046902919404, 318.535703347134, 2 ),
      ( 600, 20.2782111677394, 99999.9997414001, -0.011484596818395, 318.870923268195, 2 ),
      ( 600, 228.896404219443, 1000000.00586028, -0.12426216866834, 322.683523162119, 2 ),
      ( 600, 3775.90429634518, 10000000.0000001, -0.469125207943469, 330.400058908489, 1 ),
      ( 600, 5422.43338213589, 100000000.017101, 2.69673957636963, 332.214738940096, 1 ),
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
      ( 250, 7180.81036888603, 100000.000002279, -0.99330038468326, 162.83647913115, 1 ),
      ( 250, 7187.22696189956, 1000000.00007522, -0.933063658277419, 162.892236214924, 1 ),
      ( 250, 7248.53488052439, 9999999.99999948, -0.336298039976418, 163.442388702767, 1 ),
      ( 250, 7693.15163627667, 100000000.003546, 5.2534407684874, 168.250194730515, 1 ),
      ( 300, 0.401358845773542, 999.999941938062, -0.00112935949525368, 157.773516264832, 2 ),
      ( 300, 6765.17728913441, 99999.9999975007, -0.994073982949485, 178.56566716039, 1 ),
      ( 300, 6774.13451976636, 1000000.00756271, -0.940818185922789, 178.616985128533, 1 ),
      ( 300, 6857.95131459606, 10000000.000007, -0.415414970282719, 179.126855603951, 1 ),
      ( 300, 7408.93682693416, 100000000.005409, 4.41110791883806, 183.593154742203, 1 ),
      ( 350, 0.343847431075979, 999.999992817704, -0.000622623974606715, 180.01888090966, 2 ),
      ( 350, 3.45798447759691, 9999.99999999784, -0.00626117420760724, 180.29343037236, 2 ),
      ( 350, 6328.96500344423, 100000.000003162, -0.994570465419799, 197.349473375995, 1 ),
      ( 350, 6342.09989736144, 1000000.00000015, -0.945817103328293, 197.393058916099, 1 ),
      ( 350, 6460.72450937205, 10000000.0001625, -0.468119491988407, 197.843588189617, 1 ),
      ( 350, 7142.88587931701, 100000000.0078, 3.81084745368938, 202.033605636893, 1 ),
      ( 400, 0.300792858821224, 999.999998754814, -0.00037794556966861, 202.41821651108, 2 ),
      ( 400, 3.01823682048776, 9999.98656492743, -0.00379196556626676, 202.565738277708, 2 ),
      ( 400, 31.2968961375184, 99999.9999999996, -0.0392683856842636, 204.103018816493, 2 ),
      ( 400, 5865.71255878169, 1000000.0033088, -0.948739531050922, 217.283264212362, 1 ),
      ( 400, 6044.17134991397, 10000000.0024491, -0.502530358334817, 217.59671811752, 1 ),
      ( 400, 6891.13171933242, 100000000.010669, 3.36327714761949, 221.494690912513, 1 ),
      ( 500, 0.240583748025003, 999.999999927498, -0.000167956610417999, 243.860468341988, 2 ),
      ( 500, 2.40948556005988, 9999.99925163398, -0.00168175144082904, 243.913065541026, 2 ),
      ( 500, 24.4713760165543, 99999.9999909202, -0.0170420321610764, 244.448295447446, 2 ),
      ( 500, 301.517534396592, 999999.99991865, -0.202224371851643, 251.153642020253, 2 ),
      ( 500, 5087.75211346827, 10000000.0140078, -0.527210965985879, 255.829280139351, 1 ),
      ( 500, 6423.40087366183, 100000000.017073, 2.74479726801305, 258.724247573155, 1 ),
      ( 600, 0.200470148721562, 999.999999992774, -8.66216734648138E-05, 279.187360779322, 2 ),
      ( 600, 2.00626650284165, 9999.99992663648, -0.000866617773939662, 279.210243556671, 2 ),
      ( 600, 20.2213394808826, 99999.99999997, -0.00870669879018778, 279.441182756065, 2 ),
      ( 600, 220.655260165677, 1000000, -0.0915567409936555, 281.975900140607, 2 ),
      ( 600, 3833.73903123765, 9999999.99994284, -0.477135031811664, 290.466302834989, 1 ),
      ( 600, 5999.23947278099, 99999999.9999995, 2.3413032530418, 291.209714974871, 1 ),
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
