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
  /// Tests and test data for <see cref="Chloropentafluoroethane"/>.
  /// </summary>
  /// <remarks>
  /// <para>Reference:</para>
  /// <para>The test data was created automatically using calls into the TREND.DLL of the following software:</para>
  /// <para>TREND 3.0.: Span, R.; Eckermann, T.; Herrig, S.; Hielscher, S.; Jäger, A.; Thol, M. (2016): TREND.Thermodynamic Reference and Engineering Data 3.0.Lehrstuhl für Thermodynamik, Ruhr-Universität Bochum.</para>
  /// </remarks>
  
  public class Test_Chloropentafluoroethane : FluidTestBase
  {

    public Test_Chloropentafluoroethane()
    {
      _fluid = Chloropentafluoroethane.Instance;

      _testDataMolecularWeight = 0.154466416;

      _testDataTriplePointTemperature = 173.75;

      _testDataTriplePointPressure = 2213;

      _testDataTriplePointLiquidMoleDensity = 11295.8421548216;

      _testDataTriplePointVaporMoleDensity = 1.5358037404999;

      _testDataCriticalPointTemperature = 353.1;

      _testDataCriticalPointPressure = 3129040.69401173;

      _testDataCriticalPointMoleDensity = 3980;

      _testDataNormalBoilingPointTemperature = 233.931807458476;

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
      ( 173.75, 0.692889034170868, 1000.0000000002, 37771.2472312644, 39214.479770219, 226.66440646161, 75.1035302444391, 83.4493510516736, 101.839930562214 ),
      ( 175, 0.687925811499853, 1000.00000000019, 37865.3094375314, 39318.9545592632, 227.26354648514, 75.3649081523604, 83.7102662427849, 102.189738411468 ),
      ( 194, 0.620393039123772, 1000.00000000007, 39335.1776352769, 40947.0590345467, 236.092266859272, 79.333636856028, 87.6723141780639, 107.349438940911 ),
      ( 213, 0.564952976316101, 1000.00000000003, 40880.8404946954, 42650.8993171496, 244.468111982606, 83.3604506741685, 91.6935597589251, 112.241308836415 ),
      ( 232, 0.518621201220943, 1000.00000000001, 42503.7657342628, 44431.9553216646, 252.475230261302, 87.4695980992599, 95.7984463527112, 116.902005778888 ),
      ( 251, 0.479320815034995, 1000.00000000001, 44205.2917824165, 46291.5771441883, 260.17735639436, 91.630153276761, 99.9558494148302, 121.363291164272 ),
      ( 270, 0.445562237044849, 1000, 45985.9192212456, 48230.2745926352, 267.621030232583, 95.7893532456494, 104.1127319599, 125.651782401295 ),
      ( 289, 0.4162493088562, 1000, 47845.0977702861, 50247.5041616573, 274.839510119892, 99.8918736239626, 108.213536926594, 129.789299240074 ),
      ( 308, 0.390557373634676, 1000, 49781.2811883301, 52341.7244612189, 281.856343323069, 103.889408150782, 112.209785278295, 133.793542060624 ),
      ( 327, 0.367854047498252, 1000, 51792.1028539382, 54510.5723306259, 288.688248927404, 107.744326965014, 116.063724823716, 137.678857799632 ),
      ( 346, 0.347646219319114, 1000, 53874.5863944314, 56751.0738820807, 295.34729034048, 111.430074644284, 119.748714795024, 141.456948344245 ),
      ( 365, 0.329543678752032, 1000, 56025.3467855155, 59059.8458958822, 301.842439527067, 114.92999583388, 123.24804029336, 145.13746188477 ),
      ( 384, 0.313233585876834, 1000, 58240.762316836, 61433.2679902002, 308.180665843976, 118.235571446017, 126.553140387233, 148.728458926466 ),
      ( 403, 0.298462188292488, 999.999999999999, 60517.111788961, 63867.6199579221, 314.367673028804, 121.344589015129, 129.661772887129, 152.236767947818 ),
      ( 422, 0.28502149217799, 1000, 62850.6783807172, 66359.1857299648, 320.40838521275, 124.259493823202, 132.576361694759, 155.668252569082 ),
      ( 441, 0.272739387877868, 1000, 65237.8246760905, 68904.3284685233, 326.307258784581, 126.986011772231, 135.302617128953, 159.028011244315 ),
      ( 460, 0.261472228064317, 1000, 67675.0442067425, 71499.5421559244, 332.068476150346, 129.532054205486, 137.848439022537, 162.320526882329 ),
      ( 479, 0.251099175633477, 1000, 70158.994651941, 74141.4848272958, 337.696061078957, 131.906877565455, 140.223075203376, 165.549779800897 ),
      ( 498, 0.2415178475811, 1000, 72686.517165225, 76826.997920645, 343.193943124296, 134.120457233778, 142.436494522975, 168.719333940042 ),
      ( 517, 0.232640920780865, 999.999999999998, 75254.6454966943, 79553.1154161026, 348.565989820739, 136.183033446901, 144.498932206677, 171.832403531818 ),
      ( 536, 0.224393460560183, 999.999999999999, 77860.607812036, 82317.0656673744, 353.816019159179, 138.104791224421, 146.420569383347, 174.891905394169 ),
      ( 173.75, 11295.8559637246, 3319.49999563618, 16689.5770646092, 16689.8709334409, 90.4280271360159, 85.8879293834202, 132.519425199519, 894.319396367545 ),
      ( 175, 11270.004723697, 3319.50000044282, 16855.3190855621, 16855.6136284733, 91.3785263054672, 86.1117503008169, 132.669566903167, 887.667947877823 ),
      ( 177.396874278351, 11220.4255763986, 3319.49999991754, 17173.6657454406, 17173.9615898341, 93.1853076971203, 86.5412062653843, 132.968851310786, 875.044320616551 ),
      ( 200, 2.00046667961481, 3319.50000000673, 39809.7739299768, 41469.1367345829, 228.779580672002, 80.6197396023375, 89.0111700524009, 108.789977521482 ),
      ( 250, 1.59864295000875, 3319.50000000075, 44110.4648106854, 46186.9134635773, 249.789737092035, 91.4262182000971, 99.7786164919941, 121.059758370757 ),
      ( 300, 1.33158985526219, 3319.50000000013, 48954.5673888315, 51447.4521062106, 268.942013878408, 102.229800205214, 110.565564133322, 132.07733702618 ),
      ( 350, 1.14110180654453, 3319.50000000003, 54320.1865691063, 57229.217105174, 286.74755487989, 112.186966733891, 120.514831229733, 142.209597637524 ),
      ( 400, 0.9983364493547, 3319.50000000001, 60152.5055406858, 63477.5368987472, 303.421591308259, 120.86903800512, 129.192702045419, 151.667604698544 ),
      ( 450, 0.887341129579833, 3319.5, 66385.2075835557, 70126.1589373736, 319.074997645318, 128.215363895448, 136.536557696756, 160.581632849535 ),
      ( 500, 0.798566805508681, 3319.5, 72954.085284411, 77110.9072022535, 333.78766219373, 134.345377627095, 142.664995209111, 169.039964829759 ),
      ( 550, 0.725945082569617, 3319.5, 79802.7038430895, 84375.3637862494, 347.631342405275, 139.437110319259, 147.755655814943, 177.107135447566 ),
      ( 173.75, 11295.9393930316, 10000.0000022188, 16689.3889453569, 16690.2742192287, 90.426944410222, 85.8880258146432, 132.518732986361, 894.354393912575 ),
      ( 175, 11270.089283521, 10000.0000027155, 16855.1287306349, 16856.0160350521, 91.3774385376907, 86.1118422675885, 132.668852304528, 887.703193822526 ),
      ( 191.686059241512, 10923.932912621, 9999.99999833705, 19087.7697129003, 19088.6851341207, 103.56175468271, 89.1248824071816, 135.059303892952, 802.964187195541 ),
      ( 200, 6.05313398091221, 10000.0000006597, 39793.5728961376, 41445.6096810813, 219.528887873295, 80.7428770611391, 89.3153298775364, 108.40216732722 ),
      ( 250, 4.82611316838736, 10000.0000000645, 44100.8824834787, 46172.9433016062, 240.582391109393, 91.4731684443948, 99.9035966618529, 120.847692498624 ),
      ( 300, 4.01614930352684, 10000.000000011, 48948.1340266252, 51438.0812980648, 259.751599228625, 102.253315307381, 110.632248115255, 131.946114660916 ),
      ( 350, 3.44003592521279, 10000.0000000025, 54315.4682817305, 57222.4146675837, 277.565112498865, 112.199177462642, 120.554098062567, 142.123066280174 ),
      ( 400, 3.00887045374366, 10000.0000000006, 60148.8051421546, 63472.3114724316, 294.243381220383, 120.875767563062, 129.217973670915, 151.608627766696 ),
      ( 450, 2.67392400859763, 10000.0000000002, 66382.163641858, 70121.9857040582, 309.899275087954, 128.219337508803, 136.554079168778, 160.540964746402 ),
      ( 500, 2.40616636893399, 10000, 72951.4963590502, 77107.4849594687, 324.613526406079, 134.347896738717, 142.677879967828, 169.012125191314 ),
      ( 550, 2.1871993316356, 10000, 79800.4494489688, 84372.5064422937, 338.458285671722, 139.438822510147, 147.765571193629, 177.088639368945 ),
      ( 173.75, 11296.8532623591, 83213.9835383691, 16687.3282817166, 16694.6944023173, 90.4150825548614, 85.8890883301896, 132.511158679922, 894.737715873759 ),
      ( 175, 11271.0155293863, 83213.9835327025, 16853.0435909881, 16860.4265977203, 91.3655215122766, 86.112855959665, 132.66103309009, 888.08923399688 ),
      ( 200, 10750.9486176423, 83213.98353564, 20213.8960765491, 20221.6362292087, 109.312905888774, 90.6591942481057, 136.501803303064, 763.531439710689 ),
      ( 225, 10212.6976746966, 83213.9830514698, 23690.6730139257, 23698.8211042444, 125.688760045669, 95.4624554573481, 141.945448817439, 650.285651156982 ),
      ( 228.620654585135, 10132.0979716108, 83213.9835372933, 24206.211576975, 24214.4244844864, 127.962068622226, 96.1830832545406, 142.873006602742, 634.501953029721 ),
      ( 250, 41.155921024659, 83213.983535509, 43988.0940674868, 46010.014157324, 222.509433432055, 92.2238730056768, 101.678824297649, 118.409175656451 ),
      ( 300, 33.864507820885, 83213.9835355089, 48876.164213239, 51333.4266655871, 241.893782099414, 102.530782075177, 111.412315062323, 130.480032858014 ),
      ( 350, 28.8542925967611, 83213.9835480012, 54263.2505310167, 57147.1882768114, 259.798683331288, 112.336121544576, 120.996900644274, 141.165931542374 ),
      ( 400, 25.1650110210286, 83213.9835386897, 60108.0223236994, 63414.7557667785, 276.524381863227, 120.950328160985, 129.499576272338, 150.959632802881 ),
      ( 450, 22.3247642072486, 83213.9835364009, 66348.6896883862, 70076.119136863, 292.207912063621, 128.263174038384, 136.748178889788, 160.094886776019 ),
      ( 500, 20.0667548103398, 83213.9835357666, 72923.0645389313, 77069.922579619, 306.939709868398, 134.375628221383, 142.820106062876, 168.707481632545 ),
      ( 550, 18.2268615684253, 83213.9835355817, 79775.7133219119, 84341.1720117246, 320.796365815915, 139.457645978176, 147.874758964717, 176.88666819117 ),
      ( 173.75, 11297.0626690019, 99999.999999862, 16686.8560850818, 16695.707943563, 90.4123640112809, 85.8893334043428, 132.509425163149, 894.825542409482 ),
      ( 175, 11271.2277702353, 99999.9999976906, 16852.565789247, 16861.4379371653, 91.3627903420657, 86.1130898667003, 132.659243531316, 888.177682692811 ),
      ( 200, 10751.2292401793, 99999.9999991122, 20213.2850406947, 20222.5863026961, 109.309849597478, 90.6591617360025, 136.498578146348, 763.634571310769 ),
      ( 225, 10213.0797103077, 99999.9996155933, 23689.8714808865, 23699.6628467088, 125.68519618536, 95.4620184141734, 141.939763919712, 650.40926846805 ),
      ( 232.637781397368, 10042.067942781, 99999.999999113, 24781.3399462564, 24791.2980545434, 130.456192528968, 96.9893141744836, 143.939779844719, 617.255591340715 ),
      ( 250, 49.754896552957, 99999.9999999999, 43960.0765323081, 45969.9289675064, 220.867228047315, 92.4612679184099, 102.20199037889, 117.818115967995 ),
      ( 300, 40.8223702836689, 100000, 48859.2723034449, 51308.9095808767, 240.309207292362, 102.599675169377, 111.604565924737, 130.136423316023 ),
      ( 350, 34.7388870838019, 100000.00002637, 54251.1447989135, 57129.7632124838, 258.236143613186, 112.368338750685, 121.101737131258, 140.944171232072 ),
      ( 400, 30.2766773929515, 100000.00000667, 60098.6122602727, 63401.4845903109, 274.972993226259, 120.967632972727, 129.565359091299, 150.810145639802 ),
      ( 450, 26.8486366058666, 100000.000001864, 66340.9853419875, 70065.5692554966, 290.662957731431, 128.273298942032, 136.793221867315, 159.992513747868 ),
      ( 500, 24.1268191910718, 100000.000000537, 72916.5306511996, 77061.2958276031, 305.398819191193, 134.382018072371, 142.85297874441, 168.637754147967 ),
      ( 550, 21.9108526297843, 100000.000000151, 79770.0343926933, 84333.9827560818, 319.258221115111, 139.461976804741, 147.899927762868, 176.840551110313 ),
      ( 173.75, 11297.0791965703, 101324.999996848, 16686.818816464, 16695.787948948, 90.4121494406113, 85.8893527724877, 132.509288377132, 894.832474039172 ),
      ( 175, 11271.2445214671, 101324.99999843, 16852.528078296, 16861.5177688138, 91.362574775071, 86.1131083537963, 132.659102323363, 888.184663415872 ),
      ( 200, 10751.2513875434, 101324.999997798, 20213.2368158683, 20222.6613001767, 109.309608376909, 90.6591592055069, 136.498323673985, 763.642710570622 ),
      ( 225, 10213.1098594327, 101324.999624136, 23689.8082249867, 23699.7292971204, 125.684914918713, 95.4619839767774, 141.939315421267, 650.419023921068 ),
      ( 232.931807458476, 10035.4373720478, 101325.000001935, 24823.5977379084, 24833.6944577867, 130.63775257464, 97.0486125653853, 144.019658161037, 615.999451433997 ),
      ( 250, 50.4382990712513, 101325, 43957.8281873235, 45966.7182939638, 220.748587983338, 92.4811148081579, 102.245327946624, 117.770912601261 ),
      ( 300, 41.3734687965164, 101325, 48857.9325284118, 51306.965760272, 240.195259303597, 102.605199800251, 111.619964942012, 130.109177879165 ),
      ( 350, 35.2043210005425, 101325.000027823, 54250.1870786872, 57128.3849006608, 258.123952855149, 112.370895028301, 121.110066474716, 140.926629254675 ),
      ( 400, 30.6806767738022, 101325.000007034, 60097.8685234605, 63400.4358284149, 274.861687169241, 120.96900227716, 129.570571306956, 150.798334851695 ),
      ( 450, 27.2060221989291, 101325.000001965, 66340.3767281356, 70064.7359623184, 290.552161141253, 128.27409932828, 136.796785993631, 159.984431373848 ),
      ( 500, 24.4474739095927, 101325.000000566, 72916.0146581288, 77060.6146431934, 305.288344015672, 134.382522955541, 142.855577753914, 168.63225212175 ),
      ( 550, 22.2017511781785, 101325.000000159, 79769.5860072692, 84333.4151929484, 319.147962985484, 139.462318895591, 147.901916602704, 176.836913880642 ),
      ( 175, 11282.5410146072, 999999.999999383, 16827.0914749092, 16915.7239911752, 91.2169437466137, 86.1264342582536, 132.565003620803, 892.88754390781 ),
      ( 200, 10766.156150647, 999999.99999977, 20180.7662467149, 20273.6499078849, 109.146901876529, 90.6586282837795, 136.32918567059, 769.116359937105 ),
      ( 225, 10233.3347126948, 1000000.00000015, 23647.3331438655, 23745.0530004006, 125.495664843064, 95.4406160293941, 141.642914197656, 656.961266026998 ),
      ( 250, 9664.76094008509, 999999.999993634, 27266.1526582254, 27369.6213323285, 140.764671251287, 100.505258321943, 148.631965965678, 551.478492493381 ),
      ( 275, 9031.0116666559, 1000000.00000084, 31085.2720948336, 31196.001660569, 155.345338301397, 105.83458788426, 157.997862271537, 448.372057897907 ),
      ( 300, 8270.66121904912, 1000000.00009942, 35190.5625159311, 35311.4718330479, 169.659913850057, 111.550704181784, 172.696565343759, 341.283997543001 ),
      ( 301.072507952292, 8233.24361143599, 999999.999995301, 35375.7039435674, 35497.1627570303, 170.277778868964, 111.81223624401, 173.583330120542, 336.414811855218 ),
      ( 325, 440.290982374456, 1000000.0000004, 50576.5805208726, 52847.8057787861, 227.35773727019, 111.507670785884, 129.612900162752, 117.969640931115 ),
      ( 375, 353.059089901929, 1000000, 56498.6202587001, 59331.007325346, 245.909444427503, 118.322608100868, 131.249221433751, 135.443003099285 ),
      ( 425, 300.182936454473, 1000000, 62695.814049229, 66027.1159940072, 262.664370084559, 125.548942785042, 136.723699997997, 148.663366768088 ),
      ( 475, 262.946136416243, 999999.999999999, 69199.7677756705, 73002.828028349, 278.176246097504, 131.919670957641, 142.228485038259, 159.860421938889 ),
      ( 525, 234.755014577462, 1000000, 75979.9545550058, 80239.7144659918, 292.658003199707, 137.32999061587, 147.132314230367, 169.825438110461 ),
      ( 194, 10925.4775912355, 3285492.72870979, 19291.1099254994, 19591.8283793403, 104.616085463071, 89.5699287386652, 134.932656188898, 810.563055325132 ),
      ( 213, 10535.0835737649, 3285492.72870968, 21875.0077258295, 22186.8697728371, 117.374911212951, 93.0959530503072, 138.366237071743, 724.410695056291 ),
      ( 232, 10132.8673986548, 3285492.72871433, 24530.63465689, 24854.8758217502, 129.370663139789, 96.7761385911355, 142.611738492253, 643.806137222894 ),
      ( 251, 9711.13200743212, 3285492.72871229, 27273.1014731143, 27611.4237949814, 140.788209291022, 100.595471109389, 147.699428928136, 567.070210917395 ),
      ( 270, 9259.73462718299, 3285492.72871214, 30118.9411345778, 30473.7561331704, 151.778225957278, 104.5274069594, 153.791094493294, 492.766292870734 ),
      ( 289, 8763.36302272346, 3285492.72871233, 33089.6960286621, 33464.6083448806, 162.480170479246, 108.562567827826, 161.3458488418, 419.368731874383 ),
      ( 308, 8194.78793124651, 3285492.72871233, 36220.7775261068, 36621.7022060713, 173.056820351151, 112.748596595289, 171.629791740534, 344.731770083406 ),
      ( 327, 7491.99810042334, 3285492.72863644, 39590.5894983041, 40029.1230756752, 183.786945971462, 117.313689078373, 189.056477052666, 264.584245295481 ),
      ( 346, 6408.84764605303, 3285492.72871233, 43504.4172349513, 44017.0667641901, 195.627062160362, 123.582727214835, 248.268017136643, 164.367239329652 ),
      ( 365, 2024.01674115761, 3285492.72871231, 52113.1431946721, 53736.396926671, 222.964330073836, 128.096405938108, 248.256096205672, 88.3773288336567 ),
      ( 384, 1542.28089472527, 3285492.72871232, 55370.4168616175, 57500.6985372506, 233.032527829824, 125.503900707199, 173.264271531545, 107.152227458052 ),
      ( 403, 1323.81850388979, 3285492.72872544, 58140.9336873933, 60622.76387716, 240.971021515574, 126.215537145257, 158.174387959532, 119.507113953149 ),
      ( 422, 1183.36675634591, 3285492.72871393, 60792.4789163924, 63568.8732261828, 248.115308705999, 127.810539269994, 152.780032566358, 129.124840383658 ),
      ( 441, 1080.81059340839, 3285492.72871258, 63409.0660893209, 66448.9074350202, 254.791185717484, 129.704507103644, 150.730660951195, 137.160209116832 ),
      ( 460, 1000.64667078327, 3285492.72871235, 66022.5655238125, 69305.9349934181, 261.134109792269, 131.681905771965, 150.179957554744, 144.148751648357 ),
      ( 479, 935.247151888867, 3285492.72871233, 68647.5334472517, 72160.5008185789, 267.214922650517, 133.647993687704, 150.391482560565, 150.387971507246 ),
      ( 498, 880.297437300698, 3285492.72871231, 71291.1377338276, 75023.3907082164, 273.076155606419, 135.557371858275, 151.015315346235, 156.061969002406 ),
      ( 517, 833.121494876893, 3285492.72871231, 73956.9089908752, 77900.5027511079, 278.745904673931, 137.387797494271, 151.865847998891, 161.293222371195 ),
      ( 536, 791.946627152611, 3285492.72871231, 76646.4206097615, 80795.0495906375, 284.244110686874, 139.128984910919, 152.837202965896, 166.167578782039 ),
      ( 194, 11020.5149526033, 10000000.0000019, 19081.5500877613, 19988.948702346, 103.509105731532, 89.6833933303735, 134.070539118623, 846.18133086711 ),
      ( 213, 10651.1081865189, 10000000.0000004, 21625.0464529827, 22563.9158950054, 116.16951285452, 93.1434444618143, 137.093208896306, 764.083817288496 ),
      ( 232, 10276.2289311683, 9999999.99999899, 24229.4319328018, 25202.5515535285, 128.033534894873, 96.7379100270865, 140.757400670527, 688.448417139513 ),
      ( 251, 9891.23108754317, 9999999.99999976, 26905.2352147843, 27916.2317137533, 139.273927022174, 100.439897360522, 144.980567832083, 617.90718252473 ),
      ( 270, 9491.18202167814, 9999999.99999991, 29661.3785300684, 30714.9880780846, 150.020383806819, 104.202554399266, 149.706438305326, 551.523705851414 ),
      ( 289, 9070.45423070929, 9999999.99999997, 32505.6759654168, 33608.1565849809, 160.37359313266, 107.977498955028, 154.920550280232, 488.642576083614 ),
      ( 308, 8622.23647568163, 9999999.99999997, 35445.5222305475, 36605.3141277199, 170.415774306321, 111.724418434156, 160.66522893741, 428.824827636766 ),
      ( 327, 8137.92337184569, 9999999.99999481, 38488.6786586123, 39717.4933749797, 180.218934471336, 115.414745378615, 167.053128900134, 371.851767763541 ),
      ( 346, 7606.49390423517, 9999999.99999967, 41643.865834431, 42958.5319770584, 189.851195235167, 119.030253474451, 174.26161236677, 317.833640921965 ),
      ( 365, 7014.73096592884, 10000000, 44919.9501795836, 46345.5216018621, 199.378918480804, 122.551570023015, 182.415242265488, 267.536033995757 ),
      ( 384, 6351.93761878337, 9999999.99999995, 48319.3262100722, 49893.6489758419, 208.853400170195, 125.918125450965, 191.028381307371, 223.046455757284 ),
      ( 403, 5628.39515877798, 10000000.0000002, 51815.6074699616, 53592.312857181, 218.253331385671, 128.947203675887, 197.599618550686, 188.236082348614 ),
      ( 422, 4904.63590245695, 9999999.99999999, 55321.8937809766, 57360.7811110209, 227.390596226708, 131.372171923288, 197.758761927483, 166.691565919196 ),
      ( 441, 4269.9046414371, 10000000, 58722.2746991414, 61064.2473752887, 235.975803594697, 133.207151312628, 191.3727250671, 157.473835176081 ),
      ( 460, 3764.78861524072, 10000000, 61967.835936232, 64624.0275639685, 243.879998213837, 134.774826824295, 183.46391293341, 155.931535779553 ),
      ( 479, 3374.09467785444, 9999999.99999999, 65082.782289815, 68046.5402618821, 251.171553768319, 136.297015397816, 177.142503278426, 158.084299153095 ),
      ( 498, 3068.46097712638, 9999999.99998857, 68108.8715137702, 71367.8342558526, 257.971927335858, 137.824422796303, 172.757663301989, 161.849368226782 ),
      ( 517, 2823.8546890082, 9999999.99999767, 71079.4512861066, 74620.7099914226, 264.382621810979, 139.343688218356, 169.85582582559, 166.289273001569 ),
      ( 536, 2623.52743138094, 9999999.99999937, 74017.1774366546, 77828.8395067309, 270.476799512215, 140.833030588924, 167.982433584664, 170.978040908612 ),
      };

      // TestData contains:
      // 0. Temperature (Kelvin)
      // 1. Pressure (Pa)
      // 2. Saturated liquid density (mol/m³
      // 3. Saturated vapor density (mol/m³)
      _testDataSaturatedProperties = new (double temperature, double pressure, double saturatedLiquidMoleDensity, double saturatedVaporMoleDensity)[]
      {
      ( 196.16875, 12715.2915097689, 10830.2559129648, 7.86625962437175 ),
      ( 218.5875, 48233.9709299883, 10352.7947387729, 27.2135546509132 ),
      ( 241.00625, 137539.511740923, 9850.79875412753, 72.5051113530673 ),
      ( 263.425, 320488.708448943, 9308.28684270705, 162.145642981963 ),
      ( 285.84375, 645306.525254097, 8701.21269019897, 323.449268596772 ),
      ( 308.2625, 1167403.89819906, 7984.92223902415, 605.57416303758 ),
      ( 330.68125, 1954490.49940248, 7042.44568561168, 1137.42757399256 ),
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
