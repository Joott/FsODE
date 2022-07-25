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
  /// Tests and test data for <see cref="Chloroethylene"/>.
  /// </summary>
  /// <remarks>
  /// <para>Reference:</para>
  /// <para>The test data was created automatically using calls into the TREND.DLL of the following software:</para>
  /// <para>TREND 3.0.: Span, R.; Eckermann, T.; Herrig, S.; Hielscher, S.; Jäger, A.; Thol, M. (2016): TREND.Thermodynamic Reference and Engineering Data 3.0.Lehrstuhl für Thermodynamik, Ruhr-Universität Bochum.</para>
  /// </remarks>
  
  public class Test_Chloroethylene : FluidTestBase
  {

    public Test_Chloroethylene()
    {
      _fluid = Chloroethylene.Instance;

      _testDataMolecularWeight = 0.06249822;

      _testDataTriplePointTemperature = 119.31;

      _testDataTriplePointPressure = 0.0649;

      _testDataTriplePointLiquidMoleDensity = 19231.0521298001;

      _testDataTriplePointVaporMoleDensity = 6.5467944090132E-05;

      _testDataCriticalPointTemperature = 424.964;

      _testDataCriticalPointPressure = 5590319.74336734;

      _testDataCriticalPointMoleDensity = 5620;

      _testDataNormalBoilingPointTemperature = 259.443328169194;

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
      ( 225, 5.20378440511958E-05, 0.0973500000682179, 18973.0136940275, 20843.7676009812, 194.887782888612, 36.7496993396612, 45.064162484817, 191.585772961279 ),
      ( 275, 4.25764171963954E-05, 0.0973500000384634, 20955.9400242955, 23242.4170566256, 204.494947699679, 42.5928445056936, 50.9073072287069, 209.108329882614 ),
      ( 325, 3.60261988867787E-05, 0.0973500000236594, 23232.4104234075, 25934.610573071, 213.476173452957, 48.4438660616691, 56.7583285493396, 225.071409884404 ),
      ( 375, 3.12227055691994E-05, 0.0973500000155482, 25796.113823467, 28914.037086068, 221.993779130614, 54.0453380022558, 62.3598003621701, 239.923133359656 ),
      ( 425, 2.75494460202562E-05, 0.0973500000106834, 28629.9217422973, 32163.5681154079, 230.121440060456, 59.2290762872596, 67.5435385744513, 253.92305954132 ),
      ( 200, 0.362331919186343, 602.338568700813, 18088.9405017978, 19751.3349440359, 117.158914414541, 33.926616950568, 42.2494600985414, 181.973630023672 ),
      ( 250, 0.289825363686132, 602.33856870081, 19927.2948725404, 22005.5759485649, 127.195555263903, 39.6536741145317, 47.9731233014642, 200.558304644964 ),
      ( 300, 0.241505206189783, 602.33856870081, 22057.1195445007, 24551.2213413269, 136.461781962244, 45.5362554660791, 53.8537339586363, 217.236049025674 ),
      ( 350, 0.206997339363409, 602.338568700809, 24478.8905075442, 27388.7760672003, 145.198605574957, 51.289635189762, 59.6060428314798, 232.606219815458 ),
      ( 400, 0.18111909263993, 602.338568700812, 27180.3406936758, 30505.9899111124, 153.515487956818, 56.6961027984433, 65.011918921887, 247.010507850504 ),
      ( 450, 0.160992765911766, 602.33856870081, 30140.822126046, 33882.223581506, 161.463031698023, 61.640798701581, 69.9562656809782, 260.649160903697 ),
      ( 200, 0.601661009783763, 1000.00000000003, 18088.3872546414, 19750.4527429126, 112.941250702188, 33.926796416589, 42.2551825488008, 181.949443937127 ),
      ( 250, 0.481218011010393, 1000, 19926.8833442672, 22004.9435521558, 122.979012227325, 39.6546631349266, 47.9774080009154, 200.543439629343 ),
      ( 300, 0.400971085401427, 1000, 22056.8208452731, 24550.7662603119, 132.245889519045, 45.5371061098641, 53.8565771522142, 217.22613148414 ),
      ( 350, 0.343669864501913, 1000, 24478.6657368394, 27388.4349755514, 140.983066637434, 51.2901470196066, 59.607839552022, 232.599265847584 ),
      ( 400, 0.300701264643836, 1000, 27180.1619130697, 30505.7215883323, 149.30014428486, 56.6963799752349, 65.0130902216009, 247.005478185724 ),
      ( 450, 0.267284546609951, 999.999999999998, 30140.6728595111, 33882.004008967, 157.24780327997, 61.6409463244941, 69.9570768212601, 260.645461805738 ),
      ( 200, 17086.7676877473, 9999.99999696268, -5109.06261497444, -5108.47736677655, -22.3089389758263, 46.7735085143551, 83.58295875632, 1528.39631550641 ),
      ( 213.224278059635, 16746.9773514895, 10000.0000024376, -3998.64616500362, -3998.04904232336, -16.9329219017978, 47.0401923618557, 84.3941221559208, 1457.43965497922 ),
      ( 225, 5.36482765688397, 10000.0000000965, 18960.8828543959, 20824.8756309887, 98.8867176463636, 36.7678876424108, 45.1911330129626, 191.113359245793 ),
      ( 275, 4.3824534115343, 10000.000000017, 20947.1187149046, 23228.9455960981, 108.515763826514, 42.6177957324055, 50.9967342833431, 208.804644823881 ),
      ( 325, 3.70531892705109, 10000.0000000039, 23225.9298037287, 25924.7528192046, 117.509139005658, 48.4608705081896, 56.815333364891, 224.863342920714 ),
      ( 375, 3.20989796725589, 10000.0000000011, 25791.1032408389, 28906.4670629949, 126.033327472835, 54.0548802184465, 62.3961164223173, 239.774743900881 ),
      ( 425, 2.83153455644019, 10000.0000000004, 28625.8332932546, 32157.4871723343, 134.164731529924, 59.2341631975057, 67.5678894746967, 253.814696443582 ),
      ( 200, 17087.8689764306, 99999.9999968701, -5110.64318368381, -5104.79107888743, -22.3168428565333, 46.7760789266691, 83.5779970589395, 1528.72954791962 ),
      ( 225, 16443.6105935151, 99999.9999730894, -3001.61493346235, -2995.53354401297, -12.3814370124956, 47.3684304834145, 85.2948192612938, 1394.22125383072 ),
      ( 250, 15783.8365134952, 99999.9999395245, -840.266754945614, -833.931159676744, -3.2738062576042, 48.3096175669535, 87.7531122453876, 1257.21550190572 ),
      ( 258.122832393389, 15563.8071274693, 99999.9999638894, -123.720579993879, -117.295416848071, -0.452928945052996, 48.6874773850065, 88.7102150482396, 1211.98814304182 ),
      ( 275, 44.6626079488917, 100000, 20865.6772855136, 23104.6867073197, 89.0729034589694, 42.8510986699228, 51.8569686626354, 205.994224213371 ),
      ( 325, 37.4806052906394, 100000.000043061, 23166.7213005243, 25834.7678613422, 98.1815517441295, 48.6178154178079, 57.349098975829, 222.962301629852 ),
      ( 375, 32.3398000801639, 100000.000011686, 25745.5887051981, 28837.7537700348, 106.766957940923, 54.1423535346738, 62.73151924422, 238.428193546169 ),
      ( 425, 28.460437520127, 100000.000003694, 28588.8200702463, 32102.4694979115, 114.93279186917, 59.2805884644848, 67.7909431271386, 252.835286758329 ),
      ( 200, 17087.8851853215, 101325.00000324, -5110.6664454167, -5104.73680585602, -22.316959193137, 46.7761167654927, 83.5779240823036, 1528.73445237551 ),
      ( 225, 16443.6302323719, 101324.999972339, -3001.64358311373, -2995.4816226135, -12.3815643767738, 47.3684685986005, 85.2947014176182, 1394.22707057248 ),
      ( 250, 15783.8608778349, 101324.999940153, -840.302491264427, -833.88295926751, -3.27394924225769, 48.3096561799344, 87.7529275612242, 1257.22252854738 ),
      ( 258.443328169194, 15555.0803092778, 101324.99996498, -95.325281196301, -88.8113321873367, -0.342976215283116, 48.7031562845762, 88.7494582672178, 1210.20338451414 ),
      ( 275, 45.2674071171215, 101325, 20864.4494528097, 23102.8149005553, 88.9589411714972, 42.8546565256097, 51.8704353929582, 205.951756537362 ),
      ( 325, 37.983749042253, 101325.000045452, 23165.8374366297, 25833.4256184266, 98.0693711476145, 48.6201797890291, 57.3572478563558, 222.933920127795 ),
      ( 375, 32.7719459050946, 101325.000012327, 25744.9129033319, 28836.7341917521, 106.655706079972, 54.1436631660071, 62.7365753521558, 238.408218050293 ),
      ( 425, 28.8397219772491, 101325.000003896, 28588.2722064563, 32101.6555907979, 114.822057092456, 59.2812806941399, 67.7942802668342, 252.820811331252 ),
      ( 200, 17098.848693321, 999999.999490145, -5126.39205018823, -5067.90858048651, -22.3956904339101, 46.8017583311277, 83.5288958026047, 1532.0511345828 ),
      ( 225, 16456.9028466424, 999999.99999969, -3020.99716411976, -2960.23238903915, -12.4677001866567, 47.3943000330542, 85.2156273679717, 1398.15720827032 ),
      ( 250, 15800.3074817833, 1000000.00001656, -864.417614033218, -801.127706468477, -3.37055476385901, 48.3358421109755, 87.6292871807032, 1261.96416050919 ),
      ( 275, 15115.2028199818, 1000000.00000032, 1361.1870565498, 1427.34561306472, 5.1229105875973, 49.6127678467478, 90.7828180128093, 1122.62102036101 ),
      ( 300, 14383.8822654756, 1000000.00000011, 3676.39699564502, 3745.91925545942, 13.1900148847976, 51.2353644303475, 94.8964046896725, 979.661329517471 ),
      ( 325, 13578.665298822, 999999.999995424, 6111.3470816629, 6184.99202230976, 20.9961963078094, 53.2288163677581, 100.580848592628, 831.942356480279 ),
      ( 332.275828057814, 13323.9142260646, 999999.999999299, 6849.36962273595, 6924.42264266931, 23.2461864200879, 53.8878858850381, 102.725354896206, 787.628606119944 ),
      ( 350, 387.169812570315, 1000000.00000002, 23830.7067487612, 26413.5527443239, 81.6435432673522, 52.9210172110632, 66.2446559266144, 212.623981181489 ),
      ( 400, 323.964497984441, 1000000, 26693.322413062, 29780.0803949444, 90.6305287768588, 57.5223999107676, 68.7439834247211, 233.487296735501 ),
      ( 450, 280.978974071838, 1000000, 29746.4137114359, 33305.3988750174, 98.9308114530494, 62.0620265523004, 72.3411177289988, 251.061565953964 ),
      ( 200, 17157.2439897849, 5869835.73053828, -5209.86626403971, -4867.74629803392, -22.816465709153, 46.9399298835437, 83.2787021661155, 1549.6963545535 ),
      ( 213, 16830.2464817026, 5869835.73053363, -4129.52036736774, -3780.75329869081, -17.5510715403878, 47.2012496833624, 83.9864975346058, 1481.81570054125 ),
      ( 226, 16501.9011956129, 5869835.73053321, -3038.95428532889, -2683.24765122944, -12.5498480321597, 47.5649041350006, 84.8909720222648, 1413.70128639308 ),
      ( 239, 16170.6176830722, 5869835.73052806, -1935.82874882518, -1572.83483940434, -7.77291520554082, 48.0213450332696, 85.9696882722799, 1345.19767158892 ),
      ( 252, 15834.8221478809, 5869835.73052089, -818.014130943738, -447.322520030607, -3.18756256581778, 48.5673164301054, 87.2133304668365, 1276.21947426759 ),
      ( 265, 15492.8865466079, 5869835.73051431, 316.556121179631, 695.429077672008, 1.23377491525023, 49.2020885947487, 88.6228129865812, 1206.74773055155 ),
      ( 278, 15143.0466386824, 5869835.73050755, 1470.00644813933, 1857.6322588869, 5.51496483298058, 49.9254995282295, 90.2083997108454, 1136.81077064107 ),
      ( 291, 14783.3002169711, 5869835.73050591, 2644.63999935145, 3041.69854814337, 9.67729931179632, 50.7372286057727, 91.9908406391994, 1066.45794478143 ),
      ( 304, 14411.270419003, 5869835.73050865, 3843.08574227939, 4250.39443608951, 13.7404689534966, 51.6368568974196, 94.0047874277841, 995.730534047237 ),
      ( 317, 14024.0082934954, 5869835.73051901, 5068.50431224699, 5487.06052012099, 17.7235365577113, 52.6244443214413, 96.3053486593766, 924.630948444405 ),
      ( 330, 13617.6883289746, 5869835.73053061, 6324.90144814683, 6755.94639415586, 21.6460723764251, 53.7015342261291, 98.9798331122425, 853.088252684864 ),
      ( 343, 13187.1084300666, 5869835.73053522, 7617.63524422505, 8062.75448789123, 25.5296900350086, 54.8727722962899, 102.16926192454, 780.914022350165 ),
      ( 356, 12724.8118368915, 5869835.73053589, 8954.28970606441, 9415.58027804114, 29.4004289819753, 56.1489013868852, 106.110603962462, 707.737904914716 ),
      ( 369, 12219.413553415, 5869835.73053573, 10346.3066509581, 10826.6763270376, 33.2929779377586, 57.552763870073, 111.229031431596, 632.90480210443 ),
      ( 382, 11652.0309245143, 5869835.73051034, 11812.4023562152, 12316.1630970283, 37.2593398197073, 59.1321088013349, 118.370795505663, 555.282870395575 ),
      ( 395, 10987.2943668303, 5869835.73053543, 13387.0241624131, 13921.2626686877, 41.3902228284315, 60.9930525743307, 129.530741276685, 472.805531634225 ),
      ( 408, 10143.5142174361, 5869835.73047914, 15147.9954563335, 15726.6741671485, 45.8854306768542, 63.423509464732, 151.127271876767, 381.004329053661 ),
      ( 421, 8809.02229527887, 5869835.73053573, 17384.758550611, 18051.1021621695, 51.4877951791239, 67.8187454964437, 229.804980332041, 264.739542661296 ),
      ( 434, 3291.27802975199, 5869835.7305358, 24393.1879620443, 26176.6397632822, 70.4778787139254, 70.7709769420367, 260.816957090407, 171.698876475047 ),
      ( 447, 2609.28434139143, 5869835.73053571, 26250.0047279043, 28499.6007713181, 75.7595660490582, 67.6586505420594, 139.189667082785, 189.990487683513 ),
      };

      // TestData contains:
      // 0. Temperature (Kelvin)
      // 1. Pressure (Pa)
      // 2. Saturated liquid density (mol/m³
      // 3. Saturated vapor density (mol/m³)
      _testDataSaturatedProperties = new (double temperature, double pressure, double saturatedLiquidMoleDensity, double saturatedVaporMoleDensity)[]
      {
      ( 195.7235, 2692.50475150437, 17196.3333556578, 1.65690077094934 ),
      ( 233.93025, 31161.8917748941, 16209.3157095459, 16.1861504969241 ),
      ( 272.137, 165888.543828435, 15176.6934162769, 76.0626713774736 ),
      ( 310.34375, 558078.580104856, 14046.1819082855, 237.02634714359 ),
      ( 348.5505, 1410542.56140194, 12731.7167405227, 587.719000926006 ),
      ( 386.75725, 2965718.60514697, 11011.1849243078, 1328.38731597836 ),
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
