using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace StarShipSimEditor
{


    public partial class Form1 : Form
    {
        SQLiteConnection connection = null;
        private string databasePath;
        private List<string> columns;
        private string lookuptable = "StarSystems";
        private string column_name = "SystemName";

        int sysobID = -1;
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

        public Form1()
        {
            InitializeComponent();

        }



        private SQLiteConnection openDatabase()
        {
            connection = new SQLiteConnection($"Data Source={databasePath};Version=3");
            connection.Open();
            return connection;
        }

        private void getColumns()
        {
            columns = new List<string>();

            SQLiteDataReader reader;
            SQLiteCommand command;
            command = connection.CreateCommand();
            command.CommandText = "select * from CelestialObjects";
            reader = command.ExecuteReader();
            //dataGridView1.DataSource = reader;
            var columncount = reader.FieldCount;
            if (columncount != 27)
            {
                MessageBox.Show("Warning this tool does not work with this database version");
            }
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
        public void getSystems()
        {
            SysName.Items.Clear();
            SQLiteDataReader reader;
            SQLiteCommand command;
            command = connection.CreateCommand();
            command.CommandText = $"select DISTINCT {column_name} from {lookuptable}";
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                SysName.Items.Add(reader.GetString(0));
            }
        }

        private void GetDBPath_Click(object sender, EventArgs e)
        {

            if (DatabaseDiag.ShowDialog() == DialogResult.OK)
            {
                databasePath = DatabaseDiag.FileName;
                DatabseFileName.Text = databasePath;
            }
            else
            {
                MessageBox.Show("No database selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DatabseFileName.Text = "None";
            }
            var conenction = openDatabase();
            SysName.Items.Clear();
            getColumns();
            if (StarBox.Checked)
            {
                lookuptable = "StarSystems";
                column_name = "SystemName";
            }
            else
            {
                lookuptable = "CelestialObjects";
                column_name = "Name_L2";
            }
            getSystems();


        }

        private void OrbitalScroll_Scroll(object sender, ScrollEventArgs e) => OrbitalPosVal.Text = OrbitalScroll.Value.ToString();


        private void InclanationScroll_Scroll(object sender, ScrollEventArgs e) => InclanationVal.Text = InclanationScroll.Value.ToString();
        private void TiltScrollBar_Scroll(object sender, ScrollEventArgs e) => TiltBox.Text = TiltScrollBar.Value.ToString();

        private void SysName_SelectedIndexChanged(object sender, EventArgs e)
        {

            SQLiteDataReader reader;
            SQLiteCommand command;
            command = connection.CreateCommand();
            command.CommandText = $"select * from CelestialObjects where Name_L2 = '{SysName.SelectedItem.ToString()}'";
            reader = command.ExecuteReader();
            reader.Read();
            sysobID = Convert.ToInt16(readData(reader, "ID"));
            GalaxyXCord.Text = readData(reader, ColumnX);
            GalaxyYCord.Text = readData(reader, ColumnY);
            GalaxyZCord.Text = readData(reader, ColumnZ);
            MajorAxisBox.Text = readData(reader, ColumnSemiMajorAxis);
            MinorAxisBox.Text = readData(reader, ColumnSemiMinorAxis);
            InclanationScroll.Value = Convert.ToInt32(readData(reader, ColumnInclination));
            InclanationVal.Text = InclanationScroll.Value.ToString();
            OrbitalScroll.Value = Convert.ToInt32(readData(reader, ColumnOrbitPosition));
            OrbitalPosVal.Text = OrbitalScroll.Value.ToString();
            PlanetTypeBox.Text = readData(reader,ColumnPlanetType);
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
            HydrogenBox.Text = readData(reader, ColumnHydrogen);
            HeliumBox.Text = readData(reader, ColumnHelium);
            MethaneBox.Text = readData(reader, ColumnMethane);
            OtherGasBox.Text = readData(reader, ColumnOther);
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

        private void StarBox_CheckedChanged(object sender, EventArgs e)
        {
            if (StarBox.Checked)
            {
                lookuptable = "StarSystems";
                column_name = "SystemName";
            }
            else
            {
                lookuptable = "CelestialObjects";
                column_name = "Name_L2";
            }
            getSystems();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StarClass.Items.AddRange(new string[] { StarTypes.GClass, StarTypes.MClass, StarTypes.Unknown });
            SysObJType.Items.AddRange(new string[] { BodyTypes.Rocky_Planet, BodyTypes.Dwarf_Planet, BodyTypes.Gas_Giant, BodyTypes.G2V_Class_Star, BodyTypes.M2V_Class_Star, BodyTypes.Class_IV_Gas_Giant, BodyTypes.Earth_Analoge });
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SQLiteCommand command;
            command = connection.CreateCommand();
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
{ColumnHydrogen} = {HydrogenBox.Text},
{ColumnHelium} = {HeliumBox.Text},
{ColumnMethane} = {MethaneBox.Text},
{ColumnOther} = {OtherGasBox.Text},
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

        private void NewBtn_Click(object sender, EventArgs e)
        {
            sysobID = -1;
        }


    }
}

