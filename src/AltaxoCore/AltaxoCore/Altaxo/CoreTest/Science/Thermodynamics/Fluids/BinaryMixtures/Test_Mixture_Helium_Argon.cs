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
  /// Tests and test data for <see cref="Mixture_Helium_Argon"/>.
  /// </summary>
  /// <remarks>
  /// <para>Reference:</para>
  /// <para>The test data was created automatically using calls into the TREND.DLL of the following software:</para>
  /// <para>TREND 3.0.: Span, R.; Eckermann, T.; Herrig, S.; Hielscher, S.; Jäger, A.; Thol, M. (2016): TREND.Thermodynamic Reference and Engineering Data 3.0.Lehrstuhl für Thermodynamik, Ruhr-Universität Bochum.</para>
  /// </remarks>
  
  public class Test_Mixture_Helium_Argon : MixtureTestBase
  {

    public Test_Mixture_Helium_Argon()
    {
      _mixture = MixtureOfFluids.FromCASRegistryNumbersAndMoleFractions(new[] { ("7440-59-7", 0.5), ("7440-37-1", 0.5) });

      // TestData for 1 Permille to 999 Permille Molefraction contains:
      // 0. Temperature (Kelvin)
      // 1. Mole density (mol/m³)
      // 2. Pressure (Pa)
      // 3. delta*AlphaR_delta
      // 4. Isochoric heat capacity (J/mol K)
      // 5. Phasetype (1: liquid, 2: gas)
      _testData_001_999 = new (double temperature, double moleDensity, double pressure, double deltaPhiR_delta, double cv, int phase)[]
      {
      ( 100, 1.20298026422346, 999.999988844929, -0.000219091083662268, 12.4748774390466, 2 ),
      ( 100, 12.053628433999, 9999.99999999824, -0.00219530694928166, 12.5030722866877, 2 ),
      ( 100, 38260.2120018207, 99999999.9999994, 2.14351813291982, 23.4083930332584, 1 ),
      ( 150, 0.801866433872564, 999.999999909304, -6.89631377787134E-05, 12.4724235529636, 2 ),
      ( 150, 8.02364709096496, 9999.99847861262, -0.000689928605665712, 12.4783575123192, 2 ),
      ( 150, 80.7405931940234, 99999.9999855709, -0.00692934869114459, 12.5383472034986, 2 ),
      ( 150, 864.651303850552, 1000000, -0.0726768917406425, 13.2142651522407, 2 ),
      ( 150, 24095.9477057608, 9999999.9996452, -0.667242332853953, 17.2495565333389, 1 ),
      ( 150, 34125.9245433774, 100000000.000001, 1.34956604216901, 19.634657699521, 1 ),
      ( 200, 0.60137563206726, 999.999999993523, -2.87359196784813E-05, 12.4720113445829, 2 ),
      ( 200, 6.0153121963645, 9999.99993471449, -0.000287381010785544, 12.4742294274967, 2 ),
      ( 200, 60.3092839741967, 99999.9999999933, -0.00287598963112038, 12.4964567893213, 2 ),
      ( 200, 619.302538067017, 1000000.00006194, -0.0289748321373671, 12.7235043687116, 2 ),
      ( 200, 8435.60906333814, 9999999.99999943, -0.287119226993384, 15.2198422296077, 2 ),
      ( 200, 30363.2910683843, 100000000.000001, 0.98054403796684, 17.584265510414, 1 ),
      ( 250, 0.481093051672464, 999.999999999587, -1.32425195545022E-05, 12.4718878402089, 2 ),
      ( 250, 4.81150392347637, 9999.99999585997, -0.000132415062532832, 12.4729939106055, 2 ),
      ( 250, 48.1724064810803, 100000, -0.00132313095570913, 12.484054138566, 2 ),
      ( 250, 487.483805900497, 999999.999443034, -0.0131227438352176, 12.5945738170759, 2 ),
      ( 250, 5415.76966239178, 9999999.99999999, -0.111692869567396, 13.6314762121833, 2 ),
      ( 250, 27023.8995708966, 99999999.9999996, 0.780226719412563, 16.334297687242, 1 ),
      ( 250, 46041.3913234403, 1000000000, 9.44900397141979, 24.1926899224455, 1 ),
      ( 300, 0.400907993024476, 999.999999999972, -6.05051762038126E-06, 12.4718379149252, 2 ),
      ( 300, 4.00929820857976, 9999.99999972223, -6.04932163031621E-05, 12.4724946235017, 2 ),
      ( 300, 40.114775363469, 99999.9973374985, -0.000603733418532106, 12.4790578598105, 2 ),
      ( 300, 403.290914101302, 999999.999999397, -0.00591470494389214, 12.5442919860888, 2 ),
      ( 300, 4194.01553936136, 10000000.00007, -0.044100901484558, 13.1419108409513, 2 ),
      ( 300, 24148.3913968589, 100000000.000297, 0.660175043279865, 15.5267641146366, 1 ),
      ( 350, 0.343634155994815, 999.999999999998, -2.31828902247754E-06, 12.471813604756, 2 ),
      ( 350, 3.43641306712553, 9999.99999998842, -2.31732686623615E-05, 12.4722515315559, 2 ),
      ( 350, 34.3712661865909, 99999.9998936905, -0.000230769635210673, 12.4766279262601, 2 ),
      ( 350, 344.394592699178, 999999.999999999, -0.00221039846312175, 12.52010035988, 2 ),
      ( 350, 3476.35646559507, 10000000.0000298, -0.0115129250377147, 12.9217232903394, 1 ),
      ( 350, 21727.208332712, 100000000.000291, 0.581580745020981, 14.9735759704094, 1 ),
      ( 350, 43754.8078841199, 1000000000, 6.85361335216694, 21.7066316849776, 1 ),
      ( 400, 0.300679248962805, 999.997129991759, -2.39558460228752E-07, 12.4718001438489, 2 ),
      ( 400, 3.0067989362522, 10000, -2.38836229147058E-06, 12.4721169338608, 2 ),
      ( 400, 30.0686139504137, 99999.9999999522, -2.31604005695843E-05, 12.4752829865907, 2 ),
      ( 400, 300.726986674692, 1000000.00004253, -0.000158985339234478, 12.5067575795617, 1 ),
      ( 400, 2989.21763969867, 10000000.0000798, 0.00587916884848841, 12.8018279371546, 1 ),
      ( 400, 19707.9978966117, 100000000.000908, 0.525670832072249, 14.5745979869024, 1 ),
      ( 400, 42731.6947346554, 1000000000, 6.03644396412953, 20.828624148241, 1 ),
      ( 500, 0.240542924886875, 1000.01644801292, 1.69352868993717E-06, 12.4717865904007, 1 ),
      ( 500, 2.40539265892629, 10000.0000000024, 1.69390287125078E-05, 12.4719814060961, 1 ),
      ( 500, 24.0502504943373, 100000.000024188, 0.000169792205722759, 12.4739288380188, 1 ),
      ( 500, 240.125989352023, 999999.999999998, 0.00173805027506477, 12.4933301479974, 1 ),
      ( 500, 2355.25354550862, 10000000.0000166, 0.0213055017065016, 12.6799481326067, 1 ),
      ( 500, 16606.1616095581, 100000000.000001, 0.44851860441795, 14.0446964892005, 1 ),
      ( 600, 0.200452296150157, 1000.01947293968, 2.38441598078711E-06, 12.4717801827789, 1 ),
      ( 600, 2.00448003774993, 10000.0000000046, 2.38460185049279E-05, 12.471917334842, 1 ),
      ( 600, 20.0404948547209, 100000.0000465, 0.000238692282597995, 12.4732885626605, 1 ),
      ( 600, 199.970845488202, 1000000, 0.00241004218301615, 12.4869711996465, 1 ),
      ( 600, 1953.12687604365, 10000000.0000031, 0.0263172665354397, 12.6207871149232, 1 ),
      ( 600, 14372.4323218586, 99999999.9999999, 0.394703270628293, 13.7141033738468, 1 ),
      ( 600, 39216.3738638448, 1000000000, 4.11145636151231, 18.5884649797971, 1 ),
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
      ( 100, 1.20275115533339, 999.999999989719, -2.6364930783301E-05, 12.4718429399872, 2 ),
      ( 100, 12.0303657796783, 9999.9998972995, -0.000263610506901272, 12.4728007319787, 2 ),
      ( 100, 120.589362824505, 99999.9999467359, -0.00263222500077904, 12.4823619225599, 2 ),
      ( 200, 0.601358715211022, 1000, 1.64207472653136E-06, 12.4717595852814, 1 ),
      ( 200, 6.01349838074177, 10000.0000000066, 1.64369663289568E-05, 12.4719673371362, 1 ),
      ( 200, 60.125991949493, 100000.000082915, 0.000165989687878259, 12.4740433089216, 1 ),
      ( 200, 600.267047764447, 1000000.00000002, 0.00182031427441248, 12.4946539995893, 1 ),
      ( 200, 5814.66513966039, 10000000.000001, 0.034212130874905, 12.6883300008696, 1 ),
      ( 250, 0.481086109049325, 1000, 3.46903312686949E-06, 12.4717532916718, 1 ),
      ( 250, 4.81071085260242, 10000.00000004, 3.46990148510492E-05, 12.4719044132111, 1 ),
      ( 250, 48.092048621641, 100000.000419886, 0.000347857373639048, 12.4734152835452, 1 ),
      ( 250, 479.379154540136, 1000000.00000008, 0.00356424219007435, 12.4884914383049, 1 ),
      ( 250, 4609.38573931541, 10000000, 0.0437134255212621, 12.6368721848935, 1 ),
      ( 250, 26930.2755171717, 100000000.000175, 0.786419814556415, 13.8891702067134, 1 ),
      ( 300, 0.400904865409979, 1000, 4.0314240068857E-06, 12.4717499318713, 1 ),
      ( 300, 4.00890318051484, 10000.0000000445, 4.03191977129597E-05, 12.4718708185933, 1 ),
      ( 300, 40.074470616979, 100000.000453763, 0.000403687075404417, 12.4730796746815, 1 ),
      ( 300, 399.275144747523, 1000000.00000006, 0.00408574612121786, 12.4851677401426, 1 ),
      ( 300, 3835.11347757296, 10000000.0094834, 0.045357546758751, 12.6062078158426, 1 ),
      ( 300, 24142.677009192, 100000000.000008, 0.660571781144455, 13.690123487939, 1 ),
      ( 350, 0.343632711136, 1000, 4.12060092512369E-06, 12.4717477983115, 1 ),
      ( 350, 3.43619966877871, 10000.0000000359, 4.12089888857125E-05, 12.4718494839151, 1 ),
      ( 350, 34.3492475122486, 100000.000362202, 0.000412387454015816, 12.4728664193703, 1 ),
      ( 350, 342.212832578507, 1000000.00000003, 0.00415324730761415, 12.4830438644665, 1 ),
      ( 350, 3290.85366850332, 10000000.0010182, 0.0442096845561859, 12.5856075373139, 1 ),
      ( 350, 21872.2281208191, 100000000, 0.571097947639727, 13.5375801543719, 1 ),
      ( 350, 56695.7654722794, 1000000000, 5.06101927095894, 17.3684935276759, 1 ),
      ( 400, 0.300678652291997, 1000, 4.02066659073727E-06, 12.4717462936011, 1 ),
      ( 400, 3.00667771812716, 10000.0000000256, 4.02085259077479E-05, 12.4718344369826, 1 ),
      ( 400, 30.0558955065335, 100000.000257361, 0.000402271013867779, 12.4727159669463, 1 ),
      ( 400, 299.469689890719, 1000000.00000001, 0.00404104778082674, 12.4815408677461, 1 ),
      ( 400, 2885.39896294064, 10000000.0001438, 0.0420737828031719, 12.5706619762312, 1 ),
      ( 400, 19995.2789382723, 100000000, 0.503754271940102, 13.4172921786632, 1 ),
      ( 400, 55289.5435964962, 1000000000, 4.438277143594, 17.1026992443301, 1 ),
      ( 500, 0.240542994067192, 1000, 3.64742202332548E-06, 12.4717442664822, 1 ),
      ( 500, 2.40535115458344, 10000.0000000123, 3.64749991968282E-05, 12.4718141656245, 1 ),
      ( 500, 24.0456163950325, 100000.000123379, 0.000364827521268627, 12.4725132358555, 1 ),
      ( 500, 239.667680814674, 1000000, 0.00365592956226884, 12.4795117439067, 1 ),
      ( 500, 2319.05425230326, 10000000.0000056, 0.0372499424607513, 12.5501855110178, 1 ),
      ( 500, 17077.3224520221, 100000000.000003, 0.408557399160702, 13.2397757322684, 1 ),
      ( 600, 0.200452575747544, 1000.01922110665, 3.25282967458793E-06, 12.4717429373498, 1 ),
      ( 600, 2.00446720681823, 10000.0000000061, 3.2528004917773E-05, 12.471800872834, 1 ),
      ( 600, 20.0388051949086, 100000.000061081, 0.000325313131482565, 12.4723802851893, 1 ),
      ( 600, 199.802604535969, 999999.999999998, 0.00325639537021542, 12.4781799737927, 1 ),
      ( 600, 1940.76649820996, 10000000.0000004, 0.0328560442414098, 12.5366667851813, 1 ),
      ( 600, 14914.5111839111, 99999999.9999997, 0.344014821149322, 13.1152525213679, 1 ),
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
      ( 100, 1.20270529568594, 1000.00000000062, 1.40451037333938E-05, 12.4717371917315, 1 ),
      ( 100, 12.0255328326622, 10000.0000062635, 0.000140454932701127, 12.4719993966658, 1 ),
      ( 100, 120.103481308962, 99999.9999999999, 0.00140493406011084, 12.474620689244, 1 ),
      ( 100, 1186.01853366847, 1000000.00247917, 0.0140838053583853, 12.50075808383, 1 ),
      ( 100, 10520.6211026866, 10000000.0064393, 0.143204546733063, 12.7525110304423, 1 ),
      ( 100, 51183.5791496628, 100000000.000039, 1.34982040683404, 14.3224278614593, 1 ),
      ( 150, 0.801806945989746, 1000.0000000001, 9.78524986272541E-06, 12.4717282885598, 1 ),
      ( 150, 8.01736340226201, 10000.0000009562, 9.78521752409288E-05, 12.4719103666844, 1 ),
      ( 150, 80.1030992199926, 100000.009496291, 0.000978488664032915, 12.4737305626203, 1 ),
      ( 150, 794.048337430537, 1000000.00003742, 0.0097808333255107, 12.4918739266872, 1 ),
      ( 150, 7307.64230496487, 10000000, 0.0972277492650317, 12.6672340435434, 1 ),
      ( 150, 42340.7277332338, 100000000.000002, 0.893719911766432, 13.910549652718, 1 ),
      ( 200, 0.601356678308448, 1000.00000000002, 7.34272188454203E-06, 12.4717232497018, 1 ),
      ( 200, 6.01316941292362, 10000.0000002279, 7.34265208541047E-05, 12.4718599799946, 1 ),
      ( 200, 60.0919901406722, 100000.002264504, 0.000734195198857082, 12.4732268846352, 1 ),
      ( 200, 596.982378436043, 1000000.00000163, 0.0073347482696649, 12.4868561317958, 1 ),
      ( 200, 5606.64509740522, 10000000.0145871, 0.0725863390930667, 12.6191841576543, 1 ),
      ( 200, 36110.0844740337, 99999999.9999999, 0.665354990614106, 13.622719831442, 1 ),
      ( 200, 94440.3008604708, 999999999.999999, 5.36763212764179, 17.0788835274715, 1 ),
      ( 250, 0.481086083775472, 1000.00000000001, 5.80217814399642E-06, 12.4717200749934, 1 ),
      ( 250, 4.81060963404129, 10000.0000000716, 5.80211670185299E-05, 12.4718282341414, 1 ),
      ( 250, 48.0809933167487, 100000.000712736, 0.000580150154712653, 12.4729095491994, 1 ),
      ( 250, 478.316894380964, 1000000.00000013, 0.00579528081796839, 12.4836950985179, 1 ),
      ( 250, 4550.07419080251, 10000000.0004254, 0.0573209467577456, 12.5888319266538, 1 ),
      ( 250, 31501.5456110558, 100000000.001933, 0.527191335515812, 13.4217538522253, 1 ),
      ( 250, 91035.8694738455, 1000000000, 4.28460790129367, 16.5635460369336, 1 ),
      ( 300, 0.400905489741538, 1000, 4.75472159255581E-06, 12.4717179144546, 1 ),
      ( 300, 4.00888335007561, 10000.0000000271, 4.75467263602788E-05, 12.4718066295372, 1 ),
      ( 300, 40.0716887803279, 100000.00027034, 0.000475418277973343, 12.472693581562, 1 ),
      ( 300, 399.012383473218, 1000000.00000001, 0.00474925724668439, 12.4815432562531, 1 ),
      ( 300, 3829.11014743798, 10000000.0000213, 0.046998860045349, 12.5680918036042, 1 ),
      ( 300, 27951.2017433081, 100000000, 0.434311839674338, 13.2758740017203, 1 ),
      ( 350, 0.343633535608894, 1000, 4.00191728585437E-06, 12.4717163597936, 1 ),
      ( 350, 3.436211594996, 10000.0000000118, 4.00187878440696E-05, 12.471791083442, 1 ),
      ( 350, 34.3497460511498, 100000.000117232, 0.000400149364523709, 12.4725381720817, 1 ),
      ( 350, 342.266655031232, 1000000, 0.00399763092945424, 12.4799943006408, 1 ),
      ( 350, 3305.48057838574, 10000000.0000015, 0.039591377571182, 12.5531077662853, 1 ),
      ( 350, 25126.4352093278, 100000000, 0.367623015119595, 13.1658360859835, 1 ),
      ( 400, 0.300679513293101, 1000.01808604605, 3.43780401783561E-06, 12.471715193475, 1 ),
      ( 400, 3.00670210777721, 10000.0000000056, 3.43771133730881E-05, 12.4717794193165, 1 ),
      ( 400, 30.0577226348722, 100000.000056231, 0.000343740622781435, 12.47242156587, 1 ),
      ( 400, 299.651438950732, 1000000, 0.00343435026406241, 12.4788317362895, 1 ),
      ( 400, 2907.82361408088, 10000000.0000001, 0.0340398416727406, 12.541824898046, 1 ),
      ( 400, 22821.2004305994, 100000000, 0.317549214231884, 13.0801268024911, 1 ),
      ( 500, 0.240543786426098, 1000.0109149784, 2.65388185660171E-06, 12.471713570467, 1 ),
      ( 500, 2.40538054082792, 10000.0000000016, 2.65383311118635E-05, 12.471763190354, 1 ),
      ( 500, 24.0480622807873, 100000.000016133, 0.000265363390642809, 12.4722593188186, 1 ),
      ( 500, 239.908286868139, 1000000, 0.00265164117750436, 12.4772135146083, 1 ),
      ( 500, 2343.7593258661, 10000000.0018237, 0.0263188498398527, 12.526058562193, 1 ),
      ( 500, 19279.1952083905, 100000000.000626, 0.247689205703523, 12.9557258341555, 1 ),
      ( 600, 0.200453260530683, 1000.00721740478, 2.13946612313337E-06, 12.4717125038762, 1 ),
      ( 600, 2.00449409478786, 10000.0000000006, 2.13943707242817E-05, 12.4717525249603, 1 ),
      ( 600, 20.041082407889, 100000.000005714, 0.000213930006391012, 12.4721526883233, 1 ),
      ( 600, 200.026056218579, 1000000, 0.0021379302120891, 12.4761495493423, 1 ),
      ( 600, 1962.83927888673, 10000000.0002065, 0.021243563464561, 12.5156481028946, 1 ),
      ( 600, 16683.847937317, 100000000, 0.20148360690465, 12.8702674424311, 1 ),
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
