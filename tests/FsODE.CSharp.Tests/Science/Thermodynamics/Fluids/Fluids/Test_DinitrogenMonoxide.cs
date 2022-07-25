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
  /// Tests and test data for <see cref="DinitrogenMonoxide"/>.
  /// </summary>
  /// <remarks>
  /// <para>Reference:</para>
  /// <para>The test data was created automatically using calls into the TREND.DLL of the following software:</para>
  /// <para>TREND 3.0.: Span, R.; Eckermann, T.; Herrig, S.; Hielscher, S.; Jäger, A.; Thol, M. (2016): TREND.Thermodynamic Reference and Engineering Data 3.0.Lehrstuhl für Thermodynamik, Ruhr-Universität Bochum.</para>
  /// </remarks>
  
  public class Test_DinitrogenMonoxide : FluidTestBase
  {

    public Test_DinitrogenMonoxide()
    {
      _fluid = DinitrogenMonoxide.Instance;

      _testDataMolecularWeight = 0.0440128;

      _testDataTriplePointTemperature = 182.33;

      _testDataTriplePointPressure = 87840;

      _testDataTriplePointLiquidMoleDensity = 28113.4320793575;

      _testDataTriplePointVaporMoleDensity = 59.3360178315936;

      _testDataCriticalPointTemperature = 309.52;

      _testDataCriticalPointPressure = 7244708.2239851;

      _testDataCriticalPointMoleDensity = 10270;

      _testDataNormalBoilingPointTemperature = 184.683919103573;

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
      ( 182.33, 0.659804892250651, 1000, 15015.4803473916, 16531.0799007519, 127.69939081132, 24.2438429789284, 32.5674652617106, 215.050160557762 ),
      ( 200, 0.601472954683461, 1000, 15452.5929449285, 17115.1780906335, 130.75633611253, 25.2264396893378, 33.5475468891367, 224.111659107643 ),
      ( 217, 0.554329741559137, 1000, 15889.5581174773, 17693.5385374839, 133.531260858915, 26.173501078441, 34.4930303632874, 232.396656328632 ),
      ( 234, 0.514042474843544, 1000, 16342.4617323178, 18287.8262672317, 136.167493550083, 27.1001261900933, 35.4185679992805, 240.334472374439 ),
      ( 251, 0.479216197074176, 1000, 16810.8446448444, 18897.5854647612, 138.682628847346, 27.9941277448518, 36.3117919912906, 247.979159347234 ),
      ( 268, 0.448810589153453, 1000, 17294.1003223931, 19522.2117443767, 141.090221796241, 28.8500471597992, 37.1671381257944, 255.36946543476 ),
      ( 285, 0.422033921675231, 1000, 17791.5684524663, 20161.0462329029, 143.401124872502, 29.6667449414961, 37.9834020990334, 262.533878630629 ),
      ( 302, 0.398272946352106, 1000, 18302.5922763665, 20813.4331686723, 145.624312283922, 30.4455759672928, 38.7618974433236, 269.494124640994 ),
      ( 319, 0.377045262993181, 1000, 18826.5496810808, 21478.7511490464, 147.767393036433, 31.1891262285056, 39.5051828841925, 276.267480421768 ),
      ( 336, 0.357966176008143, 1000, 19362.8668005292, 22156.426826651, 149.836936833335, 31.9004053176475, 40.2162495065943, 282.868257279673 ),
      ( 353, 0.340725143419018, 999.999999999999, 19911.0208685102, 22845.9378222914, 151.838688026576, 32.5823741863353, 40.8980453759714, 289.308730923747 ),
      ( 370, 0.325068726938296, 999.999999999999, 20470.537105278, 23546.8096505291, 153.777712565501, 33.2377021221955, 41.5532306026767, 295.599715787408 ),
      ( 387, 0.310788040765566, 1000, 21040.9828055407, 24258.609833713, 155.65850444253, 33.868670286411, 42.1840796785568, 301.750916829867 ),
      ( 404, 0.29770937217207, 1000, 21621.9605870145, 24980.9411683246, 157.48506707707, 34.4771621869319, 42.7924711759035, 307.771145763853 ),
      ( 421, 0.285687076308196, 1000, 22213.1019123467, 25713.4352593169, 159.26097855627, 35.0647005981049, 43.379924155975, 313.668456965444 ),
      ( 438, 0.274598126752641, 1000, 22814.0614375163, 26455.7468773474, 160.989445867622, 35.6325049406018, 43.9476552042309, 319.450237278702 ),
      ( 455, 0.264337888404182, 1000, 23424.5123905416, 27207.5493438782, 162.673351102252, 36.1815534621736, 44.4966403740479, 325.123270279694 ),
      ( 472, 0.254816804320173, 999.999999999998, 24044.1429812352, 27968.5309456314, 164.315291401763, 36.7126415504894, 45.0276733336254, 330.693786908965 ),
      ( 489, 0.245957773950818, 999.999999999999, 24672.6537364304, 28738.3922733224, 165.917613759467, 37.2264320207462, 45.5414155355229, 336.167509030321 ),
      ( 506, 0.237694060079367, 1000, 25309.7556097744, 29516.8443341039, 167.482445429061, 37.7234959820918, 46.0384369977937, 341.549689269219 ),
      ( 523, 0.229967604111881, 1000, 25955.1687061077, 30303.6072779749, 169.011720501478, 38.2043444647017, 46.5192478685937, 346.845148645029 ),
      ( 182.33, 6.61301587713101, 10000.0000000331, 15007.8503755386, 16520.0197375713, 108.51268273942, 24.3147736022176, 32.7242137567733, 214.763115406658 ),
      ( 200, 6.02485191111421, 10000.0000000132, 15446.5821614219, 17106.3739949051, 111.581475315634, 25.2698167592003, 33.6517220706186, 223.889088812136 ),
      ( 217, 5.55051153327457, 10000.0000000061, 15884.6043098015, 17686.2400581568, 114.36364120988, 26.2028318021754, 34.5683036486626, 232.217307251989 ),
      ( 234, 5.14571414796028, 10000.000000003, 16338.2744822573, 18281.6393316178, 117.004814232033, 27.1209540776995, 35.4753234222354, 240.187261820029 ),
      ( 251, 4.79612971096168, 10000.0000000016, 16807.2353049108, 18892.2498067385, 119.523466546433, 28.0094424135562, 36.3559433121948, 247.856716340662 ),
      ( 268, 4.49113861469003, 10000.0000000009, 17290.939680005, 19517.5465291661, 121.933647209846, 28.8616221844059, 37.2023467311832, 255.266608349273 ),
      ( 285, 4.22269383394976, 10000.0000000005, 17788.7646051171, 20156.92114055, 124.246506391477, 29.6756979274606, 38.0120614297767, 262.446822805185 ),
      ( 302, 3.98458184062614, 10000.0000000003, 18300.0779037542, 20809.7515407823, 126.471206553011, 30.4526412657806, 38.7856346969963, 269.4200243441 ),
      ( 319, 3.77192624304277, 10000.0000000002, 18824.274250047, 21475.4395580763, 128.615480292764, 31.1948019226918, 39.5251389576853, 276.20414566556 ),
      ( 336, 3.58084522005541, 10000.0000000001, 19360.7915750784, 22153.4283369224, 130.685981003237, 31.9050380478289, 40.2332450891916, 282.813970142064 ),
      ( 353, 3.40820955755146, 10000.0000000001, 19909.1156053426, 22843.2074888195, 132.688511225247, 32.586210524225, 40.9126839756571, 289.262121895671 ),
      ( 370, 3.25146827161904, 10000, 20468.7778041553, 23544.3114291599, 134.62817831393, 33.2409208391479, 41.5659646980207, 295.55967795438 ),
      ( 387, 3.10852069381571, 10000, 21039.3501412985, 24256.3144098313, 136.509506335704, 33.8714032195598, 42.195254415392, 301.716544762813 ),
      ( 404, 2.97762114742446, 10000, 21620.4387939394, 24978.8243993915, 138.336520957906, 34.4795080648093, 42.8023539385587, 307.741691037408 ),
      ( 421, 2.8573068981161, 10000, 22211.6779757079, 25711.4770370524, 140.112817000186, 35.0667343962053, 43.3887250087666, 313.643295157347 ),
      ( 438, 2.74634299492548, 10000, 22812.7244979046, 26453.9302826436, 141.841614223858, 35.6342843310909, 43.9555412923472, 319.42884307695 ),
      ( 455, 2.64367954779091, 10000, 23423.2532983404, 27205.8600096402, 143.525804605007, 36.1831233352835, 44.5037462441691, 325.105198429331 ),
      ( 472, 2.54841828391514, 10000, 24042.9539587564, 27966.9565697552, 145.16799302987, 36.7140372326307, 45.034108446742, 330.678657438737 ),
      ( 489, 2.4597861109483, 9999.99999999999, 24671.5281184287, 28736.9222417188, 146.770532628507, 37.2276815970934, 45.5472698146999, 336.154995664866 ),
      ( 506, 2.37711403019758, 9999.99999999999, 25308.6876418092, 29515.4694255038, 148.335555567987, 37.7246219944763, 46.0437849792614, 341.539510245048 ),
      ( 523, 2.29982017671169, 9999.99999999999, 25954.1533861499, 30302.3194302874, 149.864999910797, 38.2053651676645, 46.524151845913, 346.837059362909 ),
      ( 182.33, 28113.80582201, 99999.9996808768, -181.608884100065, -178.051912827161, -0.970028309646413, 42.2957462210127, 75.6016555956618, 1149.65450103099 ),
      ( 183.464064240587, 28038.1556749511, 100000.000000905, -95.8670036094873, -92.300435210331, -0.501175774766337, 42.2258411339645, 75.6276223291663, 1142.3050443083 ),
      ( 200, 61.3189326820133, 100000, 15381.7907341817, 17012.6084217396, 92.1098141447235, 25.9176031013876, 35.0252900274517, 221.522446747315 ),
      ( 250, 48.5643093124666, 100000.000017223, 16742.3657785994, 18801.4911205004, 100.085841025585, 28.1232301833337, 36.7733459761844, 246.162552756324 ),
      ( 300, 40.3039828590317, 100000.000003011, 18213.6614507961, 20694.8058169193, 106.983661920557, 30.436554193172, 38.9426252139568, 267.852323281377 ),
      ( 350, 34.4743920327767, 100000.00000067, 19792.1329315179, 22692.8367323447, 113.139650857438, 32.5077713834822, 40.946091568364, 287.656474296293 ),
      ( 400, 30.1294997000839, 100000.00000017, 21467.2976650562, 24786.3039876169, 118.727822577512, 34.362684970405, 42.7635410865264, 306.030270286451 ),
      ( 450, 26.7624578988895, 100000.000000046, 23229.899146004, 26966.476719628, 123.861657422727, 36.0398774038378, 44.4178245567851, 323.257047944535 ),
      ( 500, 24.0750055031042, 100000.000000013, 25071.9639989128, 29225.6494461339, 128.620814569879, 37.5627807479703, 45.925694072862, 339.539984325469 ),
      ( 182.33, 28113.8465350841, 101324.999681293, -181.629237334311, -178.025141411157, -0.970139966638676, 42.2957762426939, 75.6015050443279, 1149.66065432381 ),
      ( 183.683919103573, 28023.5043051311, 101325.000000988, -79.2618835270892, -75.6461687007876, -0.410710895453246, 42.2124926025031, 75.63296681736, 1140.88719336783 ),
      ( 200, 62.1482300903988, 101325, 15380.7703668425, 17011.146643892, 91.9951875906078, 25.9301677519748, 35.0503028920514, 221.485591214735 ),
      ( 250, 49.2140144486048, 101325.000018171, 16741.8163855601, 18800.6811449872, 99.9741910117158, 28.1257888287379, 36.7805272088273, 246.143959429195 ),
      ( 300, 40.8408991871235, 101325.000003175, 18213.2830939823, 20694.2519761542, 106.872955393108, 30.4376477636325, 38.946300354685, 267.841138289544 ),
      ( 350, 34.9326736692015, 101325.000000706, 19791.8468983818, 22692.426480701, 113.029389826162, 32.5083590417432, 40.9483355105564, 287.649419767023 ),
      ( 400, 30.5295424879559, 101325.000000179, 21467.0693491181, 24785.9857737633, 118.617808430025, 34.3630436958269, 42.7650507974654, 306.02578290538 ),
      ( 450, 27.1175348225293, 101325.000000048, 23229.7102567826, 26966.2224679098, 123.751794438873, 36.0401172763162, 44.418908369201, 323.254263352423 ),
      ( 500, 24.3942753726654, 101325.000000013, 25071.8037488212, 29225.4421927633, 128.511050869334, 37.5629526464989, 45.9265091725235, 339.538381605643 ),
      ( 182.33, 28114.781556502, 131759.999684293, -182.096667662997, -177.410164962647, -0.9727043728887, 42.296465909506, 75.5980483117644, 1149.8019714634 ),
      ( 188.201223893781, 27720.5892706855, 131760.000000657, 262.158017674487, 266.91116338557, 1.42577510660637, 41.9503503208123, 75.7756425599394, 1111.82142457381 ),
      ( 200, 81.3277574481473, 131760, 15356.7710102339, 16976.8820785122, 89.6892010112763, 26.2442465247, 35.6662210965208, 220.621986031211 ),
      ( 250, 64.1835570767318, 131760, 16729.1430947546, 18782.0053230427, 97.739465751383, 28.1856084916937, 36.9478476026969, 245.715375659697 ),
      ( 300, 53.1948065897027, 131760.000009153, 18204.5783122073, 20681.5118411782, 104.660097605317, 30.4628644027321, 39.031130336481, 267.583949230914 ),
      ( 350, 45.4701532645294, 131760.000002025, 19785.2713650963, 22682.9963680338, 110.826801946443, 32.521874114978, 41.000006421812, 287.487355399014 ),
      ( 400, 39.7244221426352, 131760.000000511, 21461.8225928876, 24778.6738620492, 116.420902514554, 34.3712876010479, 42.7997789353184, 305.922748891623 ),
      ( 450, 35.2770043526047, 131760.000000138, 23225.3704360461, 26960.3814557788, 121.558364763887, 36.0456281510644, 44.4438252797642, 323.190354205439 ),
      ( 500, 31.7298314706597, 131760.000000037, 25068.1223930097, 29220.6814799332, 126.319903317582, 37.5669012724717, 45.9452417606252, 339.501616461313 ),
      ( 200, 26931.751234333, 797731.264521933, 1146.79908502436, 1176.41956003844, 5.98724951797478, 41.3766617341142, 76.3522926518474, 1039.3907424821 ),
      ( 225, 25074.4857512307, 797731.264650996, 3087.04013587856, 3118.85459750164, 15.1350934008326, 40.5120113540932, 79.4961275802275, 878.077220108411 ),
      ( 227.6495309583, 24862.4070670102, 797731.264610617, 3298.06858184162, 3330.15442383031, 16.0687115508363, 40.4461375134144, 80.0110308444738, 860.677464605142 ),
      ( 250, 417.202914471543, 797731.264521362, 16422.001966023, 18334.0961457384, 81.512789250198, 30.0768772104096, 42.0278286301718, 235.484390118428 ),
      ( 300, 334.293317774649, 797731.264521363, 18006.9482029122, 20393.2695025175, 89.0235440882105, 31.0646793253959, 41.1071630001515, 261.815838866903 ),
      ( 350, 281.424855975127, 797731.264521361, 19638.7119719846, 22473.3274921996, 95.434209717404, 32.8258141283065, 42.1954731385894, 283.929527782116 ),
      ( 400, 243.83847254163, 797731.264521362, 21345.8549253056, 24617.4111166083, 101.158191076371, 34.5536194638109, 43.5845385082942, 303.687851812327 ),
      ( 450, 215.472229822927, 797731.264521361, 23129.8916335461, 26832.137928472, 106.37369885138, 36.1667058244841, 44.9997117683116, 321.817284762146 ),
      ( 500, 193.19805439563, 797731.264568347, 24987.3570106691, 29116.4424047422, 111.185950081469, 37.6533672754205, 46.3599055655548, 338.720748205238 ),
      ( 200, 26939.5905674152, 1000000.00000163, 1142.89992536446, 1180.0200143836, 5.96770516155766, 41.3809111737672, 76.317116826019, 1040.48501206541 ),
      ( 225, 25086.1571276215, 1000000.00013302, 3081.32202506217, 3121.1846471069, 15.1096054566, 40.5152111615545, 79.4240525998824, 879.513320038679 ),
      ( 233.948072202791, 24356.3940287655, 1000000.00002727, 3798.94270799392, 3839.99968871308, 18.2422071608068, 40.3103437577328, 81.3322750214355, 820.482859389104 ),
      ( 250, 536.19761194855, 1000000.00000001, 16314.9276085683, 18179.9116698848, 79.1879534457955, 30.9214312502121, 44.3008508745823, 231.971700876904 ),
      ( 300, 424.115477908917, 1000000, 17943.9778666415, 20301.8262642771, 86.931459727194, 31.2681608485636, 41.8332093187501, 260.005509390471 ),
      ( 350, 355.21546083659, 1000000, 19593.1443845626, 22408.3371626157, 93.4243326980016, 32.9213390630448, 42.5848867344145, 282.844364549497 ),
      ( 400, 306.959531440004, 1000000, 21310.1860724616, 24567.9444984952, 99.1899802463814, 34.6097304351016, 43.8326366606738, 303.016706525341 ),
      ( 450, 270.831889017949, 1000000, 23100.6965049651, 26793.023887926, 104.429961636589, 36.2036583085827, 45.1726462235635, 321.409988146807 ),
      ( 500, 242.60002264564, 1000000, 24962.7476090512, 29084.758765912, 109.257911944628, 37.6796484098986, 46.4876546783426, 338.492577951652 ),
      ( 200, 27184.9161254855, 7606943.63510895, 1021.05788878101, 1300.88011078072, 5.35137931854339, 41.5248166539314, 75.2800147751824, 1074.76791855413 ),
      ( 217, 26018.6539172514, 7606943.63515163, 2297.60950693446, 2589.97450242363, 11.5368323983867, 40.8716388722693, 76.5151199499425, 971.854672372171 ),
      ( 234, 24768.7339163638, 7606943.63517336, 3600.48577890381, 3907.6045707185, 17.3817301730843, 40.4093758043837, 78.6776549831716, 869.126648911264 ),
      ( 251, 23396.2321675009, 7606943.6351826, 4947.35262499178, 5272.48803913548, 23.0109959040263, 40.1058714689146, 82.1779623691854, 764.86480590758 ),
      ( 268, 21832.7455576374, 7606943.63518461, 6366.60479801683, 6715.02380995935, 28.5697905681722, 39.9633784207584, 88.0994656134089, 656.056907242004 ),
      ( 285, 19925.8319240495, 7606943.6351843, 7918.46658465706, 8300.22949745184, 34.3010166223847, 40.0741233174445, 100.058799316947, 535.791401668713 ),
      ( 302, 17109.4660358554, 7606943.63518436, 9818.34340860971, 10262.9477942313, 40.9790824817423, 41.1008425653795, 143.288485063676, 379.646113044751 ),
      ( 319, 5558.14969590335, 7606943.63518435, 15432.7399362498, 16801.3507242592, 61.9804808365003, 42.9831341363064, 168.819693806053, 206.573551908903 ),
      ( 336, 4163.74059579913, 7606943.63518435, 16879.2334590248, 18706.1829195313, 67.81470099962, 38.4069455943054, 85.1281152902627, 232.607376405533 ),
      ( 353, 3557.82938651055, 7606943.63518434, 17847.9808758396, 19986.0664355424, 71.5339920688999, 37.0365188927635, 68.2591158502002, 249.963941508184 ),
      ( 370, 3171.37272694256, 7606943.63518964, 18679.5036982368, 21078.1317656867, 74.5567923845943, 36.5855403393374, 61.0485783940969, 263.88349955015 ),
      ( 387, 2890.25539239626, 7606943.63518523, 19448.103827675, 22080.0316687917, 77.2049122831875, 36.5229223434513, 57.1765137455009, 275.839545269642 ),
      ( 404, 2671.12163322641, 7606943.63518454, 20182.9310557291, 23030.7772715512, 79.6095458858871, 36.6548704280105, 54.8595800504472, 286.485852795501 ),
      ( 421, 2492.77313590386, 7606943.63518439, 20898.4167684265, 23950.0156185666, 81.8385249491454, 36.8947240983553, 53.3932029937715, 296.179198827315 ),
      ( 438, 2343.24991552719, 7606943.63518438, 21602.7132588299, 24849.0352088609, 83.9320994302557, 37.1981545840777, 52.4413897516179, 305.139944670152 ),
      ( 455, 2215.14212044611, 7606943.63518435, 22300.8327559442, 25734.8984824595, 85.9164300100639, 37.5401016784074, 51.8228983369888, 313.515781481794 ),
      ( 472, 2103.54381069457, 7606943.63518433, 22996.0391679567, 26612.2907508855, 87.8096575568604, 37.9052705725048, 51.4310182096842, 321.41152524273 ),
      ( 489, 2005.04122802628, 7606943.63518437, 23690.5442468925, 27484.4530847035, 89.624985227027, 38.2837665202342, 51.198688305776, 328.904754147839 ),
      ( 506, 1917.16509770504, 7606943.63518433, 24385.8883353286, 28353.6966603864, 91.372389893526, 38.6689049017937, 51.0816015659479, 336.054755997496 ),
      ( 523, 1838.07291089765, 7606943.63518434, 25083.1635060719, 29221.7064278918, 93.0596401379623, 39.0560274977195, 51.0493126363331, 342.907998927937 ),
      ( 200, 27269.0794519572, 9999999.9999405, 979.352036192565, 1346.06775234127, 5.13785641759906, 41.5789514888598, 74.9510029555358, 1086.54867346123 ),
      ( 217, 26124.5084757781, 9999999.99997529, 2245.49833643231, 2628.28065783932, 11.2903771494753, 40.9219076113634, 76.0215543861403, 985.53994715102 ),
      ( 234, 24905.5414887773, 9999999.99999103, 3533.87197878281, 3935.38904696208, 17.0887234363179, 40.4528769233138, 77.9076281162127, 885.331293207419 ),
      ( 251, 23580.2836513751, 9999999.99999842, 4859.20625868646, 5283.28936760255, 22.6481361669008, 40.1359768716298, 80.8910476070002, 784.617484669286 ),
      ( 268, 22096.9504175418, 10000000.0000002, 6243.10760880415, 6695.65874418895, 28.0910426730963, 39.961912773365, 85.6679651717119, 681.362766768861 ),
      ( 285, 20355.210937925, 10000000.0000001, 7725.10066070659, 8216.37535348654, 33.59000931077, 39.9722325858323, 94.1677243950753, 571.635634948196 ),
      ( 302, 18095.1210834667, 10000000.0000001, 9403.96502129055, 9956.60017381998, 39.5155081554866, 40.3976501321203, 113.969218545167, 445.995504188459 ),
      ( 319, 14021.2230061602, 10000000.0000001, 11756.1265166065, 12469.3310634286, 47.5867637983774, 42.9552850173786, 217.563330170035, 278.483555660035 ),
      ( 336, 7272.6449903366, 10000000, 15294.6213965161, 16669.6369532066, 60.4359294788652, 42.400611007258, 165.022245079339, 222.792152086003 ),
      ( 353, 5449.27223895621, 10000000, 16869.1522720815, 18704.2597068892, 66.3568664163876, 39.1048344704827, 93.3883315543842, 241.640584484556 ),
      ( 370, 4618.18156899732, 10000000.0000162, 17936.126794983, 20101.4812425318, 70.2261433927247, 37.9031965074731, 74.0271430406239, 257.446286996948 ),
      ( 387, 4094.83002329379, 10000000.0000028, 18836.4778613044, 21278.581671015, 73.3380097377675, 37.4710545181594, 65.4132123929841, 270.838880009571 ),
      ( 404, 3718.93669743958, 10000000.0000006, 19657.9750240244, 22346.9156577506, 76.0403727017761, 37.3882225720771, 60.6907886926919, 282.605040567371 ),
      ( 421, 3428.89955575358, 10000000.0000001, 20435.910359914, 23352.2979173216, 78.4784147101505, 37.4884797092103, 57.8076779794416, 293.199597025781 ),
      ( 438, 3194.74377793519, 10000000, 21187.901603282, 24318.043077871, 80.7274854543856, 37.6939191350063, 55.9372198478873, 302.903559563758 ),
      ( 455, 2999.69572201033, 10000000, 21923.9458595712, 25257.617313854, 82.8322006544075, 37.9632641924815, 54.6818626263608, 311.903732796729 ),
      ( 472, 2833.4526318465, 10000000, 22650.2130677298, 26179.4762315481, 84.8214275360393, 38.2725158909275, 53.826298373549, 320.331510520427 ),
      ( 489, 2689.24930212678, 10000000, 23370.7389950114, 27089.2488379224, 86.7150730849092, 38.6066927287689, 53.2435334340017, 328.283334869922 ),
      ( 506, 2562.41403584613, 10000000, 24088.2748539532, 27990.8447978062, 88.5275405127342, 38.9559259385999, 52.8537134057095, 335.832353279764 ),
      ( 523, 2449.59118039877, 10000000, 24804.7526120251, 28887.0664609719, 90.2696491233654, 39.313451047544, 52.6040799582903, 343.035501572878 ),
      };

      // TestData contains:
      // 0. Temperature (Kelvin)
      // 1. Pressure (Pa)
      // 2. Saturated liquid density (mol/m³
      // 3. Saturated vapor density (mol/m³)
      _testDataSaturatedProperties = new (double temperature, double pressure, double saturatedLiquidMoleDensity, double saturatedVaporMoleDensity)[]
      {
      ( 198.22875, 213756.63335725, 27033.4315120194, 135.751566536079 ),
      ( 214.1275, 448163.405936547, 25893.7363427358, 272.163298365228 ),
      ( 230.02625, 839082.160741326, 24671.592010005, 496.210726876392 ),
      ( 245.925, 1439612.97101231, 23334.900274015, 846.166050836435 ),
      ( 261.82375, 2307033.92914981, 21832.1416657091, 1381.97197439414 ),
      ( 277.7225, 3504207.25368905, 20063.3010682745, 2216.85170944045 ),
      ( 293.62125, 5106761.07901642, 17755.3680544635, 3647.41733251453 ),
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
