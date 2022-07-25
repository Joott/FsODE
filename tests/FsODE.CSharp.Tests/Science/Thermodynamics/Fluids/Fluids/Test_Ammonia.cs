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
  /// Tests and test data for <see cref="Ammonia"/>.
  /// </summary>
  /// <remarks>
  /// <para>Reference:</para>
  /// <para>The test data was created automatically using calls into the TREND.DLL of the following software:</para>
  /// <para>TREND 3.0.: Span, R.; Eckermann, T.; Herrig, S.; Hielscher, S.; Jäger, A.; Thol, M. (2016): TREND.Thermodynamic Reference and Engineering Data 3.0.Lehrstuhl für Thermodynamik, Ruhr-Universität Bochum.</para>
  /// </remarks>
  
  public class Test_Ammonia : FluidTestBase
  {

    public Test_Ammonia()
    {
      _fluid = Ammonia.Instance;

      _testDataMolecularWeight = 0.01703026;

      _testDataTriplePointTemperature = 195.495;

      _testDataTriplePointPressure = 6091;

      _testDataTriplePointLiquidMoleDensity = 43035.3392920733;

      _testDataTriplePointVaporMoleDensity = 3.76350602709112;

      _testDataCriticalPointTemperature = 405.4;

      _testDataCriticalPointPressure = 11339342.3296868;

      _testDataCriticalPointMoleDensity = 13211.7771543124;

      _testDataNormalBoilingPointTemperature = 239.823552600533;

      _testDataNormalSublimationPointTemperature = null;

      _testDataIsMeltingCurveImplemented = true;

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
      ( 195.495, 0.615648251146334, 1000.00000000007, 23685.6668679395, 25309.9710028705, 144.458752463313, 25.9857837129995, 34.349711777394, 354.948261764714 ),
      ( 200, 0.601733741392226, 1000.00000000005, 23802.8141196052, 25464.6787138797, 145.241136715812, 25.9773575515013, 34.334813446226, 359.023120695504 ),
      ( 225, 0.534728170123152, 1000.00000000001, 24453.4765373845, 26323.5856056419, 149.287623681477, 26.0839354723083, 34.4198619315156, 380.597287390897 ),
      ( 250, 0.481191932232843, 1000, 25109.2038514103, 27187.37668228, 152.927732479932, 26.385035901213, 34.7115623473072, 400.628582078066 ),
      ( 275, 0.437416001761897, 1000, 25774.2140135763, 28060.3672315017, 156.255597115496, 26.826566200533, 35.1484649675021, 419.35484876704 ),
      ( 300, 0.400947733681834, 1000, 26451.6238343009, 28945.7144999774, 159.336663373542, 27.3760942426253, 35.6954831861479, 436.962880510545 ),
      ( 325, 0.370095684441531, 1000, 27143.8599256242, 29845.8638722765, 162.218340643735, 28.0114875766743, 36.3294040369359, 453.604544708813 ),
      ( 350, 0.34365411300651, 1000, 27852.86545688, 30762.7680657891, 164.936014844484, 28.7164620672363, 37.0334573128952, 469.405466854946 ),
      ( 375, 0.320739816901061, 1000, 28580.2220033264, 31698.0138935315, 167.516724634739, 29.4784692859432, 37.7948568948316, 484.470599574218 ),
      ( 400, 0.300690850645756, 1000, 29327.2292570597, 32652.9041083311, 169.981532049156, 30.2875343074949, 38.6035031532574, 498.888208209847 ),
      ( 425, 0.283001243473645, 1000, 30094.9608304137, 33628.5142089278, 172.347112152069, 31.1355457910024, 39.4512152845654, 512.732907936082 ),
      ( 450, 0.267277578514144, 1000, 30884.305144854, 34625.7338331833, 174.626852241077, 32.0157898759975, 40.3312386969827, 526.068059642419 ),
      ( 475, 0.253209327194922, 999.999999999999, 31695.9963797347, 35645.2979756834, 176.831631376604, 32.9226283005811, 41.237910161191, 538.947696350474 ),
      ( 500, 0.240548103314912, 999.999999999999, 32530.6384780851, 36687.811144256, 178.970385196154, 33.8512677963368, 42.166420502579, 551.418088900104 ),
      ( 525, 0.229092854293123, 1000, 33388.7241323916, 37753.7664340625, 181.050522835454, 34.7975901866255, 43.1126410637035, 563.519026621747 ),
      ( 550, 0.218679096190722, 999.999999999999, 34270.6500429667, 38843.5608397438, 183.078239754929, 35.7580243896627, 44.0729936493813, 575.284869258827 ),
      ( 575, 0.209170959689672, 1000, 35176.7293490995, 39957.5077204547, 185.058755898417, 36.7294482017864, 45.0443511002847, 586.745413672404 ),
      ( 600, 0.200455226088307, 1000, 36107.2018775753, 41095.8470703899, 186.99649938519, 37.7091117457261, 46.0239600058573, 597.926609810849 ),
      ( 625, 0.192436795534079, 999.999999999999, 37062.2426806506, 42258.7540714407, 188.895249868975, 38.6945769898757, 47.0093797629046, 608.851153618677 ),
      ( 650, 0.185035221487186, 1000.000107625, 38041.9692157813, 43446.3462829563, 190.758250726938, 39.6836693885792, 47.9984339193879, 619.538979252028 ),
      ( 675, 0.178181916832997, 1000.00009130533, 39046.4474343562, 44658.6897374996, 192.588302851259, 40.6744387973037, 48.989170893882, 630.007668749809 ),
      ( 700, 0.171818155446417, 1000.00007743995, 40075.6969847603, 45895.8041488825, 194.387831246564, 41.6651275766177, 49.9798319478811, 640.272793913549 ),
      ( 199.7226128085, 42771.8866982606, 9136.50001094882, 303.358518767877, 303.572128704595, 1.53519575095404, 49.8460220184389, 71.9609592735759, 2082.79861788825 ),
      ( 225, 4.89940325527541, 9136.50000005962, 24433.7538598306, 26298.5728028768, 130.805985592677, 26.4058932057941, 34.91951265402, 379.924789084847 ),
      ( 275, 4.00110506885987, 9136.50000000409, 25765.8914290045, 28049.3855744376, 137.831408826468, 26.9143737251101, 35.2970881579088, 419.066041559181 ),
      ( 325, 3.38340922077575, 9136.50000000056, 27139.3018684444, 29839.6846491905, 143.810398096943, 28.0439319549754, 36.3899542561399, 453.447398720313 ),
      ( 375, 2.93147038746389, 9136.50000000012, 28577.2973123018, 31693.9926195685, 149.115008875531, 29.4932809798612, 37.8252830382683, 484.373402082233 ),
      ( 425, 2.58621738638403, 9136.50000000005, 30092.8883515601, 33625.6540224206, 153.948319450969, 31.1434180440481, 39.4688463606891, 512.668325469392 ),
      ( 475, 2.31379088427571, 9136.49999999999, 31694.4293300804, 35643.1439966005, 158.434416145016, 32.9273113644427, 41.2491939636503, 538.902988865422 ),
      ( 525, 2.09332137773505, 9136.49999999999, 33387.4855466958, 37752.0805377839, 162.654247483723, 34.8006245611621, 43.1203951579676, 563.487379331004 ),
      ( 575, 1.91122856667693, 9136.49999999999, 35175.7189964509, 39956.1519385378, 166.663082638717, 36.7315483124627, 45.049966171201, 586.722812248657 ),
      ( 625, 1.75828958925475, 9136.49999999999, 37061.3990745378, 42257.6420915214, 170.499983981508, 38.6961074767221, 47.0136101765379, 608.835062621126 ),
      ( 675, 1.62801940715254, 9136.49999999998, 39045.7304325727, 44657.7642694297, 174.193325270768, 40.6756007509472, 48.9924575230431, 629.996401110628 ),
      ( 200, 42754.4408319482, 10000.0000152196, 323.317214641775, 323.551108474103, 1.63505895044483, 49.8375093186159, 71.9875032674884, 2080.18859595809 ),
      ( 200.930527933919, 42695.7049980657, 10000.0000156743, 390.344927228377, 390.579142824914, 1.96942172788618, 49.8086098438664, 72.0771352826781, 2071.5155326598 ),
      ( 225, 5.36407385937144, 10000.0000000859, 24431.6492346818, 26295.9039526915, 130.04575761623, 26.4402932367588, 34.9731025418609, 379.853213097815 ),
      ( 275, 4.37979570206828, 10000.0000000059, 25765.006449108, 28048.2179686051, 137.0773282052, 26.9237276543054, 35.3129361795988, 419.03533629656 ),
      ( 325, 3.70341479422255, 10000.0000000008, 27138.8177773395, 29839.0284087819, 143.058047396733, 28.0473801100447, 36.3963927226268, 453.430708355649 ),
      ( 375, 3.20864650890447, 10000.0000000002, 28576.9868175518, 31693.5657153047, 148.363319935553, 29.494853724943, 37.8285149829753, 484.363083078062 ),
      ( 425, 2.83071044233444, 10000, 30092.6683642229, 33625.3504253924, 153.196940940442, 31.1442536629038, 39.470718412971, 512.661470347321 ),
      ( 475, 2.53250958992088, 10000, 31694.2630044769, 35642.915376732, 157.683205112745, 32.9278083973325, 41.2503918428897, 538.898243871188 ),
      ( 525, 2.29118825265724, 9999.99999999999, 33387.3540892415, 37751.9016066279, 161.903136223243, 34.8009465961292, 43.1212182433392, 563.484020697658 ),
      ( 575, 2.09187678374789, 10000, 35175.6117651536, 39956.0080474258, 165.912035287426, 36.7317711904797, 45.0505621659306, 586.720413750942 ),
      ( 625, 1.92447789280369, 10000, 37061.3095419145, 42257.5240775003, 169.748979868629, 38.6962699009211, 47.0140591827163, 608.833355100421 ),
      ( 675, 1.78189221802652, 9999.99999999998, 39045.6543374157, 44657.6660510507, 173.442351677101, 40.6757240637099, 48.9928063481753, 629.995205489327 ),
      ( 200, 42756.2046626391, 100000.000015239, 322.697091030708, 325.03593286207, 1.63195806705842, 49.8423236276998, 71.9829583718846, 2080.30837444106 ),
      ( 225, 41099.2713526969, 100000.000073304, 2152.82901171184, 2155.26214487411, 10.2519085765419, 49.056965526664, 74.4202288248355, 1876.18558776277 ),
      ( 238.561659291391, 40136.3637656987, 100000.000120941, 3170.40505258717, 3172.89655881092, 14.6433168343372, 48.6550963157686, 75.6393932240555, 1777.22658583239 ),
      ( 250, 49.1945322766839, 100000, 24954.3496419952, 26987.0958715472, 114.015926998623, 28.4587803981566, 38.1301585499019, 395.328241542844 ),
      ( 300, 40.5018502480307, 100000.000021812, 26377.6395069536, 28846.6625123081, 120.800063155708, 28.0207709454583, 36.8486227116815, 434.394464972529 ),
      ( 350, 34.5570029685946, 100000.000003579, 27808.8973133255, 30702.666778648, 126.520734470201, 28.9796674420076, 37.5514829517851, 467.911138148226 ),
      ( 400, 30.1713036487742, 100000.000000809, 29297.4909114902, 32611.8985739802, 131.617599524586, 30.4172305018887, 38.8830614715052, 497.92812370165 ),
      ( 450, 26.7868490078328, 100000.000000222, 30862.4890986874, 34595.6642836814, 136.288806277875, 32.0888610628173, 40.5017459219041, 525.415961053193 ),
      ( 500, 24.0908837857602, 100000.000000069, 32513.7486823976, 36664.6964387924, 140.647047239855, 33.8967274911115, 42.2796617787826, 550.961117631565 ),
      ( 550, 21.8907849173033, 100000.000000024, 34257.0753115383, 38825.2075360242, 144.764003085017, 35.7885204948327, 44.1529664724397, 574.959653538247 ),
      ( 600, 20.0604148594179, 100000.000000008, 36095.9916948672, 41080.933467049, 148.688261695259, 37.7308003824879, 46.0830782976769, 597.694474990646 ),
      ( 650, 18.5133812048643, 100000.000000003, 38032.5215349242, 43434.0199912801, 152.454163224902, 39.6998196441974, 48.0436896749957, 619.374842047899 ),
      ( 700, 17.1884003723776, 100000.000000001, 40067.6086328225, 45885.4856797584, 156.086723815335, 41.6776024634125, 50.0154375358511, 640.15961923029 ),
      ( 200, 42756.2306265253, 101325.000014183, 322.687963887983, 325.057793934491, 1.63191242419641, 49.8423944671257, 71.9828914763558, 2080.31013791468 ),
      ( 225, 41099.3048825797, 101325.000073222, 2152.81676238892, 2155.28213255425, 10.251854126226, 49.0570127875125, 74.4201453665666, 1876.18921961472 ),
      ( 238.823552600533, 40117.3890198569, 101325.00012238, 3190.20201659074, 3192.72772932026, 14.7262609691899, 48.6475148700202, 75.6619859255304, 1775.34762916603 ),
      ( 250, 49.8617531836088, 101325, 24952.1949888079, 26984.3136675652, 113.897786620015, 28.4884071417954, 38.1800503107501, 395.255034725121 ),
      ( 300, 41.0441350903641, 101325.000023014, 26376.6359520042, 28845.3199625195, 120.687263021478, 28.0296288365673, 36.8645873244532, 434.359628097589 ),
      ( 350, 35.0175078364494, 101325.000003774, 27808.3055731666, 30701.8581491242, 126.409597745303, 28.983224649268, 37.5585179011382, 467.89101940131 ),
      ( 400, 30.5724676192754, 101325.000000853, 29297.0917739206, 32611.3482893799, 131.507157536024, 30.4189725768764, 38.8868306312602, 497.915237635046 ),
      ( 450, 27.1425789343438, 101325.000000234, 30862.1966296268, 34595.2612085429, 136.178712759103, 32.089840321354, 40.5040377770414, 525.407222185134 ),
      ( 500, 24.4105782819045, 101325.000000073, 32513.5223885172, 36664.3867732084, 140.537151264919, 33.8973361870091, 42.2811815943077, 550.954999320921 ),
      ( 550, 22.1811484598583, 101325.000000025, 34256.893496253, 38824.9617449911, 144.654229205339, 35.7889286890133, 44.1540388591762, 574.955302103327 ),
      ( 600, 20.3264174704644, 101325.000000009, 36095.841582509, 41080.7337873081, 148.578568235907, 37.7310906443025, 46.0838705990602, 597.691370671072 ),
      ( 650, 18.7588172778102, 101325.000000003, 38032.3950424945, 43433.8549799427, 152.344525363695, 39.700035770198, 48.0442959613629, 619.372648234604 ),
      ( 700, 17.4162359903708, 101325.000000001, 40067.5003513109, 45885.3475633045, 155.977125875755, 41.6777693989806, 50.0159144106417, 640.158107539704 ),
      ( 200, 42759.3941578815, 262807.789338717, 321.576137277116, 327.722337299696, 1.62635171599758, 49.8510197080268, 71.9747420112833, 2080.52507403626 ),
      ( 225, 41103.3898025531, 262807.78939934, 2151.32467157057, 2157.71849433462, 10.2452206549363, 49.0627678821485, 74.4099819434129, 1876.63164165598 ),
      ( 250, 39296.4930637439, 262807.789500769, 4039.15476964743, 4045.84258754188, 18.2005494887984, 48.3301604485736, 76.5994494482543, 1695.99597498389 ),
      ( 259.694739789678, 38556.5132537591, 262807.789558242, 4785.60686024157, 4792.42303129491, 21.1303236986612, 48.0557361755527, 77.4214273495606, 1626.74855145939 ),
      ( 275, 119.641800185731, 262807.789325435, 25490.3309658265, 27686.9527896159, 108.892157510999, 29.9809589412748, 40.6624439077366, 409.550900549182 ),
      ( 325, 99.2119687152914, 262807.789325435, 26994.0102712779, 29642.9627386925, 115.432395675901, 29.0992918882672, 38.3903835865642, 448.433214750883 ),
      ( 375, 85.2656741959698, 262807.789325435, 28485.1839212236, 31567.4065366387, 120.939458864187, 29.9622902224075, 38.7995499839737, 481.310475807536 ),
      ( 425, 74.914638312434, 262807.789345697, 30027.912584515, 33536.0092030911, 125.865781464534, 31.3902542091504, 40.0265579250728, 510.64456098436 ),
      ( 475, 66.8659154817627, 262807.789331349, 31645.4036265618, 35575.7736430021, 130.401635620901, 33.0736124639526, 41.6041493477603, 537.506297921262 ),
      ( 525, 60.4068164631263, 262807.789327355, 33348.780914285, 37699.4122621194, 134.650988503491, 34.8952844266691, 43.3635945401514, 562.50065041125 ),
      ( 575, 55.0999119481098, 262807.789326103, 35144.1689104408, 39913.8278814679, 138.678690623693, 36.7970243732548, 45.2257611192364, 586.019189287406 ),
      ( 625, 50.6580512243802, 262807.789325677, 37035.0683060962, 42222.9463032506, 142.528338254731, 38.7438116329105, 47.1458971910317, 608.33480932422 ),
      ( 675, 46.883582408095, 262807.789325525, 39023.3584830038, 44628.8983292965, 146.230667547208, 40.7118133960005, 49.0951462721971, 629.646625472558 ),
      ( 200, 42773.8163730756, 1000000.00001294, 316.513885204503, 339.892673556959, 1.60101556841804, 49.8901883018483, 71.9376223523736, 2081.50666960695 ),
      ( 225, 41122.000535848, 999999.999998269, 2144.5326679572, 2168.85055101171, 10.2150030864267, 49.0889208376653, 74.3637835653381, 1878.64622193093 ),
      ( 250, 39320.2889042895, 999999.999994248, 4030.21360899661, 4055.6457720824, 18.164745973108, 48.3505514512543, 76.5373943674448, 1698.91792366179 ),
      ( 275, 37369.7727188325, 1000000.00039826, 5968.9752161505, 5995.73481161077, 25.559508624438, 47.6521339082215, 78.7276593025766, 1520.10478808226 ),
      ( 297.045092065434, 35492.6146600915, 1000000.00000094, 7729.77203897206, 7757.94691449413, 31.7223819230843, 47.1068711383356, 81.3182650955671, 1355.61120803962 ),
      ( 300, 452.145463206529, 1000000.00000001, 25591.8684470378, 27803.5460627065, 98.978644853548, 35.8655178307915, 52.4927101851474, 407.157897250514 ),
      ( 350, 364.968616439132, 1000000, 27384.7715749617, 30124.733190721, 106.152657699806, 31.6314305974983, 43.0626548556711, 453.445126751475 ),
      ( 400, 311.572727372711, 999999.999999999, 29019.1559573824, 32228.6794879955, 111.773568998423, 31.640843462678, 41.6267611000397, 488.944214473323 ),
      ( 450, 273.435786652171, 1000000, 30660.7835687323, 34317.9493415215, 116.694594221073, 32.7620443692172, 42.1212673799778, 519.411628451483 ),
      ( 500, 244.262033227397, 1000000, 32358.5362383619, 36452.5003587254, 121.191412726142, 34.3118126467742, 43.3383541141109, 546.792728905294 ),
      ( 550, 221.016001201056, 1000000, 34132.7632754994, 38657.3225588352, 125.393073987367, 36.0659956991804, 44.8939905321525, 572.012396248958 ),
      ( 600, 201.968426469667, 1000000.00008334, 35993.5604926185, 40944.8294486775, 129.372762159663, 37.9278464347189, 46.6277945154314, 595.602111781108 ),
      ( 650, 186.033145397931, 1000000.0000302, 37946.3231910172, 43321.7093776624, 133.176822338137, 39.8464491969709, 48.4590891925833, 617.903330378015 ),
      ( 700, 172.482470495766, 1000000.00001104, 39993.8888061651, 45791.5794186473, 136.836701981482, 41.7908247111443, 50.3413735422106, 639.151544578892 ),
      ( 200, 42947.3455694815, 9999999.99999973, 256.435724354067, 489.278985500939, 1.29803938592587, 50.3417232704657, 71.4948120973091, 2093.54884459364 ),
      ( 225, 41344.4413244049, 10000000.0000021, 2064.1116515827, 2305.98213476418, 9.8543997907217, 49.3926351151432, 73.8243429944037, 1902.61493829605 ),
      ( 250, 39602.2927850408, 9999999.99999893, 3924.95371904196, 4177.46435155201, 17.7397593975866, 48.5933301519162, 75.8313692964765, 1733.13331463458 ),
      ( 275, 37733.1563451453, 10000000.0000002, 5831.05243870744, 6096.07134962309, 25.0528847593808, 47.8477887900917, 77.6728897927711, 1565.82529632489 ),
      ( 300, 35713.8543512525, 9999999.99999938, 7784.75147669311, 8064.75485862013, 31.9033670458068, 47.163965540073, 79.9603476313207, 1394.15497231419 ),
      ( 325, 33474.3596903772, 9999999.99997509, 9806.6562924497, 10105.3924024895, 38.4349517291485, 46.6253236978707, 83.6308116916694, 1212.31935913634 ),
      ( 350, 30857.30319479, 9999999.99999976, 11949.0363898102, 12273.1087799628, 44.8575961677466, 46.4081601711997, 90.6302405948165, 1011.46595353462 ),
      ( 375, 27440.2380891508, 10000000.0000002, 14352.5269195276, 14716.9552443661, 51.5952254943601, 47.0462686839198, 108.089417427314, 772.445716264366 ),
      ( 397.316899118526, 21597.6739192839, 10000000, 17396.1644129005, 17859.1772372154, 59.706778839274, 52.1125317682765, 247.225356834243, 438.995365139284 ),
      ( 400, 6545.4687198087, 10000000, 23801.090791791, 25328.8652611329, 78.4576676184098, 57.6108899690519, 305.523471086921, 336.275905749936 ),
      ( 450, 3595.64892294484, 10000000.0000283, 28170.5670733196, 30951.7062263152, 91.8666149887136, 40.6457181499701, 71.3943241376923, 452.562037508788 ),
      ( 500, 2865.57084728732, 10000000.0000005, 30616.1239317703, 34105.8300088219, 98.5251478602381, 38.6026304390934, 57.8064942374428, 505.635811274736 ),
      ( 550, 2449.71497052853, 10000000, 32797.0900019585, 36879.1975615341, 103.814681037062, 38.8253454888404, 53.8691550563763, 544.868748468624 ),
      ( 600, 2164.96710657857, 10000000, 34919.7982651879, 39538.8060873454, 108.443664449942, 39.8621683051991, 52.8057358534364, 577.379197043664 ),
      ( 650, 1951.80237108212, 9999999.99999999, 37056.5224512048, 42179.9919930805, 112.671719558106, 41.2795267382659, 52.9829969462585, 605.819573014766 ),
      ( 700, 1783.50596734086, 9999999.99999998, 39240.6127745589, 44847.5466357949, 116.625087253042, 42.895818275925, 53.7961696382276, 631.498844613858 ),
      ( 200, 42983.5161196009, 11906309.4461733, 244.106680555567, 521.103783655373, 1.23532121374136, 50.4312346706692, 71.4032903850835, 2096.11529589871 ),
      ( 225, 41390.4766361639, 11906309.4461721, 2047.6454777216, 2335.3036641888, 9.77990741338097, 49.4533542831137, 73.7154596116228, 1907.55683608882 ),
      ( 250, 39660.1318532, 11906309.4461716, 3903.53104737473, 4203.739566354, 17.6524556181472, 48.6431726443999, 75.6928798760565, 1740.06834596015 ),
      ( 275, 37806.7120529464, 11906309.4460673, 5803.28172361232, 6118.2075343888, 24.9498472339852, 47.8901345675138, 77.4731269264806, 1574.92102636292 ),
      ( 300, 35810.4319040622, 11906309.4461705, 7748.04681130621, 8080.52840432548, 31.7782621753794, 47.1952939366184, 79.6361922977165, 1406.05658197254 ),
      ( 325, 33608.674719591, 11906309.4461717, 9755.86216674999, 10110.125152289, 38.2746409252439, 46.6327454347302, 83.0331871746388, 1228.39193893229 ),
      ( 350, 31064.6991477504, 11906309.4461708, 11872.0983840415, 12255.3729617074, 44.6310095055514, 46.3503094243339, 89.2937066978327, 1034.69384804407 ),
      ( 375, 27842.5666346083, 11906309.4461598, 14209.4932669479, 14637.1230039047, 51.1984577211918, 46.7350948320769, 103.528904908143, 811.388695160776 ),
      ( 400, 22420.8570182852, 11906309.4461712, 17266.6382931461, 17797.6755071322, 59.3354382968363, 50.0580912002003, 178.887129396851, 505.399958444247 ),
      ( 425, 6010.67803223143, 11906309.4461711, 25465.8279719824, 27446.6875991867, 82.8608681496816, 48.5034596130839, 136.600325394028, 387.090968056736 ),
      ( 450, 4647.45876223935, 11906309.4461711, 27472.0783545674, 30033.9750932561, 88.7896693027552, 42.6546700100297, 84.1933025356103, 437.434702738359 ),
      ( 475, 3980.89879364682, 11906309.4461813, 28931.0530891903, 31921.9127074209, 92.8763123943695, 40.4238626170411, 69.0674002593316, 471.160038880624 ),
      ( 500, 3547.78273219253, 11906309.4461726, 30195.8815029017, 33551.8675778479, 96.2220579766489, 39.5217001623771, 62.0964523559466, 497.771215740444 ),
      ( 525, 3231.44867335981, 11906309.4461714, 31368.2304392637, 35052.7418301849, 99.1519170623821, 39.2712814252669, 58.3303872007767, 520.288958946696 ),
      ( 550, 2984.78136340713, 11906309.4461711, 32492.5464078335, 36481.5519652054, 101.81103586064, 39.3923306160658, 56.170082362545, 540.105733392132 ),
      ( 575, 2784.15351205023, 11906309.4461711, 33592.4036319669, 37868.8594360879, 104.277969238646, 39.7463239526346, 54.9335483412821, 557.988871799192 ),
      ( 600, 2616.08258936251, 11906309.4461711, 34681.8347884397, 39233.0326346333, 106.600415226269, 40.2560668983635, 54.2780472762346, 574.410572272232 ),
      ( 625, 2472.17614846802, 11906309.4461711, 35769.8559695782, 40585.9810072497, 108.809654118383, 40.8745662924153, 54.0112258361934, 589.684219068008 ),
      ( 650, 2346.87072176815, 11906309.4461711, 36862.5774243239, 41935.8476883122, 110.927362720066, 41.5712278673367, 54.016177429134, 604.029507774933 ),
      ( 675, 2236.29718488207, 11906309.4461711, 37964.3015926204, 43288.4193023151, 112.969198610432, 42.3250714733267, 54.2174452721635, 617.606962870902 ),
      ( 700, 2137.66102326541, 11906309.4461711, 39078.1427861531, 44647.9264499744, 114.946843256289, 43.1211079047624, 54.5639847153361, 630.537726760826 ),
      ( 225, 43213.626342412, 100000000.000184, 1447.81364220081, 3761.89853773384, 6.8728723079556, 51.1713178601163, 69.8904162506411, 2107.9521001325 ),
      ( 250, 41849.5768214632, 100000000.000158, 3142.2192442664, 5531.72966695894, 14.3301474809359, 50.3129482267965, 71.5485589632421, 1996.45623844422 ),
      ( 275, 40434.6796834786, 100000000.000127, 4859.34150466942, 7332.46607948796, 21.194648444207, 49.5960275686705, 72.3971396027545, 1884.58304500581 ),
      ( 300, 38995.1627477021, 100000000.000067, 6582.96827874924, 9147.38891335627, 27.511191944569, 48.8941062362835, 72.7403018400937, 1774.72424441004 ),
      ( 325, 37541.4021248246, 100000000.000022, 8304.06324935223, 10967.7890118457, 33.339510865507, 48.216712495555, 72.8766242664646, 1668.4849220366 ),
      ( 350, 36075.7412517186, 100000000.000002, 10019.1960501864, 12791.1418655822, 38.7444543009028, 47.5976560136216, 73.0005065780279, 1566.64998297859 ),
      ( 375, 34597.3040900507, 100000000.000001, 11728.1902900793, 14618.5889101486, 43.7876022657136, 47.0649781112424, 73.2151593725395, 1469.71883954939 ),
      ( 400, 33104.9860290379, 99999999.9999987, 13432.2830540802, 16452.9760672802, 48.5230288888718, 46.6357707395625, 73.557360026841, 1378.23191871558 ),
      ( 425, 31599.5253898805, 100000000, 15132.8261966404, 18297.430688834, 52.9956630331799, 46.3173647360677, 74.0152037419427, 1292.89191056162 ),
      ( 450, 30085.0387027554, 100000000, 16830.3939039626, 20154.3052004716, 57.2409597782698, 46.1095353986696, 74.5405045203301, 1214.53134106077 ),
      ( 475, 28569.9708902663, 99999999.9999997, 18524.2397865627, 22024.4183616157, 61.2853055184763, 46.0065544133753, 75.0609803295241, 1143.96780758146 ),
      ( 500, 27067.1837502069, 100000000, 20212.1204292374, 23906.6311298283, 65.1470058024238, 45.9991565164775, 75.4948903986105, 1081.81615292165 ),
      ( 525, 25593.0179112446, 100000000.000058, 21890.4874886553, 25797.8031615023, 68.8377754704661, 46.0765908621932, 75.7662670913811, 1028.3587217666 ),
      ( 550, 24165.5210839918, 100000000.000003, 23554.9780810318, 27693.1052769004, 72.3645453606933, 46.2285247546416, 75.817947374482, 983.532328124226 ),
      ( 575, 22802.2573843047, 99999999.9999188, 25201.1025149292, 29586.6332242155, 75.7314036406642, 46.4462743462073, 75.6228805297402, 946.98354659198 ),
      ( 600, 21518.0917388297, 99999999.9999903, 26825.026489079, 31472.2787275077, 78.9415624821323, 46.7230988630085, 75.1926485976423, 918.111024439022 ),
      ( 625, 20323.4012586657, 99999999.9999983, 28424.2700109973, 33344.7062473954, 81.9990972851992, 47.0538336889084, 74.5760565848328, 896.096733278033 ),
      ( 650, 19223.2429611757, 100000000, 29998.0855638404, 35200.1214639206, 84.910019552495, 47.4343404566267, 73.8443019265147, 879.978191734872 ),
      ( 675, 18217.6865371956, 99999999.9999997, 31547.4067903689, 37036.5779755151, 87.682450313112, 47.8610454021222, 73.0708992778598, 868.760698278459 ),
      ( 700, 17302.9696044878, 100000000, 33074.4813452052, 38853.8361198945, 90.3261093649432, 48.3306065675108, 72.3172527198905, 861.518495514561 ),
      };

      // TestData contains:
      // 0. Temperature (Kelvin)
      // 1. Pressure (Pa)
      // 2. Saturated liquid density (mol/m³
      // 3. Saturated vapor density (mol/m³)
      _testDataSaturatedProperties = new (double temperature, double pressure, double saturatedLiquidMoleDensity, double saturatedVaporMoleDensity)[]
      {
      ( 221.733125, 37529.8807357286, 41323.2312740849, 20.6506844017015 ),
      ( 247.97125, 150217.874887518, 39444.9287780308, 75.5033041322734 ),
      ( 274.209375, 446663.660056312, 37410.9514474396, 210.716281394609 ),
      ( 300.4475, 1076234.24374777, 35189.9692973127, 490.955935647259 ),
      ( 326.685625, 2227216.27426532, 32692.6927249255, 1017.55703630631 ),
      ( 352.92375, 4121670.38031067, 29721.1955524583, 1978.6935621243 ),
      ( 379.161875, 7027043.72460256, 25762.3588433895, 3866.25783696286 ),
      };

      // TestData contains:
      // 0. Temperature (Kelvin)
      // 1. Pressure (Pa
      _testDataMeltingLine = new (double temperature, double pressure)[]
     {
      ( 195.495000092171, 6091.22310769953 ),
      ( 195.495016943452, 6309.57344480193 ),
      ( 195.495301753982, 10000 ),
      ( 195.495753149314, 15848.9319246111 ),
      ( 195.49646856537, 25118.8643150958 ),
      ( 195.497602430106, 39810.7170553497 ),
      ( 195.499399501436, 63095.7344480193 ),
      ( 195.502247676341, 100000 ),
      ( 195.50676183391, 158489.319246111 ),
      ( 195.51391650502, 251188.643150958 ),
      ( 195.525256430888, 398107.170553497 ),
      ( 195.543230349486, 630957.344480193 ),
      ( 195.571720475282, 1000000 ),
      ( 195.616882784682, 1584893.19246111 ),
      ( 195.688481585201, 2511886.43150958 ),
      ( 195.802011721215, 3981071.70553497 ),
      ( 195.982079794129, 6309573.44480193 ),
      ( 196.267807728188, 10000000 ),
      ( 196.721509528813, 15848931.9246111 ),
      ( 197.442727744104, 25118864.3150958 ),
      ( 198.591201629803, 39810717.0553497 ),
      ( 200.425109614114, 63095734.4480193 ),
      ( 203.366410561752, 100000000 ),
      ( 208.116728743151, 158489319.246111 ),
      ( 215.87379747851, 251188643.150958 ),
      ( 228.764454493304, 398107170.553497 ),
      ( 250.789763597832, 630957344.480193 ),
      ( 290.122052811407, 1000000000 ),
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

    [Fact]
    public override void MeltingPressure_TestMonotony()
    {
      base.MeltingPressure_TestMonotony();
    }

    [Fact]
    public override void MeltingPressure_TestDerivative()
    {
      base.MeltingPressure_TestDerivative();
    }

    [Fact]
    public override void MeltingPressure_TestData()
    {
      base.MeltingPressure_TestData();
    }

    [Fact]
    public override void MeltingTemperature_TestData()
    {
      base.MeltingTemperature_TestData();
    }
  }
}
