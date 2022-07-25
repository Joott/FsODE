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
  /// Tests and test data for <see cref="Dodecamethylpentasiloxane"/>.
  /// </summary>
  /// <remarks>
  /// <para>Reference:</para>
  /// <para>The test data was created automatically using calls into the TREND.DLL of the following software:</para>
  /// <para>TREND 3.0.: Span, R.; Eckermann, T.; Herrig, S.; Hielscher, S.; Jäger, A.; Thol, M. (2016): TREND.Thermodynamic Reference and Engineering Data 3.0.Lehrstuhl für Thermodynamik, Ruhr-Universität Bochum.</para>
  /// </remarks>
  
  public class Test_Dodecamethylpentasiloxane : FluidTestBase
  {

    public Test_Dodecamethylpentasiloxane()
    {
      _fluid = Dodecamethylpentasiloxane.Instance;

      _testDataMolecularWeight = 0.384839;

      _testDataTriplePointTemperature = 192;

      _testDataTriplePointPressure = 2.057E-07;

      _testDataTriplePointLiquidMoleDensity = double.NaN;

      _testDataTriplePointVaporMoleDensity = double.NaN;

      _testDataCriticalPointTemperature = 628.36;

      _testDataCriticalPointPressure = 945240.883459883;

      _testDataCriticalPointMoleDensity = 685.7981627;

      _testDataNormalBoilingPointTemperature = 503.022623775204;

      _testDataNormalSublimationPointTemperature = null;

      _testDataIsMeltingCurveImplemented = false;

      _testDataIsSublimationCurveImplemented = false;

      // TestData contains:
      // 0. Temperature (Kelvin)
      // 1. Mole density (mol/m³)
      // 2. Pressure (Pa)
      // 3. Internal energy (J/mol)
      // 4. Enthalpy (J/mol)
      // 5. Entropy (J/mol K)
      // 6. Isochoric heat capacity (J/(mol K))
      // 7. Isobaric heat capacity (J/(mol K))
      // 8. Speed of sound (m/s)
      _testDataEquationOfState = new (double temperature, double moleDensity, double pressure, double internalEnergy, double enthalpy, double entropy, double isochoricHeatCapacity, double isobaricHeatCapacity, double speedOfSound)[]
      {
      ( 275, 0.000192851628174926, 0.440949078501371, -349084.41557658, -346797.947566564, -789.521642797056, 816.216107590292, 824.530865549599, 77.4716462390309 ),
      ( 325, 0.000163181707737312, 0.44094905523191, -299843.101468495, -297140.90487216, -624.433652836685, 1168.63319720633, 1176.94780511457, 84.0926189010489 ),
      ( 375, 0.0001414239824187, 0.440949045188126, -231185.183335431, -228067.260634862, -427.452480594685, 1583.40829185413, 1591.72283653699, 90.2464443418037 ),
      ( 425, 0.000124785795857017, 0.440949040269915, -141315.0115579, -137781.363859927, -202.000767967404, 2010.09059859318, 2018.40511312145, 96.0214499958514 ),
      ( 475, 0.000111650414690429, 0.440949037618862, -30524.278711126, -26574.906567355, 44.9601740891646, 2416.48895975216, 2424.8034584665, 101.477612591003 ),
      ( 525, 0.000101017023861876, 0.440949036078163, 99746.9864238674, 104112.082713787, 306.242047701192, 2788.05981048582, 2796.37430025786, 106.660571970239 ),
      ( 575, 9.22329246854213E-05, 0.440949035127155, 247650.576611469, 252431.396873118, 575.869206134386, 3121.9543773972, 3130.26886179225, 111.606416072088 ),
      ( 625, 8.48542846602288E-05, 0.440949034510666, 411365.760977368, 416562.305103293, 849.405770758063, 3421.31377571487, 3429.62825670714, 116.344218236157 ),
      ( 225, 2450.82494514474, 1000.00000134675, -460750.162446041, -460749.754420162, -1221.79681723684, 648.114694753519, 752.849101563494, 1083.40366656632 ),
      ( 250, 2384.82722753257, 999.999999408734, -440898.66310324, -440898.243785653, -1138.21618584796, 741.873405241285, 841.597341663311, 993.068194245787 ),
      ( 275, 2320.36903229942, 999.999999522152, -418365.713003212, -418365.282037282, -1052.40609079512, 870.706214575604, 966.777588806555, 911.029856962272 ),
      ( 300, 2256.76764532187, 999.999999899596, -392297.648090105, -392297.204978471, -961.776115824721, 1029.93563348505, 1123.3508614533, 836.363453265101 ),
      ( 325, 2193.44533279736, 1000.00000000325, -361995.131319455, -361994.675415683, -864.852880170133, 1212.74925338004, 1304.27510389574, 767.784074133678 ),
      ( 350, 2129.87512641076, 1000.00002939173, -326944.437969794, -326943.968458686, -761.04191068583, 1411.69545698134, 1501.95526595324, 703.97004138173 ),
      ( 369.175473951162, 2080.62250815818, 1000.00008559516, -296630.752437697, -296630.271812268, -676.758258552865, 1570.79829755554, 1660.4573632845, 657.511504555148 ),
      ( 375, 0.321735226024468, 1000.00000000625, -231216.173989658, -228108.028163157, -491.777606813768, 1583.60073867868, 1592.08200616526, 89.9676929644471 ),
      ( 425, 0.283522488079485, 1000.00000000131, -141335.536328362, -137808.479244548, -266.291519330208, 2010.19836589146, 2018.60996191245, 95.8444881844513 ),
      ( 475, 0.253504337572754, 1000.00000000033, -30538.6783616909, -26593.972682983, -19.3125900440112, 2416.55341643791, 2424.92874081237, 101.358907526766 ),
      ( 525, 0.229269943597534, 1000.0000000001, 99736.4027193311, 104098.073439482, 241.979442425237, 2788.10045222958, 2796.4553472696, 106.577606111362 ),
      ( 575, 0.209282137719379, 1000.00000000003, 247642.494017052, 252420.732670849, 511.612704939071, 3121.98114062848, 3130.32378006668, 111.5466363443 ),
      ( 625, 0.192509003646969, 1000.00000000001, 411359.38841507, 416553.950648813, 785.153130733565, 3421.33205497376, 3429.66694972723, 116.300185793198 ),
      ( 225, 2450.84808807863, 9999.99999932789, -460751.066384314, -460746.986164064, -1221.80083483445, 648.117001501221, 752.848407083096, 1083.4523370911 ),
      ( 250, 2384.85412773701, 9999.99999944505, -440899.693239325, -440895.500110746, -1138.22030649636, 741.87562770854, 841.59605740319, 993.121419318059 ),
      ( 275, 2320.40031644926, 10000.0000005648, -418366.888361619, -418362.578760413, -1052.41036494189, 870.708378385512, 966.775622530031, 911.088180765113 ),
      ( 300, 2256.80410764883, 9999.99999997236, -392298.991795701, -392294.560750948, -961.780594974627, 1029.93775644049, 1123.34807659184, 836.427601341751 ),
      ( 325, 2193.48799490409, 9999.99999987372, -361996.67197018, -361992.113021135, -864.857620783956, 1212.75134647887, 1304.2713028054, 767.854996182944 ),
      ( 350, 2129.92532844343, 10000.0000309664, -326946.211670514, -326941.516670226, -761.046978576069, 1411.69752408082, 1501.95016087333, 704.048983277773 ),
      ( 375, 2065.59479989521, 10000.0001070148, -286819.338097276, -286814.496876671, -650.390114375865, 1619.75172975738, 1709.27984500321, 643.834459277856 ),
      ( 400, 1999.93355872228, 10000.0001938972, -241452.577067576, -241447.57690137, -533.346806308011, 1830.92802729376, 1920.24899583962, 586.207208804561 ),
      ( 421.923023986641, 1940.73888791795, 10000.0002266325, -197331.221782263, -197326.069105471, -426.003411255833, 2014.94203315412, 2104.53190576494, 537.102538585418 ),
      ( 425, 2.88469708843502, 10000.0000148201, -141524.007539698, -138057.439054947, -285.881260535919, 2011.18888035117, 2020.54031400598, 94.2050790003036 ),
      ( 475, 2.56265896651978, 10000.0000035948, -30669.9389712183, -26767.7420210032, -38.7342806438279, 2417.1410589593, 2426.08933392392, 100.271419784879 ),
      ( 525, 2.30914791924796, 10000.0000010218, 99640.3241574835, 103970.92589922, 222.651419504542, 2788.46939293711, 2797.19910794697, 105.822458842999 ),
      ( 575, 2.10309840106931, 10000.0000003261, 247569.304863919, 252324.194124089, 492.340539815264, 3122.2234801379, 3130.82489602536, 111.004779207733 ),
      ( 625, 1.93174325003112, 10000.0000001132, 411301.777565272, 416478.44894743, 765.916133589922, 3421.49730813637, 3430.01871991964, 115.902208152491 ),
      ( 225, 2451.079397446, 100000.000000092, -460760.100337347, -460719.301985362, -1221.84099514775, 648.140062025595, 752.841490061749, 1083.93882699574 ),
      ( 250, 2385.12296465533, 100000.000001011, -440909.987465437, -440868.060905891, -1138.26149379664, 741.897844642925, 841.583254812399, 993.653388544159 ),
      ( 275, 2320.71293012274, 99999.9999838544, -418378.632533986, -418335.542327229, -1052.45308263128, 870.730007868763, 966.756017595322, 911.67104864529 ),
      ( 300, 2257.16841461494, 99999.9999925447, -392312.416352389, -392268.113056567, -961.82535660498, 1029.95897645326, 1123.32031231684, 837.068590816539 ),
      ( 325, 2193.91417232154, 99999.9999981012, -362012.061713702, -361966.481079209, -864.904988823293, 1212.77226705256, 1304.23341667062, 768.563556231996 ),
      ( 350, 2130.42671734721, 100000.000031925, -326963.925890586, -326916.986937363, -761.097607990438, 1411.7181840608, 1501.89929839754, 704.837499739015 ),
      ( 375, 2066.1893268302, 100000.000111086, -286839.841463434, -286791.443188014, -650.444810440458, 1619.77207825862, 1709.21176226507, 644.719429425072 ),
      ( 400, 2000.64606895646, 100000.000199243, -241476.489119037, -241426.505265446, -533.406610908106, 1830.94788202313, 1920.15716422064, 587.211148495083 ),
      ( 425, 1933.14418962888, 100000.00023649, -190844.333951304, -190792.60475243, -410.684473475823, 2040.54647911918, 2130.06622572756, 531.437613341489 ),
      ( 450, 1862.84817040262, 100000.000191297, -135013.376502522, -134959.695262269, -283.087628901688, 2245.15997229752, 2335.6379141558, 476.571423139449 ),
      ( 475, 1788.59183320783, 100000.000083773, -74119.9001329754, -74063.990227637, -151.437701078771, 2442.53732867301, 2534.85576297216, 421.739224038216 ),
      ( 500, 1708.58732167899, 100000.00000025, -8335.38888772042, -8276.86100405219, -16.5022673344603, 2631.39123947775, 2726.92276619488, 365.882758691935 ),
      ( 501.450690046943, 1703.7135393779, 99999.9999999664, -4371.70610546305, -4313.01079214384, -8.58605299486538, 2642.07413550869, 2737.85242327405, 362.581797750096 ),
      ( 525, 25.0404181110379, 100000, 98587.0778644304, 102580.62140498, 201.47141552037, 2792.54129560261, 2806.51832948008, 97.2948397581119 ),
      ( 575, 22.1732270001493, 100000, 246792.038760974, 251301.982216626, 471.832663600446, 3124.80095966568, 3136.62409669732, 105.186876022738 ),
      ( 625, 20.0283562673846, 100000, 410701.250500282, 415694.17147018, 745.806143605494, 3423.22047082788, 3433.91100434845, 111.762188492576 ),
      ( 225, 2451.08280120594, 101325.000000862, -460760.23326353, -460718.894390787, -1221.84158618426, 648.140401433397, 752.841388604592, 1083.94598628616 ),
      ( 250, 2385.12692029183, 101325.000000701, -440910.138922517, -440867.656906512, -1138.26209990495, 741.898171620556, 841.583066872279, 993.661216494232 ),
      ( 275, 2320.71752940027, 101324.999983419, -418378.805306626, -418335.144241158, -1052.45371120801, 870.730326185908, 966.755729750965, 911.679624734937 ),
      ( 300, 2257.17377373339, 101324.999992813, -392312.613822172, -392267.723614261, -961.826015190535, 1029.95928872954, 1123.31990470777, 837.078020943651 ),
      ( 325, 2193.92044058519, 101324.999997641, -362012.288057625, -361966.103611679, -864.90568566949, 1212.77257490859, 1304.23286059231, 768.573978857031 ),
      ( 350, 2130.43409034837, 101325.000030857, -326964.186374403, -326916.625644648, -761.098352697115, 1411.71848807216, 1501.89855213796, 704.84909622343 ),
      ( 375, 2066.19806716999, 101325.00011082, -286840.142891317, -286791.103546193, -650.445614797719, 1619.77237768618, 1709.21076388553, 644.732441100168 ),
      ( 400, 2000.65654019158, 101325.000200334, -241476.840552576, -241426.194678002, -533.407490150309, 1830.94817420674, 1920.15581859444, 587.225904323867 ),
      ( 425, 1933.15691483301, 101325.000236309, -190844.747919045, -190792.333653312, -410.685448324079, 2040.54675826016, 2130.06437993341, 531.45457585451 ),
      ( 450, 1862.86394000272, 101325.000191366, -135013.871168155, -134959.479111915, -283.088729175172, 2245.16022697738, 2335.6353070696, 476.591269063978 ),
      ( 475, 1788.6119211766, 101325.000083576, -74120.5035169883, -74063.8534416512, -151.438972691612, 2442.53753642643, 2534.85191090986, 421.762997756362 ),
      ( 500, 1708.6139721497, 101325.000000106, -8336.1480694337, -8276.84561630403, -16.5037875357825, 2631.39135343888, 2726.91666419828, 365.912199209736 ),
      ( 502.022623775204, 1701.81125448321, 101325.000000195, -2805.44673029114, -2745.90722511202, -5.46424529989693, 2646.27754339009, 2742.1489054237, 361.30805079661 ),
      ( 525, 25.4064900504523, 101325, 98570.0619498509, 102558.216149773, 201.328678684186, 2792.60790730237, 2806.69027378375, 97.1530684840367 ),
      ( 575, 22.4858612868778, 101325, 246779.910784966, 251286.0757349, 471.701800993405, 3124.8412969654, 3136.72233222517, 105.095135072436 ),
      ( 625, 20.3050182008811, 101325, 410692.05713678, 415682.202873049, 745.68186820416, 3423.24686644681, 3433.97400509316, 111.698906701839 ),
      ( 224, 2456.02967307274, 992502.925649116, -461600.11114908, -461196.002462393, -1225.58468846068, 645.376313525753, 750.021657379828, 1092.51716039585 ),
      ( 248, 2392.9509652181, 992502.927633136, -442684.876823917, -442270.115743536, -1145.39255240666, 733.286529803278, 832.978928309016, 1005.77275201091 ),
      ( 272, 2331.40713718587, 992502.927632186, -421367.180217939, -420941.470391542, -1063.38399624707, 853.760905552896, 949.773228827556, 926.777786397152 ),
      ( 296, 2270.79740820123, 992502.923731206, -396880.647946062, -396443.575523773, -977.159654925592, 1002.91608431791, 1096.18390951756, 854.773072206707 ),
      ( 320, 2210.62132338499, 992502.927632293, -368585.195127361, -368136.225004286, -885.292224897249, 1174.88836206166, 1266.12666153945, 788.665223808553 ),
      ( 344, 2150.43532708224, 992502.927521587, -335996.688535306, -335535.152717408, -787.134849015342, 1363.09426807783, 1452.87282158423, 727.297040596182 ),
      ( 368, 2089.81885936999, 992502.927443562, -298790.71122021, -298315.788275098, -682.621175973233, 1561.16939284471, 1649.96566903854, 669.628124771422 ),
      ( 392, 2028.34340221427, 992502.927384277, -256788.619527672, -256299.302518382, -572.081850001469, 1763.54274395531, 1851.78324719439, 614.781155547497 ),
      ( 416, 1965.53887255423, 992502.927347339, -209933.840067273, -209428.887994736, -456.091296056154, 1965.70509710799, 2053.80281452577, 562.018089378739 ),
      ( 440, 1900.85074596349, 992502.927323006, -158264.530968493, -157742.394798974, -335.348945229322, 2164.26033332376, 2252.65529915674, 510.69487900188 ),
      ( 464, 1833.57759793277, 992502.927303059, -101886.59814614, -101345.305032381, -210.592761110628, 2356.84380179103, 2446.05594330144, 460.214201720909 ),
      ( 488, 1762.76972251437, 992502.92730967, -40949.1525381555, -40386.1164735843, -82.5396542692299, 2541.97362834737, 2632.68396202809, 409.978715433233 ),
      ( 512, 1687.04745377186, 992502.927633116, 24377.1113201161, 24965.4189728819, 48.1540640458189, 2718.88145161712, 2812.07603495238, 359.338462158547 ),
      ( 536, 1604.23883454591, 992502.927632804, 93919.7741361548, 94538.4494270529, 180.920071039024, 2887.35427633818, 2984.61748913966, 307.517145286825 ),
      ( 560, 1510.55219045386, 992502.927550708, 167526.849233985, 168183.895666292, 315.304331466361, 3047.61468729168, 3151.83464706186, 253.478575750572 ),
      ( 584, 1398.26615357847, 992502.927628512, 245105.031487475, 245814.841222258, 451.018350910186, 3200.29556235986, 3317.84624031769, 195.5836331904 ),
      ( 608, 1246.30966618506, 992502.927608311, 326747.89878662, 327544.252176581, 588.142483045136, 3346.82950848588, 3498.91250532676, 129.972975703212 ),
      ( 632, 640.290724847355, 992502.927632877, 418198.341568628, 419748.423256708, 736.701879739582, 3506.90047665333, 7689.04614485515, 18.8276676401761 ),
      ( 656, 302.447172715072, 992502.927632878, 511242.737822188, 514524.312315754, 884.009171338419, 3615.14004781243, 3730.1185129673, 67.3671272221933 ),
      ( 224, 2456.04864013897, 999999.998016689, -461600.851364376, -461193.693305014, -1225.58800697785, 645.378226987733, 750.021142115176, 1092.55720801782 ),
      ( 248, 2392.97284049672, 999999.999999875, -442685.714492008, -442267.824249764, -1145.39594544673, 733.288373206955, 832.977963545018, 1005.81631752279 ),
      ( 272, 2331.43236746302, 999999.999999599, -421368.128895885, -420939.208025627, -1063.3875010349, 853.762698963786, 949.771754069878, 926.825245011077 ),
      ( 296, 2270.82654908076, 999999.996099541, -396881.723808083, -396441.355521696, -977.163308614884, 1002.91784197254, 1096.18183657381, 854.824916942353 ),
      ( 320, 2210.65507353315, 999999.999999866, -368586.41773481, -368134.063130977, -885.296067046555, 1174.89009327358, 1266.12386603411, 788.722087227104 ),
      ( 344, 2150.4745782367, 999999.999888456, -335998.081926689, -335533.06829202, -787.138924152834, 1363.09597729175, 1452.86912870661, 727.359730510808 ),
      ( 368, 2089.86477115211, 999999.999811478, -298792.305498934, -298313.805639223, -682.625536711296, 1561.17107883344, 1649.96083011849, 669.697681918136 ),
      ( 392, 2028.39751747997, 999999.999751241, -256790.453248556, -256297.453236904, -572.086561288691, 1763.54439789028, 1851.77690060855, 614.858942493503 ),
      ( 416, 1965.6033018641, 999999.999715199, -209935.963954596, -209427.2143006, -456.096441492079, 1965.70669883726, 2053.79441820477, 562.105927041228 ),
      ( 440, 1900.92847589024, 999999.999690555, -158267.013959163, -157740.955239767, -335.35463709685, 2164.26184442026, 2252.64400838743, 510.795261834118 ),
      ( 464, 1833.67303493381, 999999.999671154, -101889.537731309, -101344.184235555, -210.599157369666, 2356.84515220465, 2446.0403754807, 460.330652187322 ),
      ( 488, 1762.88971938504, 999999.999678099, -40952.6936382337, -40385.4431808273, -82.546989453043, 2541.97468916279, 2632.66170693909, 410.116402951324 ),
      ( 512, 1687.20342254981, 999999.999999796, 24372.7389258283, 24965.4356846392, 48.1454175925026, 2718.8819741611, 2812.04252654918, 359.505367506457 ),
      ( 536, 1604.45163034084, 1000000.0000001, 93914.1728671379, 94537.4387737503, 180.909467246621, 2887.35373741166, 2984.56302621696, 307.726479002571 ),
      ( 560, 1510.86541372642, 999999.999913484, 167519.238483472, 168181.110805671, 315.290496681445, 3047.61181503708, 3151.73481269293, 253.754572221012 ),
      ( 584, 1398.79304553535, 999999.999994335, 245093.530514622, 245808.432553337, 450.998197913213, 3200.28638438596, 3317.61938407051, 195.979184436556 ),
      ( 608, 1247.50879074556, 999999.999965145, 326725.576401911, 327527.173959687, 588.10450485973, 3346.7931617409, 3498.04385651, 130.659077996066 ),
      ( 632, 756.985541624912, 1000000, 416316.538877357, 417637.56807146, 733.344956745073, 3504.48808872173, 6705.35765057063, 19.7459588331141 ),
      ( 656, 306.917780895871, 1000000, 511124.480135816, 514382.681720231, 883.75576008664, 3615.44355605936, 3733.84126732179, 66.7708182538302 ),
      ( 224, 2477.83578560414, 10000000.0045219, -462444.74999398, -458408.970035268, -1229.44206024534, 647.616695598431, 749.614667259989, 1138.86988024975 ),
      ( 248, 2417.91953215087, 9999999.99999906, -443634.069504387, -439498.282573916, -1149.31398844419, 735.437019936407, 832.113946155779, 1055.87357537288 ),
      ( 272, 2359.96439200997, 9999999.99999858, -422433.641257469, -418196.289188152, -1067.40765791774, 855.845012310848, 948.408716765331, 980.941604180357 ),
      ( 296, 2303.45765808459, 9999999.99999722, -398079.026874919, -393737.727192288, -981.321561463215, 1004.95056635292, 1094.25873496704, 913.40756984933 ),
      ( 320, 2248.00830112014, 9999999.99998327, -369932.502916237, -365484.120766135, -889.628387609002, 1176.88456665626, 1263.55707267222, 852.276427852908 ),
      ( 344, 2193.31132650464, 9999999.99996199, -337512.853118431, -332953.536855793, -791.6830894676, 1365.05865146573, 1449.5470137365, 796.501190357401 ),
      ( 368, 2139.12491104759, 9999999.99995243, -300499.315340949, -295824.506521554, -687.422917699486, 1563.10338250026, 1645.73525616567, 745.17316842767 ),
      ( 392, 2085.25554812674, 9999999.99996018, -258717.899907071, -253922.324607467, -577.184125193911, 1765.4419427532, 1846.45032240687, 697.578351046025 ),
      ( 416, 2031.54857850594, 9999999.99997507, -212118.068903329, -207195.715529269, -461.549227717884, 1967.55768162582, 2047.10027512473, 653.184445029453 ),
      ( 440, 1977.88268088366, 9999999.99998597, -160745.972717883, -155690.061112692, -341.229053785057, 2166.04430346168, 2244.21626554644, 611.608600957117 ),
      ( 464, 1924.16759468605, 9999999.99999425, -104718.365458067, -99521.3129624266, -216.977640673792, 2358.52240627415, 2435.36438601115, 572.587259149054 ),
      ( 488, 1870.3447436488, 9999999.99999772, -44199.5418725567, -38852.9339629961, -89.5349732006298, 2543.48762547392, 2618.99046265477, 535.953544735477 ),
      ( 512, 1816.39057862707, 9999999.99999946, 20617.6729745238, 26123.0968176479, 40.4083841166527, 2720.13535305908, 2794.24257863593, 501.621216544062 ),
      ( 536, 1762.32232704099, 9999999.99999996, 89526.7151387717, 95201.0460182938, 172.230456344378, 2888.18977835068, 2960.79926400341, 469.572012991217 ),
      ( 560, 1708.20533597576, 10000000, 162318.199450703, 168172.296607171, 305.38571284769, 3047.75219270052, 3118.71878864633, 439.842579976691 ),
      ( 584, 1654.16026383743, 9999999.99999985, 238787.56683656, 244832.930286895, 439.405513582717, 3199.17486105845, 3268.31646006961, 412.507201361316 ),
      ( 608, 1600.36714805094, 10000000.0005361, 318740.151489556, 324988.717646838, 573.894107658581, 3342.96144854747, 3410.07113213052, 387.653566628166 ),
      ( 632, 1547.06243177631, 10000000.0001594, 401994.326496577, 408458.189747834, 708.522306296918, 3479.69206847259, 3544.55804575852, 365.351515020818 ),
      ( 656, 1494.52546034811, 10000000.0000476, 488383.268950154, 495074.356031212, 843.020229422496, 3609.96965726628, 3672.40196919766, 345.61924406939 ),
      };

      // TestData contains:
      // 0. Temperature (Kelvin)
      // 1. Pressure (Pa)
      // 2. Saturated liquid density (mol/m³
      // 3. Saturated vapor density (mol/m³)
      _testDataSaturatedProperties = new (double temperature, double pressure, double saturatedLiquidMoleDensity, double saturatedVaporMoleDensity)[]
      {
      ( 246.545, 0.0146582223975225, 2393.83631126381, 7.15073283093073E-06 ),
      ( 301.09, 8.53330317168459, 2254.00086272932, 0.00340890964521494 ),
      ( 355.635, 448.747897954746, 2115.45599139181, 0.152028871373287 ),
      ( 410.18, 6167.29901812199, 1972.63483116213, 1.83306860319854 ),
      ( 464.725, 38203.6861595847, 1818.83921752878, 10.4292743269921 ),
      ( 519.27, 145049.928240468, 1642.31090283209, 38.8976691247829 ),
      ( 573.815, 405619.807480641, 1411.71005125545, 120.32353169483 ),
      };
    }

    [Fact]
    public override void CASNumberAttribute_Test()
    {
      base.CASNumberAttribute_Test();
    }

    [Fact]
    public override void ConstantsAndCharacteristicPoints_Test()
    {
      base.ConstantsAndCharacteristicPoints_Test();
    }

    [Fact]
    public override void EquationOfState_Test()
    {
      base.EquationOfState_Test();
    }

    [Fact]
    public override void SaturatedVaporPressure_TestMonotony()
    {
      base.SaturatedVaporPressure_TestMonotony();
    }

    [Fact]
    public override void SaturatedVaporPressure_TestInverseIteration()
    {
      base.SaturatedVaporPressure_TestInverseIteration();
    }

    [Fact]
    public override void SaturatedVaporProperties_TestData()
    {
      base.SaturatedVaporProperties_TestData();
    }

    [Fact]
    public override void MeltingPressure_TestImplemented()
    {
      base.MeltingPressure_TestImplemented();
    }

    [Fact]
    public override void SublimationPressure_TestImplemented()
    {
      base.SublimationPressure_TestImplemented();
    }
  }
}
