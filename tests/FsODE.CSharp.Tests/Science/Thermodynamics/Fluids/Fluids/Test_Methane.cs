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
  /// Tests and test data for <see cref="Methane"/>.
  /// </summary>
  /// <remarks>
  /// <para>Reference:</para>
  /// <para>The test data was created automatically using calls into the TREND.DLL of the following software:</para>
  /// <para>TREND 3.0.: Span, R.; Eckermann, T.; Herrig, S.; Hielscher, S.; Jäger, A.; Thol, M. (2016): TREND.Thermodynamic Reference and Engineering Data 3.0.Lehrstuhl für Thermodynamik, Ruhr-Universität Bochum.</para>
  /// </remarks>
  
  public class Test_Methane : FluidTestBase
  {

    public Test_Methane()
    {
      _fluid = Methane.Instance;

      _testDataMolecularWeight = 0.0160428;

      _testDataTriplePointTemperature = 90.6941;

      _testDataTriplePointPressure = 11696;

      _testDataTriplePointLiquidMoleDensity = 28141.9147926592;

      _testDataTriplePointVaporMoleDensity = 15.6296918097174;

      _testDataCriticalPointTemperature = 190.564;

      _testDataCriticalPointPressure = 4599200.08935367;

      _testDataCriticalPointMoleDensity = 10139.128;

      _testDataNormalBoilingPointTemperature = 111.667205473581;

      _testDataNormalSublimationPointTemperature = null;

      _testDataIsMeltingCurveImplemented = true;

      _testDataIsSublimationCurveImplemented = true;

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
      ( 90.6941, 1.32697500150429, 1000.00000000006, 6842.64905640037, 7596.24275550279, 105.461454574019, 24.9815117962446, 33.319391458419, 250.223588718125 ),
      ( 100, 1.20328517009508, 1000.00000000002, 7075.17691114652, 7906.23510487545, 108.715250668748, 24.9743620164763, 33.305057912645, 262.773046030832 ),
      ( 127, 0.947241789738489, 1000, 7749.57937536425, 8805.27604207918, 116.67403365483, 24.9739038827122, 33.2957152766014, 296.162329408102 ),
      ( 154, 0.781089682047614, 1000, 8424.18247717496, 9704.44519601989, 123.09356081145, 24.9966459175737, 33.3153055030283, 326.10792360359 ),
      ( 181, 0.664540378676381, 1000, 9100.02025852357, 10604.8197140386, 128.480449441123, 25.0762188443444, 33.393402508029, 353.411138104295 ),
      ( 208, 0.578261523518061, 1000, 9779.4370968888, 11508.7584494771, 133.135119935029, 25.2739460987812, 33.5903182128483, 378.491519339047 ),
      ( 235, 0.511814031485353, 1000, 10466.4860004726, 12420.3206718236, 137.255166766189, 25.6509537508189, 33.9668314962628, 401.57921428228 ),
      ( 262, 0.459064615971036, 999.999999999999, 11166.5951113144, 13344.9376914428, 140.979041653822, 26.2456769366934, 34.5612314378409, 422.846592472637 ),
      ( 289, 0.41617300569315, 1000, 11885.8262326912, 14288.6730928197, 144.406666604766, 27.0667879629234, 35.3821198213906, 442.478650561647 ),
      ( 316, 0.380611847013615, 999.999999999999, 12630.1224467136, 15257.4710377947, 147.610747672398, 28.0983333738998, 36.4135056159493, 460.687795655267 ),
      ( 343, 0.350649766994719, 999.999999999999, 13404.7728181592, 16256.6212838537, 150.644090112459, 29.3095366609867, 37.6245907617159, 477.696860076976 ),
      ( 370, 0.325060864953839, 999.999999999999, 14214.140675862, 17290.4876244311, 153.544875309647, 30.6639326903344, 38.978897035956, 493.715637880325 ),
      ( 397, 0.302952787263044, 999.999999999999, 15061.6026780413, 18362.4470407364, 156.340626967031, 32.1257122793329, 40.4406069333726, 508.925051424266 ),
      ( 424, 0.283660525691656, 1000.00006410507, 15949.6192221494, 19474.9601615231, 159.051190963238, 33.663193461125, 41.9780329917326, 523.471651211736 ),
      ( 451, 0.266678279245017, 1000.00003819182, 16879.8676825394, 20629.7045309805, 161.690941038542, 35.2501497306792, 43.5649449608749, 537.469456027193 ),
      ( 478, 0.251614601711817, 1000.00001792449, 17853.3920862752, 21827.7243035677, 164.270372469633, 36.8658280105599, 45.1805871414896, 551.005258118024 ),
      ( 505, 0.238161745604246, 1000.00000193379, 18870.7431895843, 23069.5703328632, 166.797243557496, 38.4943092920425, 46.8090386460768, 564.144667645707 ),
      ( 532, 0.22607444282713, 999.999989226712, 19932.0974149657, 24355.4191169741, 169.277375720294, 40.1236355502651, 48.4383400758824, 576.937519316397 ),
      ( 559, 0.215154814470386, 999.999979071132, 21037.3518808053, 25685.167833856, 171.715212016752, 41.7449391143373, 50.0596227371742, 589.422179337439 ),
      ( 586, 0.205241452704082, 999.999970919245, 22186.1972919856, 27058.5072359278, 174.114205051067, 43.3516842123345, 51.6663500843166, 601.628759729764 ),
      ( 613, 0.196201388292542, 999.99996435572, 23378.1723140248, 28474.9760270785, 176.477086473419, 44.9390556477232, 53.2537063271126, 613.581426975016 ),
      ( 90.6941, 13.3480915116567, 10000.0000005963, 6832.87452279973, 7582.04529315767, 86.2083761295375, 25.19870462213, 33.7610763933583, 249.304243763705 ),
      ( 100, 12.0847499019353, 10000.0000002267, 7067.79481297612, 7895.28401063219, 89.4963788116897, 25.0979217402664, 33.5798821410922, 262.068668111241 ),
      ( 127, 9.49239056104078, 10000.0000000259, 7745.39241749706, 8798.8678234784, 97.4961712833413, 25.0098084693195, 33.3980682299931, 295.779568095091 ),
      ( 154, 7.82035462751062, 10000.0000000049, 8421.30292119748, 9700.01731156881, 103.929988689562, 25.0116733011144, 33.3678642342137, 325.87214777561 ),
      ( 181, 6.65045269562509, 10000.0000000012, 9097.84105398934, 10601.4980917395, 109.323540644469, 25.0840407170383, 33.4253529669206, 353.256551439709 ),
      ( 208, 5.78552865706628, 10000.0000000003, 9777.69346235708, 11506.1439796294, 113.981869531853, 25.2786281543439, 33.6117873513941, 378.386716089273 ),
      ( 235, 5.11991360270249, 10000.0000000001, 10465.0392546456, 12418.1972131552, 118.10414337365, 25.6540312834247, 33.9822321935788, 401.507026817795 ),
      ( 262, 4.59176626665991, 10000, 11165.3634528691, 13343.1746521474, 121.829473839649, 26.2478361525441, 34.5727981278518, 422.796784813423 ),
      ( 289, 4.16245546192227, 10000, 11884.7572996326, 14287.1854076277, 125.258101124719, 27.0683761750967, 35.3911085561042, 442.444751340982 ),
      ( 316, 3.80659526122886, 10000, 12629.1806799107, 15256.2001852026, 128.462900676177, 28.0995437178661, 36.4206782801688, 460.665539263936 ),
      ( 343, 3.50681263200548, 9999.99999999999, 13403.9329676899, 16255.5252964997, 131.496774854402, 29.3104846366907, 37.6304368756564, 477.683342498414 ),
      ( 370, 3.25081546823599, 10000, 14213.3841759871, 17289.5354056435, 134.397963999197, 30.6646914408884, 38.9837456077895, 493.708826803608 ),
      ( 397, 3.02966088879976, 10000, 15060.9154893668, 18361.61492968, 137.194029291717, 32.126330302618, 40.4446872462435, 508.923488293516 ),
      ( 424, 2.83668687980278, 10000, 15948.9904799042, 19474.22975506, 139.904841885755, 33.6637041437405, 41.9815096672471, 523.47426425257 ),
      ( 451, 2.66682850172989, 10000, 16879.2888139605, 20629.0612472134, 142.544791099557, 35.250576783887, 43.5679391896252, 537.475440204418 ),
      ( 478, 2.5161662492841, 9999.99999999999, 17852.8562142047, 21827.1564031708, 145.124384807309, 36.866188722197, 45.1831900650631, 551.013996528556 ),
      ( 505, 2.38161950885909, 10000, 18870.2447175962, 23069.0682336122, 147.651389754969, 38.4946165524699, 46.8113200830276, 564.155679029891 ),
      ( 532, 2.26073348015956, 10000, 19931.6317315622, 24354.9749021575, 150.131633535969, 40.1238991589882, 48.4403543789129, 576.950422292509 ),
      ( 559, 2.15152791633262, 10000, 21036.9151439403, 25684.7748923955, 152.569563806279, 41.7451666482305, 50.0614128246503, 589.436667518475 ),
      ( 586, 2.05238771991663, 9999.99999999998, 22185.7862691343, 27058.1599941175, 154.968636647531, 43.3518816177342, 51.6679502768198, 601.644584047983 ),
      ( 613, 1.96198247569056, 10000, 23377.7842614988, 28474.669745392, 157.331586378078, 44.9392276535149, 53.2551443823485, 613.598382872111 ),
      ( 92.9669319304804, 27952.8943930336, 17543.9999845692, -1029.72810907885, -1029.10048176634, -10.0511973670836, 34.5448694376758, 54.1598535035989, 1517.89922698292 ),
      ( 100, 21.279561618295, 17544.000002258, 7061.45824776225, 7885.91132235823, 84.7588322735402, 25.2098582430103, 33.8258136318907, 261.467782191351 ),
      ( 150, 14.1028524638104, 17544.0000000585, 8318.63763050011, 9562.64128473094, 98.3610866254418, 25.0219958301739, 33.4156242692415, 321.388305733295 ),
      ( 200, 10.5618898823756, 17544.0000000047, 9574.13658365603, 11235.2029453949, 107.983473885524, 25.2090463021095, 33.559804580664, 371.060652964388 ),
      ( 250, 8.44486679433646, 17544.0000000006, 10851.0142418565, 12928.489284064, 115.537388922137, 25.9578712119837, 34.2929833353439, 413.499963261477 ),
      ( 300, 7.03557574169313, 17544.0000000001, 12183.8506988529, 14677.4632536909, 121.910755766799, 27.4657675431499, 35.7934574050694, 450.00350519672 ),
      ( 350, 6.02967019538742, 17544, 13609.6208203099, 16519.2326948401, 127.584638616648, 29.6500601864132, 37.9736702762275, 481.915763655675 ),
      ( 400, 5.27554754703334, 17544, 15156.9812075164, 18482.5127933071, 132.823901752335, 32.2944451706766, 40.6155861004264, 510.56980243816 ),
      ( 450, 4.68915194442304, 17544, 16843.5798553175, 20584.9813300268, 137.773255577204, 35.1915391241637, 43.5110795299159, 536.970525542511 ),
      ( 500, 4.22010935675994, 17544, 18678.0976369391, 22835.3358781466, 142.512449667821, 38.1929466913475, 46.5113945975419, 561.758432425639 ),
      ( 550, 3.83638764846066, 17544, 20663.2516029603, 25236.3035485945, 147.08690200112, 41.2062790706449, 49.5239504556365, 585.318593519893 ),
      ( 600, 3.51664282138714, 17544, 22798.1755476097, 27787.0245411164, 151.523862334196, 44.1777715763332, 52.4948727396779, 607.887010411788 ),
      ( 100, 27360.2741931188, 99999.9999634984, -648.032183345479, -644.377249215153, -6.0931114695335, 33.9107555609715, 54.6724044388426, 1452.55936479777 ),
      ( 110.507625984548, 26432.3964188649, 99999.9997811706, -68.494015970905, -64.7107797407689, -0.582073163392377, 33.0771897994756, 55.7118173891075, 1349.73996921003 ),
      ( 125, 98.6988529456897, 100000, 7650.16751969387, 8663.35052046315, 77.4570053446948, 25.4504415389511, 34.6231014046634, 289.297903885987 ),
      ( 175, 69.3762711960511, 100000.000016984, 8924.04705014228, 10365.4620799929, 88.9189328005674, 25.1511250813637, 33.7672374233389, 345.672940494325 ),
      ( 225, 53.6910622656274, 100000.000001733, 10193.7585534105, 12056.2659388484, 97.4162369500794, 25.5267839812542, 33.9957818034224, 392.338347048771 ),
      ( 275, 43.8360754169727, 100000.000000244, 11497.4804309744, 13778.7065455167, 104.325614579524, 26.6336970130372, 35.0415351124103, 432.035479570472 ),
      ( 325, 37.0528030331529, 100000.000000038, 12874.7646783993, 15573.615826329, 110.318297430576, 28.4961023071088, 36.8727108906041, 466.271617525785 ),
      ( 375, 32.0936338312229, 100000.000000006, 14359.9469714419, 17475.8297202106, 115.75833192014, 30.9355641698673, 39.2941565992831, 496.526423886705 ),
      ( 425, 28.308101206742, 100000.000000001, 15976.4171029492, 19508.9747715004, 120.844197556928, 33.7268062207649, 42.0741110633508, 524.030457088637 ),
      ( 475, 25.3228515616808, 100000, 17737.1216650857, 21686.1240022207, 125.684246125726, 36.6894603117004, 45.0292546718661, 549.615676145859 ),
      ( 525, 22.9079841595988, 100000, 19647.4972279111, 24012.7874823178, 130.338943646505, 39.7046901636468, 48.0392516994898, 573.789297407654 ),
      ( 575, 20.9140836716419, 99999.9999999998, 21708.2824367946, 26489.7493932261, 134.843551832985, 42.7014811722368, 51.0322612628993, 596.856450913742 ),
      ( 625, 19.2397893870498, 100000, 23917.4727827472, 29115.0348759846, 139.219861865528, 45.6391483841203, 53.9671134772895, 619.00933155084 ),
      ( 100, 27360.3373025813, 101324.999964716, -648.047403599877, -644.344050134452, -6.09326375694092, 33.9108129893826, 54.6722397826027, 1452.56984239031 ),
      ( 110.667205473581, 26417.974453337, 101324.999775675, -59.6232582378428, -55.7878014372213, -0.501839459690135, 33.0652878128284, 55.7298541436411, 1348.15282909078 ),
      ( 125, 100.041844251926, 101325, 7649.47891896673, 8662.30510942402, 77.341968685944, 25.4574655461269, 34.6427611868196, 289.235223665086 ),
      ( 175, 70.304378680333, 101325.000017915, 8923.70111420388, 10364.934248183, 88.8075044351014, 25.1525044139003, 33.7727400449442, 345.647672223771 ),
      ( 225, 54.405671698686, 101325.000001827, 10193.5294333502, 12055.9271731115, 97.3057738153441, 25.5273156180669, 33.998387049811, 392.32614751254 ),
      ( 275, 44.4182615135063, 101325.000000257, 11497.310869075, 13778.4672346713, 104.215554210762, 26.6339707208815, 35.0430531994385, 432.029408319406 ),
      ( 325, 37.5443720603835, 101325.00000004, 12874.6311918463, 15573.4378155681, 110.208443093151, 28.4962660970898, 36.8737001446162, 466.268849617254 ),
      ( 375, 32.5191584509727, 101325.000000006, 14359.8375660812, 17475.6931056016, 115.648596563975, 30.9356714393317, 39.2948489144274, 496.525611630994 ),
      ( 425, 28.6833023677701, 101325.000000001, 15976.3248253838, 19508.8678603815, 120.734536794547, 33.7268807689206, 42.0746204571328, 524.030888478813 ),
      ( 475, 25.6584125601111, 101325, 17737.0421321441, 21686.0393572304, 125.574635018413, 36.6895143082718, 45.0296437437479, 549.616942178382 ),
      ( 525, 23.2115025484371, 101325, 19647.4275054124, 24012.7200920754, 130.229367146773, 39.7047304599367, 48.0395576317246, 573.79114593371 ),
      ( 575, 21.1911584789748, 101325, 21708.2204689441, 26489.6957290405, 134.734000348048, 42.701511909893, 51.0325074922168, 596.858717434044 ),
      ( 625, 19.4946671045461, 101325, 23917.4170765181, 29114.9923650118, 139.110329005642, 45.6391722081542, 53.9673154823443, 619.011903962053 ),
      ( 100, 27366.5521487287, 231931.55074109, -649.545847695758, -641.070846918144, -6.10826202627773, 33.9164687943211, 54.6560513020142, 1453.60160080622 ),
      ( 121.776158627757, 25380.9853906253, 231931.550775054, 564.832441123872, 573.970445311082, 4.8763834491286, 32.2805952011309, 57.2064094007236, 1235.25393284358 ),
      ( 125, 237.592602508809, 231931.550775397, 7577.93588669902, 8554.10916956374, 69.8697550429648, 26.2594646830497, 36.8986758187201, 282.732084733662 ),
      ( 175, 162.973911748574, 231931.550775396, 8889.13539992833, 10312.2561208275, 81.723361744925, 25.2929374927511, 34.3369772206696, 343.13114253939 ),
      ( 225, 125.262829705154, 231931.550775396, 10170.8291149833, 12022.3883630166, 90.3193909118053, 25.5802030499023, 34.2591838888929, 391.122988970183 ),
      ( 275, 101.9801502451, 231931.550782427, 11480.5592482414, 13754.84056892, 97.2693184025868, 26.6610119118971, 35.1937632361938, 431.433652499671 ),
      ( 325, 86.0783043097222, 231931.550776486, 12861.4599790784, 15555.8851613167, 103.282623242485, 28.5124097193959, 36.9715523705648, 465.998761181833 ),
      ( 375, 74.4998369046528, 231931.550775556, 14349.0492263666, 17462.2312199378, 108.734534701409, 30.9462354064409, 39.3632033097942, 496.447826851228 ),
      ( 425, 65.6823623847619, 231931.550775413, 15967.2285952654, 19498.3371357405, 113.827835976403, 33.7342205377781, 42.1248632332523, 524.075219731837 ),
      ( 475, 58.7391497796085, 231931.550775397, 17729.2038085535, 21677.7041127903, 118.672830306223, 36.6948306702554, 45.0679958902577, 549.743158707289 ),
      ( 525, 53.1279438068328, 231931.550775397, 19640.5569216303, 24006.085382861, 123.330973182225, 39.7086983866773, 48.0697033449782, 573.974478135994 ),
      ( 575, 48.4979208965231, 231931.550775395, 21702.1145461041, 26484.4133846512, 127.838070979791, 42.7045391049174, 51.0567646247219, 597.083018930874 ),
      ( 625, 44.6118278424938, 231931.550775393, 23911.9284357218, 29110.8086877089, 132.216234333059, 45.641518949427, 53.9872129298194, 619.266176859675 ),
      ( 100, 27402.8659278686, 999999.999970147, -658.285279485363, -621.79274609114, -6.19595419384016, 33.9495318306007, 54.5624977996447, 1459.62846511809 ),
      ( 125, 25121.1662574535, 1000000.00000095, 734.880830431716, 774.687899488643, 6.25665817202068, 32.1022794770435, 57.5098270306155, 1210.24257520805 ),
      ( 148.138777446828, 22545.9682756194, 1000000.00003669, 2123.81274559063, 2168.16657363704, 16.4694109939265, 30.848155828127, 64.0479878192704, 944.106607432575 ),
      ( 150, 968.437034967044, 1000000.00000114, 7907.63732225481, 8940.22897653327, 61.8778916861665, 28.1647549507821, 45.5647232868552, 287.760426857745 ),
      ( 200, 643.629394337477, 1000000, 9358.24185124384, 10911.9309909845, 73.276053262328, 25.8788919791962, 36.7298697771033, 357.813397171125 ),
      ( 250, 496.925179461093, 1000000, 10703.183568804, 12715.5589551438, 81.328996446115, 26.242051532196, 35.839795768863, 407.197012378949 ),
      ( 300, 407.75573177268, 1000000, 12071.922453508, 14524.3711184295, 87.9222589573344, 27.6212948257728, 36.7205556691593, 447.035472723295 ),
      ( 350, 346.74529543154, 1000000, 13520.0345689682, 16403.9958315297, 93.7134583466362, 29.7470838985951, 38.591894279502, 480.795407393008 ),
      ( 400, 302.045894784425, 1000000.00001499, 15082.6271375594, 18393.3822820009, 99.0227045297419, 32.3599019110879, 41.0563671294387, 510.57269775646 ),
      ( 450, 267.761936459726, 1000000.00000082, 16780.2430735972, 20514.9038443644, 104.017069391265, 35.2380375926001, 43.8403545904782, 537.703901006121 ),
      ( 500, 240.577207369414, 1000000, 18623.0708329654, 22779.7405812531, 108.786849379687, 38.2271896954449, 46.7660631627954, 562.990515874066 ),
      ( 550, 218.466172647065, 999999.999999734, 20614.6934702641, 25192.0611601135, 113.382982203977, 41.2321604503921, 49.726310808835, 586.903040032577 ),
      ( 600, 200.115148697964, 999999.999998842, 22754.7784691574, 27751.9014081517, 117.835836084251, 44.1977068242376, 52.6591968033792, 609.726465312649 ),
      ( 100, 27578.2539021193, 4829160.0938203, -700.100497558711, -524.992961347029, -6.62082255503945, 34.1095348393053, 54.1345790687635, 1488.70013356978 ),
      ( 127, 25212.1175295851, 4829160.09381718, 776.001459401754, 967.542693022865, 6.57971080102219, 32.1466380890003, 56.7193603780137, 1234.46124627839 ),
      ( 154, 22362.1666504358, 4829160.09381526, 2351.19412265796, 2567.14636777376, 17.981822084258, 30.7109073878735, 62.7856289456048, 950.705117160401 ),
      ( 181, 18003.2840366817, 4829160.09382125, 4247.30755308499, 4515.54528593316, 29.5848377717278, 30.6735189056508, 91.2648401333559, 583.308239677525 ),
      ( 208, 4238.14089459206, 4829160.09382134, 8428.93972556503, 9568.39219161765, 55.7703629700248, 29.5666222715284, 70.9379082412391, 316.801906104542 ),
      ( 235, 3094.81940647008, 4829160.09382351, 9533.03699704919, 11093.4382546242, 62.6896822168075, 27.7485013051552, 48.6219043263795, 366.148498396148 ),
      ( 262, 2554.57230294145, 4829160.0938214, 10430.7462793947, 12321.1449532787, 67.6402038763696, 27.53219330748, 43.2609295741305, 401.06373241814 ),
      ( 289, 2209.48647870221, 4829160.09382135, 11273.2846243658, 13458.9328011575, 71.7749329944979, 27.947915472961, 41.3469828536632, 429.222559206927 ),
      ( 316, 1961.32838387903, 4829160.09382135, 12103.937652486, 14566.1261026784, 75.4378495112596, 28.7442408914374, 40.8278653757948, 453.223861343085 ),
      ( 343, 1770.83832022731, 4829160.09382135, 12943.1844994986, 15670.231931588, 78.7904516718104, 29.8048271702961, 41.0515903385369, 474.37807078705 ),
      ( 370, 1618.37165394197, 4829160.09382136, 13802.9958803196, 16786.9582365922, 81.9240976180954, 31.0559590955804, 41.728818222915, 493.476586084741 ),
      ( 397, 1492.71019476184, 4829160.09382136, 14691.0699394092, 17926.2324718067, 84.8956511552371, 32.4433507262774, 42.7017291995944, 511.041303030651 ),
      ( 424, 1386.8592566836, 4829160.09382137, 15612.5406938122, 19094.6244528876, 87.7425207530183, 33.9252133051758, 43.8726630097663, 527.431072287041 ),
      ( 451, 1296.1741818307, 4829160.09382159, 16570.8450291666, 20296.5480724111, 90.4902329088266, 35.4693625934145, 45.1766657200978, 542.898132665416 ),
      ( 478, 1217.4209916481, 4829160.09379413, 17568.2403984529, 21534.9537432397, 93.1566964648216, 37.0513220908183, 46.5688022753364, 557.62262686403 ),
      ( 505, 1148.26288844135, 4829160.09382136, 18606.1456810702, 22811.7680541632, 95.7547766112801, 38.652734482826, 48.0173071192034, 571.73525787672 ),
      ( 532, 1086.96026831148, 4829160.09382135, 19685.377038334, 24128.1890109585, 98.2939179769908, 40.2599831188136, 49.4994277380216, 585.332557934183 ),
      ( 559, 1032.18597097832, 4829160.09382133, 20806.3146625938, 25484.8902580789, 100.781198040221, 41.863035992392, 50.9987060104275, 598.48725184872 ),
      ( 586, 982.906500660487, 4829160.09382135, 21969.0215724768, 26882.1644711923, 103.222025250605, 43.454518086419, 52.5031252055008, 611.255301497303 ),
      ( 613, 938.302882672543, 4829160.09382135, 23173.3284270942, 28320.0248542293, 105.62060968777, 45.0289955204763, 54.0038223310029, 623.68070372174 ),
      ( 100, 27801.7008799053, 9999999.99999993, -752.390504052574, -392.700280666716, -7.16523020001262, 34.3138949887214, 53.6424468367607, 1525.6728907717 ),
      ( 127, 25564.0298916616, 9999999.99999935, 687.569080718438, 1078.74371329314, 5.8517803278095, 32.3734230751565, 55.5361847417959, 1289.37717705529 ),
      ( 154, 23005.0414147649, 9999999.99999924, 2187.37518645123, 2622.06251518524, 16.8589390005507, 30.8809564878806, 59.2570838687352, 1039.6274351157 ),
      ( 181, 19779.5953833542, 10000000.0000001, 3818.70131158883, 4324.27282638411, 27.0242784398568, 30.0338949126925, 68.3339227849176, 770.345133103861 ),
      ( 208, 14805.0882246542, 9999999.99999998, 5810.86506356634, 6486.30852248119, 38.1119299617754, 30.3860236679502, 97.4857002686029, 487.279289127668 ),
      ( 235, 8668.45602532282, 9999999.99999996, 8058.45361909776, 9212.06159389596, 50.4517288050326, 29.8868706219955, 85.3684781646479, 381.464061347913 ),
      ( 262, 6177.13761108226, 10000000, 9469.87092826957, 11088.7437184854, 58.03699382125, 28.8806145988335, 58.7588632626857, 405.031506833163 ),
      ( 289, 5012.17842177734, 9999999.99999999, 10542.2568114599, 12537.397279036, 63.3064157147003, 28.8294530122746, 49.9654480661493, 433.727371393045 ),
      ( 316, 4298.9015215499, 10000000, 11506.236615098, 13832.4122555194, 67.5926027427947, 29.3718459926819, 46.4701334722906, 459.26514965599 ),
      ( 343, 3800.70775390428, 10000000, 12434.3915049814, 15065.4804093381, 71.337695995129, 30.2796975980364, 45.1069055028106, 481.837054961903 ),
      ( 370, 3425.6685861921, 10000000.000019, 13358.5878167697, 16277.7260078738, 74.7398656767778, 31.4304811743615, 44.8207446350698, 502.105108239505 ),
      ( 397, 3129.43196616191, 10000000, 14295.8667418603, 17491.3348357919, 77.9055942860809, 32.7474489142723, 45.1561037193349, 520.615529802025 ),
      ( 424, 2887.48021193361, 10000000, 15256.3851180147, 18719.6123147487, 80.8985622782006, 34.1774123330328, 45.8785941839802, 537.771044500327 ),
      ( 451, 2684.93864785009, 9999999.99999999, 16246.5484052823, 19971.0282953562, 83.7595404048921, 35.6818760152688, 46.8526206348537, 553.862265013548 ),
      ( 478, 2512.1520773969, 10000000, 17270.4956677937, 21251.1463974908, 86.5159007011433, 37.2326115242539, 47.9934164580062, 569.099081655174 ),
      ( 505, 2362.52346136866, 9999999.99999998, 18330.9042325296, 22563.6664308812, 89.1866950132393, 38.8088980586625, 49.2451914438727, 583.634656108358 ),
      ( 532, 2231.36017453424, 9999999.99999998, 19429.4684267167, 23911.0398530273, 91.7855816051145, 40.395557744669, 50.5699065249933, 597.582527022592 ),
      ( 559, 2115.21427522553, 9999999.99999998, 20567.2026452592, 25294.8560641705, 94.3226046202229, 41.9814859847804, 51.9409454186117, 611.028472119867 ),
      ( 586, 2011.48391963496, 10000000, 21744.6410605497, 26716.0951708141, 96.805319325344, 43.5585463082057, 53.3392945013206, 624.038638493956 ),
      ( 613, 1918.16145280735, 9999999.99999999, 22961.9727367583, 28175.2982289187, 99.239525594225, 45.1207491368043, 54.7511240594065, 636.665100233537 ),
      ( 127, 29043.6269694124, 100000000.000713, -67.2924070134288, 3375.80373611046, -1.81220363176138, 35.1577275123081, 50.1490392012421, 1837.34807109386 ),
      ( 154, 27688.3954056529, 100000000.000136, 1109.19586650471, 4720.81721671558, 7.79254751872049, 33.7597552770277, 49.4802911451737, 1717.69142564595 ),
      ( 181, 26384.0947885276, 100000000.000022, 2258.068120927, 6048.23036835437, 15.735972440176, 32.6443231657002, 48.8642532019148, 1609.75675620804 ),
      ( 208, 25129.4653287373, 100000000.000003, 3381.37356518675, 7360.76583206662, 22.4958627548616, 31.8627423833345, 48.3890814082499, 1513.76335209904 ),
      ( 235, 23926.6753860576, 100000000.000001, 4483.52171612489, 8662.95736217676, 28.3824825900057, 31.4368879635077, 48.1037587024745, 1429.1182228416 ),
      ( 262, 22779.3492565101, 99999999.9999994, 5570.33915383156, 9960.28018655972, 33.6083159526608, 31.3664012046248, 48.0300657223518, 1355.08526731328 ),
      ( 289, 21691.2553342042, 99999999.9999996, 6648.3353476012, 11258.4880777806, 38.3241712974276, 31.6289799505612, 48.1677629808741, 1290.96261732536 ),
      ( 316, 20665.3717146269, 99999999.9999998, 7724.09040225581, 12563.1032872367, 42.6395939556897, 32.1854363888398, 48.5011872682528, 1236.06220483768 ),
      ( 343, 19703.3326570431, 99999999.9997652, 8803.81712577101, 13879.1006699495, 46.6354701559049, 32.9878469095961, 49.0065988355381, 1189.64804191264 ),
      ( 370, 18805.2410295027, 99999999.9999413, 9893.10644598891, 15210.7729328505, 50.3723516151715, 33.9870601457952, 49.657981960967, 1150.9102789464 ),
      ( 397, 17969.7676254892, 99999999.9999859, 10996.8191732841, 16561.721407086, 53.8961701968209, 35.1377638202371, 50.4305427127743, 1118.98538793112 ),
      ( 424, 17194.4237422827, 99999999.9999959, 12119.0750926429, 17934.9140820059, 57.2422333771065, 36.4010222059856, 51.3023069626887, 1093.00056353368 ),
      ( 451, 16475.8995095936, 99999999.9999994, 13263.2978343329, 19332.7691819684, 60.4380429809332, 37.7449458074228, 52.2545284110234, 1072.11861149523 ),
      ( 478, 15810.3911610483, 99999999.9999993, 14432.2862843432, 20757.2404857526, 63.5052970168119, 39.1442569599328, 53.2714884184499, 1055.57051728394 ),
      ( 505, 15193.8756737648, 100000000, 15628.2942057154, 22209.8934070745, 66.4613219361722, 40.5793457454883, 54.3400575994413, 1042.67309013153 ),
      ( 532, 14622.3186721626, 99999999.9999997, 16853.1077745449, 23691.9684396715, 69.320106995038, 42.0351928155146, 55.4492211080932, 1032.83429881832 ),
      ( 559, 14091.8181532775, 100000000, 18108.1160318984, 25204.4324129569, 72.0930598812464, 43.5003601450292, 56.589659131305, 1025.55029291523 ),
      ( 586, 13598.6944531693, 100000000, 19394.3724232052, 26748.019521048, 74.7895660288114, 44.9661352641496, 57.7534100559904, 1020.39768268215 ),
      ( 613, 13139.5390976203, 99999999.9999994, 20712.6473227155, 28323.2643509878, 77.4174084600938, 46.4258485224205, 58.9336126910075, 1017.02370262485 ),
      };

      // TestData contains:
      // 0. Temperature (Kelvin)
      // 1. Pressure (Pa)
      // 2. Saturated liquid density (mol/m³
      // 3. Saturated vapor density (mol/m³)
      _testDataSaturatedProperties = new (double temperature, double pressure, double saturatedLiquidMoleDensity, double saturatedVaporMoleDensity)[]
      {
      ( 103.1778375, 47357.4990266918, 27082.18019425, 56.3909197720772 ),
      ( 115.661575, 139117.834446198, 25959.4708968933, 151.49860268639 ),
      ( 128.1453125, 328079.297330931, 24750.5035297283, 335.344630724055 ),
      ( 140.62905, 662296.173819096, 23420.5518102406, 652.886937079355 ),
      ( 153.1127875, 1194006.18194999, 21910.980036312, 1170.75474246183 ),
      ( 165.596525, 1979305.44641169, 20105.9440981803, 2010.9029423576 ),
      ( 178.0802625, 3082308.85207166, 17696.6771641099, 3487.61714210899 ),
      };

      // TestData contains:
      // 0. Temperature (Kelvin)
      // 1. Pressure (Pa
      _testDataMeltingLine = new (double temperature, double pressure)[]
     {
      ( 90.6941000088863, 11696.0641151345 ),
      ( 90.6951616989687, 15848.9319246111 ),
      ( 90.6975315245788, 25118.8643150958 ),
      ( 90.7012873692877, 39810.7170553497 ),
      ( 90.7072397415019, 63095.7344480193 ),
      ( 90.7166730376713, 100000 ),
      ( 90.7316223530084, 158489.319246111 ),
      ( 90.7553117766207, 251188.643150958 ),
      ( 90.7928478347045, 398107.170553497 ),
      ( 90.852315524125, 630957.344480194 ),
      ( 90.9465079051576, 1000000 ),
      ( 91.0956485992516, 1584893.19246111 ),
      ( 91.3316601251857, 2511886.43150958 ),
      ( 91.7048138143912, 3981071.70553497 ),
      ( 92.2939880337874, 6309573.44480194 ),
      ( 93.2222489392523, 10000000 ),
      ( 94.6799505171561, 15848931.9246111 ),
      ( 96.9577325966673, 25118864.3150958 ),
      ( 100.491080675562, 39810717.0553497 ),
      ( 105.915747330326, 63095734.4480194 ),
      ( 114.129365178596, 100000000 ),
      ( 126.351876069335, 158489319.246111 ),
      ( 144.182423971622, 251188643.150958 ),
      ( 169.667330784438, 398107170.553498 ),
     };

      // TestData contains:
      // 0. Temperature (Kelvin)
      // 1. Pressure (Pa
      _testDataSublimationLine = new (double temperature, double pressure)[]
     {
      ( 90, 10593.3025834062 ),
      ( 87.75, 7602.3096283273 ),
      ( 85.5, 5361.3759937743 ),
      ( 83.25, 3710.29667579724 ),
      ( 81, 2515.70361705614 ),
      ( 78.75, 1668.27446262859 ),
      ( 76.5, 1079.89587936976 ),
      ( 74.25, 680.845627976878 ),
      ( 72, 417.056212688014 ),
      ( 69.75, 247.518701056579 ),
      ( 67.5, 141.878199219348 ),
      ( 65.25, 78.2627096177306 ),
      ( 63, 41.375166119262 ),
      ( 60.75, 20.8650676191001 ),
      ( 58.5, 9.9822645845412 ),
      ( 56.25, 4.5021825425656 ),
      ( 54, 1.90020281732125 ),
      ( 51.75, 0.744047891458011 ),
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

    [Fact]
    public override void SublimationPressure_TestMonotony()
    {
      base.SublimationPressure_TestMonotony();
    }

    [Fact]
    public override void SublimationPressure_TestDerivative()
    {
      base.SublimationPressure_TestDerivative();
    }

    [Fact]
    public override void SublimationPressure_TestData()
    {
      base.SublimationPressure_TestData();
    }

    [Fact]
    public override void SublimationTemperature_TestData()
    {
      base.SublimationTemperature_TestData();
    }
  }
}
