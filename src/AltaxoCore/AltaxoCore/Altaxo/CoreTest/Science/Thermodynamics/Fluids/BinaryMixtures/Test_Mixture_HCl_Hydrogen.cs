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
  /// Tests and test data for <see cref="Mixture_HCl_Hydrogen"/>.
  /// </summary>
  /// <remarks>
  /// <para>Reference:</para>
  /// <para>The test data was created automatically using calls into the TREND.DLL of the following software:</para>
  /// <para>TREND 3.0.: Span, R.; Eckermann, T.; Herrig, S.; Hielscher, S.; Jäger, A.; Thol, M. (2016): TREND.Thermodynamic Reference and Engineering Data 3.0.Lehrstuhl für Thermodynamik, Ruhr-Universität Bochum.</para>
  /// </remarks>
  
  public class Test_Mixture_HCl_Hydrogen : MixtureTestBase
  {

    public Test_Mixture_HCl_Hydrogen()
    {
      _mixture = MixtureOfFluids.FromCASRegistryNumbersAndMoleFractions(new[] { ("7647-01-0", 0.5), ("1333-74-0", 0.5) });

      // TestData for 1 Permille to 999 Permille Molefraction contains:
      // 0. Temperature (Kelvin)
      // 1. Mole density (mol/m³)
      // 2. Pressure (Pa)
      // 3. delta*AlphaR_delta
      // 4. Isochoric heat capacity (J/mol K)
      // 5. Phasetype (1: liquid, 2: gas)
      _testData_001_999 = new (double temperature, double moleDensity, double pressure, double deltaPhiR_delta, double cv, int phase)[]
      {
      ( 200, 0.601357089300674, 1000.00000000036, 6.6650367189241E-06, 18.9651738513242, 1 ),
      ( 200, 6.01321015832382, 10000.0000035953, 6.66558033610197E-05, 18.9654036384893, 1 ),
      ( 200, 60.0960193655979, 100000, 0.000667105269154723, 18.9677012715454, 1 ),
      ( 200, 597.341530911852, 1000000.0010955, 0.00672909257492069, 18.9906528713529, 1 ),
      ( 200, 5597.40045483132, 10000000.0009015, 0.0743578241804095, 19.21697364461, 1 ),
      ( 250, 0.481085810793761, 1000.0000000002, 6.37537082609644E-06, 20.0090268883137, 1 ),
      ( 250, 4.81058207546893, 10000.0000020453, 6.37560004919579E-05, 20.0092071478466, 1 ),
      ( 250, 48.0782239515162, 99999.9999999999, 0.000637790570896171, 20.011009673137, 1 ),
      ( 250, 478.028440994323, 1000000.00018793, 0.00640220672663885, 20.0290270034074, 1 ),
      ( 250, 4508.81793168488, 10000000.0000097, 0.0669955744131339, 20.2076531448417, 1 ),
      ( 300, 0.400905062981158, 1000.00000000003, 5.82498009565276E-06, 20.5331311251932, 1 ),
      ( 300, 4.00884046436959, 10000.0000002924, 5.82507795453093E-05, 20.5332804603623, 1 ),
      ( 300, 40.0673963084025, 100000.002926198, 0.000582606282086103, 20.5347737399162, 1 ),
      ( 300, 398.581087283306, 1000000.00000257, 0.00583648100677111, 20.5496987196564, 1 ),
      ( 300, 3783.25091793923, 10000000, 0.0596902160101723, 20.6976733582329, 1 ),
      ( 350, 0.343633103387439, 1000.00000000002, 5.26548262503528E-06, 20.7720410548211, 1 ),
      ( 350, 3.43616819566598, 10000.000000159, 5.26552076224615E-05, 20.7721687154446, 1 ),
      ( 350, 34.3454053128684, 100000.001587811, 0.000526590541312037, 20.7734452349604, 1 ),
      ( 350, 341.833432557269, 1000000.00000065, 0.00527005272901719, 20.7862013946455, 1 ),
      ( 350, 3262.51480439967, 10000000.0111528, 0.0532823095172261, 20.91255855697, 1 ),
      ( 400, 0.300679117610613, 1000.00000000001, 4.75947008238885E-06, 20.8713729419058, 1 ),
      ( 400, 3.00666238535602, 10000.0000000901, 4.75947959621205E-05, 20.8714843616566, 1 ),
      ( 400, 30.0537505556407, 100000.000898917, 0.000475957662872659, 20.8725984653858, 1 ),
      ( 400, 299.255874438423, 1000000.00000018, 0.00476072271459509, 20.8837299062359, 1 ),
      ( 400, 2869.5585120602, 10000000.0016093, 0.0478286029798581, 20.9939025815453, 1 ),
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
      ( 200, 0.601388610420131, 999.999999980347, -4.51550776186449E-05, 19.8868225105562, 2 ),
      ( 200, 6.01633185875207, 9999.99980089338, -0.000451655934905729, 19.8919089980816, 2 ),
      ( 200, 60.4096263105097, 99999.9995688444, -0.00452710698322239, 19.9430757914631, 2 ),
      ( 250, 0.481100319332538, 999.999999998287, -2.31876710358916E-05, 20.4098064280861, 2 ),
      ( 250, 4.81200747802706, 9999.99998276147, -0.000231886725911136, 20.4116886636053, 2 ),
      ( 250, 48.2207816746736, 99999.9999999996, -0.00231985664704334, 20.4305534579086, 2 ),
      ( 250, 492.558295386268, 1000000.00001502, -0.0232848208166878, 20.6233915208114, 2 ),
      ( 300, 0.400912807168834, 999.999999999798, -1.28973721376315E-05, 20.6734778154946, 2 ),
      ( 300, 4.00959347239286, 9999.99999796424, -0.000128967668334118, 20.6744486082509, 2 ),
      ( 300, 40.142509901007, 99999.9999999999, -0.00128906379797972, 20.6841633647141, 2 ),
      ( 300, 406.114720507507, 999999.999791908, -0.0128217072573931, 20.7819518611009, 2 ),
      ( 300, 4525.8120283033, 9999999.99999888, -0.114175237636928, 21.7706432614498, 2 ),
      ( 350, 0.343637658922991, 999.999999999983, -7.39723430251908E-06, 20.7977005511554, 2 ),
      ( 350, 3.43660535653932, 9999.99999983943, -7.39645568258041E-05, 20.7983187776353, 2 ),
      ( 350, 34.3889204005447, 99999.9984132382, -0.000738863109746514, 20.8045015085676, 2 ),
      ( 350, 346.164395371766, 999999.999999361, -0.00730658164406398, 20.8663578587128, 2 ),
      ( 350, 3661.98935450049, 9999999.99998865, -0.0616162864252633, 21.4709636471152, 2 ),
      ( 400, 0.300681991492595, 999.999999999997, -4.2042997476243E-06, 20.8597268149458, 2 ),
      ( 400, 3.00693367370022, 9999.99999995914, -4.20362935132785E-05, 20.8601723003946, 2 ),
      ( 400, 30.0806973191935, 99999.9996017714, -0.000419690589999707, 20.8646264073968, 2 ),
      ( 400, 301.92700653376, 999999.999999982, -0.00412774997825382, 20.9090851138561, 2 ),
      ( 400, 3108.78665569755, 9999999.99999988, -0.0328035962702399, 21.3390307837313, 2 ),
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
      ( 200, 0.601502208295156, 999.999999999918, -0.000233409485540453, 20.8193718627373, 2 ),
      ( 200, 6.02771830975531, 9999.99999916563, -0.0023392251051483, 20.9277207746312, 2 ),
      ( 200, 61.6105163665992, 99999.9909840027, -0.0239299249501279, 22.0419297883066, 2 ),
      ( 200, 32111.969156031, 10000000.0000008, -0.812729699306133, 36.7928892991449, 1 ),
      ( 250, 0.481139745420434, 999.999999999972, -0.000104534787618216, 20.8145196771398, 2 ),
      ( 250, 4.81593326812534, 9999.99999971959, -0.00104627121063358, 20.8535619479024, 2 ),
      ( 250, 48.6222379025691, 99999.9969724663, -0.0105567522034291, 21.2491551053161, 2 ),
      ( 250, 544.979604103381, 999999.999629304, -0.117234028605959, 25.8495654278084, 2 ),
      ( 250, 28459.4482829795, 10000000.0004999, -0.830956157400114, 34.4844107709988, 1 ),
      ( 300, 0.400930836553637, 999.991084705963, -5.7270973891412E-05, 20.8153192229257, 2 ),
      ( 300, 4.01137703820684, 9999.99999993275, -0.00057294332852599, 20.8305770235779, 2 ),
      ( 300, 40.3227425667216, 99999.9992302394, -0.00575246334107823, 20.984311560933, 2 ),
      ( 300, 426.51174767504, 999999.999995066, -0.0600308740967472, 22.6483289638317, 2 ),
      ( 300, 23244.6015148881, 9999999.99966247, -0.827526458399218, 33.5205557614188, 1 ),
      ( 350, 0.343647453609322, 999.99000755548, -3.53046701336456E-05, 20.8239840587829, 2 ),
      ( 350, 3.43756706418006, 9999.99999998226, -0.000353113954266947, 20.8307125321298, 2 ),
      ( 350, 34.4855256598233, 99999.9998191339, -0.00353752898214451, 20.898319245834, 2 ),
      ( 350, 356.47985170642, 999999.999999908, -0.0360315751839533, 21.6077830072291, 2 ),
      ( 350, 6378.51542339488, 9999999.9998685, -0.461261283662607, 32.9026181995192, 2 ),
      ( 400, 0.300687922621556, 999.994659238458, -2.33351474099702E-05, 20.8483689967676, 2 ),
      ( 400, 3.00751091702126, 9999.99999999666, -0.000233368113963205, 20.8517443083468, 2 ),
      ( 400, 30.1384704645015, 99999.999966381, -0.00233521690411664, 20.8856036512024, 2 ),
      ( 400, 307.917531286576, 1000000, -0.0235018294322391, 21.2349124484093, 2 ),
      ( 400, 3975.91531494086, 9999999.99561932, -0.243744189167362, 25.6855762813292, 2 ),
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
