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
  /// Tests and test data for <see cref="Fluid_2_methylpentane"/>.
  /// </summary>
  /// <remarks>
  /// <para>Reference:</para>
  /// <para>The test data was created automatically using calls into the TREND.DLL of the following software:</para>
  /// <para>TREND 3.0.: Span, R.; Eckermann, T.; Herrig, S.; Hielscher, S.; Jäger, A.; Thol, M. (2016): TREND.Thermodynamic Reference and Engineering Data 3.0.Lehrstuhl für Thermodynamik, Ruhr-Universität Bochum.</para>
  /// </remarks>
  
  public class Test_Fluid_2_methylpentane : FluidTestBase
  {

    public Test_Fluid_2_methylpentane()
    {
      _fluid = Fluid_2_methylpentane.Instance;

      _testDataMolecularWeight = 0.08617536;

      _testDataTriplePointTemperature = 119.6;

      _testDataTriplePointPressure = 7.673E-06;

      _testDataTriplePointLiquidMoleDensity = 9370.78245063215;

      _testDataTriplePointVaporMoleDensity = 7.71710650450453E-09;

      _testDataCriticalPointTemperature = 497.7;

      _testDataCriticalPointPressure = 3042618.64803573;

      _testDataCriticalPointMoleDensity = 2715;

      _testDataNormalBoilingPointTemperature = 333.362052534715;

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
      ( 150, 9.22848739041479E-09, 1.15095000000293E-05, 5288.83198959982, 6536.00278944115, 184.023353681185, 73.9405157082538, 82.2549877153362, 126.885295992491 ),
      ( 200, 6.92136554217806E-09, 1.15095000000087E-05, 9454.13297908163, 11117.0273790192, 210.250028135936, 92.983254545595, 101.297726547543, 144.990070127135 ),
      ( 250, 5.5370924336171E-09, 1.15095000000035E-05, 14615.7188298741, 16694.3368298421, 235.05506016714, 113.655064316385, 121.969536317123, 160.889269220645 ),
      ( 300, 4.61424369464485E-09, 1.15095000000018E-05, 20825.7410637507, 23320.0826637315, 259.157027358444, 134.719965950229, 143.034437950573, 175.30356030064 ),
      ( 200, 0.00290568594922872, 4.83177271902871, 9454.05119676812, 11116.9193812363, 102.597567306017, 92.984245676959, 101.299535537132, 144.98830621575 ),
      ( 250, 0.00232452666676793, 4.83177181861886, 14615.6801155719, 16694.2847139597, 127.402854941854, 113.655415286284, 121.97019700667, 160.88841924636 ),
      ( 300, 0.00193709920021547, 4.83177150778617, 20825.7193678127, 23320.0529090422, 151.504905205581, 134.720116076208, 143.034732717323, 175.30307688469 ),
      ( 350, 0.00166036840441381, 4.83177137434424, 28080.0028603932, 30990.0626769374, 175.110820275818, 155.338174815177, 163.652725184355, 188.617300522461 ),
      ( 400, 0.0014528213304986, 4.83177130760921, 36345.8582211593, 39671.6431653761, 198.266666417827, 175.139019752951, 183.453539151612, 201.06055010713 ),
      ( 450, 0.00129139622985683, 4.83177127031409, 45576.5423116079, 49318.0518178341, 220.968640277193, 193.89996039398, 202.214463554966, 212.788891909358 ),
      ( 500, 0.00116225632907676, 4.83177124766987, 55715.8977067797, 59873.1314656253, 243.194160895718, 211.466048193777, 219.780542038201, 223.915855851359 ),
      ( 550, 0.00105659649946903, 4.8317712330249, 66701.8865969562, 71274.8444247107, 264.915812053458, 227.759163521735, 236.07365161992, 234.526968636475 ),
      ( 225, 8273.77866237297, 999.99999995062, -20117.9215130587, -20117.8006492986, -72.3987375212431, 124.648749847494, 165.71710153546, 1388.82254930543 ),
      ( 235.821852519529, 8165.4745705178, 1000.00000397818, -18305.8753154564, -18305.7528485997, -64.5335153375575, 127.958262764482, 169.20728746167, 1334.70055733587 ),
      ( 250, 0.481732543423627, 1000.00000000048, 14607.6956042533, 16683.5362624193, 83.0336379474391, 113.727803038021, 122.106687325239, 160.713044353352 ),
      ( 300, 0.401175825372242, 1000.00000000006, 20821.2477789456, 23313.9204096361, 107.15272603297, 134.751057532378, 143.095535671134, 175.203421075383 ),
      ( 350, 0.343766578989699, 1000.00000000001, 28077.1770758512, 30986.1276868702, 130.765473751173, 155.35325854883, 163.683971624745, 188.554237747309 ),
      ( 400, 0.300752728387117, 1000, 36343.9052753594, 39668.8958926111, 153.924511451515, 175.147121314562, 183.471411160191, 201.017665442165 ),
      ( 450, 0.267314393505562, 999.999999999999, 45575.0980252373, 49316.0114376652, 176.628158215987, 193.904650687513, 202.22557537794, 212.758260453215 ),
      ( 500, 0.240571282291479, 999.999999999999, 55714.7727932094, 59871.5449169427, 198.85463854603, 211.468932316428, 219.787927018685, 223.893225033709 ),
      ( 550, 0.218694304410323, 1000, 66700.9747237954, 71273.5675158041, 220.576881577533, 227.761027933581, 236.078832570199, 234.509860539136 ),
      ( 200, 8523.93445690729, 10000.0025276203, -24169.617807725, -24168.444640266, -91.4795100155213, 117.733419023152, 158.660457461885, 1519.74529109599 ),
      ( 225, 8273.85064488844, 10000.0000006701, -20118.2172203371, -20117.0085932504, -72.400051801517, 124.649270427935, 165.716349674332, 1388.87491445696 ),
      ( 250, 8022.99802128422, 10000.0000033084, -15872.9433171822, -15871.696900322, -54.5162701557056, 132.504071491171, 174.090396121148, 1265.837245126 ),
      ( 274.326945424432, 7775.00650772448, 10000.0000020954, -11529.4044008811, -11528.1182283239, -37.9426590001863, 140.699823852521, 183.135910569308, 1151.98971169309 ),
      ( 300, 4.03624449507492, 10000.0000006276, 20780.5293476957, 23258.0799551551, 87.8720320405427, 135.032941684472, 143.654088796921, 174.293895204089 ),
      ( 350, 3.44960589460822, 10000.0000001155, 28051.5220358096, 30950.4039097494, 111.547335403148, 155.490211263912, 163.969070012365, 187.980983830509 ),
      ( 400, 3.01405369145841, 10000.0000000281, 36326.2004503394, 39643.9913803309, 134.735448022802, 175.220569220332, 183.633954328649, 200.62863128201 ),
      ( 450, 2.67700700237402, 10000.0000000083, 45562.0151524888, 49297.5302225429, 157.454296765489, 193.947138082167, 202.326455650608, 212.480711741758 ),
      ( 500, 2.40813350986076, 10000.0000000028, 55704.5879316553, 59857.1816142958, 179.689485627905, 211.495045783905, 219.854899518808, 223.688323377 ),
      ( 550, 2.18852386959739, 10000.000000001, 66692.7213499008, 71262.0112438423, 201.417094533338, 227.777903529461, 236.125783556198, 234.355041877703 ),
      ( 200, 8524.54362467739, 100000.002523502, -24172.1023512628, -24160.3715176925, -91.4919350384127, 117.738844201405, 158.655686644704, 1520.21170740829 ),
      ( 225, 8274.57013724482, 100000.000000334, -20121.1726961918, -20109.0874762539, -72.4131898183404, 124.654475561873, 165.70884268122, 1389.39833095571 ),
      ( 250, 8023.85392425249, 100000.000003113, -15876.4693531288, -15864.0065140807, -54.530377224005, 132.509078213279, 174.079260202505, 1266.42786625612 ),
      ( 275, 7769.0891427754, 100000.000002642, -11410.2890339053, -11397.4175121394, -37.5089617785628, 140.936695785353, 183.380294159828, 1149.579131652 ),
      ( 300, 7506.76927639364, 100000.000002531, -6702.37847648563, -6689.05716656912, -21.1280443387787, 149.694958339523, 193.39842869298, 1037.16198647051 ),
      ( 325, 7232.69561182178, 99999.9999999984, -1735.90181218568, -1722.07570842479, -5.23091488325701, 158.631698668912, 204.072151375631, 927.473991866225 ),
      ( 331.949202106159, 7153.71530441288, 100000.000000184, -307.205898356814, -293.227148050872, -0.880916535596884, 161.133984195216, 207.164378474155, 897.227279720824 ),
      ( 350, 35.789156456618, 100000, 27784.0480648309, 30578.1904783637, 91.6317756934341, 156.928029150377, 167.118545143121, 181.928158078149 ),
      ( 400, 30.8249019669276, 99999.9999999999, 36144.6717809458, 39388.8021307289, 115.134510849235, 175.974608370591, 185.358282330134, 196.613485651696 ),
      ( 450, 27.1682021066123, 100000, 45429.0260271923, 49109.7995876798, 138.013044223608, 194.379215481961, 203.375708577671, 209.651512312567 ),
      ( 500, 24.3282269465216, 100000.000029723, 55601.5817840236, 59712.0334108333, 160.338295148628, 211.759242642625, 220.543526055141, 221.615610229469 ),
      ( 550, 22.0453771899347, 100000.000010714, 66609.520146595, 71145.6185380696, 182.120875804726, 227.948098600206, 236.604996602462, 232.797045996522 ),
      ( 200, 8524.55258984259, 101325.002522901, -24172.1389135948, -24160.2526589844, -91.4921179121673, 117.738924062297, 158.655616506628, 1520.21857174952 ),
      ( 225, 8274.58072525496, 101325.000000018, -20121.2161856921, -20108.9708522589, -72.4133831741927, 124.654552183903, 165.708732319188, 1389.40603362064 ),
      ( 250, 8023.86651843405, 101325.000003082, -15876.5212337423, -15863.8932818976, -54.5305848252235, 132.509151916275, 174.07909651277, 1266.43655709753 ),
      ( 275, 7769.10428115819, 101325.000001991, -11410.3512886879, -11397.3092446716, -37.5091882513969, 140.93676628603, 183.38005631578, 1149.58901993381 ),
      ( 300, 7506.78774270296, 101325.000002671, -6702.4538939697, -6688.95610990072, -21.1282958403484, 149.695024514588, 193.398082318404, 1037.17337055034 ),
      ( 325, 7232.71860590998, 101325.000000128, -1735.99451000978, -1721.98525491208, -5.23120024347528, 158.631757969016, 204.071636172719, 927.48731329552 ),
      ( 332.362052534715, 7149.00277006947, 101325.000000305, -221.747828576006, -207.574523115205, -0.623605379107858, 161.282872909779, 207.349398129063, 895.445639307422 ),
      ( 350, 36.2841697485473, 101325, 27779.9456341823, 30572.4857612458, 91.5104229624495, 156.950351487274, 167.169749135734, 181.834243003185 ),
      ( 400, 31.2440042832747, 101325, 36141.9351842631, 39384.9574000243, 115.018161103237, 175.986000613952, 185.385135246184, 196.552590112782 ),
      ( 450, 27.5342886402336, 101325, 45427.0379134565, 49106.9949780433, 137.899157066293, 194.385678560743, 203.39173378178, 209.609109533001 ),
      ( 500, 24.6543268470144, 101325.000031359, 55600.0493047292, 59709.8755701187, 160.225776041583, 211.763174596172, 220.553929029977, 221.584768189268 ),
      ( 550, 22.3398959840773, 101325.000011299, 66608.2860801576, 71143.8935907529, 182.009184303317, 227.950623943519, 236.612186107982, 232.77397450945 ),
      ( 200, 8530.61232560559, 1000000.00246747, -24196.8330121073, -24079.6081325443, -91.6158175804306, 117.793023872933, 158.608700371647, 1524.85872132967 ),
      ( 225, 8281.73203398782, 1000000.00000037, -20150.5689014887, -20029.8212129743, -72.5440947394958, 124.706459623214, 165.63492031465, 1394.60918663388 ),
      ( 250, 8032.36467594368, 1000000.00000167, -15911.5071127166, -15787.0107731771, -54.670818283909, 132.559092703502, 173.969758885708, 1272.30186613634 ),
      ( 275, 7779.30625550963, 1000000.00000209, -11452.2854075497, -11323.7392406863, -37.6620132554748, 140.984566462129, 183.221546913968, 1156.25441502642 ),
      ( 300, 7519.21092061634, 1000000.0000022, -6753.17612110357, -6620.18344267499, -21.2977728484842, 149.739960660916, 193.168038482547, 1044.83443027795 ),
      ( 325, 7248.14962978089, 999999.999999886, -1798.20279822284, -1660.2365515147, -5.42310737264584, 158.67218692259, 203.731226726322, 936.431244288897 ),
      ( 350, 6960.95877774224, 999999.99999985, 3428.36302961614, 3572.021400816, 10.0818296786801, 167.687378851791, 214.978107699465, 829.358797629128 ),
      ( 375, 6650.03692873208, 1000000.00016644, 8946.19590756032, 9096.57101237303, 25.3231744950643, 176.733371519796, 227.186474912414, 721.638278353869 ),
      ( 400, 6302.64139459778, 999999.999999938, 14786.4778956945, 14945.1415316833, 40.4166855468352, 185.800356859511, 241.087513304927, 610.511836467342 ),
      ( 425, 5893.16338244354, 1000000.00000007, 21011.8848122916, 21181.5729636466, 55.5345446173141, 194.959775264015, 258.818119305606, 491.064295847313 ),
      ( 427.631726251225, 5844.4270086762, 999999.999986481, 21694.619354701, 21865.7225267488, 57.1393373751507, 195.938495574774, 261.127477889203, 477.63445127599 ),
      ( 450, 330.440754591575, 1000000.00000178, 43784.1487355591, 46810.4098311003, 115.069174139094, 199.903341680351, 221.88329354273, 173.644491271407 ),
      ( 500, 274.260455660769, 1000000.00000003, 54430.000062536, 58076.1691669763, 138.800632918705, 214.782087941596, 230.159525317906, 198.062357763761 ),
      ( 550, 238.873907412143, 1000000, 65702.8897863742, 69889.1988346649, 161.309224521397, 229.805897839251, 242.601580052577, 216.160255148198 ),
      ( 200, 8545.2397952532, 3194749.57901826, -24256.2826039989, -23882.4195345514, -91.9151662082872, 117.924596453293, 158.499446105463, 1536.06303128381 ),
      ( 218, 8367.76910556853, 3194749.57907922, -21368.7315375757, -20986.9392654929, -78.0556302321003, 122.784495550355, 163.361487687945, 1442.34694835754 ),
      ( 236, 8190.79537164815, 3194749.57921526, -18387.0178537679, -17996.9764189307, -64.880018355385, 128.194905442127, 168.963513570963, 1353.10164571252 ),
      ( 254, 8013.18002374445, 3194749.57935756, -15299.5801283786, -14900.8932687435, -52.2400304834457, 133.997099876587, 175.127089350348, 1267.71717120094 ),
      ( 272, 7833.82850536002, 3194749.57947428, -12097.6346165553, -11689.820024075, -40.0284336948933, 140.069483420447, 181.722270219228, 1185.60583492518 ),
      ( 290, 7651.62669874441, 3194749.57954995, -8774.360814155, -8356.83527281172, -28.1655939629316, 146.322575535189, 188.661336292427, 1106.20371257838 ),
      ( 308, 7465.3758408502, 3194749.57959075, -5324.21036224299, -4896.26813298385, -16.5904783882559, 152.691930179959, 195.892044007602, 1028.97139580015 ),
      ( 326, 7273.71577503522, 3194749.57960571, -1742.32482658955, -1303.10645754485, -5.25455269780017, 159.131423726955, 203.392932536104, 953.3882734708 ),
      ( 344, 7075.02297387197, 3194749.57962617, 1975.98931404296, 2427.54255866483, 5.88252125593596, 165.608044827083, 211.172466789302, 878.939578104246 ),
      ( 362, 6867.26143076825, 3194749.57970653, 5835.80987503562, 6301.02437311671, 16.8561804646815, 172.098517642244, 219.273905429893, 805.095858686179 ),
      ( 380, 6647.74626678002, 3194749.57990929, 9843.29581117847, 10323.8721526484, 27.6998934123831, 178.587778768153, 227.789390361054, 731.282508553821 ),
      ( 398, 6412.73856464272, 3194749.58043756, 14006.746206337, 14504.9342344678, 38.4484198972468, 185.069447743922, 236.89154936136, 656.832434514492 ),
      ( 416, 6156.68771107225, 3194749.58043767, 18338.4667266202, 18857.3739264595, 49.1424878569869, 191.549126828201, 246.904611715539, 580.90469930488 ),
      ( 434, 5870.64929388194, 3194749.58033316, 22858.5476584211, 23402.7378187262, 59.8373336208543, 198.053530953688, 258.481833313279, 502.32406000252 ),
      ( 452, 5538.42431005191, 3194749.58043755, 27603.902158111, 28180.7358208261, 70.6223587052575, 204.656282099745, 273.139468424119, 419.202343075877 ),
      ( 470, 5124.45612776894, 3194749.58043747, 32656.1574380317, 33279.5893693005, 81.6813803331632, 211.569957884465, 295.478330901795, 327.783446641775 ),
      ( 488, 4510.35452081552, 3194749.58043436, 38285.7113619312, 38994.0258781606, 93.6064247237279, 219.700480638144, 352.038530816924, 216.874282804927 ),
      ( 506, 1740.5808680564, 3194749.58043751, 49707.3970082658, 51542.8472531056, 118.762981710822, 232.188905567659, 521.711555077806, 104.930213829861 ),
      ( 524, 1250.75850628123, 3194749.58043752, 55647.9780689231, 58202.2278017002, 131.712638215469, 231.366769804286, 311.848407700842, 139.767632541329 ),
      ( 542, 1068.24569142203, 3194749.58043752, 60524.8645401765, 63515.515105015, 141.684777955554, 234.256155847332, 284.172474459131, 160.094354175898 ),
      ( 200, 8589.13582153983, 9999999.99918492, -24433.2931701784, -23269.0316883531, -92.8198476397727, 118.327591040031, 158.204248902314, 1569.7225890541 ),
      ( 218, 8416.8803040057, 9999999.99926459, -21567.9953386986, -20379.9066837483, -78.9906650850411, 123.175406975611, 162.947602183488, 1478.66488156617 ),
      ( 236, 8245.85259421789, 9999999.9993916, -18611.342326407, -17398.611455326, -65.853183639679, 128.575313743248, 168.410389681797, 1392.33711528392 ),
      ( 254, 8075.07934575914, 9999999.99951934, -15552.3150963811, -14313.937171987, -53.2597086146124, 134.367729814718, 174.407314815776, 1310.18913128424 ),
      ( 272, 7903.6793180337, 9999999.9996294, -12382.81915183, -11117.5856324471, -41.1040304960616, 140.430181166038, 180.799284552144, 1231.70560648137 ),
      ( 290, 7730.8190417784, 9999999.99971283, -9096.9245586952, -7803.4005548773, -29.3080302030359, 146.672177303283, 187.485986243424, 1156.41208771692 ),
      ( 308, 7555.67647324762, 9999999.99977509, -5690.25496263231, -4366.74673207452, -17.8128201176126, 153.027996046785, 194.397332817363, 1083.88220997946 ),
      ( 326, 7377.40845009999, 9999999.999821, -2159.52649235491, -804.036950538168, -6.57287237820491, 159.449776775676, 201.485834563297, 1013.74129125825 ),
      ( 344, 7195.11896054124, 9999999.99985726, 1497.78832576232, 2887.61941190534, 4.44790835165863, 165.902000351805, 208.720774601788, 945.667095904799 ),
      ( 362, 7007.82595117315, 9999999.99988846, 5283.70414981892, 6710.68022907135, 15.2788604358677, 172.357582368344, 216.084274874702, 879.390145972341 ),
      ( 380, 6814.42500160763, 9999999.99991879, 9199.90309960164, 10667.3783447705, 25.944439048098, 178.795384469149, 223.568915953054, 814.696132848233 ),
      ( 398, 6613.64913782586, 9999999.99994916, 13247.8717749131, 14759.8963458502, 36.4655709016413, 185.198802124617, 231.176347044638, 751.433016717558 ),
      ( 416, 6404.02614679494, 9999999.99997542, 17429.0018979017, 18990.5195698712, 46.8606554966, 191.555078966215, 238.916101302396, 689.525770700548 ),
      ( 434, 6183.83960820488, 9999999.99999242, 21744.6428350205, 23361.7611035351, 57.1462883144462, 197.855029762614, 246.803415064363, 629.002423680685 ),
      ( 452, 5951.11062418481, 9999999.99999897, 26196.0656514963, 27876.4242654599, 67.3376961578735, 204.092853497836, 254.85403022184, 570.035467644922 ),
      ( 470, 5703.63917625027, 9999999.99999994, 30784.2541304499, 32537.5207188483, 77.4487748761513, 210.265612912193, 263.072687875459, 513.000789907798 ),
      ( 488, 5439.18247763822, 10000000, 35509.3815941627, 37347.8931795181, 87.4915041639443, 216.371669567703, 271.431171875376, 458.546984328891 ),
      ( 506, 5155.89456686849, 9999999.99999997, 40369.8078431089, 42309.3354789646, 97.4744577200637, 222.40690797439, 279.835025199605, 407.642494283171 ),
      ( 524, 4853.14736231805, 10000000.0000346, 45360.5770788292, 47421.0955946441, 107.400374857074, 228.357487635193, 288.092459636958, 361.525078898493 ),
      ( 542, 4532.66044808564, 10000000, 50471.8790581739, 52678.0888800951, 117.263594614474, 234.189901628286, 295.919434483172, 321.464535697774 ),
      ( 200, 9035.92404447026, 99999999.9999948, -26087.1874066429, -15020.250643137, -102.555082034712, 123.022461436413, 157.376018374618, 1918.93814702094 ),
      ( 218, 8902.92026332407, 99999999.9999947, -23384.3531852881, -12152.0836554858, -88.8258212304822, 127.70278323785, 161.443773836681, 1846.2710454952 ),
      ( 236, 8774.11678080514, 99999999.9999935, -20601.2863408608, -9204.12780078302, -75.8349181890767, 132.962552002258, 166.204404814876, 1778.76635538987 ),
      ( 254, 8648.91992292946, 99999999.9999969, -17727.8977779763, -6165.76043700225, -63.4302028106865, 138.635043923042, 171.460708575428, 1715.99030148445 ),
      ( 272, 8526.87051277771, 99999999.9999963, -14757.1124125541, -3029.48035221688, -51.5027137388345, 144.592084943834, 177.061951159583, 1657.53167490332 ),
      ( 290, 8407.61070150151, 99999999.999998, -11684.1261258992, 209.859401063802, -39.9728663525727, 150.738392571336, 182.895762065884, 1603.00797743053 ),
      ( 308, 8290.86063863993, 99999999.9999996, -8505.81466773012, 3555.65932858157, -28.7813269317474, 157.003986176904, 188.878972368486, 1552.0730166619 ),
      ( 326, 8176.40160714383, 100000000, -5220.29623149001, 7010.02277737926, -17.8829840560661, 163.33699755843, 194.949387645014, 1504.42026872519 ),
      ( 344, 8064.06351422082, 100000000.000001, -1826.62345403037, 10574.0725255651, -7.24293962826147, 169.697917898678, 201.059334297339, 1459.78199838238 ),
      ( 362, 7953.7153806082, 100000000, 1675.42756788884, 14248.1681318532, 3.16619442069705, 176.055479975547, 207.1710591464, 1417.9257063042 ),
      ( 380, 7845.25793273362, 100000000.00241, 5285.50162628105, 18032.0551315736, 13.3661584478469, 182.38396160707, 213.253694193525, 1378.64940035954 ),
      ( 398, 7738.61769493058, 100000000.000678, 9002.76624670098, 21924.9706949432, 23.3743637253962, 188.661558571476, 219.281387217523, 1341.77669046528 ),
      ( 416, 7633.74217040492, 100000000.000186, 12825.9881895474, 25925.7232562979, 33.2048549755733, 194.869481700569, 225.232221501109, 1307.15224719122 ),
      ( 434, 7530.59582680719, 100000000.00005, 16753.5957318998, 30032.7574741981, 42.8690342472894, 200.991498290787, 231.08762360645, 1274.63785206582 ),
      ( 452, 7429.15669093656, 100000000.000013, 20783.7332691993, 34244.2112426968, 52.3762195847525, 207.013715932731, 236.832042684489, 1244.10908973621 ),
      ( 470, 7329.41341762823, 100000000.000003, 24914.311620671, 38557.9682548417, 61.7340848631963, 212.924476089132, 242.452758498808, 1215.45264424998 ),
      ( 488, 7231.36274132565, 100000000.000001, 29143.0554272577, 42971.7075882844, 70.9490106910667, 218.7142782322, 247.93973195133, 1188.56412765449 ),
      ( 506, 7135.00724924115, 100000000, 33467.5478937894, 47482.9506126353, 80.0263663301947, 224.375692974729, 253.285451798724, 1163.3463622719 ),
      ( 524, 7040.35343618293, 100000000, 37885.2725726526, 52089.1049379518, 88.9707365687, 229.903247068569, 258.484757398246, 1139.70804324028 ),
      ( 542, 6947.41001532265, 100000000, 42393.6516995077, 56787.5049166703, 97.7861037937739, 235.293277718571, 263.534633201462, 1117.56271697694 ),
      };

      // TestData contains:
      // 0. Temperature (Kelvin)
      // 1. Pressure (Pa)
      // 2. Saturated liquid density (mol/m³
      // 3. Saturated vapor density (mol/m³)
      _testDataSaturatedProperties = new (double temperature, double pressure, double saturatedLiquidMoleDensity, double saturatedVaporMoleDensity)[]
      {
      ( 214.125, 161.09681318835, 8382.46055020147, 0.0905227460117244 ),
      ( 261.3875, 4766.68182907412, 7907.5285912846, 2.2051654629636 ),
      ( 308.65, 42837.4690330491, 7412.65840542221, 17.1470528754405 ),
      ( 355.9125, 197188.824829677, 6871.19480432318, 72.189134834812 ),
      ( 403.175, 608419.905419544, 6237.99367778803, 218.208569932929 ),
      ( 450.4375, 1464085.3275449, 5396.68855323958, 575.502640659402 ),
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
