using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarShipSimEditor
{
    public static class StarTypes
    {
        public const string
            GClass = "G Class Star",
            MClass = "M Class Star",
            Unknown = "Unknown";
    }

    public static class BodyTypes
    {
        public static string
            Rocky_Planet = "Rocky Planet",
            Dwarf_Planet = "Dwarf Planet",
            Gas_Giant = "Gas Giant",
            G2V_Class_Star = "G2V Class Star",
            M2V_Class_Star = "M2V Class Star",
            Class_IV_Gas_Giant = "Class IV Gas Giant",
            Earth_Analoge = "Earth Analoge";
    }
    public partial class Form1 : Form
    {
        string ColumnX = "X";
        string ColumnY = "Y";
        string ColumnZ = "Z";
        string ColumnSemiMajorAxis = "SemiMajorAxis";
        string ColumnSemiMinorAxis = "SemiMinorAxis";
        string ColumnInclination = "Inclination";
        string ColumnOrbitPosition = "OrbitPosition";
        string ColumnPlanetType = "PlanetType";
        string ColumnRadius = "Radius";
        string ColumnMass = "Mass";
        string ColumnTilt = "Tilt";
        string ColumnAtmosphere = "Atmosphere?";
        string ColumnAtmosphereOpacity = "AtmosphereOpacity";
        string ColumnAtmosphereHue = "AtmosphereHue";
        string ColumnAtmosphereTemp = "AtmosphereTemp";
        string ColumnHydrogen = "Hydrogen";
        string ColumnHelium = "Helium";
        string ColumnMethane = "Methane";
        string ColumnOther = "Other";
        string ColumnRing = "Ring?";
        string ColumnRingSeed = "RingSeed";
        string ColumnName_L0 = "Name_L0";
        string ColumnName_L1 = "Name_L1";
        string ColumnName_L2 = "Name_L2";
        string ColumnName_L3 = "Name_L3";
        string ColumnFlavourText = "FlavourText";

        string ColumnStarPitch = "SystemPitch";
        string ColumnStarYaw = "SystemYaw";
        string ColumnStarKelvin = "StarKelvin";
        string ColumnStarRadius = "StarRadius";
        string ColumnStarMass = "StarMass";
        string ColumnStarAge = "StarAge";
        string ColumnStarHydro = "HydrogenFrac";
        string ColumnStarHelium = "HeliumFrac";
        string ColumnStarMetals = "MetalsFrac";
        string ColumnStarKuipStart = "KuiperStart";
        string ColumnStarKuipEnd = "KuiperEnd";
        string ColumnStarFlav = "FlavourText";
        string ColumnStarRaceName = "RaceName";
        string ColumnStarRaceTechL = "RaceTechLevel";
        string ColumnStarRaceGov = "RaceGovernment";
        string ColumnStarRacePhys = "RacePhysiology";
        string ColumnStarRaceRel = "RaceReligion";
        string ColumnStarRaceAgg = "RaceAggression";
        string ColumnStarRaceXen = "RaceXenophobia";
        
    }
}
