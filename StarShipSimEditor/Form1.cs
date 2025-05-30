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
        private List<string> systemNames;
        private string lookuptable = "StarSystems";
        private string column_name = "SystemName";
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
            //var i = columns.IndexOf("Name_L0");
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
            }
            var conenction = openDatabase();
            SysName.Items.Clear();
            getColumns();

            getSystems();


        }

        private void OrbitalScroll_Scroll(object sender, ScrollEventArgs e) => OrbitalPosVal.Text = OrbitalScroll.Value.ToString();


        private void InclanationScroll_Scroll(object sender, ScrollEventArgs e) => InclanationVal.Text = InclanationScroll.Value.ToString();

        private void SysName_SelectedIndexChanged(object sender, EventArgs e)
        {

            SQLiteDataReader reader;
            SQLiteCommand command;
            command = connection.CreateCommand();
            command.CommandText = $"select * from CelestialObjects where Name_L2 = '{SysName.SelectedItem.ToString()}'";
            reader = command.ExecuteReader();
            reader.Read();

            GalaxyXCord.Text = readData(reader, "X");
            GalaxyYCord.Text = readData(reader, "Y");
            GalaxyZCord.Text = readData(reader, "Z");
            MajorAxisBox.Text = readData(reader, "SemiMajorAxis");
            MinorAxisBox.Text = readData(reader, "SemiMinorAxis");
            InclanationScroll.Value = Convert.ToInt32(readData(reader, "Inclination"));
            OrbitalScroll.Value = Convert.ToInt32(readData(reader, "OrbitPosition"));
            if (readData(reader, "Atmosphere?") == "1")
            { AtmosCheckBox.Checked = true; }
            else
            { AtmosCheckBox.Checked = false; }
            AtmosOpacBox.Text = readData(reader, "AtmosphereOpacity");
            AtmosHue.Text = readData(reader, "AtmosphereHue");
            AtmosTemp.Text = readData(reader, "AtmosphereTemp");
            HydrogenBox.Text = readData(reader, "Hydrogen");
            HeliumBox.Text = readData(reader, "Helium");
            MethaneBox.Text = readData(reader, "Methane");
            OtherGasBox.Text = readData(reader, "Other");
            if (readData(reader, "Ring?") == "1")
            { RingChkBox.Checked = true; }
            else
            { RingChkBox.Checked = false; }
            RingSpeedBox.Text = readData(reader, "RingSeed");
            StarClass.SelectedItem = readData(reader, "Name_L0");
            SysObJType.SelectedItem = readData(reader, "Name_L1");
            ObjFriendlyName.Text = readData(reader, "Name_L3");
            DescriptionBox.Text = readData(reader, "FlavourText");


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
    }
}

