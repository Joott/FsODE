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
  /// Tests and test data for <see cref="Fluid_1_1_1_3_3_3_hexafluoropropane"/>.
  /// </summary>
  /// <remarks>
  /// <para>Reference:</para>
  /// <para>The test data was created automatically using calls into the TREND.DLL of the following software:</para>
  /// <para>TREND 3.0.: Span, R.; Eckermann, T.; Herrig, S.; Hielscher, S.; Jäger, A.; Thol, M. (2016): TREND.Thermodynamic Reference and Engineering Data 3.0.Lehrstuhl für Thermodynamik, Ruhr-Universität Bochum.</para>
  /// </remarks>
  
  public class Test_Fluid_1_1_1_3_3_3_hexafluoropropane : FluidTestBase
  {

    public Test_Fluid_1_1_1_3_3_3_hexafluoropropane()
    {
      _fluid = Fluid_1_1_1_3_3_3_hexafluoropropane.Instance;

      _testDataMolecularWeight = 0.1520384;

      _testDataTriplePointTemperature = 179.6;

      _testDataTriplePointPressure = 160.3;

      _testDataTriplePointLiquidMoleDensity = 11234.5055619022;

      _testDataTriplePointVaporMoleDensity = 0.10739880724453;

      _testDataCriticalPointTemperature = 398.07;

      _testDataCriticalPointPressure = 3190866.15547813;

      _testDataCriticalPointMoleDensity = 3626;

      _testDataNormalBoilingPointTemperature = 271.661627105418;

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
      ( 179.6, 11234.5062480195, 240.449974710283, 13715.3674515441, 13715.3888543516, 77.2598298689429, 130.546605156732, 182.36763477862, 1035.84426131142 ),
      ( 182.167532698228, 11189.135421174, 240.450000251602, 14182.6964416739, 14182.71793127, 79.8434726622049, 129.73056010626, 181.671003724005, 1025.40665618993 ),
      ( 200, 0.144643565179753, 240.450000000001, 45269.4635763922, 46931.8258093833, 258.244596774894, 92.1680705434866, 100.495949235915, 109.169341237699 ),
      ( 250, 0.115694345766265, 240.45, 50179.5053770872, 52257.8264774612, 281.963384692737, 104.32837792303, 112.649202513994, 121.48187553767 ),
      ( 300, 0.0964052401732805, 240.45, 55706.1000352159, 58200.2590619224, 303.597696755051, 116.742342277402, 125.060033445451, 132.560641814686 ),
      ( 350, 0.0826304743075502, 240.45, 61855.7516390469, 64765.6949985034, 323.814236238111, 129.269654943879, 137.585945492614, 142.723429221989 ),
      ( 400, 0.0723005024501514, 240.45, 68636.5554767899, 71962.2585058357, 343.014676439455, 141.996281977374, 150.311896371006, 152.166018731114 ),
      ( 179.6, 11234.51275224, 999.999979141225, 13715.348365019, 13715.4373764431, 77.2597235963539, 130.546674026535, 182.367565484973, 1035.84636341326 ),
      ( 196.269451682768, 10938.5344627139, 1000.00000089274, 16722.1648366424, 16722.2562565675, 93.2718845140362, 126.160038500089, 178.729209184113, 966.739585887689 ),
      ( 200, 0.602163403348527, 1000.00000000048, 45265.2260044837, 46925.9048076784, 246.373257577253, 92.1906584085847, 100.561090715803, 109.080665841819 ),
      ( 250, 0.481374963343554, 1000.00000000004, 50176.9963166489, 52254.378972893, 270.10320307707, 104.344576413921, 112.685512289556, 121.437141632272 ),
      ( 300, 0.401029501233747, 1000.00000000001, 55704.5744826105, 58198.1566178987, 291.742467294022, 116.751340773053, 125.079212209347, 132.535029430964 ),
      ( 350, 0.343694765025415, 1000, 61854.7462657039, 64764.304693008, 311.961219705641, 129.274260517843, 137.596299151138, 142.707375070504 ),
      ( 400, 0.300712803094219, 1000, 68635.8337127452, 71961.2657851757, 331.162728060572, 141.998723528935, 150.317947898791, 152.155375437282 ),
      ( 179.6, 11234.5898190776, 9999.99997067138, 13715.1222158379, 13716.0123239889, 77.2584643951323, 130.547490047053, 182.366744517106, 1035.87127068321 ),
      ( 200, 10871.8221617765, 9999.99999764472, 17387.5942846225, 17388.5140936341, 96.6304852909729, 125.459888526817, 178.177384416853, 950.897570129483 ),
      ( 225, 10416.4456586185, 9999.99999908867, 21814.7865843295, 21815.746604698, 117.490453804363, 123.055649024042, 176.573460652834, 842.022498417312 ),
      ( 226.062556510508, 10396.7346563778, 9999.9999977039, 22002.4060558396, 22003.3678962951, 118.322363409711, 123.03231174423, 176.578161364641, 837.339682640425 ),
      ( 250, 4.83981339462488, 10000.0000004384, 50147.0761235066, 52213.2714878866, 250.838590334085, 104.537869245509, 113.122337691618, 120.902878155102 ),
      ( 300, 4.02134994407522, 10000.0000000577, 55686.4397203489, 58173.1668490811, 272.537202405936, 116.858378524811, 125.308202267445, 132.230431755903 ),
      ( 350, 3.44235137221975, 10000.0000000107, 61842.8125026261, 64747.803573762, 292.782333888458, 129.328958151407, 137.719516809431, 142.516818982619 ),
      ( 400, 3.01003595119234, 10000.0000000025, 68627.2728103515, 71949.4922662491, 311.996543675932, 142.027694740183, 150.389845502306, 152.029170531896 ),
      ( 179.6, 11234.6978443701, 22616.2738696129, 13714.8052271327, 13716.8183007536, 77.2566993468987, 130.548633870234, 182.365593990992, 1035.90618344856 ),
      ( 200, 10871.9524888584, 22616.2738904523, 17387.2113330627, 17389.2915733796, 96.6285704432666, 125.46119053962, 178.175726275616, 950.939344661048 ),
      ( 225, 10416.6135858798, 22616.2738916163, 21814.3017281099, 21816.4729014672, 117.488298775657, 123.057078098667, 176.570967167628, 842.075828989593 ),
      ( 239.610036036444, 10142.4444005014, 22616.2738939524, 24396.6066172757, 24398.8364814978, 128.608053733728, 123.205998849668, 177.098383535872, 777.678550640801 ),
      ( 250, 11.0307286457973, 22616.2739033739, 50104.5273166383, 52154.8246840738, 243.882431205442, 104.813152344948, 113.756056713223, 120.140489109803 ),
      ( 300, 9.13030074779348, 22616.2738927823, 55660.8348496994, 58137.891686874, 265.666386788698, 117.009723150634, 125.634713233644, 131.799936523163 ),
      ( 350, 7.80256536314503, 22616.2738915134, 61826.0180839501, 64724.5870595257, 285.948994840405, 129.406026956077, 137.89392772153, 142.248668251286 ),
      ( 400, 6.8168332990501, 22616.2738912955, 68615.2451660593, 71932.9548560479, 305.181149822461, 142.068434461699, 150.491233027143, 151.851970974555 ),
      ( 200, 10872.7515622626, 100000.000001614, 17384.8635345812, 17394.0608384494, 96.6168293788532, 125.469173339877, 178.165569012953, 951.195475239471 ),
      ( 225, 10417.6430324057, 100000.000004071, 21811.3295866704, 21820.9286869365, 117.475086673558, 123.06583881523, 176.555697891103, 842.402756685404 ),
      ( 250, 9944.06785691786, 100000.000000483, 26237.3437001462, 26247.3999468894, 136.128741525609, 123.865202429175, 178.024743118357, 732.513778212185 ),
      ( 270.345841712694, 9538.40371880807, 100000.000003408, 29888.0679080911, 29898.5518426101, 150.167859075537, 126.156282379388, 181.164265372247, 644.488745678458 ),
      ( 275, 45.7365252448417, 100000, 52597.7125833554, 54784.1489045378, 241.869813847435, 112.240270936319, 122.749483044567, 122.506430382183 ),
      ( 325, 37.887262358152, 100000, 58537.8077491764, 61177.2172439742, 263.205143101175, 123.857082632216, 133.251342572219, 135.032416379768 ),
      ( 375, 32.5181301271433, 100000.000053887, 65054.292610602, 68129.5001844352, 283.082666335361, 136.051509066036, 144.987135088317, 145.796831795352 ),
      ( 200, 10872.7652397817, 101325.000004738, 17384.8233507975, 17394.1425072191, 96.6166284017024, 125.469309975967, 178.165395292805, 951.199859336914 ),
      ( 225, 10417.6606506967, 101324.99999913, 21811.2787231247, 21821.0049950197, 117.474860540726, 123.065988749694, 176.555436815358, 842.408351754921 ),
      ( 250, 9944.09119993613, 101325.000000808, 26237.2786468005, 26247.468114894, 136.128481217175, 123.865347186404, 178.024340127355, 732.521010062885 ),
      ( 270.661627105418, 9531.95172055387, 101325.000003673, 29945.1985567187, 29955.8285937745, 150.379086461332, 126.200788217441, 181.225667991831, 643.145028468785 ),
      ( 275, 46.3720099356072, 101325, 52593.9729910417, 54779.0195340038, 241.746540110555, 112.264405120952, 122.808018060792, 122.440844993081 ),
      ( 325, 38.4016377379837, 101325, 58535.5613770911, 61174.1207190479, 263.088732473212, 123.869044592205, 133.278893614587, 134.995416547471 ),
      ( 375, 32.9551227297856, 101325.000056859, 65052.779670405, 68127.4154679309, 282.96917332812, 136.057532685047, 145.001794349894, 145.773592341209 ),
      ( 200, 10882.0066377285, 1000000.00000164, 17357.6945208967, 17449.5893371096, 96.480769472022, 125.561604601756, 178.049081685795, 954.16189174633 ),
      ( 225, 10429.5459107011, 999999.999997829, 21776.9869394148, 21872.8683908759, 117.322185370429, 123.167138802027, 176.381200719671, 846.182170802231 ),
      ( 250, 9959.80049398903, 1000000.00000056, 26193.5087740737, 26293.9123916567, 135.953053243676, 123.962959919291, 177.756715771377, 737.386937259057 ),
      ( 275, 9463.73080024381, 1000000.00000319, 30676.1589729835, 30781.8255458299, 153.05983980867, 126.912058575247, 181.682249467002, 630.923142160325 ),
      ( 300, 8926.10218546197, 1000000.00000021, 35287.0963210874, 35399.1273038414, 169.126072063276, 131.250863003796, 188.172149400307, 527.029504897107 ),
      ( 325, 8316.82754585617, 1000000.00000002, 40100.1061370198, 40220.3442920718, 184.556811754041, 136.564555201774, 198.349711848212, 422.467728461083 ),
      ( 342.867645953059, 7799.14348081608, 999999.99999995, 43734.2533371583, 43862.4725451341, 195.463305872969, 141.072929583265, 210.390650011481, 342.596633902384 ),
      ( 350, 435.824683855511, 1000000.00000493, 60165.3917936156, 62459.8923968362, 249.521226779294, 137.894467170805, 164.733924103339, 115.752876214743 ),
      ( 400, 340.023662669394, 1000000.00000002, 67568.4996101036, 70509.4714005649, 271.0225213161, 145.762601394896, 161.31550321575, 136.879294045162 ),
      ( 200, 10905.850944201, 3350409.46318594, 17287.901430956, 17595.1135394222, 96.1296235409985, 125.799506556152, 177.758594737061, 961.803263195539 ),
      ( 210, 10728.8921128289, 3350409.46312503, 19054.2896355592, 19366.568799884, 104.772806785691, 124.398862469087, 176.629464572067, 919.741495208893 ),
      ( 220, 10550.1721060617, 3350409.46305336, 20811.9686620912, 21129.537838155, 112.97424576611, 123.61232142045, 176.051217924236, 877.20656821497 ),
      ( 230, 10369.3418829007, 3350409.46294151, 22566.1354686552, 22889.2427112148, 120.796457756362, 123.367316151308, 175.968116401523, 834.513537327887 ),
      ( 240, 10186.0220804513, 3350409.46279696, 24321.4705812944, 24650.3928471539, 128.291789734461, 123.59084831319, 176.333074301649, 791.953418215813 ),
      ( 250, 9999.77801518706, 3350409.46260776, 26082.2174509226, 26417.2658347486, 135.504410234979, 124.213071084984, 177.106792314281, 749.762138786783 ),
      ( 260, 9810.09685988331, 3350409.46237265, 27852.259695227, 28193.7863396859, 142.471902780562, 125.170207792427, 178.258107094645, 708.10555037086 ),
      ( 270, 9616.36341373642, 3350409.46325212, 29635.2049794593, 29983.612097525, 149.226585065459, 126.406382578869, 179.765016436576, 667.0766631445 ),
      ( 280, 9417.83016250968, 3350409.46325222, 31434.4816424107, 31790.233381977, 155.796637069205, 127.874396310955, 181.616385763756, 626.700144264072 ),
      ( 290, 9213.57548147868, 3350409.46325205, 33253.4555385644, 33617.0938969832, 162.207106239401, 129.535515447569, 183.814534749103, 586.938505476441 ),
      ( 300, 9002.44101640033, 3350409.46325206, 35095.574299577, 35467.7410771375, 168.480841885116, 131.358591646812, 186.37846762566, 547.693888387735 ),
      ( 310, 8782.93736668144, 3350409.46325212, 36964.5449509188, 37346.0129408833, 174.639396108452, 133.320310816767, 189.34828831908, 508.804091859969 ),
      ( 320, 8553.10304152538, 3350409.4632522, 38864.5720116108, 39256.2906015759, 180.703989731693, 135.408307180868, 192.794892480356, 470.04219118163 ),
      ( 330, 8310.28183204197, 3350409.46325224, 40800.7339450917, 41203.8983059361, 186.696782772877, 137.624366644161, 196.840575491644, 431.12667873062 ),
      ( 340, 8050.73939025858, 3350409.46325204, 42779.6223064542, 43195.7840154403, 192.64279177182, 139.984142720976, 201.695856600388, 391.730540843458 ),
      ( 350, 7768.95685454388, 3350409.46325204, 44810.4645385697, 45241.7205650841, 198.573036029251, 142.51716494208, 207.733109986887, 351.473662072817 ),
      ( 360, 7456.20363563581, 3350409.46324416, 46907.3485130393, 47356.6937330695, 204.5305777803, 145.272297771686, 215.669869737543, 309.874581510124 ),
      ( 370, 7097.17783372873, 3350409.46324867, 49094.4108551596, 49566.4871567179, 210.584474735105, 148.33275152141, 227.090412369404, 266.16688159919 ),
      ( 380, 6660.25795781536, 3350409.46325198, 51420.4942533752, 51923.5392532045, 216.869193361787, 151.89040333034, 246.316124011474, 218.746342904915 ),
      ( 390, 6056.72794920838, 3350409.46322699, 54018.8603662053, 54572.0318956719, 223.74631793608, 156.717575483013, 291.686326381698, 163.337135020242 ),
      ( 400, 4378.07679800063, 3350409.46325204, 58208.017973398, 58973.2876609426, 234.860197154493, 175.958993897308, 1474.50304956233, 74.283173981242 ),
      ( 200, 10970.9239132124, 9999999.99997144, 17098.9654518834, 18010.4657119415, 95.1668877645419, 126.447069380538, 177.032671695595, 982.651908061541 ),
      ( 210, 10800.1445439057, 9999999.99994824, 18848.1770198718, 19774.0905536486, 103.771889314931, 125.07450738379, 175.787248630217, 942.489335668286 ),
      ( 220, 10628.4216583833, 9999999.99993294, 20587.1221905614, 21527.9956637215, 111.931186546716, 124.306381320387, 175.077681389371, 902.08029370668 ),
      ( 230, 10455.5255474193, 9999999.99990403, 22320.7923513799, 23277.2244268935, 119.706855409056, 124.067516636841, 174.842440703076, 861.739548775203 ),
      ( 240, 10281.2222360406, 9999999.99988103, 24053.598875387, 25026.2458788558, 127.150595252653, 124.283458864441, 175.027835179659, 821.757460985179 ),
      ( 250, 10105.2576470759, 9999999.999867, 25789.4415483173, 26779.0254212986, 134.30571330167, 124.883777269785, 175.586723798457, 782.372806548562 ),
      ( 260, 9927.34690528321, 9999999.99985034, 27531.769820416, 28539.0883008983, 141.208691138689, 125.804667840485, 176.478204675232, 743.761302089134 ),
      ( 270, 9747.16668057494, 9999999.99983897, 29283.6428175243, 30309.5819778516, 147.890451155377, 126.990469128543, 177.667636869974, 706.035927231531 ),
      ( 280, 9564.34872726689, 9999999.99983335, 31047.7897662504, 32093.3392631361, 154.377395357577, 128.394149836452, 179.126752716494, 669.254427130941 ),
      ( 290, 9378.47290049386, 9999999.99983374, 32826.6708550765, 33892.942529147, 160.692265573379, 129.976949081543, 180.833725032369, 633.429676549455 ),
      ( 300, 9189.05829012448, 9999999.99984104, 34622.5363266241, 35710.7871227463, 166.854855102273, 131.707504532982, 182.7728895523, 598.539545476857 ),
      ( 310, 8995.55249877731, 9999999.99985619, 36437.4798101948, 37549.1402669833, 172.882588858204, 133.561262681738, 184.934230489346, 564.536131719482 ),
      ( 320, 8797.32012090109, 9999999.99987938, 38273.4881615567, 39410.1979620926, 178.791004945771, 135.520470509941, 187.313687933131, 531.358070897647 ),
      ( 330, 8593.62926733834, 9999999.99991038, 40132.4983790515, 41296.1510907082, 184.594190347737, 137.573306221013, 189.914545807118, 498.946342346113 ),
      ( 340, 8383.63229436024, 9999999.99994548, 42016.4639994837, 43209.2644049443, 190.305190064579, 139.711240996887, 192.748328570393, 467.256747575989 ),
      ( 350, 8166.33926962931, 9999999.999975, 43927.4197312156, 45151.9586182008, 195.936366016411, 141.926528739537, 195.83467918268, 436.265091400018 ),
      ( 360, 7940.58643937895, 9999999.99999272, 45867.5399903363, 47126.8928197949, 201.499706241708, 144.211439452605, 199.20180642798, 405.968894715737 ),
      ( 370, 7705.00169429804, 9999999.99999901, 47839.1971419431, 49137.0553899691, 207.007114983256, 146.558275051521, 202.887411308162, 376.38863630022 ),
      ( 380, 7457.97294111341, 9999999.99999992, 49845.0075719933, 51185.8544856196, 212.470663093588, 148.959702104531, 206.937121505096, 347.571200321158 ),
      ( 390, 7197.6422774191, 10000000.0000001, 51887.8259586655, 53277.1698041318, 217.902705587668, 151.410323659298, 211.398095499486, 319.604863053228 ),
      ( 400, 6921.97268856273, 9999999.99999996, 53970.6359895511, 55415.3108604189, 223.31574790907, 153.908346033707, 216.306322633243, 292.651830278062 ),
      };

      // TestData contains:
      // 0. Temperature (Kelvin)
      // 1. Pressure (Pa)
      // 2. Saturated liquid density (mol/m³
      // 3. Saturated vapor density (mol/m³)
      _testDataSaturatedProperties = new (double temperature, double pressure, double saturatedLiquidMoleDensity, double saturatedVaporMoleDensity)[]
      {
      ( 206.90875, 2307.6320060511, 10747.3284838349, 1.34505673609529 ),
      ( 234.2175, 15615.0101851943, 10244.369612951, 8.11520319171603 ),
      ( 261.52625, 65141.375290621, 9716.28127416865, 31.0106351554423 ),
      ( 288.835, 196908.487791288, 9149.42851141502, 88.5639120179785 ),
      ( 316.14375, 477113.855120106, 8520.1594874949, 210.422843848363 ),
      ( 343.4525, 989899.69335075, 7779.45868768153, 450.199188032254 ),
      ( 370.76125, 1840848.02104819, 6793.59348354427, 943.393144744569 ),
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
