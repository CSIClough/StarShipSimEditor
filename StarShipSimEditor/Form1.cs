
using Nancy.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace StarShipSimEditor
{
    public partial class Form1 : Form
    {
        SQLiteConnection stars_customConnection = null;
        SQLiteConnection stars_2000lyConnection = null;
        readonly string gaiaStars = "stars_2000ly.db";
        readonly string customStars = "stars_custom.db";
        private string databasePath;
        private List<string> columns;
        private string lookuptable = "";
        private string column_name = "SystemName";
        int starsSelected = 0;

        int sysobID = -1;

        public Form1()
        {
            InitializeComponent();

        }

        private SQLiteConnection OpenDatabase(string dbname)
        {

            var connection = new SQLiteConnection($"Data Source={databasePath + "\\" + dbname};Version=3");
            connection.Open();
            return connection;
        }

        private void GetColumns(SQLiteConnection connection)
        {
            columns = [];

            SQLiteDataReader reader;
            SQLiteCommand command;
            command = connection.CreateCommand();
            command.CommandText = $"select * from {lookuptable}";
            reader = command.ExecuteReader();
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



        public void GetSystems(SQLiteConnection connection, string table, string NamingColumn)
        {
            GetColumns(connection);
            var tmp = SysName.SelectedItem;
            SysName.Items.Clear();
            SQLiteDataReader reader;
            SQLiteCommand command;
            command = connection.CreateCommand();
            command.CommandText = $"SELECT json_group_array( json_object('Name', ifNull({NamingColumn},'N/A'))    ) AS json_result FROM (select {NamingColumn} from {table})";
            reader = command.ExecuteReader();

            reader.Read();
            string jsondata = reader.GetString(0);
            reader = null;
            JavaScriptSerializer js = new();
            SysObject[] systemobjects = js.Deserialize<SysObject[]>(jsondata);
            jsondata = null;
            GC.Collect();

            var somelist = systemobjects.Select(s => new { s.Name }).Select(a => a.Name.ToString()).ToArray();
            systemobjects = null;
            GC.Collect();

            SysName.Items.AddRange(somelist);
            somelist = null;
            GC.Collect();
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


            stars_customConnection = OpenDatabase(customStars);
            stars_2000lyConnection = OpenDatabase(gaiaStars);
            SysName.Items.Clear();

            if (starsSelected == 1)
            {
                lookuptable = StarSystemTbl;
                column_name = "SystemName";
                GetColumns(stars_customConnection);
                GetSystems(stars_customConnection, lookuptable, column_name);

            }
            else if (starsSelected == 0)
            {
                lookuptable = CelestialObjecttbl;
                column_name = "Name_L2";
                GetColumns(stars_customConnection);
                GetSystems(stars_customConnection, lookuptable, column_name);

            }
            else
            {
                lookuptable = "Stars";
                column_name = "Name1";
                GetColumns(stars_2000lyConnection);
                GetSystems(stars_2000lyConnection, lookuptable, column_name);

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
                GalaxyXCord.Text = ReadData(reader, ColumnX);
                GalaxyYCord.Text = ReadData(reader, ColumnY);
                GalaxyZCord.Text = ReadData(reader, ColumnZ);
                SysPitch.Text = ReadData(reader, ColumnStarPitch);
                SysYaw.Text = ReadData(reader, ColumnStarYaw);
                StarTemp.Text = ReadData(reader, ColumnStarKelvin);
                StarRadius.Text = ReadData(reader, ColumnStarRadius);
                StarMass.Text = ReadData(reader, ColumnStarMass);
                StarAge.Text = ReadData(reader, ColumnStarAge);
                StarHydro.Text = ReadData(reader, ColumnStarHydro);
                StarHelium.Text = ReadData(reader, ColumnStarHelium);
                StarMetals.Text = ReadData(reader, ColumnStarMetals);
                KuiperStart.Text = ReadData(reader, ColumnStarKuipStart);
                KuiperEnd.Text = ReadData(reader, ColumnStarKuipEnd);
                RaceDesc.Text = ReadData(reader, ColumnStarFlav);
                RaceName.Text = ReadData(reader, ColumnStarRaceName);
                RaceTech.Text = ReadData(reader, ColumnStarRaceTechL);
                RaceGov.Text = ReadData(reader, ColumnStarRaceGov);
                RacePhys.Text = ReadData(reader, ColumnStarRacePhys);
                RaceRelig.Text = ReadData(reader, ColumnStarRaceRel);
                RaceAgg.Text = ReadData(reader, ColumnStarRaceAgg);
                RaceXen.Text = ReadData(reader, ColumnStarRaceXen);
            }
            else if (starsSelected == 0)
            {
                command = stars_customConnection.CreateCommand();
                command.CommandText = $"select * from {lookuptable} where {column_name} = '{SysName.SelectedItem.ToString()}'";
                reader = command.ExecuteReader();
                NewBtn.BackColor = Color.DimGray;

                reader.Read();
                GalaxyXCord.Text = ReadData(reader, ColumnX);
                GalaxyYCord.Text = ReadData(reader, ColumnY);
                GalaxyZCord.Text = ReadData(reader, ColumnZ);

                sysobID = Convert.ToInt16(ReadData(reader, "ID"));

                MajorAxisBox.Text = ReadData(reader, ColumnSemiMajorAxis);
                MinorAxisBox.Text = ReadData(reader, ColumnSemiMinorAxis);
                InclanationScroll.Value = Convert.ToInt32(ReadData(reader, ColumnInclination));
                InclanationVal.Text = InclanationScroll.Value.ToString();
                OrbitalScroll.Value = Convert.ToInt32(ReadData(reader, ColumnOrbitPosition));
                OrbitalPosVal.Text = OrbitalScroll.Value.ToString();
                PlanetTypeBox.Text = ReadData(reader, ColumnPlanetType);
                RadiusBx.Text = ReadData(reader, ColumnRadius);
                MassBx.Text = ReadData(reader, ColumnMass);
                TiltBox.Text = ReadData(reader, ColumnTilt);
                if (ReadData(reader, ColumnAtmosphere) == "1")
                { AtmosCheckBox.Checked = true; }
                else
                { AtmosCheckBox.Checked = false; }
                AtmosOpacBox.Text = ReadData(reader, ColumnAtmosphereOpacity);
                AtmosHue.Text = ReadData(reader, ColumnAtmosphereHue);
                AtmosTemp.Text = ReadData(reader, ColumnAtmosphereTemp);
                HydrogenBox.Text = (Convert.ToUInt16(ReadData(reader, ColumnHydrogen)) * 100).ToString();
                HeliumBox.Text = (Convert.ToUInt16(ReadData(reader, ColumnHelium)) * 100).ToString();
                MethaneBox.Text = (Convert.ToUInt16(ReadData(reader, ColumnMethane)) * 100).ToString();
                OtherGasBox.Text = (Convert.ToUInt16(ReadData(reader, ColumnOther)) * 100).ToString();
                if (ReadData(reader, ColumnRing) == "1")
                { RingChkBox.Checked = true; }
                else
                { RingChkBox.Checked = false; }
                RingSeedBox.Text = ReadData(reader, ColumnRingSeed);
                StarClass.SelectedItem = ReadData(reader, ColumnName_L0);
                SysObJType.SelectedItem = ReadData(reader, ColumnName_L1);
                ObjFriendlyName.Text = ReadData(reader, ColumnName_L3);
                DescriptionBox.Text = ReadData(reader, ColumnFlavourText);

                if (SearchStarForObject(SysName.SelectedItem.ToString()))
                {
                    isStar.Checked = true;
                }
                else
                {
                    isStar.Checked = false;
                }
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
                GalaxyXCord.Text = ReadData(reader, ColumnX);
                GalaxyYCord.Text = ReadData(reader, ColumnY);
                GalaxyZCord.Text = ReadData(reader, ColumnZ);
                GaiaSector.Text = ReadData(reader, ColumnGaiaSector);
                GaiaName2.Text = ReadData(reader, ColumnGaiaName2);
                GaiaName3.Text = ReadData(reader, ColumnGaiaName3);
                GaiaTeff.Text = ReadData(reader, ColumnGaiaTeff);
                GaiaSpectral.Text = ReadData(reader, ColumnGaiaSprectral);


                if (ReadData(reader, ColumnGaiaBinary) == "1") { GaiaBinary.Checked = true; } else { GaiaBinary.Checked = false; }


            }
        }

        private bool SearchStarForObject(string SearchObject)
        {
            SQLiteCommand command;
            command = stars_customConnection.CreateCommand();
            command.CommandText = $"select \"{ColumnStarSysName}\" from \"{StarSystemTbl}\" where \"{ColumnStarSysName}\" = \"{SearchObject}\";";
            var item = command.ExecuteReader();
            item.Read();

            string value;
            try
            {
                value = item.GetValue(0).ToString();
            }
            catch
            {
                value = "";
            }

            if (value.Length > 0)
            {
                return true;
            }
            return false;
        }

        private string ReadData(SQLiteDataReader reader, string column_name)
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
            List<string> steampaths = [];
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
            StarClass.Items.AddRange([StarTypes.GClass, StarTypes.MClass, StarTypes.Unknown]);
            SysObJType.Items.AddRange([BodyTypes.Rocky_Planet, BodyTypes.Dwarf_Planet, BodyTypes.Gas_Giant, BodyTypes.G2V_Class_Star, BodyTypes.M2V_Class_Star, BodyTypes.Class_IV_Gas_Giant, BodyTypes.Earth_Analoge]);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SQLiteCommand command;
            command = stars_customConnection.CreateCommand();
            if (starsSelected == 1)
            {
                //Do Stuff here to save Star Systems
                if (SearchStarForObject(SysName.Text))
                {
                    command.CommandText = $@"
update {StarSystemTbl}
set 
{ColumnStarSysName} = '{SysName.Text}',
{ColumnStarYaw} = {Convert.ToUInt64(SysYaw.Text)},
{ColumnStarKelvin} = {Convert.ToUInt64(StarTemp.Text)},
{ColumnStarRadius} = {Convert.ToUInt64(StarRadius.Text)},
{ColumnStarMass} = {Convert.ToUInt64(StarMass.Text)},
{ColumnStarAge} = {Convert.ToUInt64(StarAge.Text)},
{ColumnStarHydro} = {Convert.ToUInt64(StarHydro.Text)},
{ColumnStarHelium} = {Convert.ToUInt64(StarHelium.Text)},
{ColumnStarMetals} = {Convert.ToUInt64(StarMetals.Text)},
{ColumnStarKuipStart} = {Convert.ToUInt64(KuiperStart.Text)},
{ColumnStarKuipEnd} = {Convert.ToUInt64(KuiperEnd.Text)},
{ColumnFlavourText} = '{RaceDesc.Text}',
{ColumnStarRaceName} = '{RaceName.Text}',
{ColumnStarRaceTechL} = {RaceTech.Text},
{ColumnStarRaceGov} = {RaceGov.Text},
{ColumnStarRacePhys} = {RacePhys.Text},
{ColumnStarRaceRel} = {RaceRelig.Text},
{ColumnStarRaceAgg} = {RaceAgg.Text},
{ColumnStarRaceXen} = {RaceXen.Text}
where ({ColumnX} = {GalaxyXCord.Text}) and ({ColumnY} = {GalaxyYCord.Text}) and ({ColumnZ} = {GalaxyZCord.Text})
;";
                }
                else
                {
                    command.CommandText = $@"
insert into {StarSystemTbl}
({ColumnStarSysName},{ColumnX},{ColumnY},{ColumnZ},{ColumnStarYaw},{ColumnStarKelvin},{ColumnStarRadius},{ColumnStarMass},{ColumnStarAge},{ColumnStarHydro},{ColumnStarHelium},{ColumnStarMetals},{ColumnStarKuipStart},{ColumnStarKuipEnd},{ColumnFlavourText},{ColumnStarRaceName},{ColumnStarRaceTechL},{ColumnStarRaceGov},{ColumnStarRacePhys},{ColumnStarRaceRel},{ColumnStarRaceAgg},{ColumnStarRaceXen})
Values 
('{SysName.Text}',{GalaxyXCord.Text},{GalaxyYCord.Text},{GalaxyZCord.Text},{Convert.ToUInt64(SysYaw.Text)},{Convert.ToUInt64(StarTemp.Text)},{Convert.ToUInt64(StarRadius.Text)},{Convert.ToUInt64(StarMass.Text)},{Convert.ToUInt64(StarAge.Text)},{Convert.ToUInt64(StarHydro.Text)},{Convert.ToUInt64(StarHelium.Text)},{Convert.ToUInt64(StarMetals.Text)},{Convert.ToUInt64(KuiperStart.Text)},{Convert.ToUInt64(KuiperEnd.Text)},'{RaceDesc.Text}','{RaceName.Text}',{RaceTech.Text},{RaceGov.Text},{RacePhys.Text},{RaceRelig.Text},{RaceAgg.Text},{RaceXen.Text})
;
";
                }
                command.ExecuteNonQuery();
            }
            else if (starsSelected == 0)
            {

                int atmosval = 0;
                if (AtmosCheckBox.Checked) { atmosval = 1; }
                int ringval = 0;
                if (RingChkBox.Checked) { ringval = 1; }

                if (sysobID == -1)
                {
                    command.CommandText = $@"
insert into {CelestialObjecttbl}
(ID,{ColumnName_L2},{ColumnX},{ColumnY},{ColumnZ},{ColumnSemiMajorAxis},{ColumnSemiMinorAxis},{ColumnInclination},{ColumnOrbitPosition},{ColumnPlanetType},{ColumnRadius},{ColumnMass},{ColumnTilt},'{ColumnAtmosphere}',{ColumnAtmosphereOpacity},{ColumnAtmosphereHue},{ColumnAtmosphereTemp},{ColumnHydrogen},{ColumnHelium},{ColumnMethane},{ColumnOther},'{ColumnRing}',{ColumnRingSeed},{ColumnName_L0},{ColumnName_L1},{ColumnName_L3},{ColumnFlavourText})
values
(IFNULL((Select MAX(ID) From {CelestialObjecttbl}),0) + 1,'{SysName.Text}',{GalaxyXCord.Text},{GalaxyYCord.Text},{GalaxyZCord.Text},{MajorAxisBox.Text},{MinorAxisBox.Text},{InclanationScroll.Value},{OrbitalScroll.Value},{PlanetTypeBox.Text},{RadiusBx.Text},{MassBx.Text},{TiltBox.Text},{atmosval},{AtmosOpacBox.Text},{AtmosHue.Text},{AtmosTemp.Text},{HydrogenBox.Text},{HeliumBox.Text},{MethaneBox.Text},{OtherGasBox.Text},{ringval},{RingSeedBox.Text},'{StarClass.SelectedItem}','{SysObJType.SelectedItem}','{ObjFriendlyName.Text}','{DescriptionBox.Text}')
;
";
                }
                else
                {
                    command.CommandText = $@"
update {CelestialObjecttbl}
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
{ColumnHydrogen} = {(Convert.ToUInt64(HydrogenBox.Text) / 100)},
{ColumnHelium} = {(Convert.ToUInt64(HeliumBox.Text) / 100)},
{ColumnMethane} = {(Convert.ToUInt64(MethaneBox.Text) / 100)},
{ColumnOther} = {(Convert.ToUInt64(OtherGasBox.Text) / 100)},
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
                { }

                if (isStar.Checked)
                {
                    if (!SearchStarForObject(SysName.SelectedItem.ToString()))
                    {
                        command.CommandText = $@"

insert into {StarSystemTbl}
({ColumnX},{ColumnY},{ColumnZ})
values
('{GalaxyXCord.Text}','{GalaxyYCord.Text}','{GalaxyYCord}')
;
";
                        command.ExecuteNonQuery();
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
        private static string PercentageValidate(string ToCheck)
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

        private static string DecimalNumberValidation(string Number)
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

        private static string IntNumberValidation(string Number)
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
                lookuptable = StarSystemTbl;
                column_name = "SystemName";
                GetSystems(stars_customConnection, lookuptable, column_name);
            }
            else if (TabControlSys.SelectedTab.Name == "GaiaDB")
            {
                var response = MessageBox.Show("This is experimental and dangerous, the database is large and will take a while to load, do you want to continue?", "Are you sure?", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes)
                {
                    starsSelected = 2;
                    lookuptable = "Stars";
                    column_name = "Name1";
                    GetSystems(stars_2000lyConnection, lookuptable, column_name);
                }
            }
            else
            {
                starsSelected = 0;
                lookuptable = CelestialObjecttbl;
                column_name = "Name_L2";
                GetSystems(stars_customConnection, lookuptable, column_name);
            }


        }

    }
    public class SysObject
    {
        public string Name { get; set; }
    }

}

