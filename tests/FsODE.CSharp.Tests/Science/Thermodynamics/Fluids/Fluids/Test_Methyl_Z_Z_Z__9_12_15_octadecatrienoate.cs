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
  /// Tests and test data for <see cref="Methyl_Z_Z_Z__9_12_15_octadecatrienoate"/>.
  /// </summary>
  /// <remarks>
  /// <para>Reference:</para>
  /// <para>The test data was created automatically using calls into the TREND.DLL of the following software:</para>
  /// <para>TREND 3.0.: Span, R.; Eckermann, T.; Herrig, S.; Hielscher, S.; Jäger, A.; Thol, M. (2016): TREND.Thermodynamic Reference and Engineering Data 3.0.Lehrstuhl für Thermodynamik, Ruhr-Universität Bochum.</para>
  /// </remarks>
  
  public class Test_Methyl_Z_Z_Z__9_12_15_octadecatrienoate : FluidTestBase
  {

    public Test_Methyl_Z_Z_Z__9_12_15_octadecatrienoate()
    {
      _fluid = Methyl_Z_Z_Z__9_12_15_octadecatrienoate.Instance;

      _testDataMolecularWeight = 0.29245618;

      _testDataTriplePointTemperature = 218.65;

      _testDataTriplePointPressure = 8.28E-12;

      _testDataTriplePointLiquidMoleDensity = double.NaN;

      _testDataTriplePointVaporMoleDensity = double.NaN;

      _testDataCriticalPointTemperature = 772;

      _testDataCriticalPointPressure = 1368997.20361407;

      _testDataCriticalPointMoleDensity = 847.3;

      _testDataNormalBoilingPointTemperature = 629.129108153121;

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
      ( 303, 3049.6092451394, 1000.00000088135, -230888.067472743, -230887.73956188, -507.673056105678, 521.633695025975, 619.80686989155, 1392.55344712477 ),
      ( 342, 2954.14763645882, 1000.00000004701, -206544.850667017, -206544.5121599, -432.110492564209, 540.446954843177, 630.010246882184, 1260.4968617032 ),
      ( 381, 2862.03538181384, 999.999999177481, -181656.825317368, -181656.475915678, -363.213781211889, 562.975057276659, 647.237415209079, 1141.11851561199 ),
      ( 420, 2771.0496851496, 999.999999060367, -155999.25461428, -155998.893740203, -299.116591860704, 587.885348667327, 669.19493980797, 1029.77979574988 ),
      ( 459, 2679.16834951966, 999.999981673083, -129415.386914051, -129415.013663903, -238.606885498609, 614.337164978625, 694.573402028344, 923.481348497293 ),
      ( 498, 0.241978111652348, 1000.00000000145, -24948.5068001469, -20815.9016104752, -11.743166969531, 602.287041755331, 610.694859452971, 119.583472053997 ),
      ( 537, 0.224294522222973, 1000.00000000061, -786.410603187477, 3672.01303591727, 35.5826801240527, 636.526752953938, 644.909381627406, 124.190133024843 ),
      ( 576, 0.209037021531256, 1000.00000000027, 24687.6706262696, 29471.5122284652, 81.94842738911, 669.564731927822, 677.930653040345, 128.621615322223 ),
      ( 615, 0.195733391071248, 1000.00000000013, 51424.2800354229, 56533.2703539737, 127.397103501133, 701.265140231256, 709.619671162937, 132.898895041249 ),
      ( 654, 0.184028097528086, 1000.00000000007, 79369.1595505743, 84803.1123731722, 171.956127103691, 731.522392071944, 739.868925656007, 137.038555346447 ),
      ( 693, 0.173647810148598, 1000.00000000003, 108464.63854003, 114223.42121137, 215.643018852856, 760.269076904994, 768.609825814499, 141.054064128513 ),
      ( 732, 0.164378647090256, 1000.00000000001, 138651.144738942, 144734.659950324, 258.46971125462, 787.475482017841, 795.811925123988, 144.956603363851 ),
      ( 771, 0.156050685122544, 1000.00000000001, 169868.595843499, 176276.770208224, 300.445574542678, 813.144742568356, 821.477894246816, 148.755625160611 ),
      ( 810, 0.148527128895026, 1000.00000000001, 202057.559628688, 208790.336377553, 341.579398861383, 837.306304015017, 845.636878512082, 152.459236861314 ),
      ( 849, 0.141696562771076, 1000, 235160.151526896, 242217.485737717, 381.880591086593, 860.009265172103, 868.337778456477, 156.074476127174 ),
      ( 888, 0.135467297084765, 999.999999999998, 269120.683135965, 276502.538546974, 421.359814283533, 881.316396246933, 889.643230246294, 159.607513085281 ),
      ( 927, 0.129763170782085, 1000, 303886.095671846, 311592.442503331, 460.029251585013, 901.299147033318, 909.624590934093, 163.063802689964 ),
      ( 966, 0.124520387462263, 1000, 339406.218721484, 347437.03215196, 497.902630362391, 920.033691363297, 928.357968705194, 166.448202145675 ),
      ( 303, 3049.6281006455, 9999.99999800088, -230888.804192614, -230885.525104257, -507.675487561196, 521.636887456412, 619.806817791646, 1392.5828458912 ),
      ( 342, 2954.17021413993, 10000.0000003651, -206545.695154686, -206542.310109386, -432.112961868004, 540.450076040413, 630.009644619419, 1260.53143400805 ),
      ( 381, 2862.06255105297, 10000.0000005612, -181657.804240098, -181654.310256363, -363.216350610766, 562.97820170427, 647.236121189387, 1141.15934705564 ),
      ( 420, 2771.08271682207, 9999.99999883773, -156000.404405342, -155996.79570758, -299.1193295148, 587.888593419797, 669.192714378058, 1029.8284052456 ),
      ( 459, 2679.20914452494, 9999.99998193349, -129416.75935517, -129413.026910466, -238.609875634506, 614.340575717798, 694.569831171033, 923.539810038334 ),
      ( 498, 2584.32200802196, 9999.99993117877, -101790.025972107, -101786.156485293, -180.857002371842, 641.685852233135, 722.590073034655, 820.192338625205 ),
      ( 537, 2483.859709625, 9999.99985092069, -73025.6584792664, -73021.6324870527, -125.261398567881, 669.386785984328, 752.884649251017, 718.16741847575 ),
      ( 576, 2.11158211975695, 10000.0000028476, 24553.2564374399, 29289.0419459848, 62.5698989475105, 670.009407807567, 678.856539081833, 127.36810348763 ),
      ( 615, 1.97275084112371, 10000.0000013291, 51312.7643848394, 56381.8282487955, 108.070785401163, 701.575274225367, 710.300999771374, 131.891016694653 ),
      ( 654, 1.85171154214099, 10000.0000006508, 79274.3877787712, 84674.7969532415, 152.666321439657, 731.74234614811, 740.383986683351, 136.217634112586 ),
      ( 693, 1.74508245518476, 10000.0000003299, 108382.424926731, 114112.813178942, 196.379544289608, 760.428231777161, 769.009656662551, 140.379354221218 ),
      ( 732, 1.65033628321241, 10000.0000001714, 138578.594952918, 144637.966065275, 239.225790543798, 787.593229588158, 796.130169597148, 144.39885621705 ),
      ( 771, 1.56553171511322, 10000.0000000904, 169803.669896387, 176191.276039113, 281.216573574141, 813.233916986332, 821.737049351726, 148.293214281189 ),
      ( 810, 1.48914455244593, 10000.000000048, 201998.789571331, 208714.054374619, 322.362062726507, 837.375457346377, 845.852239537806, 152.075750218935 ),
      ( 849, 1.41995660865111, 10000.0000000254, 235106.458010273, 242148.926730162, 362.672573201467, 860.064150884088, 868.519935679205, 155.757174763156 ),
      ( 888, 1.3569798028848, 10000.0000000133, 269071.255111843, 276440.561551596, 402.159380590615, 881.360929749464, 889.799658773623, 159.346315368054 ),
      ( 927, 1.29940263657713, 10000.0000000068, 303840.310587913, 311536.154600011, 440.835090958972, 901.33602738729, 909.760672324543, 162.850596293311 ),
      ( 966, 1.24655144441327, 10000.0000000034, 339363.588880069, 347385.720694059, 478.713730533235, 920.06480515736, 928.477654825482, 166.276365803287 ),
      ( 275, 3121.74408056478, 15000.0000007919, -248217.876093662, -248213.071087354, -567.684417585466, 511.798651898581, 619.123151785222, 1499.20482742603 ),
      ( 300, 3057.19402417432, 14999.9999991556, -232748.020955956, -232743.114496019, -513.842125289367, 520.406700823566, 619.417446080111, 1403.47037113321 ),
      ( 325, 2995.23407929312, 15000.0000004047, -217207.449365544, -217202.441409704, -464.088146140334, 531.683468900003, 624.50723887965, 1316.19421206265 ),
      ( 350, 2935.09448313099, 14999.9999978003, -201494.079621494, -201488.969053475, -417.512323102683, 544.825422455886, 633.06619567462, 1235.21515626145 ),
      ( 375, 2876.12240357603, 14999.9999992461, -185532.676464437, -185527.461109214, -373.467543975175, 559.333753488617, 644.234806318925, 1158.93053439777 ),
      ( 400, 2817.7411341043, 15000.0000005727, -169265.645774276, -169260.322361199, -331.477844256495, 574.876723110346, 657.437809518348, 1086.15496786581 ),
      ( 425, 2759.41515148215, 15000.0000050167, -152647.424281531, -152641.988347037, -291.183180035915, 591.210451844854, 672.274311265021, 1015.99820339334 ),
      ( 450, 2700.61824297128, 15000.0000189453, -135640.976004677, -135635.421720928, -252.304850647224, 608.13723193451, 688.455625516053, 947.771352571244 ),
      ( 475, 2640.80178875059, 15000.0000399638, -118215.435480378, -118209.75538727, -214.622774942082, 625.485871786901, 705.773338876097, 880.920213805837 ),
      ( 500, 2579.35960093793, 15000.0000581648, -100344.293828045, -100338.478431055, -177.959723031394, 643.103931093746, 724.086421613947, 814.980432173866 ),
      ( 525, 2515.58439223133, 15000.0000533855, -82003.7365767492, -81997.7737475554, -142.169698575411, 660.855841115778, 743.321350907629, 749.549148318684 ),
      ( 550, 2448.60840914901, 15000.0000272589, -63170.8376656802, -63164.711737185, -107.128760403271, 678.62373487145, 763.483583299129, 684.269080216893 ),
      ( 553.024156761166, 2440.23945509469, 15000.0000233678, -60858.1795738249, -60852.0326360758, -102.935413559456, 680.769209762906, 765.989326821275, 676.366993628698 ),
      ( 575, 3.1914581242119, 15000.0000151175, 23807.174508665, 28507.2205162628, 57.8867294206764, 669.436618866458, 678.571902671414, 126.536214723383 ),
      ( 625, 2.92236755262821, 15000.0000056728, 58310.0538855378, 63442.8784654517, 116.123413528276, 709.607387557503, 718.510139177025, 132.481109165825 ),
      ( 675, 2.69729356703433, 15000.0000022973, 94760.1518674221, 100321.281803601, 172.868795908094, 747.479439067723, 756.23686795125, 138.06474231751 ),
      ( 725, 2.50562007782162, 15000.0000009779, 133039.902509896, 139026.444577366, 228.170379526468, 782.899405565606, 791.56071430049, 143.365395148901 ),
      ( 775, 2.34009929304501, 15000.0000004284, 173026.261370012, 179436.245786063, 282.057902765241, 815.826751941345, 824.42122060728, 148.433785869549 ),
      ( 825, 2.19554283187892, 15000.0000001896, 214596.011015079, 221428.034413754, 334.554822372515, 846.305897163612, 854.851843330477, 153.305080960459 ),
      ( 875, 2.0681032149409, 15000.0000000833, 257629.485493955, 264882.508404861, 385.684375429379, 874.438968332698, 882.948394864834, 158.00507010246 ),
      ( 925, 1.95484897087358, 15000.0000000356, 302012.961068681, 309686.188117691, 435.472387746063, 900.36332615538, 908.84443562853, 162.55353454318 ),
      ( 975, 1.8534980165152, 15000.0000000145, 347640.022005137, 355732.828075799, 483.948220848002, 924.23465643299, 932.693267045807, 166.96619096553 ),
      ( 275, 3121.90047823794, 99999.9999977652, -248224.219757398, -248192.187986785, -567.707488808834, 511.829923982341, 619.12586558433, 1499.45158892159 ),
      ( 300, 3057.369612117, 100000.000000929, -232754.90623755, -232722.198383189, -513.865079828328, 520.436937496984, 619.417325591532, 1403.74451085074 ),
      ( 325, 2995.43108958208, 100000.000001091, -217214.951218468, -217181.567042031, -464.111232649335, 531.713110869759, 624.503957844526, 1316.49829347888 ),
      ( 350, 2935.31575789411, 99999.9999999364, -201502.288480577, -201468.220595467, -417.535781204819, 544.854868195824, 633.059319819694, 1235.55271014741 ),
      ( 375, 2876.37155336235, 99999.999998054, -185541.701530162, -185506.935507017, -373.491615434502, 559.36335379822, 644.223736413864, 1159.3060789368 ),
      ( 400, 2818.02275847772, 100000.000001708, -169275.620247493, -169240.134373683, -331.502785537263, 574.906784683636, 657.421705104431, 1086.57408436506 ),
      ( 425, 2759.73515698998, 100000.00000684, -152658.513176557, -152622.277815438, -291.209277238036, 591.241246734597, 672.251985307454, 1016.46769850164 ),
      ( 450, 2700.98431153117, 100000.000018653, -135653.387582201, -135616.364042452, -252.332438342016, 608.169009152452, 688.425388828005, 948.29953056564 ),
      ( 475, 2641.22408228848, 100000.000041465, -118229.438100942, -118191.576868072, -214.652261470707, 625.518868098742, 705.732757370386, 881.517288545086 ),
      ( 500, 2579.85184828766, 100000.000059716, -100360.241351001, -100321.479435224, -177.99162658199, 643.138378432842, 724.031920950833, 815.659125714163 ),
      ( 525, 2516.16561756287, 100000.000056329, -82022.1078320264, -81982.3648201363, -142.204701496429, 660.891966939096, 743.247546308304, 750.325554085254 ),
      ( 550, 2449.30578365821, 100000.00002892, -63192.3001418572, -63151.4722465833, -107.167795238688, 678.661747821479, 763.382091826632, 685.163923337972 ),
      ( 575, 2378.16950039918, 100000.000000349, -43846.8160646, -43804.7669171429, -72.7714721482913, 696.349711414191, 784.540720745085, 619.862609758818 ),
      ( 600, 2301.2755763262, 100000.000000005, -23957.2782741787, -23913.8241129175, -38.9128234425456, 713.881263048391, 806.980890029434, 554.150952124645 ),
      ( 625, 2216.53388995054, 100000.000000234, -3485.99537410163, -3440.87988976204, -5.48632980686321, 731.211343701244, 831.217909654896, 487.791426283345 ),
      ( 627.525297269034, 2207.42830099226, 100000.000000202, -1383.85591544431, -1338.55433081063, -2.12938967680633, 732.950079529958, 833.799214345199, 481.042919683797 ),
      ( 650, 19.9645600106202, 100000, 75323.6438298837, 80332.5195550088, 127.390910182558, 731.188998118455, 743.709436833441, 126.823485993775 ),
      ( 700, 18.1607324556306, 100000, 112883.497258363, 118389.883096287, 183.782128254912, 767.010525435536, 778.355361059426, 134.345910361679 ),
      ( 750, 16.7115827795308, 100000, 152155.810817671, 158139.684476992, 238.61810992644, 800.68929145666, 811.315359604934, 141.009782290194 ),
      ( 800, 15.5080198890586, 100000, 193038.941026317, 199487.217512637, 291.977550312276, 832.080983568269, 842.231138363071, 147.083987754084 ),
      ( 850, 14.4852279814191, 99999.9999999997, 235423.30763802, 242326.892457553, 343.911521240374, 861.181046030036, 870.996691415582, 152.723311018841 ),
      ( 900, 13.6012562150382, 100000.000094284, 279199.151616666, 286551.413680792, 394.460337945764, 888.066607106579, 897.63605314876, 158.024763475215 ),
      ( 950, 12.8272256274751, 100000.000037947, 324260.66848729, 332056.586555789, 443.661108814099, 912.860241607527, 922.241837984669, 163.053315906546 ),
      ( 1000, 12.1423238881564, 100000.000014195, 370508.159297898, 378743.815086304, 491.550967185889, 935.70701180232, 944.941136892507, 167.854843815447 ),
      ( 275, 3121.90291572404, 101325.000000625, -248224.318614244, -248191.86244801, -567.707848379819, 511.830411367964, 619.125907989413, 1499.45543476553 ),
      ( 300, 3057.37234859934, 101324.999998967, -232755.013530589, -232721.872326821, -513.865437570019, 520.4374087319, 619.417323853003, 1403.74878324512 ),
      ( 325, 2995.43415980939, 101325.000000533, -217215.068114387, -217181.241632283, -464.111592435068, 531.713572820094, 624.503906891105, 1316.50303231427 ),
      ( 350, 2935.31920610661, 101324.999997702, -201502.416386802, -201467.897142766, -417.536146766278, 544.85532706839, 633.059212902222, 1235.55797036555 ),
      ( 375, 2876.3754357521, 101324.999999194, -185541.842145818, -185506.615520413, -373.491990535549, 559.363815055679, 644.223564221011, 1159.31193083465 ),
      ( 400, 2818.02714661418, 101325.000001134, -169275.775644638, -169239.819638989, -331.503174169183, 574.907253099945, 657.421454579208, 1086.58061476063 ),
      ( 425, 2759.74014275569, 101325.00000584, -152658.685921399, -152621.970508076, -291.209683851539, 591.241726542189, 672.251638014116, 1016.47501324077 ),
      ( 450, 2700.99001438846, 101325.000019547, -135653.580912389, -135616.066889945, -252.332868139522, 608.169504222514, 688.424918542633, 948.307758732253 ),
      ( 475, 2641.23066020434, 101325.000040881, -118229.656186734, -118191.29338807, -214.652720798515, 625.519382108756, 705.732126325168, 881.526588828254 ),
      ( 500, 2579.8595145716, 101325.000059564, -100360.489688514, -100321.214294064, -177.99212348891, 643.138914981277, 724.031073724379, 815.669695650429 ),
      ( 525, 2516.17466761527, 101325.000056491, -82022.3938537119, -81982.1243917542, -142.20524657372, 660.892529550171, 743.246399483399, 750.337643363597 ),
      ( 550, 2449.31663904317, 101325.000028646, -63192.6342001571, -63151.2655186181, -107.168402948593, 678.662339721827, 763.38051569447, 685.17785318237 ),
      ( 575, 2378.18278474376, 101325.000000274, -43847.2130897454, -43804.60702908, -72.7721630380039, 696.35033480449, 784.538505138023, 619.878802061395 ),
      ( 600, 2301.29225341348, 101325.000000075, -23957.7607301303, -23913.7311203101, -38.9136280641173, 713.881917189434, 806.977675749263, 554.169976073215 ),
      ( 625, 2216.55553392816, 101325.000000193, -3486.59894633561, -3440.8861282044, -5.4872962319691, 731.21202005443, 831.21303574921, 487.814082737611 ),
      ( 628.129108153121, 2205.2567209833, 101325.000000068, -880.878694211392, -834.931662722519, -1.32817855715992, 733.366182299299, 834.415567793111, 479.451107530383 ),
      ( 650, 20.2513954886568, 101325, 75307.4675386988, 80310.8264458296, 127.256158409213, 731.228466050992, 743.820472296121, 126.682514015663 ),
      ( 700, 18.4156677269995, 101325, 112870.574310303, 118372.682705289, 183.654052844684, 767.035307302477, 778.428025290229, 134.242639041376 ),
      ( 750, 16.9425930290963, 101325, 152145.043295119, 158125.532812042, 238.49424980533, 800.705680181964, 811.366536616695, 140.931959697561 ),
      ( 800, 15.7200865746462, 101325, 193029.697333734, 199475.272523086, 291.856543028883, 832.092359019767, 842.269227416745, 147.024521821329 ),
      ( 850, 14.6817455878114, 101325, 235415.197874327, 242316.625187175, 343.792550775048, 861.189306951248, 871.026279897196, 152.677703795167 ),
      ( 900, 13.7846815811104, 101325.000099155, 279191.9211365, 286542.471782371, 394.342884184014, 888.072859297133, 897.659822971931, 157.989967744036 ),
      ( 950, 12.9994162343023, 101325.000039883, 324254.142847833, 332048.723636201, 443.544822812548, 912.86515012421, 922.261445148928, 163.027162711901 ),
      ( 1000, 12.3047308078919, 101325.00001491, 370502.213948636, 378736.851633674, 491.435604593731, 935.710988990629, 944.957652636183, 167.835729665971 ),
      ( 275, 3121.93175817317, 117004.153924766, -248225.488350152, -248188.01022347, -567.712103139666, 511.836178547817, 619.126410019448, 1499.50094217533 ),
      ( 300, 3057.40472882734, 117004.153922515, -232756.28307915, -232718.013970445, -513.869670659043, 520.44298477081, 619.417303605691, 1403.7993376343 ),
      ( 325, 2995.47048890335, 117004.153924459, -217216.451277428, -217177.390918009, -464.11584968131, 531.719038958487, 624.503304390148, 1316.55910555853 ),
      ( 350, 2935.3600074276, 117004.153925352, -201503.929813511, -201464.069573667, -417.540472319557, 544.86075674257, 633.057948330071, 1235.62021238334 ),
      ( 375, 2876.42137402922, 117004.153924745, -185543.505935228, -185502.828948545, -373.496428923624, 559.369272893835, 644.221527462555, 1159.38117316168 ),
      ( 400, 2818.0790684506, 117004.153928259, -169277.614306057, -169236.09518928, -331.507772607049, 574.912795577941, 657.418491229794, 1086.65788431288 ),
      ( 425, 2759.79913498499, 117004.153931905, -152660.72980748, -152618.333912631, -291.214494984745, 591.247403724251, 672.247530075717, 1016.56156192682 ),
      ( 450, 2701.05748998375, 117004.153945469, -135655.868314899, -135612.550409086, -252.337953499874, 608.175361893313, 688.419355948827, 948.405113195035 ),
      ( 475, 2641.30848741886, 117004.153967453, -118232.236423447, -118187.938623881, -214.658155439654, 625.525463754295, 705.72466256417, 881.636625662769 ),
      ( 500, 2579.9502159425, 117004.153986645, -100363.427750479, -100318.076428092, -177.998002588042, 643.145263144038, 724.021053664128, 815.794750564125 ),
      ( 525, 2516.28173603476, 117004.153983229, -82025.7776180613, -81979.2787891315, -142.21169535541, 660.899185883654, 743.232837230605, 750.480668271148 ),
      ( 550, 2449.44505840782, 117004.153955993, -63196.5860488831, -63148.8184316612, -107.175592376576, 678.669342348206, 763.361878599618, 685.342644956619 ),
      ( 575, 2378.3399262758, 117004.153927139, -43851.9094845732, -43802.7137608525, -72.7803359556863, 696.357709704982, 784.51231061056, 620.070346151414 ),
      ( 600, 2301.48950570754, 117004.153927082, -23963.4670993004, -23912.6286515747, -38.9231454552911, 713.889655597034, 806.939682579991, 554.394996032885 ),
      ( 625, 2216.81149046334, 117004.153926758, -3493.73677051714, -3440.95639003368, -5.49872584881242, 731.220021099531, 831.155444502248, 488.082033710963 ),
      ( 634.816982250148, 2180.78930863309, 117004.153927066, 4714.4836743134, 4768.13587879913, 7.53352978938138, 737.967533015547, 841.349047629068, 461.814875406455 ),
      ( 650, 23.6973604297308, 117004.153926862, 75113.4433851399, 80050.877420201, 125.755851974991, 731.703287280307, 745.183448613641, 124.990800867456 ),
      ( 700, 21.4638197933025, 117004.153926862, 112716.322600297, 118167.549597803, 182.235211059111, 767.331744716514, 779.309449792389, 133.011607247337 ),
      ( 750, 19.6965165411471, 117004.153926862, 152016.897157471, 157957.244714991, 237.126353515447, 800.900983428183, 811.982811409711, 140.00812726594 ),
      ( 800, 18.2431480319706, 117004.153926862, 192919.897390794, 199333.491893334, 290.522917061789, 832.227561119336, 842.725669865754, 146.320610881592 ),
      ( 850, 17.0165061646801, 117004.153926862, 235318.993618635, 242194.914726913, 342.483291216853, 861.287303404443, 871.379641065274, 152.139001551236 ),
      ( 900, 15.9616230980202, 117004.153926862, 279106.227675995, 286436.569534611, 393.051715149997, 888.146923212805, 897.942984423561, 157.579706826028 ),
      ( 950, 15.0414010318172, 117004.15399539, 324176.855768777, 331955.662659696, 442.267551770861, 912.923237946141, 922.494580676984, 162.719325283278 ),
      ( 1000, 14.2295080412334, 117004.15395228, 370431.835604907, 378654.477850389, 490.169305289161, 935.758021424941, 945.153749543446, 167.611164233565 ),
      ( 275, 3123.55276430185, 1000000.00000086, -248291.15871783, -247971.01045223, -567.951241854416, 512.160337303367, 619.155382893627, 1502.05870209195 ),
      ( 300, 3059.22396282843, 999999.999997237, -232827.52857637, -232500.648291649, -514.107517470909, 520.7563070663, 619.417123792313, 1406.63975731677 ),
      ( 325, 2997.51079019713, 999999.999999274, -217294.037497827, -216960.427355949, -464.354966655052, 532.026074515123, 624.470693258217, 1319.70828281805 ),
      ( 350, 2937.65041480859, 1000000.00000034, -201588.778697467, -201248.370596163, -417.783321108377, 545.165609151326, 632.988549537477, 1239.1140866062 ),
      ( 375, 2878.99870730637, 999999.999998467, -185636.728107708, -185289.385124378, -373.745484343343, 559.67554301352, 644.109340530444, 1163.2656618171 ),
      ( 400, 2820.99012161022, 1000000.00000202, -169380.560715121, -169026.075248355, -331.765649183134, 575.223617310297, 657.255119901004, 1090.98956215804 ),
      ( 425, 2763.10382215476, 1000000.00000621, -152775.06858352, -152413.156739315, -291.484095936975, 591.565539699217, 672.021155516579, 1021.40918258004 ),
      ( 450, 2704.83345247088, 1000000.00002165, -135783.696612904, -135413.988082751, -252.622656551181, 608.503319991641, 688.113236848917, 953.852183837808 ),
      ( 475, 2645.65797385136, 1000000.0000464, -118376.244027747, -117998.266220362, -214.962059417838, 625.865603942734, 705.314821150367, 887.785284817743 ),
      ( 500, 2585.01059764355, 1000000.00006925, -100527.141241602, -100140.295632156, -178.326274632963, 643.49986825606, 723.472555507591, 822.771335635426 ),
      ( 525, 2522.24203611939, 1000000.00007302, -82213.9352384919, -81817.4625821201, -142.571086267581, 661.270459974091, 742.49358373987, 758.443595635899 ),
      ( 550, 2456.57282263501, 1000000.00004677, -63415.7333674152, -63008.662186446, -107.575239489117, 679.059263770513, 762.35182280325, 694.493620918576 ),
      ( 575, 2387.02669927755, 1000000.00001382, -44111.3855446237, -43692.4543276765, -73.2330763598169, 696.767573514536, 783.103780929795, 630.670688882837 ),
      ( 600, 2312.3316842002, 999999.999999931, -24277.1220542905, -23844.6581448813, -39.4477859441377, 714.31891339488, 804.919077195538, 566.790706523563 ),
      ( 625, 2230.7636189857, 999999.999998959, -3883.13381384577, -3434.85682407953, -6.12425705312448, 731.663450949307, 828.141303401161, 502.747049275871 ),
      ( 650, 2139.87550476147, 999999.999998724, 17112.1270746716, 17579.4439806194, 26.8403391195689, 748.785636228339, 853.428955907337, 438.492355590502 ),
      ( 675, 2035.94938153398, 999999.999997334, 38773.6266603767, 39264.7980073008, 59.5734305785066, 765.71863277761, 882.161037980477, 373.883581769755 ),
      ( 700, 1912.5566247233, 999999.999995503, 61221.3244680366, 61744.1848043365, 92.2704025946513, 782.576940423502, 917.923634279543, 308.060669808703 ),
      ( 725, 1755.14485401019, 999999.9999911, 84749.19571899, 85318.9492625259, 125.355528016984, 799.673611126428, 973.988545654181, 237.343441023782 ),
      ( 750, 1502.81408368092, 999999.999999768, 110646.580049965, 111311.99835477, 160.587415564191, 818.503695867526, 1162.0281085211, 145.764040041865 ),
      ( 752.716516624252, 1457.19466485224, 1000000.00000001, 113868.788054107, 114555.038164762, 164.90358196027, 820.998258558343, 1230.94865967001, 131.925271597893 ),
      ( 775, 256.720967045214, 1000000, 162797.320292349, 166692.600103382, 233.702537716697, 830.599052450846, 933.016367139911, 90.8594303735065 ),
      ( 825, 197.022847543882, 1000000, 207042.515921837, 212118.069404421, 290.511913274052, 854.830857891283, 900.935638564568, 116.930459372307 ),
      ( 875, 168.050522450151, 1000000, 251427.560158951, 257378.151596693, 343.771260948691, 880.135311624395, 911.617327775101, 132.955819077841 ),
      ( 925, 149.255506909628, 999999.999999997, 296687.310488231, 303387.230784006, 394.901064121625, 904.48660609568, 929.233639853368, 145.070490879375 ),
      ( 975, 135.546740973178, 1000000, 342946.202995133, 350323.731903761, 444.314913560639, 927.394438423716, 948.27927730014, 155.027326461516 ),
      ( 303, 3052.60719938496, 1437447.06379596, -231004.987547973, -230534.095955997, -508.059694132159, 522.141387679377, 619.801127242087, 1397.22797287964 ),
      ( 342, 2957.73369740717, 1437447.06379399, -206678.715018413, -206192.71891097, -432.502770152381, 540.942836093626, 629.918349704703, 1265.98787038377 ),
      ( 381, 2866.34480388394, 1437447.0637943, -181811.767829006, -181310.276500452, -363.621443550297, 563.473974306428, 647.03789988676, 1147.59405424419 ),
      ( 420, 2776.27913734068, 1437447.06379304, -156180.888165768, -155663.127885665, -299.550212842022, 588.399298715755, 668.851673532438, 1037.47365678992 ),
      ( 459, 2685.60983298649, 1437447.06378091, -129631.625176025, -129096.38470806, -239.079389464348, 614.87620304877, 694.024523973333, 932.709923714654 ),
      ( 498, 2592.37402053821, 1437447.06374157, -102050.898034419, -101496.407419888, -181.382578377484, 642.255447337911, 721.732620507097, 831.317763298594 ),
      ( 537, 2494.28883879094, 1437447.06367669, -73350.7079603106, -72774.4126085768, -125.868955318696, 669.998811526281, 751.516487980383, 731.854540528507 ),
      ( 576, 2388.37168343361, 1437447.06368887, -43454.282160346, -42852.4298298819, -72.0917801956002, 697.672640355835, 783.293133803381, 633.269023813057 ),
      ( 615, 2270.32382276387, 1437447.06379476, -12279.4658203526, -11646.3195487142, -19.6820547330126, 724.964838567566, 817.500538645098, 534.926830090418 ),
      ( 654, 2133.3618844144, 1437447.06379503, 20287.6257089933, 20961.4200025431, 31.7134110264803, 751.718837627694, 855.5343627604, 436.706572514609 ),
      ( 693, 1965.36095062716, 1437447.06379355, 54454.3198670653, 55185.7107412632, 82.5303811710172, 778.008894822346, 901.619969829883, 338.441858193033 ),
      ( 732, 1736.27110191943, 1437447.0637947, 90800.9544789687, 91628.847693459, 133.673083506775, 804.40260867932, 977.057707653329, 234.931811193441 ),
      ( 771, 1185.90403184104, 1437447.06379479, 134881.281175855, 136093.391958178, 192.73456659377, 837.364153725328, 1794.31876001622, 84.7443879277982 ),
      ( 810, 367.442053223321, 1437447.06379478, 188586.444852624, 192498.482277805, 264.48751105612, 853.46906602517, 980.478346103205, 95.0514584831924 ),
      ( 849, 290.678841970157, 1437447.06379478, 224619.899211962, 229565.037475387, 309.188937282274, 870.587175111774, 935.31980432218, 115.982827878756 ),
      ( 888, 250.383949671136, 1437447.06379478, 260210.884438646, 265951.855717687, 351.092394163762, 888.957522813969, 933.491775785605, 130.377940177794 ),
      ( 927, 223.762986148308, 1437447.06379478, 296078.164731289, 302502.136311835, 391.373097599257, 907.151882822658, 941.775298027661, 141.637070306728 ),
      ( 966, 204.218221740384, 1437447.06379478, 332414.485273332, 339453.264925532, 430.416717701072, 924.709976649824, 953.47693863428, 151.019711583145 ),
      ( 303, 3070.01877511056, 10000000.0000008, -231675.365801754, -228418.056732157, -510.306986886773, 525.094145165805, 619.865380169804, 1424.38799458383 ),
      ( 342, 2978.42033348192, 9999999.99999909, -207440.266122984, -204082.781657953, -434.768454580803, 543.808510871116, 629.529617473877, 1297.66020219233 ),
      ( 381, 2890.98510649452, 10000000.0000006, -182684.73852173, -179225.70997899, -365.956852306476, 566.332842385972, 646.106769545082, 1184.59232192879 ),
      ( 420, 2805.8280855786, 9999999.99999877, -157191.721884095, -153627.711654317, -302.007897365742, 591.312373780388, 667.23140782544, 1080.89165542273 ),
      ( 459, 2721.42379145379, 9999999.99999594, -130815.835386321, -127141.288249856, -241.719338776586, 617.889745538245, 691.475648294726, 983.949874167394 ),
      ( 498, 2636.42264334192, 9999999.99998846, -103457.847030389, -99664.8284772971, -184.280077971151, 645.40549465288, 717.865324801975, 892.161259817377 ),
      ( 537, 2549.52315591049, 9999999.99997865, -75051.5501321002, -71129.2480432582, -129.125921689248, 673.312427383604, 745.687510084591, 804.567661906387 ),
      ( 576, 2459.38379091118, 9999999.99997616, -45555.5948216624, -41489.5356580085, -75.8549352599422, 701.162145723412, 774.411699152234, 720.720095258335 ),
      ( 615, 2364.57512939401, 9999999.99998625, -14947.6714052333, -10718.5818425139, -24.1744440664141, 728.606760241551, 803.64298208727, 640.670107217173 ),
      ( 654, 2263.59468138578, 9999999.99999713, 16779.4586251098, 21197.2106556434, 26.1328259025839, 755.396962704811, 833.075175481162, 565.009334196646 ),
      ( 693, 2154.98119385935, 9999999.99999946, 49620.1166012552, 54260.5283266543, 75.2301224848886, 781.370326978864, 862.451421327805, 494.820539528523 ),
      ( 732, 2037.52235028015, 9999999.99999989, 83557.3866012603, 88465.30822412, 123.241542658346, 806.425309290172, 891.596421304838, 431.327348943702 ),
      ( 771, 1910.39651980117, 9999999.99999986, 118568.25975771, 123802.775156137, 170.268172074382, 830.479945644977, 920.578866113846, 375.215260988123 ),
      ( 810, 1773.08649176161, 10000000.0000001, 154632.682031557, 160272.564827159, 216.406714606658, 853.430671655984, 949.700545952077, 326.387209879232 ),
      ( 849, 1625.84167960775, 10000000.0000435, 191723.680010154, 197874.340388387, 261.740435704103, 875.139365899084, 978.30204355923, 285.375688927108 ),
      ( 888, 1472.7742330142, 9999999.99975398, 229731.256540197, 236521.163489674, 306.242222007394, 895.459648328262, 1002.27574474141, 255.243714237994 ),
      ( 927, 1325.26284720672, 9999999.99999932, 268374.613636199, 275920.286572761, 349.661738922611, 914.314884724333, 1016.45714335769, 238.765095388617 ),
      ( 966, 1195.49710691485, 10000000.0000001, 307336.699604317, 315701.42080871, 391.696527620193, 931.797932461001, 1022.80156313751, 233.260319330719 ),
      };

      // TestData contains:
      // 0. Temperature (Kelvin)
      // 1. Pressure (Pa)
      // 2. Saturated liquid density (mol/m³
      // 3. Saturated vapor density (mol/m³)
      _testDataSaturatedProperties = new (double temperature, double pressure, double saturatedLiquidMoleDensity, double saturatedVaporMoleDensity)[]
      {
      ( 287.81875, 7.29543066433176E-05, 3088.23974608475, 3.04857705780834E-08 ),
      ( 356.9875, 0.382719805185252, 2918.47972401371, 0.00012894201895611 ),
      ( 426.15625, 67.501611920041, 2756.6536735836, 0.0190552835858837 ),
      ( 495.325, 1973.67810299881, 2590.93027542427, 0.481115415281294 ),
      ( 564.49375, 20346.7067307031, 2407.93705364818, 4.44509250753434 ),
      ( 633.6625, 111747.188053914, 2185.02511817058, 23.3481806821181 ),
      ( 702.83125, 422357.189357605, 1869.27536075426, 96.7400943319196 ),
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
