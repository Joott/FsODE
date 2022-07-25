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
  /// Tests and test data for <see cref="Mixture_Hexane_Water"/>.
  /// </summary>
  /// <remarks>
  /// <para>Reference:</para>
  /// <para>The test data was created automatically using calls into the TREND.DLL of the following software:</para>
  /// <para>TREND 3.0.: Span, R.; Eckermann, T.; Herrig, S.; Hielscher, S.; Jäger, A.; Thol, M. (2016): TREND.Thermodynamic Reference and Engineering Data 3.0.Lehrstuhl für Thermodynamik, Ruhr-Universität Bochum.</para>
  /// </remarks>
  
  public class Test_Mixture_Hexane_Water : MixtureTestBase
  {

    public Test_Mixture_Hexane_Water()
    {
      _mixture = MixtureOfFluids.FromCASRegistryNumbersAndMoleFractions(new[] { ("110-54-3", 0.5), ("7732-18-5", 0.5) });

      // TestData for 1 Permille to 999 Permille Molefraction contains:
      // 0. Temperature (Kelvin)
      // 1. Mole density (mol/m³)
      // 2. Pressure (Pa)
      // 3. delta*AlphaR_delta
      // 4. Isochoric heat capacity (J/mol K)
      // 5. Phasetype (1: liquid, 2: gas)
      _testData_001_999 = new (double temperature, double moleDensity, double pressure, double deltaPhiR_delta, double cv, int phase)[]
      {
      ( 300, 0.401106005794458, 999.999999764677, -0.00048306899458739, 25.5146588356316, 2 ),
      ( 300, 55058.6456961789, 999999.999869226, -0.992718450684403, 74.4189018959369, 1 ),
      ( 300, 55279.7775781025, 10000000.000201, -0.927475785632555, 73.9004508738557, 1 ),
      ( 300, 57284.372292984, 99999999.999834, -0.300136794955615, 69.8864709764823, 1 ),
      ( 350, 0.343708080484048, 999.999999939825, -0.000200793264056653, 25.7243996584179, 2 ),
      ( 350, 3.44334980451792, 9999.99934059625, -0.00202103831386378, 26.01632930261, 2 ),
      ( 350, 55972.4286526321, 100000000.000583, -0.386056538030201, 67.2235689416506, 1 ),
      ( 400, 0.300715765558448, 999.999999993924, -0.000105024819014288, 26.1062667286493, 2 ),
      ( 400, 3.01001141892932, 9999.99993686991, -0.00105301577683677, 26.2084672976972, 2 ),
      ( 400, 30.3971079385768, 99999.9999986425, -0.0108131877702711, 27.3148688189232, 2 ),
      ( 400, 51775.2745776624, 1000000.00016115, -0.994192513985875, 65.5155347676649, 1 ),
      ( 400, 52027.6728250503, 9999999.99999813, -0.9422068744166, 65.3264935377373, 1 ),
      ( 400, 54213.7809135498, 100000000.003585, -0.445373154421005, 63.6795507252552, 1 ),
      ( 500, 0.240557178139192, 999.99999999892, -4.08708964388301E-05, 27.096551929369, 2 ),
      ( 500, 2.40645762089718, 9999.99998902737, -0.000408965182166451, 27.1192976856563, 2 ),
      ( 500, 24.1541397050681, 99999.9999999996, -0.00411544649350333, 27.3522544853677, 2 ),
      ( 500, 251.601141350147, 999999.999999978, -0.043933803078767, 30.2643289523248, 2 ),
      ( 500, 46245.0056717368, 9999999.9999949, -0.947984145994336, 58.1602371156788, 1 ),
      ( 500, 49645.530495762, 100000000.000004, -0.515470287154503, 57.4581585797669, 1 ),
      ( 600, 0.200460150526788, 999.999999999996, -2.00965979876074E-05, 28.2231652051392, 2 ),
      ( 600, 2.00496423774853, 9999.99999928705, -0.000201010144527165, 28.2314314063231, 2 ),
      ( 600, 20.0860761841926, 99999.9910299777, -0.00201452907859231, 28.3147423336711, 2 ),
      ( 600, 204.672369242091, 999999.999786362, -0.0205999827775974, 29.2137780765991, 2 ),
      ( 600, 2764.99647614015, 10000000.000001, -0.275022143103959, 47.4727629085267, 2 ),
      ( 600, 43695.2459645769, 99999999.9999985, -0.541240431230823, 52.9433847327633, 1 ),
      };

      // TestData for 500 Permille to 500 Permille Molefraction contains:
      // 0. Temperature (Kelvin)
      // 1. Mole density (mol/m³)
      // 2. Pressure (Pa)
      // 3. delta*AlphaR_delta
      // 4. Isochoric heat capacity (J/mol K)
      // 5. Phasetype (1: liquid, 2: gas)
      _testData_500_500 = new (double temperature, double moleDensity, double pressure, double deltaPhiR_delta, double cv, int phase)[]
      {
      ( 300, 0.401049417201537, 999.999999999128, -0.00035035378526073, 80.1418574930963, 2 ),
      ( 350, 0.343701985208692, 999.999998488036, -0.000191381886100715, 89.7628039711539, 2 ),
      ( 350, 3.44296732200203, 9999.99999959507, -0.00191847689362892, 89.8521099688852, 2 ),
      ( 400, 0.300716527960961, 999.999999740974, -0.000115879715966711, 99.57274296415, 2 ),
      ( 400, 3.01030930954123, 9999.99729984593, -0.00116017926592674, 99.6166243067197, 2 ),
      ( 400, 30.425435787986, 100000.00000087, -0.011742401275284, 100.07239491649, 2 ),
      };

      // TestData for 999 Permille to 1 Permille Molefraction contains:
      // 0. Temperature (Kelvin)
      // 1. Mole density (mol/m³)
      // 2. Pressure (Pa)
      // 3. delta*AlphaR_delta
      // 4. Isochoric heat capacity (J/mol K)
      // 5. Phasetype (1: liquid, 2: gas)
      _testData_999_001 = new (double temperature, double moleDensity, double pressure, double deltaPhiR_delta, double cv, int phase)[]
      {
      ( 300, 0.401207224227465, 999.999987562347, -0.000751860956450172, 134.882353358015, 2 ),
      ( 300, 4.03963769823092, 9999.99042610206, -0.00757046767263692, 135.223999860829, 2 ),
      ( 300, 7595.66284869442, 1000000.01804424, -0.947219145049797, 150.787190667773, 1 ),
      ( 300, 7708.54211685256, 10000000.0000303, -0.479920371332707, 151.18500719282, 1 ),
      ( 300, 8413.18989586101, 100000000.017719, 3.76520293972961, 154.842954145941, 1 ),
      ( 350, 0.343778555922974, 999.999998370254, -0.000422389181976288, 153.832795523603, 2 ),
      ( 350, 3.45096508199914, 9999.98225610994, -0.00423985167317438, 153.999260992981, 2 ),
      ( 350, 35.9503462070658, 99999.9999996117, -0.0441445386908677, 155.748429973295, 2 ),
      ( 350, 7040.80252255855, 1000000.00000037, -0.95119400860113, 167.554027609283, 1 ),
      ( 350, 7207.04494064864, 10000000.0000014, -0.523197995284938, 167.878294097222, 1 ),
      ( 350, 8090.70012646258, 99999999.9999991, 3.24726342848595, 171.31516024451, 1 ),
      ( 400, 0.300757424942425, 999.999999704975, -0.000260162521891032, 173.051925829367, 2 ),
      ( 400, 3.01465241733965, 9999.99689630969, -0.00260747259463182, 173.14156065304, 2 ),
      ( 400, 30.892400954901, 99999.9995979709, -0.0266888623994068, 174.063267654727, 2 ),
      ( 400, 6405.05961264416, 1000000.00000001, -0.953055990526817, 185.209031849755, 1 ),
      ( 400, 6671.74753528542, 10000000.0009502, -0.549324704556292, 185.3272957398, 1 ),
      ( 400, 7784.98399028042, 99999999.9999999, 2.86229669207315, 188.49571939463, 1 ),
      ( 500, 0.240571606789918, 999.999999998976, -0.000117484704427694, 208.857813340494, 2 ),
      ( 500, 2.40826521258054, 9999.99985077875, -0.00117585864906635, 208.889973880095, 2 ),
      ( 500, 24.3430818255664, 99999.9999997085, -0.011861583041377, 209.215561095412, 2 ),
      ( 500, 276.891854939417, 999999.98435456, -0.131273312458223, 212.959427400611, 2 ),
      ( 500, 5395.64020724155, 10000000.0017305, -0.554189430534703, 219.154077609223, 1 ),
      ( 500, 7217.3577972484, 99999999.9999999, 2.33284492834078, 221.202477468225, 1 ),
      ( 600, 0.200464929512981, 999.999999998208, -6.05763055073557E-05, 239.535473058618, 2 ),
      ( 600, 2.00574317105755, 9999.99998187305, -0.000605915149619493, 239.549608394168, 2 ),
      ( 600, 20.1677874337877, 99999.999999999, -0.00607448013143203, 239.691900621991, 2 ),
      ( 600, 213.791421281324, 1000000.00009818, -0.0623908813298705, 241.209453051442, 2 ),
      ( 600, 3646.76485262194, 9999999.99999999, -0.450327086639155, 249.777031297657, 1 ),
      ( 600, 6705.32099627517, 99999999.9999993, 1.98945846439038, 249.678343848296, 1 ),
      };
    }

    [Fact]
    public override void CASNumberAttribute_Test()
    {
      base.CASNumberAttribute_Test();
    }

    [Fact]
    public override void Constants_Test()
    {
      base.Constants_Test();
    }

    [Fact]
    public override void DeltaPhiRDelta_001_999_Test()
    {
      base.DeltaPhiRDelta_001_999_Test();
    }

    [Fact]
    public override void DeltaPhiRDelta_500_500_Test()
    {
      base.DeltaPhiRDelta_500_500_Test();
    }

    [Fact]
    public override void DeltaPhiRDelta_999_001_Test()
    {
      base.DeltaPhiRDelta_999_001_Test();
    }
  }
}
