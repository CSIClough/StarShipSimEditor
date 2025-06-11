//using Nancy;
using Nancy.Json;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
//using System.Net.Http.Json;
//using System.Text.Json;
//using System.Text.Json.Nodes;
//using System.Text.Json.Serialization;
//using System.Text.Json.Serialization.Metadata;
using System.Windows.Forms;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StarShipSimEditor
{

    public class SysObject
    {
        public string Name { get; set; }
    }


    public partial class Form1 : Form
    {
        SQLiteConnection stars_customConnection = null;
        SQLiteConnection stars_2000lyConnection = null;
        string gaiaStars = "stars_2000ly.db";
        string customStars = "stars_custom.db";
        private string databasePath;
        private List<string> columns;
        private string lookuptable = "StarSystems";
        private string column_name = "SystemName";
        int starsSelected = 0;

        int sysobID = -1;

        public Form1()
        {
            InitializeComponent();

        }

        private SQLiteConnection openDatabase(string dbname)
        {

            var connection = new SQLiteConnection($"Data Source={databasePath + "\\" + dbname};Version=3");
            connection.Open();
            return connection;
        }

        private void getColumns(SQLiteConnection connection, string table)
        {
            columns = new List<string>();

            SQLiteDataReader reader;
            SQLiteCommand command;
            command = connection.CreateCommand();
            command.CommandText = $"select * from {lookuptable}";
            reader = command.ExecuteReader();
            var columncount = reader.FieldCount;

            var schemaTable = reader.GetSchemaTable();
            if (schemaTable != null)
            {
                foreach (System.Data.DataRow row in schemaTable.Rows)
                {
                    var columnName = row["ColumnName"];
                    columns.Add(columnName.ToString());
                }
            }
        }



        public void getSystems(SQLiteConnection connection, string table, string NamingColumn)
        {
            getColumns(connection, table);
            var tmp = SysName.SelectedItem;
            SysName.Items.Clear();
            SQLiteDataReader reader;
            SQLiteCommand command;
            command = connection.CreateCommand();
            command.CommandText = $"SELECT json_group_array( json_object('Name', ifNull({NamingColumn},'N/A'))    ) AS json_result FROM (select {NamingColumn} from {table})";
            reader = command.ExecuteReader();

            reader.Read();
            string jsondata = reader.GetString(0);
            
            JavaScriptSerializer js = new JavaScriptSerializer();
            SysObject[] systemobjects = js.Deserialize<SysObject[]>(jsondata);
            jsondata = null;
            

            List<string> names = new List<string>();

            var somelist = systemobjects.Select(s => new { s.Name }).Select(a => a.Name.ToString()).ToArray();

            SysName.Items.AddRange(somelist);
           
            if (SysName.Items.Contains(tmp))
            {
                SysName.SelectedItem = tmp;
            }
            else
            {
                SysName.SelectedText = "";
                SysName.Text = "";
            }
        }

        private void getDBFolder()
        {


            stars_customConnection = openDatabase(customStars);
            stars_2000lyConnection = openDatabase(gaiaStars);
            SysName.Items.Clear();

            if (starsSelected == 1)
            {
                lookuptable = "StarSystems";
                column_name = "SystemName";
                getColumns(stars_customConnection, column_name);
                getSystems(stars_customConnection, lookuptable, column_name);

            }
            else if (starsSelected == 0)
            {
                lookuptable = "CelestialObjects";
                column_name = "Name_L2";
                getColumns(stars_customConnection, column_name);
                getSystems(stars_customConnection, lookuptable, column_name);

            }
            else
            {
                lookuptable = "Stars";
                column_name = "Name1";
                getColumns(stars_2000lyConnection, column_name);
                getSystems(stars_2000lyConnection, lookuptable, column_name);

            }
        }

        private void GetDBPath_Click(object sender, EventArgs e)
        {
            if (DatabaseDiag.ShowDialog() == DialogResult.OK)
            {
                databasePath = DatabaseDiag.SelectedPath;
                DatabaseFileName.Text = databasePath;
            }
            else
            {
                MessageBox.Show("No database folder selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DatabaseFileName.Text = "None";
            }
            getDBFolder();

        }

        private void OrbitalScroll_Scroll(object sender, ScrollEventArgs e) => OrbitalPosVal.Text = OrbitalScroll.Value.ToString();
        private void InclanationScroll_Scroll(object sender, ScrollEventArgs e) => InclanationVal.Text = InclanationScroll.Value.ToString();
        private void TiltScrollBar_Scroll(object sender, ScrollEventArgs e) => TiltBox.Text = TiltScrollBar.Value.ToString();

        private void SysName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteDataReader reader;
            SQLiteCommand command;


            if (starsSelected == 1)
            {
                command = stars_customConnection.CreateCommand();
                command.CommandText = $"select * from {lookuptable} where {column_name} = '{SysName.SelectedItem.ToString()}'";
                reader = command.ExecuteReader();
                NewBtn.BackColor = Color.DimGray;

                reader.Read();
                GalaxyXCord.Text = readData(reader, ColumnX);
                GalaxyYCord.Text = readData(reader, ColumnY);
                GalaxyZCord.Text = readData(reader, ColumnZ);
                SysPitch.Text = readData(reader, ColumnStarPitch);
                SysYaw.Text = readData(reader, ColumnStarYaw);
                StarTemp.Text = readData(reader, ColumnStarKelvin);
                StarRadius.Text = readData(reader, ColumnStarRadius);
                StarMass.Text = readData(reader, ColumnStarMass);
                StarAge.Text = readData(reader, ColumnStarAge);
                StarHydro.Text = readData(reader, ColumnStarHydro);
                StarHelium.Text = readData(reader, ColumnStarHelium);
                StarMetals.Text = readData(reader, ColumnStarMetals);
                KuiperStart.Text = readData(reader, ColumnStarKuipStart);
                KuiperEnd.Text = readData(reader, ColumnStarKuipEnd);
                RaceDesc.Text = readData(reader, ColumnStarFlav);
                RaceName.Text = readData(reader, ColumnStarRaceName);
                RaceTech.Text = readData(reader, ColumnStarRaceTechL);
                RaceGov.Text = readData(reader, ColumnStarRaceGov);
                RacePhys.Text = readData(reader, ColumnStarRacePhys);
                RaceRelig.Text = readData(reader, ColumnStarRaceRel);
                RaceAgg.Text = readData(reader, ColumnStarRaceAgg);
                RaceXen.Text = readData(reader, ColumnStarRaceXen);
            }
            else if (starsSelected == 0)
            {
                command = stars_customConnection.CreateCommand();
                command.CommandText = $"select * from {lookuptable} where {column_name} = '{SysName.SelectedItem.ToString()}'";
                reader = command.ExecuteReader();
                NewBtn.BackColor = Color.DimGray;

                reader.Read();
                GalaxyXCord.Text = readData(reader, ColumnX);
                GalaxyYCord.Text = readData(reader, ColumnY);
                GalaxyZCord.Text = readData(reader, ColumnZ);

                sysobID = Convert.ToInt16(readData(reader, "ID"));

                MajorAxisBox.Text = readData(reader, ColumnSemiMajorAxis);
                MinorAxisBox.Text = readData(reader, ColumnSemiMinorAxis);
                InclanationScroll.Value = Convert.ToInt32(readData(reader, ColumnInclination));
                InclanationVal.Text = InclanationScroll.Value.ToString();
                OrbitalScroll.Value = Convert.ToInt32(readData(reader, ColumnOrbitPosition));
                OrbitalPosVal.Text = OrbitalScroll.Value.ToString();
                PlanetTypeBox.Text = readData(reader, ColumnPlanetType);
                RadiusBx.Text = readData(reader, ColumnRadius);
                MassBx.Text = readData(reader, ColumnMass);
                TiltBox.Text = readData(reader, ColumnTilt);
                if (readData(reader, ColumnAtmosphere) == "1")
                { AtmosCheckBox.Checked = true; }
                else
                { AtmosCheckBox.Checked = false; }
                AtmosOpacBox.Text = readData(reader, ColumnAtmosphereOpacity);
                AtmosHue.Text = readData(reader, ColumnAtmosphereHue);
                AtmosTemp.Text = readData(reader, ColumnAtmosphereTemp);
                HydrogenBox.Text = (Convert.ToUInt16(readData(reader, ColumnHydrogen)) * 100).ToString();
                HeliumBox.Text = (Convert.ToUInt16(readData(reader, ColumnHelium)) * 100).ToString();
                MethaneBox.Text = (Convert.ToUInt16(readData(reader, ColumnMethane)) * 100).ToString();
                OtherGasBox.Text = (Convert.ToUInt16(readData(reader, ColumnOther)) * 100).ToString();
                if (readData(reader, ColumnRing) == "1")
                { RingChkBox.Checked = true; }
                else
                { RingChkBox.Checked = false; }
                RingSeedBox.Text = readData(reader, ColumnRingSeed);
                StarClass.SelectedItem = readData(reader, ColumnName_L0);
                SysObJType.SelectedItem = readData(reader, ColumnName_L1);
                ObjFriendlyName.Text = readData(reader, ColumnName_L3);
                DescriptionBox.Text = readData(reader, ColumnFlavourText);
            }
            else
            {
                lookuptable = "Stars";
                column_name = "Name1";
                command = stars_2000lyConnection.CreateCommand();
                command.CommandText = $"select * from {lookuptable} where {column_name} = '{SysName.SelectedItem.ToString()}'";
                reader = command.ExecuteReader();
                NewBtn.BackColor = Color.DimGray;

                reader.Read();
                GalaxyXCord.Text = readData(reader, ColumnX);
                GalaxyYCord.Text = readData(reader, ColumnY);
                GalaxyZCord.Text = readData(reader, ColumnZ);
                GaiaSector.Text = readData(reader, ColumnGaiaSector);
                GaiaName2.Text = readData(reader, ColumnGaiaName2);
                GaiaName3.Text = readData(reader, ColumnGaiaName3);
                GaiaTeff.Text = readData(reader, ColumnGaiaTeff);
                GaiaSpectral.Text = readData(reader, ColumnGaiaSprectral);


                if (readData(reader, ColumnGaiaBinary) == "1") { GaiaBinary.Checked = true; } else { GaiaBinary.Checked = false; }


            }
        }

        private string readData(SQLiteDataReader reader, string column_name)
        {
            try
            {
                string value;
                value = reader.GetValue(columns.IndexOf(column_name)).ToString();
                return value;
            }
            catch
            {
                return "";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string steampath = "C:\\Program Files (x86)\\Steam\\SteamApps\\libraryfolders.vdf";
            string targetloc = "steamapps\\common\\Starship Simulator Dev Playtest\\StarshipSimulator\\Content";
            var steamcontents = File.ReadAllLines(steampath);
            List<string> steampaths = new List<string>();
            foreach (var item in steamcontents)
            {
                if (item.Contains("path"))
                {
                    var tmp = item.Replace('"', '\0');
                    tmp = tmp.Split('\0')[3];
                    var starshiploc = $"{tmp}\\{targetloc}";
                    if (Directory.Exists(starshiploc))
                    {
                        steampaths.Add(starshiploc);
                    }
                }
            }

            foreach (var item in steampaths)
            {
                var path = item + "\\" + customStars;
                if (File.Exists(path))
                {
                    path = item + "\\" + gaiaStars;
                    if (File.Exists(path))
                    {
                        databasePath = item;
                        break;
                    }
                }
            }

            DatabaseFileName.Text = databasePath;
            getDBFolder();

            TabControlSys.SelectedIndex = 1;
            StarClass.Items.AddRange(new string[] { StarTypes.GClass, StarTypes.MClass, StarTypes.Unknown });
            SysObJType.Items.AddRange(new string[] { BodyTypes.Rocky_Planet, BodyTypes.Dwarf_Planet, BodyTypes.Gas_Giant, BodyTypes.G2V_Class_Star, BodyTypes.M2V_Class_Star, BodyTypes.Class_IV_Gas_Giant, BodyTypes.Earth_Analoge });
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (starsSelected == 1)
            {
                //Do Stuff here to save Star Systems
            }
            else if (starsSelected == 0)
            {
                SQLiteCommand command;
                command = stars_customConnection.CreateCommand();
                int atmosval = 0;
                if (AtmosCheckBox.Checked) { atmosval = 1; }
                int ringval = 0;
                if (RingChkBox.Checked) { ringval = 1; }

                if (sysobID == -1)
                {
                    command.CommandText = $@"
insert into CelestialObjects
(ID,{ColumnName_L2},{ColumnX},{ColumnY},{ColumnZ},{ColumnSemiMajorAxis},{ColumnSemiMinorAxis},{ColumnInclination},{ColumnOrbitPosition},{ColumnPlanetType},{ColumnRadius},{ColumnMass},{ColumnTilt},'{ColumnAtmosphere}',{ColumnAtmosphereOpacity},{ColumnAtmosphereHue},{ColumnAtmosphereTemp},{ColumnHydrogen},{ColumnHelium},{ColumnMethane},{ColumnOther},'{ColumnRing}',{ColumnRingSeed},{ColumnName_L0},{ColumnName_L1},{ColumnName_L3},{ColumnFlavourText})
values
(IFNULL((Select MAX(ID) From CelestialObjects),0) + 1,'{SysName.Text}',{GalaxyXCord.Text},{GalaxyYCord.Text},{GalaxyZCord.Text},{MajorAxisBox.Text},{MinorAxisBox.Text},{InclanationScroll.Value},{OrbitalScroll.Value},{PlanetTypeBox.Text},{RadiusBx.Text},{MassBx.Text},{TiltBox.Text},{atmosval},{AtmosOpacBox.Text},{AtmosHue.Text},{AtmosTemp.Text},{HydrogenBox.Text},{HeliumBox.Text},{MethaneBox.Text},{OtherGasBox.Text},{ringval},{RingSeedBox.Text},'{StarClass.SelectedItem}','{SysObJType.SelectedItem}','{ObjFriendlyName.Text}','{DescriptionBox.Text}')
;
";
                }
                else
                {
                    command.CommandText = $@"
update CelestialObjects
set 
{ColumnName_L2} = '{SysName.Text}',
{ColumnX} = {GalaxyXCord.Text},
{ColumnY} = {GalaxyYCord.Text},
{ColumnZ} = {GalaxyZCord.Text},
{ColumnSemiMajorAxis} = {MajorAxisBox.Text},
{ColumnSemiMinorAxis} = {MinorAxisBox.Text},
{ColumnInclination} = {InclanationScroll.Value},
{ColumnOrbitPosition} = {OrbitalScroll.Value},
{ColumnPlanetType} = {PlanetTypeBox.Text},
{ColumnRadius} = {RadiusBx.Text},
{ColumnMass} = {MassBx.Text},
{ColumnTilt} = {TiltBox.Text},
'{ColumnAtmosphere}' = {atmosval},
{ColumnAtmosphereOpacity} = {AtmosOpacBox.Text},
{ColumnAtmosphereHue} = {AtmosHue.Text},
{ColumnAtmosphereTemp} = {AtmosTemp.Text},
{ColumnHydrogen} = {(Convert.ToUInt16(HydrogenBox.Text) / 100)},
{ColumnHelium} = {(Convert.ToUInt16(HeliumBox.Text) / 100)},
{ColumnMethane} = {(Convert.ToUInt16(MethaneBox.Text) / 100)},
{ColumnOther} = {(Convert.ToUInt16(OtherGasBox.Text) / 100)},
'{ColumnRing}' = {ringval},
{ColumnRingSeed} = {RingSeedBox.Text},
{ColumnName_L0} = '{StarClass.SelectedItem}',
{ColumnName_L1} = '{SysObJType.SelectedItem}',
{ColumnName_L3} = '{ObjFriendlyName.Text}',
{ColumnFlavourText} = '{DescriptionBox.Text}'
where ID = {sysobID}
;
";
                }
                try
                {

                    command.ExecuteNonQuery();
                }
                catch
                {
                    try
                    {

                        command.ExecuteNonQuery();
                    }
                    catch
                    {

                    }

                }
            }
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            sysobID = -1;
            NewBtn.BackColor = Color.Red;
        }

        private void HydrogenBox_TextChanged(object sender, EventArgs e) => HydrogenBox.Text = PercentageValidate(HydrogenBox.Text);
        private void HeliumBox_TextChanged(object sender, EventArgs e) => HeliumBox.Text = PercentageValidate(HeliumBox.Text);
        private void MethaneBox_TextChanged(object sender, EventArgs e) => MethaneBox.Text = PercentageValidate(MethaneBox.Text);
        private void OtherGasBox_TextChanged(object sender, EventArgs e) => OtherGasBox.Text = PercentageValidate(OtherGasBox.Text);
        private string PercentageValidate(string ToCheck)
        {
            string ReturnableString = "0";
            if (ToCheck == "") { ReturnableString = "0"; return ReturnableString; }
            try
            {
                var tempval = Convert.ToDecimal(ToCheck);
                if ((tempval <= 100) && (tempval >= 0))
                {
                    ReturnableString = tempval.ToString();
                }
                else
                {
                    ReturnableString = "0";
                }
            }
            catch
            {

            }
            return ReturnableString;
        }

        private void AtmosTemp_TextChanged(object sender, EventArgs e) => AtmosTemp.Text = DecimalNumberValidation(AtmosTemp.Text);
        private void AtmosHue_TextChanged(object sender, EventArgs e) => AtmosHue.Text = DecimalNumberValidation(AtmosHue.Text);
        private void AtmosOpacBox_TextChanged(object sender, EventArgs e) => AtmosOpacBox.Text = DecimalNumberValidation(AtmosOpacBox.Text);
        private void MinorAxisBox_TextChanged(object sender, EventArgs e) => MinorAxisBox.Text = DecimalNumberValidation(MinorAxisBox.Text);
        private void MajorAxisBox_TextChanged(object sender, EventArgs e) => MajorAxisBox.Text = DecimalNumberValidation(MajorAxisBox.Text);
        private void GalaxyXCord_TextChanged(object sender, EventArgs e) => GalaxyXCord.Text = DecimalNumberValidation(GalaxyXCord.Text);
        private void GalaxyYCord_TextChanged(object sender, EventArgs e) => GalaxyYCord.Text = DecimalNumberValidation(GalaxyYCord.Text);
        private void GalaxyZCord_TextChanged(object sender, EventArgs e) => GalaxyZCord.Text = DecimalNumberValidation(GalaxyZCord.Text);
        private void RadiusBx_TextChanged(object sender, EventArgs e) => RadiusBx.Text = DecimalNumberValidation(RadiusBx.Text);
        private void MassBx_TextChanged(object sender, EventArgs e) => MassBx.Text = DecimalNumberValidation(MassBx.Text);

        private string DecimalNumberValidation(string Number)
        {
            try
            {
                return Convert.ToDecimal(Number).ToString();
            }
            catch
            {
                return "0";
            }
        }

        private void OrbitalPosVal_TextChanged(object sender, EventArgs e) => OrbitalPosVal.Text = IntNumberValidation(OrbitalPosVal.Text);
        private void InclanationVal_TextChanged(object sender, EventArgs e) => InclanationVal.Text = IntNumberValidation(InclanationVal.Text);
        private void TiltBox_TextChanged(object sender, EventArgs e) => TiltBox.Text = IntNumberValidation(TiltBox.Text);

        private string IntNumberValidation(string Number)
        {
            try
            {
                return Convert.ToInt64(Number).ToString();
            }
            catch
            {
                return "0";
            }
        }

        private void RingChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (RingChkBox.Checked)
            {
                RingSeedBox.Enabled = true;
            }
            else
            {
                RingSeedBox.Enabled = false;
            }
        }
        private void ToggleStarCheck(object sender, MouseEventArgs e)
        {
            if (TabControlSys.SelectedTab.Name == "StarTabControl")
            {
                starsSelected = 1;
                lookuptable = "StarSystems";
                column_name = "SystemName";
                getSystems(stars_customConnection, lookuptable, column_name);
            }
            else if (TabControlSys.SelectedTab.Name == "GaiaDB")
            {
                var response = MessageBox.Show("This is experimental and dangerous, the database is large and will take a while to load, do you want to continue?", "Are you sure?", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes)
                {
                    starsSelected = 2;
                    lookuptable = "Stars";
                    column_name = "Name1";
                    getSystems(stars_2000lyConnection, lookuptable, column_name);
                }
            }
            else
            {
                starsSelected = 0;
                lookuptable = "CelestialObjects";
                column_name = "Name_L2";
                getSystems(stars_customConnection, lookuptable, column_name);
            }


        }

    }
}

