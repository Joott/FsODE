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
  /// Tests and test data for <see cref="Mixture_H2S_Argon"/>.
  /// </summary>
  /// <remarks>
  /// <para>Reference:</para>
  /// <para>The test data was created automatically using calls into the TREND.DLL of the following software:</para>
  /// <para>TREND 3.0.: Span, R.; Eckermann, T.; Herrig, S.; Hielscher, S.; Jäger, A.; Thol, M. (2016): TREND.Thermodynamic Reference and Engineering Data 3.0.Lehrstuhl für Thermodynamik, Ruhr-Universität Bochum.</para>
  /// </remarks>
  
  public class Test_Mixture_H2S_Argon : MixtureTestBase
  {

    public Test_Mixture_H2S_Argon()
    {
      _mixture = MixtureOfFluids.FromCASRegistryNumbersAndMoleFractions(new[] { ("7783-06-4", 0.5), ("7440-37-1", 0.5) });

      // TestData for 1 Permille to 999 Permille Molefraction contains:
      // 0. Temperature (Kelvin)
      // 1. Mole density (mol/m³)
      // 2. Pressure (Pa)
      // 3. delta*AlphaR_delta
      // 4. Isochoric heat capacity (J/mol K)
      // 5. Phasetype (1: liquid, 2: gas)
      _testData_001_999 = new (double temperature, double moleDensity, double pressure, double deltaPhiR_delta, double cv, int phase)[]
      {
      ( 200, 0.601375745072651, 999.999999993393, -2.89238257339702E-05, 12.4846052448078, 2 ),
      ( 200, 6.0153235071552, 9999.99993341348, -0.00028926079994157, 12.4868418153402, 2 ),
      ( 200, 60.3104253796638, 99999.9999999931, -0.00289486070994124, 12.5092553227779, 2 ),
      ( 200, 619.427797432124, 1000000.00006841, -0.0291711907713518, 12.7382986653527, 2 ),
      ( 200, 8468.72465476125, 9999999.99999887, -0.289906833082206, 15.2667401134292, 2 ),
      ( 200, 30369.5399497856, 100000000, 0.980136518299966, 17.6180132355449, 1 ),
      ( 250, 0.481093101331878, 999.999999999578, -1.33457402319553E-05, 12.4847507320975, 2 ),
      ( 250, 4.81150889126668, 9999.99999576166, -0.000133447406564303, 12.4858650276379, 2 ),
      ( 250, 48.1729051109661, 100000, -0.00133346809712674, 12.4970076845746, 2 ),
      ( 250, 487.535536344355, 999999.999403854, -0.01322745742922, 12.6083692292449, 2 ),
      ( 250, 5422.55932218493, 10000000, -0.112805130927597, 13.6545871867376, 2 ),
      ( 250, 27030.8702681819, 100000000, 0.779767636096459, 16.3622315045487, 1 ),
      ( 300, 0.400908018315675, 999.999999999971, -6.11360203117714E-06, 12.4851819765619, 2 ),
      ( 300, 4.00930073803166, 9999.99999971339, -6.11240741623626E-05, 12.4858430884005, 2 ),
      ( 300, 40.1150286393536, 99999.9972511866, -0.000610043346612478, 12.4924503760795, 2 ),
      ( 300, 403.316558927578, 999999.999999339, -0.00597791371538074, 12.5581266804393, 2 ),
      ( 300, 4196.70701826927, 10000000.0001065, -0.0447139493458813, 13.1600538528577, 2 ),
      ( 300, 24154.8362655631, 100000000.000262, 0.659732083945698, 15.5513400145303, 1 ),
      ( 350, 0.343634170462974, 999.999999999998, -2.35956676180875E-06, 12.4858064437001, 2 ),
      ( 350, 3.43641448558339, 9999.99999998778, -2.35860317319767E-05, 12.4862470357122, 2 ),
      ( 350, 34.3714080422712, 99999.9998877083, -0.000234895824730972, 12.490650075166, 2 ),
      ( 350, 344.408781025941, 1000000, -0.00225150358486483, 12.5343881279094, 2 ),
      ( 350, 3477.70471235413, 10000000.0000271, -0.0118961446050535, 12.9384902439789, 1 ),
      ( 350, 21732.507249006, 100000000.000295, 0.581195116989981, 14.9962843607112, 1 ),
      ( 400, 0.300679257639794, 999.996789916839, -2.67850407037668E-07, 12.486549483556, 2 ),
      ( 400, 3.00679978688494, 10000, -2.67126463562245E-06, 12.4868680340663, 2 ),
      ( 400, 30.0686989606012, 99999.9999999268, -2.59875338212633E-05, 12.4900516818022, 2 ),
      ( 400, 300.735431633513, 999999.99972206, -0.000187061898556433, 12.5217012024101, 2 ),
      ( 400, 2989.97965100866, 10000000.0000767, 0.00562281549742181, 12.818384436338, 1 ),
      ( 400, 19712.0135518325, 100000000.000942, 0.525360028306785, 14.5963100014381, 1 ),
      ( 500, 0.240542928448346, 1000.01630919111, 1.6790125320973E-06, 12.4882185492539, 1 ),
      ( 500, 2.40539300804451, 10000.0000000023, 1.6793886469994E-05, 12.4884142849754, 1 ),
      ( 500, 24.0502853603375, 100000.00002359, 0.000168342247036779, 12.4903709110089, 1 ),
      ( 500, 240.129429767199, 999999.999999999, 0.00172369803682758, 12.5098635416075, 1 ),
      ( 500, 2355.54910191503, 10000000.0000163, 0.0211773560509161, 12.6973273301777, 1 ),
      ( 500, 16608.0645155597, 100000000, 0.448352637170936, 14.065860931866, 1 ),
      ( 600, 0.200452297773968, 1000.0194110396, 2.37647376087628E-06, 12.4900062967596, 1 ),
      ( 600, 2.00448019692087, 10000.0000000045, 2.37666090190724E-05, 12.4901440136691, 1 ),
      ( 600, 20.0405107455492, 100000.000046057, 0.000237899158034369, 12.4915208865955, 1 ),
      ( 600, 199.972408357506, 999999.999999999, 0.0024022079228176, 12.5052596372105, 1 ),
      ( 600, 1953.25779813069, 10000000.000003, 0.0262484750023221, 12.6396019941948, 1 ),
      ( 600, 14373.0406394352, 100000000, 0.394644241885881, 13.7357782684858, 1 ),
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
      ( 200, 0.601415984915025, 999.999999997152, -9.35500139983058E-05, 18.7692445562516, 2 ),
      ( 200, 6.01923243552698, 9999.99997099856, -0.000936200945521986, 18.7836516196938, 2 ),
      ( 200, 60.7086588503268, 99999.9999973088, -0.00943335936755354, 18.9296695586276, 2 ),
      ( 250, 0.481110731860906, 999.99999998993, -4.77102388534094E-05, 18.9033476139994, 2 ),
      ( 250, 4.81317487973845, 9999.99989796044, -0.000477252591596365, 18.9090811409614, 2 ),
      ( 250, 48.3402142186513, 99999.9999999692, -0.00478765818521233, 18.966749046229, 2 ),
      ( 250, 506.14815020348, 999999.983996775, -0.0495119301010399, 19.5802692023017, 2 ),
      ( 300, 0.400917296705368, 999.999999998773, -2.6975832617707E-05, 19.1438210531127, 2 ),
      ( 300, 4.01014671780894, 9999.99998763333, -0.000269791009890921, 19.1466439415412, 2 ),
      ( 300, 40.1992338358287, 99999.9999999998, -0.00270118762375491, 19.1749521598374, 2 ),
      ( 300, 412.179060940166, 1000000.00001338, -0.0273487432552442, 19.4661608829322, 2 ),
      ( 300, 25752.9260339121, 100000000.001546, 0.556741479024492, 25.4987343970504, 1 ),
      ( 350, 0.34363966041872, 999.99999999999, -1.61020687952472E-05, 19.4681710652501, 2 ),
      ( 350, 3.43689468991573, 9999.99999841348, -0.00016102292124147, 19.4697833782355, 2 ),
      ( 350, 34.4188425768897, 99999.9805702797, -0.00161045087553292, 19.4859292787505, 2 ),
      ( 350, 349.266102194675, 999999.999593462, -0.016125169455971, 19.6496370147998, 2 ),
      ( 350, 4086.74370988284, 9999999.99999994, -0.159149309318636, 21.4348874635704, 2 ),
      ( 350, 23406.5386384196, 100000000, 0.468111677756683, 24.614353445641, 1 ),
      ( 400, 0.300682816769478, 999.999999999968, -9.8294571687112E-06, 19.8464057915889, 2 ),
      ( 400, 3.00709417575705, 9999.9999996547, -9.82887577422317E-05, 19.8474324083884, 2 ),
      ( 400, 30.0975510900893, 99999.9965551533, -0.000982304736901795, 19.8577057557727, 2 ),
      ( 400, 303.644428529297, 999999.999994719, -0.00976328570569014, 19.9611277871532, 2 ),
      ( 400, 3302.10934290031, 9999999.99973934, -0.0894309364172031, 21.0234334775131, 2 ),
      ( 400, 21267.290923803, 100000000.002486, 0.413813646048018, 24.1001412151913, 1 ),
      ( 500, 0.240544740099647, 999.999999999999, -3.46894010682968E-06, 20.6877040600221, 2 ),
      ( 500, 2.40552231935135, 9999.99999999004, -3.46825243779689E-05, 20.6882259386426, 2 ),
      ( 500, 24.0627179109194, 99999.9999028765, -0.000346137676270486, 20.6934453064877, 2 ),
      ( 500, 241.362705427688, 999999.999999999, -0.00339247295111023, 20.7456871152395, 2 ),
      ( 500, 2471.70629418689, 9999999.99981963, -0.0268103878592058, 21.2624943558836, 2 ),
      ( 500, 17717.8371891063, 100000000.003369, 0.357636862858942, 23.7403295936785, 1 ),
      ( 600, 0.200453374072587, 999.996230432435, -6.5175192659877E-07, 21.5847772435098, 2 ),
      ( 600, 2.00454546294379, 9999.99999999998, -6.51260180151792E-06, 21.5851005109769, 2 ),
      ( 600, 20.0466197353836, 99999.9999995773, -6.46320440446332E-05, 21.5883329800626, 2 ),
      ( 600, 200.573011029708, 999999.998752306, -0.000597140239422747, 21.6206337759036, 2 ),
      ( 600, 2007.01493754631, 10000000.0000964, -0.00123692622431584, 21.9379671974666, 1 ),
      ( 600, 15072.2782822374, 100000000.000001, 0.329946522086001, 23.8903208174581, 1 ),
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
      ( 200, 0.601526298772206, 999.999999783759, -0.000274642803173867, 25.060998682773, 2 ),
      ( 200, 6.0302134235212, 9999.99772060795, -0.00275321609733816, 25.1521229812687, 2 ),
      ( 200, 28526.6465074339, 1000000.00168916, -0.978919320408571, 43.0223666491254, 1 ),
      ( 200, 28740.3290326521, 10000000.0000004, -0.790760539583262, 43.1764631254555, 1 ),
      ( 200, 30364.0198989659, 100000000.000005, 0.980505532219683, 44.5917534732368, 1 ),
      ( 250, 0.481151940463971, 999.999999985952, -0.000131071572271805, 25.3244301731289, 2 ),
      ( 250, 4.81720988345116, 9999.99985595003, -0.00131219778345091, 25.3574552078595, 2 ),
      ( 250, 48.7561396580013, 99999.9999997738, -0.013275295178755, 25.6929842985128, 2 ),
      ( 250, 25854.6989756211, 1000000.00002671, -0.98139259422191, 39.0065438291101, 1 ),
      ( 250, 26210.7018286253, 10000000.0000003, -0.816453264675141, 39.1520926744108, 1 ),
      ( 250, 28532.6301983114, 100000000.000056, 0.68610069166126, 40.5502997252645, 1 ),
      ( 300, 0.400936799546563, 999.999999998388, -7.33372717829637E-05, 25.8034991894041, 2 ),
      ( 300, 4.01201802510187, 9999.99998364468, -0.000733811693527926, 25.8181179571643, 2 ),
      ( 300, 40.3889161422922, 99999.9999999987, -0.00738263300635128, 25.9654261910718, 2 ),
      ( 300, 435.309797764861, 999999.999999985, -0.0790296979437986, 27.6062355738402, 2 ),
      ( 300, 23228.5878045817, 10000000.0017267, -0.827407761773829, 36.7507970635175, 1 ),
      ( 300, 26720.238095536, 100000000.00085, 0.500388561304016, 38.0889110297692, 1 ),
      ( 350, 0.343650413429789, 999.999999999985, -4.51116230413205E-05, 26.4510227800535, 2 ),
      ( 350, 3.4379005212574, 9999.99999784675, -0.000451267635177836, 26.4584802247746, 2 ),
      ( 350, 34.5197942456244, 100000, -0.00452792863349812, 26.5333988009391, 2 ),
      ( 350, 360.554912210111, 999999.990336942, -0.0469276680607614, 27.3216464650366, 2 ),
      ( 350, 18949.6617914848, 10000000.0000003, -0.818659079731702, 35.8340367470242, 1 ),
      ( 350, 24911.8437403094, 100000000.010318, 0.379403766397264, 36.5926302828433, 1 ),
      ( 400, 0.300689401385945, 999.999999999947, -2.94471114003776E-05, 27.2065063694126, 2 ),
      ( 400, 3.00769131277208, 9999.99999945437, -0.000294525988021992, 27.2107427355709, 2 ),
      ( 400, 30.1570411855337, 99999.9943144155, -0.0029507697587371, 27.2532349012796, 2 ),
      ( 400, 310.006269370825, 999999.999876321, -0.0300823671628573, 27.6915656411969, 2 ),
      ( 400, 5034.26557238696, 9999999.99999999, -0.402732051719949, 34.5930754463379, 2 ),
      ( 400, 23115.4432573415, 100000000.000001, 0.300777768369862, 35.7181586983545, 1 ),
      ( 500, 0.240547770072535, 999.99792013018, -1.38538149257447E-05, 28.8872509896319, 2 ),
      ( 500, 2.4057776773262, 9999.9999999997, -0.000138542192064657, 28.8889886207744, 2 ),
      ( 500, 24.0878246055229, 99999.9999970322, -0.00138579759377086, 28.9063910648207, 2 ),
      ( 500, 243.934065244183, 999999.999999999, -0.0138956716827309, 29.0830040808201, 2 ),
      ( 500, 2802.52697264744, 10000000, -0.141687341784664, 31.0569986608057, 2 ),
      ( 500, 19675.8389666734, 100000000.000095, 0.222537132820143, 35.1012770954893, 1 ),
      ( 600, 0.200455070150628, 999.998374804562, -6.84532764915461E-06, 30.6795500671799, 2 ),
      ( 600, 2.00467419754697, 9999.99999999993, -6.84489626794662E-05, 30.680449197416, 2 ),
      ( 600, 20.0590911573418, 99999.9999992679, -0.000684046971842577, 30.6894479563836, 2 ),
      ( 600, 201.825309424362, 999999.993273609, -0.00679603286319924, 30.7801602097892, 2 ),
      ( 600, 2139.53041819001, 9999999.9999994, -0.0630948909932169, 31.7345876923713, 2 ),
      ( 600, 16678.1212882126, 99999999.9999999, 0.201896151872523, 35.3665940126537, 1 ),
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
