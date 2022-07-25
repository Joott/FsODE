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
  /// Tests and test data for <see cref="Cyclopropane"/>.
  /// </summary>
  /// <remarks>
  /// <para>Reference:</para>
  /// <para>The test data was created automatically using calls into the TREND.DLL of the following software:</para>
  /// <para>TREND 3.0.: Span, R.; Eckermann, T.; Herrig, S.; Hielscher, S.; Jäger, A.; Thol, M. (2016): TREND.Thermodynamic Reference and Engineering Data 3.0.Lehrstuhl für Thermodynamik, Ruhr-Universität Bochum.</para>
  /// </remarks>
  
  public class Test_Cyclopropane : FluidTestBase
  {

    public Test_Cyclopropane()
    {
      _fluid = Cyclopropane.Instance;

      _testDataMolecularWeight = 0.042081;

      _testDataTriplePointTemperature = 145.7;

      _testDataTriplePointPressure = 342710;

      _testDataTriplePointLiquidMoleDensity = double.NaN;

      _testDataTriplePointVaporMoleDensity = double.NaN;

      _testDataCriticalPointTemperature = 398.3;

      _testDataCriticalPointPressure = 5568853.07419068;

      _testDataCriticalPointMoleDensity = 6142.9149;

      _testDataNormalBoilingPointTemperature = 241.67;

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
      ( 275, 0.437453806111316, 1000, 25389.8472498074, 27675.8029005065, 160.52649436042, 8.50124199929131, 16.823934075622, 327.844696379531 ),
      ( 285, 0.42209444636581, 1000, 25476.8221342443, 27845.960152074, 161.134222510472, 8.88719580495765, 17.2088804817981, 330.145960923257 ),
      ( 295, 0.407777835878102, 1000, 25567.6893737454, 28020.0051006328, 161.734398100739, 9.28038369307452, 17.6012071412505, 332.428124543672 ),
      ( 305, 0.394401168931192, 1000, 25662.5142697887, 28198.0037124543, 162.327744879736, 9.67927898177727, 17.9993620741576, 334.705665988675 ),
      ( 315, 0.381874740567946, 1000, 25761.3471708204, 28380.0068876499, 162.914867903724, 10.0824402101671, 18.4018836014513, 336.989390417475 ),
      ( 325, 0.370119921151232, 1000, 25864.2243413213, 28566.0513515767, 163.49627116674, 10.4885100858653, 18.8073981371543, 339.287175040694 ),
      ( 335, 0.359067496063335, 1000, 25971.1688168291, 28756.1605272, 164.072372500304, 10.8962147150786, 19.2146185550476, 341.604582014895 ),
      ( 345, 0.348656295838815, 1000, 26082.1912485509, 28950.3453932915, 164.643516239245, 11.3043630328359, 19.6223429667015, 343.945356638047 ),
      ( 355, 0.338832059034899, 999.999999999999, 26197.2907401754, 29148.6053319774, 165.209984046873, 11.7118463767766, 20.0294537976865, 346.31182859014 ),
      ( 365, 0.329546482906338, 1000, 26316.4556787811, 29350.9289681963, 165.772004213525, 12.1176381650842, 20.4349170823802, 348.70523253355 ),
      ( 375, 0.320756426617011, 999.999999999999, 26439.6645612311, 29557.2950029557, 166.329759681279, 12.5207936507878, 20.837781920716, 351.125962455787 ),
      ( 385, 0.312423239103703, 1000, 26566.8868170869, 29767.6730417892, 166.883394999759, 12.9204497326372, 21.2371800560976, 353.573772078444 ),
      ( 395, 0.304512189393072, 1000, 26698.0836288162, 29982.0244194726, 167.433022380241, 13.3158248082885, 21.6323255448132, 356.04793168171 ),
      ( 405, 0.29699198158468, 1000, 26833.2087498774, 30200.3030217976, 167.978726985396, 13.7062186594239, 22.0225144951567, 358.547349908976 ),
      ( 415, 0.289834340160829, 1000, 26972.2093211287, 30422.456105016, 168.520571568036, 14.0910123611775, 22.4071248600881, 361.07066756232 ),
      ( 425, 0.283013653996809, 999.999999999999, 27115.0266859033, 30648.4251134268, 169.058600553052, 14.469668210215, 22.7856162713417, 363.616329081189 ),
      ( 435, 0.276506669593251, 1000, 27261.5972040173, 30878.1464954721, 169.592843641086, 14.8417296672374, 23.1575299058525, 366.182636298295 ),
      ( 445, 0.270292225763491, 999.999999999998, 27411.8530649165, 31111.5525186293, 170.123318999856, 15.2068213107223, 23.5224883775612, 368.767788164147 ),
      ( 455, 0.264351023379834, 1000, 27565.7231001271, 31348.5720833261, 170.650036098621, 15.5646487994774, 23.8801956492792, 371.369909397853 ),
      ( 465, 0.258665424886948, 1000, 27723.1335951364, 31589.1315360559, 171.172998232728, 15.9149988421542, 24.2304369605073, 373.987070430203 ),
      ( 275, 4.38278326290066, 10000.0000000184, 25379.4426872569, 27661.0978365467, 141.344258615267, 8.56074798053772, 16.9595565706873, 327.399671644396 ),
      ( 285, 4.22798354011627, 10000.0000000128, 25467.3360152609, 27832.5297075093, 141.956541149864, 8.94001825211459, 17.328615165918, 329.761859148371 ),
      ( 295, 4.08382422364847, 10000.000000009, 25559.0173480009, 28007.7025637115, 142.560607803131, 9.32752551956921, 17.7074079201768, 332.093063980205 ),
      ( 305, 3.94923420404162, 10000.0000000064, 25654.5672280108, 28186.7037089955, 143.157297744041, 9.72155736711165, 18.0939595417641, 334.410404401327 ),
      ( 315, 3.82328313349325, 10000.0000000046, 25754.0485271884, 28369.6016135924, 143.747308109874, 10.1205269232571, 18.4864740476144, 336.726689498344 ),
      ( 325, 3.70515873298945, 10000.0000000034, 25857.5078835533, 28556.4475837521, 144.331216989809, 10.5229618949847, 18.8833112973148, 339.051326359519 ),
      ( 335, 3.59414841536327, 10000.0000000025, 25964.976989221, 28747.2772295943, 144.909502312153, 10.927496578924, 19.282969743312, 341.391051843619 ),
      ( 345, 3.48962428176734, 10000.0000000019, 26076.4737687478, 28942.1117837771, 145.482557513402, 11.3328659712201, 19.6840735981496, 343.750518567453 ),
      ( 355, 3.39103078067557, 10000.0000000014, 26192.0034757516, 29140.9593085881, 146.050704648718, 11.7379013758573, 20.0853631812348, 346.132761236601 ),
      ( 365, 3.29787448710096, 10000.0000000011, 26311.5597279463, 29343.8158186843, 146.614205446178, 12.1415270957252, 20.4856875820769, 348.539565705916 ),
      ( 375, 3.20971558400368, 10000.0000000008, 26435.1254952953, 29550.6663394243, 147.173270692368, 12.5427579148522, 20.8839990302648, 350.971759559664 ),
      ( 385, 3.126160720593, 10000.0000000007, 26562.6740521375, 29761.4859155607, 147.728068251811, 12.9406971648559, 21.2793485361924, 353.429439741637 ),
      ( 395, 3.04685699216449, 10000.0000000005, 26694.1699013838, 29976.2405813393, 148.278729958851, 13.3345352270887, 21.6708824872445, 355.91214992397 ),
      ( 405, 2.9714868393914, 10000.0000000004, 26829.5696768796, 30194.8883003498, 148.825357572081, 13.7235483627595, 22.0578399690252, 358.419017891328 ),
      ( 415, 2.89976370594993, 10000.0000000003, 26968.8230285653, 30417.3798814846, 149.368027944068, 14.1070977921287, 22.439550641546, 360.948861208657 ),
      ( 425, 2.83142832511938, 10000.0000000002, 27111.8734939858, 30643.6598758921, 149.90679753016, 14.4846289644384, 22.8154330436603, 363.500267791641 ),
      ( 435, 2.76624553082159, 10000.0000000002, 27258.6593588918, 30873.667458708, 150.441706337445, 14.8556709750605, 23.1849932305004, 366.071656659703 ),
      ( 445, 2.70400150810919, 10000.0000000002, 27409.1145090655, 31107.3372985168, 150.97278139692, 15.2198360971245, 23.5478236717365, 368.661323072495 ),
      ( 455, 2.64450141360765, 10000.0000000001, 27563.1692750467, 31344.6004168656, 151.500039827658, 15.5768194028033, 23.903602355517, 371.267471387596 ),
      ( 465, 2.58756730878083, 10000.0000000001, 27720.7512710781, 31585.3850396628, 152.023491550171, 15.926398455288, 24.252092055663, 373.888238290158 ),
      ( 275, 44.6880489464715, 100000, 25272.8232076787, 27510.5579568458, 121.810300060663, 9.17894609728058, 18.4017792739406, 322.937507278546 ),
      ( 285, 43.0101515882448, 100000, 25370.452362533, 27695.4848561951, 122.470803373518, 9.48549184657887, 18.5908585830258, 325.90736161353 ),
      ( 295, 41.4626001029073, 100000, 25470.6927170534, 27882.5048019638, 123.11574104088, 9.81192689451236, 18.8189125702062, 328.729428209681 ),
      ( 305, 40.0295590168718, 99999.9999999999, 25573.8126415891, 28071.9665672382, 123.747314738422, 10.1542004741425, 19.0780570494419, 331.446125672554 ),
      ( 315, 38.6978472537837, 100000.000049967, 25680.0254279748, 28264.1485031981, 124.367285597973, 10.5089430183493, 19.3620086007885, 334.089719824459 ),
      ( 325, 37.4563716660389, 100000.000036125, 25789.4995929443, 28459.2723335537, 124.97707247912, 10.8733046800593, 19.665667980672, 336.684617556838 ),
      ( 335, 36.295706016071, 100000.000026465, 25902.3666191707, 28657.5134671804, 125.577824733747, 11.2448421113878, 19.9848314975849, 339.24915918928 ),
      ( 345, 35.2077720190842, 100000.000019631, 26018.7269086442, 28859.0088772228, 126.170477142219, 11.6214377628638, 20.3159871437844, 341.797010733356 ),
      ( 355, 34.1855940855887, 100000.000014736, 26138.6544647193, 29063.8632460665, 126.755792013644, 12.0012414975122, 20.6561680897563, 344.338241226174 ),
      ( 365, 33.2231079329058, 100000.000011187, 26262.2006558433, 29272.1538550785, 127.334391950436, 12.3826277641626, 21.0028457434098, 346.880154351613 ),
      ( 375, 32.3150093407178, 100000.000008585, 26389.3973057937, 29483.9345517596, 127.906785687213, 12.7641637836528, 21.3538505767433, 349.427929384181 ),
      ( 385, 31.4566332557506, 100000.000006657, 26520.2592832944, 29699.2390295893, 128.473388717975, 13.1445856376083, 21.7073127483793, 351.985114637912 ),
      ( 395, 30.6438561517651, 100000.000005214, 26654.7867148733, 29918.0835894559, 129.034539947255, 13.5227801004361, 22.0616170426885, 354.554007011574 ),
      ( 405, 29.8730164283851, 100000.000004122, 26792.966910937, 30140.4695055897, 129.590515269529, 13.8977706947823, 22.4153682999042, 357.135943622073 ),
      ( 415, 29.1408489591558, 100000.00000329, 26934.7760712481, 30366.3850866015, 130.141538747776, 14.2687068871972, 22.7673646275412, 359.731525576173 ),
      ( 425, 28.4444308515317, 100000.000002649, 27080.1808190601, 30595.8074991863, 130.687791895313, 14.6348556427189, 23.1165764482612, 362.340789324294 ),
      ( 435, 27.7811361746439, 100000.000002152, 27229.1396009662, 30828.704405426, 131.229421444198, 14.9955947685974, 23.4621299710576, 364.963337488121 ),
      ( 445, 27.1485979217931, 100000.000001763, 27381.6039806157, 31065.0354524668, 131.766545894873, 15.3504076273275, 23.8032940472456, 367.598438323723 ),
      ( 455, 26.5446758560068, 100000.000001456, 27537.5198478949, 31304.7536443786, 132.299261075866, 15.698878906606, 24.1394696399319, 370.245100887434 ),
      ( 465, 25.967429174761, 100000.000001211, 27696.8285602776, 31547.8066192995, 132.82764489299, 16.0406912116461, 24.4701813283916, 372.902131366525 ),
      ( 275, 45.29351623688, 101325, 25271.2170266523, 27508.292184829, 121.69496655801, 9.18837555918243, 18.4242626560788, 322.871581151186 ),
      ( 285, 43.5913113385649, 101325, 25368.9974981382, 27693.4286035259, 122.356218548815, 9.49376575142324, 18.6103770016498, 325.850385297608 ),
      ( 295, 42.0215767571787, 101325, 25469.3698646404, 27880.6311218156, 123.001786081315, 9.81924064841724, 18.8359844973001, 328.679700162091 ),
      ( 305, 40.5681779882211, 101325, 25572.6058039945, 28070.2530986159, 123.633894055735, 10.1607078217866, 19.0930871117054, 331.402305627539 ),
      ( 315, 39.2176930342145, 101325, 25678.9212024868, 28262.576490716, 124.254321418307, 10.51476657823, 19.3753173901457, 334.050748178194 ),
      ( 325, 37.9588318777113, 101325.000038119, 25788.4866412905, 28457.8258971598, 124.864500871547, 10.8785434467837, 19.6775129177679, 336.64965273731 ),
      ( 335, 36.7820051667971, 101325.000027922, 25901.4352672261, 28656.1790493673, 125.465592698424, 11.2495768901702, 19.9954217352864, 339.217529281552 ),
      ( 345, 35.6789981046279, 101325.000020709, 26017.8688387626, 28857.7748171641, 126.058540376121, 11.625735172775, 20.3254944207404, 341.768176189117 ),
      ( 355, 34.642719631302, 101325.000015543, 26137.8624764335, 29062.7194476509, 126.644113219494, 12.0051569612647, 20.6647347623293, 344.311766149525 ),
      ( 365, 33.6670069357381, 101325.000011799, 26261.4684772355, 29271.091524666, 127.22293952368, 12.3862077717883, 21.0105908216589, 346.855684361043 ),
      ( 375, 32.7464710539416, 101325.000009054, 26388.7194431484, 29482.9459887248, 127.795532687798, 12.7674476273909, 21.3608743225029, 349.405174509689 ),
      ( 385, 31.8763735211966, 101325.00000702, 26519.6309000298, 29698.317457321, 128.362312056947, 13.1476067566191, 21.7137002217767, 351.963836069249 ),
      ( 395, 31.0525268033879, 101325.000005498, 26654.203533133, 29917.2230177323, 128.923619737334, 13.525567134031, 22.0674408688297, 354.53400679384 ),
      ( 405, 30.2712131619733, 101325.000004347, 26792.4251309131, 30139.6646175561, 129.479734302193, 13.9003483153718, 22.4206908497817, 357.117056610832 ),
      ( 415, 29.5291179696112, 101325.000003469, 26934.2723045177, 30365.6311452303, 130.030882068935, 14.2710964649786, 22.7722397537162, 359.713613129128 ),
      ( 425, 28.8232744705582, 101325.000002793, 27079.7120331028, 30595.1002693107, 130.577246458503, 14.6370757805467, 23.1210508784465, 362.323734331695 ),
      ( 435, 28.1510176906666, 101325.000002269, 27228.7030726754, 30828.0400883266, 131.118975825264, 14.9976617357608, 23.4662444361823, 364.947040438914 ),
      ( 445, 27.5099457255076, 101325.000001858, 27381.1972571063, 31064.4106306575, 131.656190055786, 15.3523357139127, 23.8070842015063, 367.582814176095 ),
      ( 455, 26.8978870257069, 101325.000001534, 27537.1407132704, 31304.1652347392, 132.188986168099, 15.7006807149592, 24.142966816462, 370.230076566685 ),
      ( 465, 26.3128725930872, 101325.000001277, 27696.4750073016, 31547.251833086, 132.717443092957, 16.0423778976361, 24.4734131639732, 372.88764375429 ),
      ( 275, 15533.0623608185, 514065.000022, 8520.8356527929, 8553.93054342558, 42.5437581439335, 38.3360345922723, 71.0981321290897, 1042.51010043736 ),
      ( 284.991698904268, 15184.6935105665, 514065.000011912, 9188.17258359787, 9222.02674072354, 44.9309215849723, 28.9523238157067, 63.3813830682894, 1068.10162271193 ),
      ( 300, 225.655147982108, 514065.000000002, 25093.4446887289, 27371.5447214423, 108.363377041126, 12.4020609983842, 25.1043051655496, 315.053219574859 ),
      ( 350, 185.892148959508, 514065, 25809.5617783361, 28574.9555987711, 112.076363375776, 13.1594782345446, 23.6017749333859, 334.318485776119 ),
      ( 400, 159.663806455797, 514065.000000001, 26543.1409473639, 29762.8124020985, 115.247958693124, 14.5689643686199, 24.0775651558201, 349.765864655669 ),
      ( 450, 140.525434232401, 514065.000000001, 27334.0861850013, 30992.2495830224, 118.142850465659, 16.1154281794906, 25.1493600583119, 364.16990258016 ),
      ( 275, 15552.6631971068, 1000000.00002351, 8502.07224869643, 8566.36991832059, 42.4753043860123, 38.3350038396278, 70.9417722658812, 1046.91491111247 ),
      ( 300, 14655.8361053171, 999999.999999032, 10068.3025825548, 10136.5347866278, 47.9479639495473, 21.2213266542983, 58.3940967519386, 1092.3178211538 ),
      ( 309.615084707222, 14277.5446501832, 999999.999999406, 10626.392492891, 10696.432547011, 49.7850043437191, 18.9073672849008, 58.4065798510356, 1076.37194107524 ),
      ( 325, 427.413432164781, 1000000.00000008, 24999.1907139201, 27338.8457756135, 103.330874384603, 15.1409947956487, 31.1163876173613, 311.330640891751 ),
      ( 375, 348.176687051674, 1000000, 25893.3937786841, 28765.4987678719, 107.42073555931, 15.1809414437325, 27.0193278992669, 333.668783319867 ),
      ( 425, 298.52797193847, 999999.999999999, 26745.8919592672, 30095.6618100003, 110.751169553118, 16.2036594318175, 26.4684986837821, 350.837956007452 ),
      ( 275, 15567.9069571987, 1381485.30108669, 8487.48536829459, 8576.22467698168, 42.4219886481516, 38.3344284968398, 70.8217207290982, 1050.33418857267 ),
      ( 300, 14676.6122020247, 1381485.30106391, 10048.1753985264, 10142.3037492689, 47.8804901179655, 21.2111960841337, 58.1734118799769, 1097.36335052279 ),
      ( 323.244852726695, 13724.8079214147, 1381485.30106206, 11408.0089166981, 11508.6649921034, 52.2657981363299, 17.8019912484798, 61.159401433639, 1015.65859157787 ),
      ( 325, 637.50407546846, 1381485.30106768, 24570.4489631313, 26737.4708759756, 99.2329748232911, 17.6015488250777, 40.0769374423063, 298.687436731312 ),
      ( 375, 498.830999956114, 1381485.30106402, 25657.1017381973, 28426.547304302, 104.08323867771, 16.3417829019894, 30.1647786883972, 326.691378526144 ),
      ( 425, 421.590341195758, 1381485.301064, 26593.5652878241, 29870.4081517893, 107.700207835731, 16.9090157522878, 28.1153066194207, 345.996849918791 ),
      ( 285, 15412.6003797307, 5847295.72789899, 8969.06607186047, 9348.45018510776, 44.1514814587576, 28.9109474505692, 61.4829244831645, 1120.34538989209 ),
      ( 295, 15075.9412505444, 5847295.72789876, 9551.02076086081, 9938.87685758629, 46.1880681445526, 23.0655145763277, 57.1213627187146, 1145.49130911592 ),
      ( 305, 14725.7282243265, 5847295.72790035, 10102.6043913242, 10499.6846333893, 48.0577578112836, 19.6988295591939, 55.4135240598522, 1151.40341747994 ),
      ( 315, 14359.2809807229, 5847295.72790051, 10646.3573876697, 11053.5710730729, 49.844622963964, 18.0384155304639, 55.641398303474, 1130.71689407561 ),
      ( 325, 13973.0462919419, 5847295.72789957, 11198.9537959573, 11617.4234414255, 51.6066657916056, 17.544465143703, 57.3494807756994, 1083.94642392877 ),
      ( 335, 13562.1357438582, 5847295.72789978, 11773.5167521313, 12204.6653439413, 53.3860974629476, 17.841775212626, 60.2956049516604, 1017.16967378299 ),
      ( 345, 13119.5170731864, 5847295.72790069, 12381.6202312028, 12827.3146645636, 55.2172522975762, 18.673936965139, 64.4437525777425, 937.438080967282 ),
      ( 355, 12634.4676602131, 5847295.72789987, 13035.452444897, 13498.2575179048, 57.1339836644416, 19.874013155905, 70.0212724158564, 849.779341882 ),
      ( 365, 12089.2542158528, 5847295.72789933, 13751.0453762649, 14234.7225017101, 59.1793576938507, 21.3500612515525, 77.7268636863208, 756.34395974738 ),
      ( 375, 11450.7195715881, 5847295.72790017, 14555.1474663085, 15065.7962243489, 61.4249318594838, 23.0919813734364, 89.441098208571, 656.320351114351 ),
      ( 385, 10642.3761249097, 5847295.72790032, 15506.5467441436, 16055.9819134395, 64.0295864673591, 25.2397137856505, 111.453625109765, 544.82037688895 ),
      ( 395, 9380.22286832789, 5847295.7279002, 16818.5994035237, 17441.9636678893, 67.5797735678155, 28.5538309268428, 186.700961070905, 404.608181264854 ),
      ( 405, 3940.96484166164, 5847295.72790025, 21795.4520200549, 23279.1738909242, 82.1404635888368, 34.2306598133725, 310.145397948774, 255.436340916577 ),
      ( 415, 3040.26800250209, 5847295.72790021, 23143.8618313834, 25067.1448192937, 86.5097042583946, 30.2910989405362, 120.337662923555, 275.338153344683 ),
      ( 425, 2666.73854422544, 5847295.72790021, 23871.6367557595, 26064.3135521263, 88.8856627771754, 28.2091489973623, 84.8718981732084, 288.081308228235 ),
      ( 435, 2429.70711206594, 5847295.72790022, 24418.8539499862, 26825.4385538928, 90.6565083239293, 26.8488403143009, 69.0177633804127, 297.955598499856 ),
      ( 445, 2257.02539945281, 5847295.7279002, 24875.6198098407, 27466.3286823761, 92.1135309114746, 25.8899515860286, 59.8770921368174, 306.182118844796 ),
      ( 455, 2121.87413633056, 5847295.72793501, 25277.6196076153, 28033.3418381747, 93.3738570301289, 25.1882049473581, 53.9036513687529, 313.318990569663 ),
      ( 465, 2011.28711514155, 5847295.72791177, 25642.983203097, 28550.2238868818, 94.4977231649195, 24.6644387427978, 49.698283203704, 319.677168598229 ),
      ( 285, 15572.9659176897, 10000000.0000011, 8815.33060232859, 9457.46903972424, 43.5935665730841, 28.910140874469, 60.3246692586818, 1156.32648064649 ),
      ( 295, 15253.4806650323, 10000000.0000008, 9379.53868404136, 10035.1267573213, 45.5861425062311, 23.041045580032, 55.7155768259746, 1186.4908714025 ),
      ( 305, 14923.8151430775, 9999999.99999919, 9910.27295391111, 10580.3428994396, 47.4038849492133, 19.6473599891194, 53.6863849169481, 1198.31273880254 ),
      ( 315, 14582.3651299449, 10000000.0000002, 10429.1651135562, 11114.9249276117, 49.1285094365019, 17.9539962446619, 53.4863076321536, 1184.25628155504 ),
      ( 325, 14227.1461808259, 10000000.0000001, 10951.572635468, 11654.4542867072, 50.8145842997879, 17.4174700639935, 54.607638531944, 1144.74845104685 ),
      ( 335, 13855.6502010836, 9999999.99999968, 11488.6409627341, 12210.368189885, 52.4991389240374, 17.6569927364558, 56.7206095392958, 1086.03975503981 ),
      ( 345, 13464.6397183373, 10000000.0000006, 12048.8307918249, 12791.5168353573, 54.2083129023287, 18.4070490232706, 59.6324652871859, 1015.67532299889 ),
      ( 355, 13049.8391528786, 10000000.0000002, 12639.1175890326, 13405.4105588424, 55.9621671837062, 19.4846972723695, 63.2659048192252, 939.530604534338 ),
      ( 365, 12605.4520376103, 9999999.99999957, 13266.0359142618, 14059.3434426363, 57.778482122961, 20.7671738505652, 67.6561926730255, 861.134145945472 ),
      ( 375, 12123.3753096197, 10000000.0000004, 13936.7448119284, 14761.5976061883, 59.6762587153444, 22.1769753952773, 72.9715216767365, 782.152232527055 ),
      ( 385, 11591.8719094836, 10000000.0000015, 14660.3438858226, 15523.0173244257, 61.6797303349304, 23.6727187802174, 79.5698022334448, 703.094203306387 ),
      ( 395, 10993.2726088107, 9999999.99999989, 15449.7911168464, 16359.4383489168, 63.824049893007, 25.2447704508076, 88.1185924684837, 623.924199665762 ),
      ( 405, 10300.1141629924, 9999999.99999999, 16324.8998155334, 17295.7628411034, 66.1643761714228, 26.9138403451455, 99.8046279034752, 544.693622096719 ),
      ( 415, 9470.37687638425, 9999999.99999993, 17316.1293927054, 18372.0535793063, 68.7887825530147, 28.7212416253627, 116.437091681006, 466.726269082978 ),
      ( 425, 8454.65702952539, 10000000, 18460.9473056365, 19643.7273953644, 71.8156713257591, 30.6466725125412, 138.497025569673, 395.474753863327 ),
      ( 435, 7272.87958448718, 9999999.99999794, 19753.0717736725, 21128.0429778332, 75.2669257420394, 32.2925373151695, 155.754061250648, 343.29783538823 ),
      ( 445, 6136.03843249852, 9999999.99999996, 21045.6478616661, 22675.3638600269, 78.7840023006224, 32.8460180050184, 149.239275632789, 318.354699737979 ),
      ( 455, 5259.10936133461, 10000000, 22152.9641807203, 24054.4268263768, 81.8497013674075, 32.2916431394155, 125.571957078024, 312.125652590676 ),
      ( 465, 4643.22486746384, 10000000, 23039.0136825536, 25192.6892605064, 84.3251717043923, 31.3237684518429, 103.053830323874, 313.719883659752 ),
      };

      // TestData contains:
      // 0. Temperature (Kelvin)
      // 1. Pressure (Pa)
      // 2. Saturated liquid density (mol/m³
      // 3. Saturated vapor density (mol/m³)
      _testDataSaturatedProperties = new (double temperature, double pressure, double saturatedLiquidMoleDensity, double saturatedVaporMoleDensity)[]
      {
      ( 303.575, 836508.536094324, 14508.3815949483, 386.999247018509 ),
      ( 335.15, 1755844.28709145, 13197.1237818659, 823.867359581565 ),
      ( 366.725, 3257735.29181098, 11479.7661655092, 1686.3818301681 ),
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