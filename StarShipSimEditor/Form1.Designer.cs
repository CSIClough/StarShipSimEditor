namespace StarShipSimEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GetDBPath = new System.Windows.Forms.Button();
            this.DatabaseDiag = new System.Windows.Forms.OpenFileDialog();
            this.DatabseFileName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SysName = new System.Windows.Forms.ComboBox();
            this.GalaxyXCord = new System.Windows.Forms.TextBox();
            this.GalaxyYCord = new System.Windows.Forms.TextBox();
            this.GalaxyZCord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MajorAxisBox = new System.Windows.Forms.TextBox();
            this.MinorAxisBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OrbitalScroll = new System.Windows.Forms.HScrollBar();
            this.OrbitalPosVal = new System.Windows.Forms.TextBox();
            this.InclanationVal = new System.Windows.Forms.TextBox();
            this.InclanationScroll = new System.Windows.Forms.HScrollBar();
            this.AtmosCheckBox = new System.Windows.Forms.CheckBox();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.AtmosOpacBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.StarBox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AtmosHue = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.AtmosTemp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.MethaneBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.HeliumBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.HydrogenBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.OtherGasBox = new System.Windows.Forms.TextBox();
            this.StarClass = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SysObJType = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.RingChkBox = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.RingSpeedBox = new System.Windows.Forms.TextBox();
            this.ObjFriendlyName = new System.Windows.Forms.TextBox();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetDBPath
            // 
            this.GetDBPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GetDBPath.Location = new System.Drawing.Point(5, 12);
            this.GetDBPath.Name = "GetDBPath";
            this.GetDBPath.Size = new System.Drawing.Size(194, 32);
            this.GetDBPath.TabIndex = 0;
            this.GetDBPath.Text = "Select Database";
            this.GetDBPath.UseVisualStyleBackColor = true;
            this.GetDBPath.Click += new System.EventHandler(this.GetDBPath_Click);
            // 
            // DatabaseDiag
            // 
            this.DatabaseDiag.FileName = "openFileDialog1";
            // 
            // DatabseFileName
            // 
            this.DatabseFileName.AutoSize = true;
            this.DatabseFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DatabseFileName.Location = new System.Drawing.Point(281, 12);
            this.DatabseFileName.Name = "DatabseFileName";
            this.DatabseFileName.Size = new System.Drawing.Size(208, 25);
            this.DatabseFileName.TabIndex = 1;
            this.DatabseFileName.Text = "No Database Selected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Object Name";
            // 
            // SysName
            // 
            this.SysName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SysName.FormattingEnabled = true;
            this.SysName.Location = new System.Drawing.Point(175, 171);
            this.SysName.Name = "SysName";
            this.SysName.Size = new System.Drawing.Size(314, 33);
            this.SysName.TabIndex = 4;
            this.SysName.SelectedIndexChanged += new System.EventHandler(this.SysName_SelectedIndexChanged);
            // 
            // GalaxyXCord
            // 
            this.GalaxyXCord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GalaxyXCord.Location = new System.Drawing.Point(27, 259);
            this.GalaxyXCord.Name = "GalaxyXCord";
            this.GalaxyXCord.Size = new System.Drawing.Size(100, 30);
            this.GalaxyXCord.TabIndex = 5;
            // 
            // GalaxyYCord
            // 
            this.GalaxyYCord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GalaxyYCord.Location = new System.Drawing.Point(152, 259);
            this.GalaxyYCord.Name = "GalaxyYCord";
            this.GalaxyYCord.Size = new System.Drawing.Size(100, 30);
            this.GalaxyYCord.TabIndex = 6;
            // 
            // GalaxyZCord
            // 
            this.GalaxyZCord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GalaxyZCord.Location = new System.Drawing.Point(277, 259);
            this.GalaxyZCord.Name = "GalaxyZCord";
            this.GalaxyZCord.Size = new System.Drawing.Size(100, 30);
            this.GalaxyZCord.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Galaxy X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Galaxy Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Galaxy Z";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Major Axis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Minor Axis";
            // 
            // MajorAxisBox
            // 
            this.MajorAxisBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MajorAxisBox.Location = new System.Drawing.Point(27, 321);
            this.MajorAxisBox.Name = "MajorAxisBox";
            this.MajorAxisBox.Size = new System.Drawing.Size(248, 30);
            this.MajorAxisBox.TabIndex = 13;
            // 
            // MinorAxisBox
            // 
            this.MinorAxisBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MinorAxisBox.Location = new System.Drawing.Point(29, 392);
            this.MinorAxisBox.Name = "MinorAxisBox";
            this.MinorAxisBox.Size = new System.Drawing.Size(248, 30);
            this.MinorAxisBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 531);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Inclination";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Orbital Position";
            // 
            // OrbitalScroll
            // 
            this.OrbitalScroll.Location = new System.Drawing.Point(28, 487);
            this.OrbitalScroll.Maximum = 360;
            this.OrbitalScroll.Name = "OrbitalScroll";
            this.OrbitalScroll.Size = new System.Drawing.Size(390, 21);
            this.OrbitalScroll.TabIndex = 17;
            this.OrbitalScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.OrbitalScroll_Scroll);
            // 
            // OrbitalPosVal
            // 
            this.OrbitalPosVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.OrbitalPosVal.Location = new System.Drawing.Point(175, 451);
            this.OrbitalPosVal.Name = "OrbitalPosVal";
            this.OrbitalPosVal.Size = new System.Drawing.Size(100, 30);
            this.OrbitalPosVal.TabIndex = 18;
            // 
            // InclanationVal
            // 
            this.InclanationVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.InclanationVal.Location = new System.Drawing.Point(175, 535);
            this.InclanationVal.Name = "InclanationVal";
            this.InclanationVal.Size = new System.Drawing.Size(100, 30);
            this.InclanationVal.TabIndex = 19;
            // 
            // InclanationScroll
            // 
            this.InclanationScroll.Location = new System.Drawing.Point(27, 571);
            this.InclanationScroll.Maximum = 360;
            this.InclanationScroll.Name = "InclanationScroll";
            this.InclanationScroll.Size = new System.Drawing.Size(390, 21);
            this.InclanationScroll.TabIndex = 20;
            this.InclanationScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.InclanationScroll_Scroll);
            // 
            // AtmosCheckBox
            // 
            this.AtmosCheckBox.AutoSize = true;
            this.AtmosCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AtmosCheckBox.Location = new System.Drawing.Point(619, 153);
            this.AtmosCheckBox.Name = "AtmosCheckBox";
            this.AtmosCheckBox.Size = new System.Drawing.Size(151, 29);
            this.AtmosCheckBox.TabIndex = 21;
            this.AtmosCheckBox.Text = "Atmosphere?";
            this.AtmosCheckBox.UseVisualStyleBackColor = true;
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // AtmosOpacBox
            // 
            this.AtmosOpacBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AtmosOpacBox.Location = new System.Drawing.Point(617, 226);
            this.AtmosOpacBox.Name = "AtmosOpacBox";
            this.AtmosOpacBox.Size = new System.Drawing.Size(100, 30);
            this.AtmosOpacBox.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(615, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Atmospheric Opacity";
            // 
            // StarBox
            // 
            this.StarBox.AutoSize = true;
            this.StarBox.Checked = true;
            this.StarBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StarBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StarBox.Location = new System.Drawing.Point(27, 142);
            this.StarBox.Name = "StarBox";
            this.StarBox.Size = new System.Drawing.Size(81, 29);
            this.StarBox.TabIndex = 24;
            this.StarBox.Text = "Star?";
            this.StarBox.UseVisualStyleBackColor = true;
            this.StarBox.CheckedChanged += new System.EventHandler(this.StarBox_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(615, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 25);
            this.label10.TabIndex = 26;
            this.label10.Text = "Atmospheric Hue";
            // 
            // AtmosHue
            // 
            this.AtmosHue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AtmosHue.Location = new System.Drawing.Point(617, 301);
            this.AtmosHue.Name = "AtmosHue";
            this.AtmosHue.Size = new System.Drawing.Size(100, 30);
            this.AtmosHue.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(615, 346);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(271, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "Atmospheric Temparature (K)";
            // 
            // AtmosTemp
            // 
            this.AtmosTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AtmosTemp.Location = new System.Drawing.Point(617, 374);
            this.AtmosTemp.Name = "AtmosTemp";
            this.AtmosTemp.Size = new System.Drawing.Size(100, 30);
            this.AtmosTemp.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(951, 346);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 25);
            this.label12.TabIndex = 34;
            this.label12.Text = "Methane %";
            // 
            // MethaneBox
            // 
            this.MethaneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MethaneBox.Location = new System.Drawing.Point(953, 374);
            this.MethaneBox.Name = "MethaneBox";
            this.MethaneBox.Size = new System.Drawing.Size(100, 30);
            this.MethaneBox.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(951, 273);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 25);
            this.label13.TabIndex = 32;
            this.label13.Text = "Helium %";
            // 
            // HeliumBox
            // 
            this.HeliumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HeliumBox.Location = new System.Drawing.Point(953, 301);
            this.HeliumBox.Name = "HeliumBox";
            this.HeliumBox.Size = new System.Drawing.Size(100, 30);
            this.HeliumBox.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(951, 198);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 25);
            this.label14.TabIndex = 30;
            this.label14.Text = "Hydrogen %";
            // 
            // HydrogenBox
            // 
            this.HydrogenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HydrogenBox.Location = new System.Drawing.Point(953, 226);
            this.HydrogenBox.Name = "HydrogenBox";
            this.HydrogenBox.Size = new System.Drawing.Size(100, 30);
            this.HydrogenBox.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(948, 419);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 25);
            this.label15.TabIndex = 36;
            this.label15.Text = "Other %";
            // 
            // OtherGasBox
            // 
            this.OtherGasBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.OtherGasBox.Location = new System.Drawing.Point(950, 447);
            this.OtherGasBox.Name = "OtherGasBox";
            this.OtherGasBox.Size = new System.Drawing.Size(100, 30);
            this.OtherGasBox.TabIndex = 35;
            // 
            // StarClass
            // 
            this.StarClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StarClass.FormattingEnabled = true;
            this.StarClass.Location = new System.Drawing.Point(235, 644);
            this.StarClass.Name = "StarClass";
            this.StarClass.Size = new System.Drawing.Size(321, 33);
            this.StarClass.TabIndex = 38;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(22, 647);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 25);
            this.label16.TabIndex = 37;
            this.label16.Text = "Star Class";
            // 
            // SysObJType
            // 
            this.SysObJType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SysObJType.FormattingEnabled = true;
            this.SysObJType.Location = new System.Drawing.Point(235, 701);
            this.SysObJType.Name = "SysObJType";
            this.SysObJType.Size = new System.Drawing.Size(321, 33);
            this.SysObJType.TabIndex = 40;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(22, 704);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(190, 25);
            this.label17.TabIndex = 39;
            this.label17.Text = "System Object Type";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(22, 763);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(200, 25);
            this.label18.TabIndex = 41;
            this.label18.Text = "Object Friendly Name";
            // 
            // RingChkBox
            // 
            this.RingChkBox.AutoSize = true;
            this.RingChkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RingChkBox.Location = new System.Drawing.Point(1188, 153);
            this.RingChkBox.Name = "RingChkBox";
            this.RingChkBox.Size = new System.Drawing.Size(84, 29);
            this.RingChkBox.TabIndex = 43;
            this.RingChkBox.Text = "Ring?";
            this.RingChkBox.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label19.Location = new System.Drawing.Point(1183, 198);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 25);
            this.label19.TabIndex = 45;
            this.label19.Text = "Ring Seed";
            // 
            // RingSpeedBox
            // 
            this.RingSpeedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RingSpeedBox.Location = new System.Drawing.Point(1185, 226);
            this.RingSpeedBox.Name = "RingSpeedBox";
            this.RingSpeedBox.Size = new System.Drawing.Size(100, 30);
            this.RingSpeedBox.TabIndex = 44;
            // 
            // ObjFriendlyName
            // 
            this.ObjFriendlyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ObjFriendlyName.Location = new System.Drawing.Point(235, 763);
            this.ObjFriendlyName.Name = "ObjFriendlyName";
            this.ObjFriendlyName.Size = new System.Drawing.Size(321, 30);
            this.ObjFriendlyName.TabIndex = 46;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DescriptionBox.Location = new System.Drawing.Point(730, 644);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(467, 149);
            this.DescriptionBox.TabIndex = 47;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label20.Location = new System.Drawing.Point(601, 647);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 25);
            this.label20.TabIndex = 48;
            this.label20.Text = "Description";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(5, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 32);
            this.button1.TabIndex = 49;
            this.button1.Text = "New Object";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(224, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 32);
            this.button2.TabIndex = 50;
            this.button2.Text = "Save Changes";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1338, 820);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.ObjFriendlyName);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.RingSpeedBox);
            this.Controls.Add(this.RingChkBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.SysObJType);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.StarClass);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.OtherGasBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.MethaneBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.HeliumBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.HydrogenBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.AtmosTemp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AtmosHue);
            this.Controls.Add(this.StarBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AtmosOpacBox);
            this.Controls.Add(this.AtmosCheckBox);
            this.Controls.Add(this.InclanationScroll);
            this.Controls.Add(this.InclanationVal);
            this.Controls.Add(this.OrbitalPosVal);
            this.Controls.Add(this.OrbitalScroll);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MinorAxisBox);
            this.Controls.Add(this.MajorAxisBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GalaxyZCord);
            this.Controls.Add(this.GalaxyYCord);
            this.Controls.Add(this.GalaxyXCord);
            this.Controls.Add(this.SysName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatabseFileName);
            this.Controls.Add(this.GetDBPath);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Starship Simulator Database Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetDBPath;
        private System.Windows.Forms.OpenFileDialog DatabaseDiag;
        private System.Windows.Forms.Label DatabseFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SysName;
        private System.Windows.Forms.TextBox GalaxyXCord;
        private System.Windows.Forms.TextBox GalaxyYCord;
        private System.Windows.Forms.TextBox GalaxyZCord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MajorAxisBox;
        private System.Windows.Forms.TextBox MinorAxisBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.HScrollBar OrbitalScroll;
        private System.Windows.Forms.TextBox OrbitalPosVal;
        private System.Windows.Forms.TextBox InclanationVal;
        private System.Windows.Forms.HScrollBar InclanationScroll;
        private System.Windows.Forms.CheckBox AtmosCheckBox;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.TextBox AtmosOpacBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox StarBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox AtmosHue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox AtmosTemp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox MethaneBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox HeliumBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox HydrogenBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox OtherGasBox;
        private System.Windows.Forms.ComboBox StarClass;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox SysObJType;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox RingChkBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox RingSpeedBox;
        private System.Windows.Forms.TextBox ObjFriendlyName;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

