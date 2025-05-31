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
            GetDBPath = new System.Windows.Forms.Button();
            DatabaseDiag = new System.Windows.Forms.OpenFileDialog();
            DatabseFileName = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            SysName = new System.Windows.Forms.ComboBox();
            GalaxyXCord = new System.Windows.Forms.TextBox();
            GalaxyYCord = new System.Windows.Forms.TextBox();
            GalaxyZCord = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            MajorAxisBox = new System.Windows.Forms.TextBox();
            MinorAxisBox = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            OrbitalScroll = new System.Windows.Forms.HScrollBar();
            OrbitalPosVal = new System.Windows.Forms.TextBox();
            InclanationVal = new System.Windows.Forms.TextBox();
            InclanationScroll = new System.Windows.Forms.HScrollBar();
            AtmosCheckBox = new System.Windows.Forms.CheckBox();
            sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            AtmosOpacBox = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            StarBox = new System.Windows.Forms.CheckBox();
            label10 = new System.Windows.Forms.Label();
            AtmosHue = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            AtmosTemp = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            MethaneBox = new System.Windows.Forms.TextBox();
            label13 = new System.Windows.Forms.Label();
            HeliumBox = new System.Windows.Forms.TextBox();
            label14 = new System.Windows.Forms.Label();
            HydrogenBox = new System.Windows.Forms.TextBox();
            label15 = new System.Windows.Forms.Label();
            OtherGasBox = new System.Windows.Forms.TextBox();
            StarClass = new System.Windows.Forms.ComboBox();
            label16 = new System.Windows.Forms.Label();
            SysObJType = new System.Windows.Forms.ComboBox();
            label17 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            RingChkBox = new System.Windows.Forms.CheckBox();
            label19 = new System.Windows.Forms.Label();
            RingSeedBox = new System.Windows.Forms.TextBox();
            ObjFriendlyName = new System.Windows.Forms.TextBox();
            DescriptionBox = new System.Windows.Forms.TextBox();
            label20 = new System.Windows.Forms.Label();
            NewBtn = new System.Windows.Forms.Button();
            SaveBtn = new System.Windows.Forms.Button();
            PlanetTypeBox = new System.Windows.Forms.ComboBox();
            label21 = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            TiltBox = new System.Windows.Forms.TextBox();
            label23 = new System.Windows.Forms.Label();
            MassBx = new System.Windows.Forms.TextBox();
            label24 = new System.Windows.Forms.Label();
            RadiusBx = new System.Windows.Forms.TextBox();
            TiltScrollBar = new System.Windows.Forms.HScrollBar();
            label25 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // GetDBPath
            // 
            GetDBPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            GetDBPath.Location = new System.Drawing.Point(5, 15);
            GetDBPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            GetDBPath.Name = "GetDBPath";
            GetDBPath.Size = new System.Drawing.Size(194, 40);
            GetDBPath.TabIndex = 0;
            GetDBPath.Text = "Select Database";
            GetDBPath.UseVisualStyleBackColor = true;
            GetDBPath.Click += GetDBPath_Click;
            // 
            // DatabaseDiag
            // 
            DatabaseDiag.FileName = "openFileDialog1";
            // 
            // DatabseFileName
            // 
            DatabseFileName.AutoSize = true;
            DatabseFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            DatabseFileName.Location = new System.Drawing.Point(394, 23);
            DatabseFileName.Name = "DatabseFileName";
            DatabseFileName.Size = new System.Drawing.Size(208, 25);
            DatabseFileName.TabIndex = 1;
            DatabseFileName.Text = "No Database Selected";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(112, 191);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(126, 25);
            label1.TabIndex = 3;
            label1.Text = "Object Name";
            // 
            // SysName
            // 
            SysName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            SysName.FormattingEnabled = true;
            SysName.Location = new System.Drawing.Point(265, 188);
            SysName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            SysName.Name = "SysName";
            SysName.Size = new System.Drawing.Size(314, 33);
            SysName.TabIndex = 4;
            SysName.SelectedIndexChanged += SysName_SelectedIndexChanged;
            // 
            // GalaxyXCord
            // 
            GalaxyXCord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            GalaxyXCord.Location = new System.Drawing.Point(15, 282);
            GalaxyXCord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            GalaxyXCord.Name = "GalaxyXCord";
            GalaxyXCord.Size = new System.Drawing.Size(100, 30);
            GalaxyXCord.TabIndex = 5;
            // 
            // GalaxyYCord
            // 
            GalaxyYCord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            GalaxyYCord.Location = new System.Drawing.Point(140, 282);
            GalaxyYCord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            GalaxyYCord.Name = "GalaxyYCord";
            GalaxyYCord.Size = new System.Drawing.Size(100, 30);
            GalaxyYCord.TabIndex = 6;
            // 
            // GalaxyZCord
            // 
            GalaxyZCord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            GalaxyZCord.Location = new System.Drawing.Point(265, 282);
            GalaxyZCord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            GalaxyZCord.Name = "GalaxyZCord";
            GalaxyZCord.Size = new System.Drawing.Size(100, 30);
            GalaxyZCord.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(12, 248);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 25);
            label2.TabIndex = 8;
            label2.Text = "Galaxy X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(137, 248);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(91, 25);
            label3.TabIndex = 9;
            label3.Text = "Galaxy Y";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(262, 248);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(90, 25);
            label4.TabIndex = 10;
            label4.Text = "Galaxy Z";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(12, 340);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(104, 25);
            label5.TabIndex = 11;
            label5.Text = "Major Axis";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(12, 432);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(104, 25);
            label6.TabIndex = 12;
            label6.Text = "Minor Axis";
            // 
            // MajorAxisBox
            // 
            MajorAxisBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            MajorAxisBox.Location = new System.Drawing.Point(17, 376);
            MajorAxisBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MajorAxisBox.Name = "MajorAxisBox";
            MajorAxisBox.Size = new System.Drawing.Size(248, 30);
            MajorAxisBox.TabIndex = 13;
            // 
            // MinorAxisBox
            // 
            MinorAxisBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            MinorAxisBox.Location = new System.Drawing.Point(17, 468);
            MinorAxisBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MinorAxisBox.Name = "MinorAxisBox";
            MinorAxisBox.Size = new System.Drawing.Size(248, 30);
            MinorAxisBox.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(13, 619);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(99, 25);
            label7.TabIndex = 15;
            label7.Text = "Inclination";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(12, 519);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(143, 25);
            label8.TabIndex = 16;
            label8.Text = "Orbital Position";
            // 
            // OrbitalScroll
            // 
            OrbitalScroll.Location = new System.Drawing.Point(18, 569);
            OrbitalScroll.Maximum = 360;
            OrbitalScroll.Name = "OrbitalScroll";
            OrbitalScroll.Size = new System.Drawing.Size(390, 21);
            OrbitalScroll.TabIndex = 17;
            OrbitalScroll.Scroll += OrbitalScroll_Scroll;
            // 
            // OrbitalPosVal
            // 
            OrbitalPosVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            OrbitalPosVal.Location = new System.Drawing.Point(165, 524);
            OrbitalPosVal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            OrbitalPosVal.Name = "OrbitalPosVal";
            OrbitalPosVal.Size = new System.Drawing.Size(100, 30);
            OrbitalPosVal.TabIndex = 18;
            // 
            // InclanationVal
            // 
            InclanationVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            InclanationVal.Location = new System.Drawing.Point(165, 624);
            InclanationVal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            InclanationVal.Name = "InclanationVal";
            InclanationVal.Size = new System.Drawing.Size(100, 30);
            InclanationVal.TabIndex = 19;
            // 
            // InclanationScroll
            // 
            InclanationScroll.Location = new System.Drawing.Point(17, 669);
            InclanationScroll.Maximum = 360;
            InclanationScroll.Name = "InclanationScroll";
            InclanationScroll.Size = new System.Drawing.Size(390, 21);
            InclanationScroll.TabIndex = 20;
            InclanationScroll.Scroll += InclanationScroll_Scroll;
            // 
            // AtmosCheckBox
            // 
            AtmosCheckBox.AutoSize = true;
            AtmosCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            AtmosCheckBox.Location = new System.Drawing.Point(733, 192);
            AtmosCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            AtmosCheckBox.Name = "AtmosCheckBox";
            AtmosCheckBox.Size = new System.Drawing.Size(151, 29);
            AtmosCheckBox.TabIndex = 21;
            AtmosCheckBox.Text = "Atmosphere?";
            AtmosCheckBox.UseVisualStyleBackColor = true;
            // 
            // sqLiteCommand1
            // 
            sqLiteCommand1.CommandText = null;
            // 
            // AtmosOpacBox
            // 
            AtmosOpacBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            AtmosOpacBox.Location = new System.Drawing.Point(731, 284);
            AtmosOpacBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            AtmosOpacBox.Name = "AtmosOpacBox";
            AtmosOpacBox.Size = new System.Drawing.Size(100, 30);
            AtmosOpacBox.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label9.Location = new System.Drawing.Point(729, 249);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(193, 25);
            label9.TabIndex = 23;
            label9.Text = "Atmospheric Opacity";
            // 
            // StarBox
            // 
            StarBox.AutoSize = true;
            StarBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            StarBox.Location = new System.Drawing.Point(12, 191);
            StarBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            StarBox.Name = "StarBox";
            StarBox.Size = new System.Drawing.Size(81, 29);
            StarBox.TabIndex = 24;
            StarBox.Text = "Star?";
            StarBox.UseVisualStyleBackColor = true;
            StarBox.CheckedChanged += StarBox_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label10.Location = new System.Drawing.Point(729, 342);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(162, 25);
            label10.TabIndex = 26;
            label10.Text = "Atmospheric Hue";
            // 
            // AtmosHue
            // 
            AtmosHue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            AtmosHue.Location = new System.Drawing.Point(731, 378);
            AtmosHue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            AtmosHue.Name = "AtmosHue";
            AtmosHue.Size = new System.Drawing.Size(100, 30);
            AtmosHue.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label11.Location = new System.Drawing.Point(729, 434);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(271, 25);
            label11.TabIndex = 28;
            label11.Text = "Atmospheric Temparature (K)";
            // 
            // AtmosTemp
            // 
            AtmosTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            AtmosTemp.Location = new System.Drawing.Point(731, 469);
            AtmosTemp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            AtmosTemp.Name = "AtmosTemp";
            AtmosTemp.Size = new System.Drawing.Size(100, 30);
            AtmosTemp.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label12.Location = new System.Drawing.Point(1021, 434);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(112, 25);
            label12.TabIndex = 34;
            label12.Text = "Methane %";
            // 
            // MethaneBox
            // 
            MethaneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            MethaneBox.Location = new System.Drawing.Point(1023, 469);
            MethaneBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MethaneBox.Name = "MethaneBox";
            MethaneBox.Size = new System.Drawing.Size(100, 30);
            MethaneBox.TabIndex = 33;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label13.Location = new System.Drawing.Point(1021, 342);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(95, 25);
            label13.TabIndex = 32;
            label13.Text = "Helium %";
            // 
            // HeliumBox
            // 
            HeliumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            HeliumBox.Location = new System.Drawing.Point(1023, 378);
            HeliumBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            HeliumBox.Name = "HeliumBox";
            HeliumBox.Size = new System.Drawing.Size(100, 30);
            HeliumBox.TabIndex = 31;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label14.Location = new System.Drawing.Point(1021, 249);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(120, 25);
            label14.TabIndex = 30;
            label14.Text = "Hydrogen %";
            // 
            // HydrogenBox
            // 
            HydrogenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            HydrogenBox.Location = new System.Drawing.Point(1023, 284);
            HydrogenBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            HydrogenBox.Name = "HydrogenBox";
            HydrogenBox.Size = new System.Drawing.Size(100, 30);
            HydrogenBox.TabIndex = 29;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label15.Location = new System.Drawing.Point(1018, 525);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(84, 25);
            label15.TabIndex = 36;
            label15.Text = "Other %";
            // 
            // OtherGasBox
            // 
            OtherGasBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            OtherGasBox.Location = new System.Drawing.Point(1020, 560);
            OtherGasBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            OtherGasBox.Name = "OtherGasBox";
            OtherGasBox.Size = new System.Drawing.Size(100, 30);
            OtherGasBox.TabIndex = 35;
            // 
            // StarClass
            // 
            StarClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            StarClass.FormattingEnabled = true;
            StarClass.Location = new System.Drawing.Point(229, 880);
            StarClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            StarClass.Name = "StarClass";
            StarClass.Size = new System.Drawing.Size(321, 33);
            StarClass.TabIndex = 38;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label16.Location = new System.Drawing.Point(16, 884);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(103, 25);
            label16.TabIndex = 37;
            label16.Text = "Star Class";
            // 
            // SysObJType
            // 
            SysObJType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            SysObJType.FormattingEnabled = true;
            SysObJType.Location = new System.Drawing.Point(229, 929);
            SysObJType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            SysObJType.Name = "SysObJType";
            SysObJType.Size = new System.Drawing.Size(321, 33);
            SysObJType.TabIndex = 40;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label17.Location = new System.Drawing.Point(16, 932);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(190, 25);
            label17.TabIndex = 39;
            label17.Text = "System Object Type";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label18.Location = new System.Drawing.Point(16, 978);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(200, 25);
            label18.TabIndex = 41;
            label18.Text = "Object Friendly Name";
            // 
            // RingChkBox
            // 
            RingChkBox.AutoSize = true;
            RingChkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            RingChkBox.Location = new System.Drawing.Point(1164, 192);
            RingChkBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            RingChkBox.Name = "RingChkBox";
            RingChkBox.Size = new System.Drawing.Size(84, 29);
            RingChkBox.TabIndex = 43;
            RingChkBox.Text = "Ring?";
            RingChkBox.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label19.Location = new System.Drawing.Point(1159, 249);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(103, 25);
            label19.TabIndex = 45;
            label19.Text = "Ring Seed";
            // 
            // RingSeedBox
            // 
            RingSeedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            RingSeedBox.Location = new System.Drawing.Point(1161, 284);
            RingSeedBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            RingSeedBox.Name = "RingSeedBox";
            RingSeedBox.Size = new System.Drawing.Size(100, 30);
            RingSeedBox.TabIndex = 44;
            // 
            // ObjFriendlyName
            // 
            ObjFriendlyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            ObjFriendlyName.Location = new System.Drawing.Point(229, 978);
            ObjFriendlyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ObjFriendlyName.Name = "ObjFriendlyName";
            ObjFriendlyName.Size = new System.Drawing.Size(321, 30);
            ObjFriendlyName.TabIndex = 46;
            // 
            // DescriptionBox
            // 
            DescriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            DescriptionBox.Location = new System.Drawing.Point(730, 835);
            DescriptionBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            DescriptionBox.Multiline = true;
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            DescriptionBox.Size = new System.Drawing.Size(532, 185);
            DescriptionBox.TabIndex = 47;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label20.Location = new System.Drawing.Point(601, 839);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(109, 25);
            label20.TabIndex = 48;
            label20.Text = "Description";
            // 
            // NewBtn
            // 
            NewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            NewBtn.Location = new System.Drawing.Point(5, 99);
            NewBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            NewBtn.Name = "NewBtn";
            NewBtn.Size = new System.Drawing.Size(194, 40);
            NewBtn.TabIndex = 49;
            NewBtn.Text = "Clone Current";
            NewBtn.UseVisualStyleBackColor = true;
            NewBtn.Click += NewBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            SaveBtn.Location = new System.Drawing.Point(224, 99);
            SaveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new System.Drawing.Size(194, 40);
            SaveBtn.TabIndex = 50;
            SaveBtn.Text = "Save Changes";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // PlanetTypeBox
            // 
            PlanetTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            PlanetTypeBox.FormattingEnabled = true;
            PlanetTypeBox.Location = new System.Drawing.Point(229, 831);
            PlanetTypeBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            PlanetTypeBox.Name = "PlanetTypeBox";
            PlanetTypeBox.Size = new System.Drawing.Size(321, 33);
            PlanetTypeBox.TabIndex = 52;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label21.Location = new System.Drawing.Point(16, 835);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(117, 25);
            label21.TabIndex = 51;
            label21.Text = "Planet Type";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label22.Location = new System.Drawing.Point(16, 716);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(38, 25);
            label22.TabIndex = 58;
            label22.Text = "Tilt";
            // 
            // TiltBox
            // 
            TiltBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            TiltBox.Location = new System.Drawing.Point(165, 716);
            TiltBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            TiltBox.Name = "TiltBox";
            TiltBox.Size = new System.Drawing.Size(100, 30);
            TiltBox.TabIndex = 57;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label23.Location = new System.Drawing.Point(728, 740);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(104, 25);
            label23.TabIndex = 56;
            label23.Text = "Mass (Kg)";
            // 
            // MassBx
            // 
            MassBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            MassBx.Location = new System.Drawing.Point(730, 775);
            MassBx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MassBx.Name = "MassBx";
            MassBx.Size = new System.Drawing.Size(531, 30);
            MassBx.TabIndex = 55;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label24.Location = new System.Drawing.Point(728, 646);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(72, 25);
            label24.TabIndex = 54;
            label24.Text = "Radius";
            // 
            // RadiusBx
            // 
            RadiusBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            RadiusBx.Location = new System.Drawing.Point(730, 681);
            RadiusBx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            RadiusBx.Name = "RadiusBx";
            RadiusBx.Size = new System.Drawing.Size(532, 30);
            RadiusBx.TabIndex = 53;
            // 
            // TiltScrollBar
            // 
            TiltScrollBar.Location = new System.Drawing.Point(15, 775);
            TiltScrollBar.Maximum = 180;
            TiltScrollBar.Name = "TiltScrollBar";
            TiltScrollBar.Size = new System.Drawing.Size(390, 21);
            TiltScrollBar.TabIndex = 59;
            TiltScrollBar.Scroll += TiltScrollBar_Scroll;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label25.Location = new System.Drawing.Point(210, 23);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(178, 25);
            label25.TabIndex = 60;
            label25.Text = "Database Selected";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DimGray;
            ClientSize = new System.Drawing.Size(1281, 1040);
            Controls.Add(label25);
            Controls.Add(TiltScrollBar);
            Controls.Add(label22);
            Controls.Add(TiltBox);
            Controls.Add(label23);
            Controls.Add(MassBx);
            Controls.Add(label24);
            Controls.Add(RadiusBx);
            Controls.Add(PlanetTypeBox);
            Controls.Add(label21);
            Controls.Add(SaveBtn);
            Controls.Add(NewBtn);
            Controls.Add(label20);
            Controls.Add(DescriptionBox);
            Controls.Add(ObjFriendlyName);
            Controls.Add(label19);
            Controls.Add(RingSeedBox);
            Controls.Add(RingChkBox);
            Controls.Add(label18);
            Controls.Add(SysObJType);
            Controls.Add(label17);
            Controls.Add(StarClass);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(OtherGasBox);
            Controls.Add(label12);
            Controls.Add(MethaneBox);
            Controls.Add(label13);
            Controls.Add(HeliumBox);
            Controls.Add(label14);
            Controls.Add(HydrogenBox);
            Controls.Add(label11);
            Controls.Add(AtmosTemp);
            Controls.Add(label10);
            Controls.Add(AtmosHue);
            Controls.Add(StarBox);
            Controls.Add(label9);
            Controls.Add(AtmosOpacBox);
            Controls.Add(AtmosCheckBox);
            Controls.Add(InclanationScroll);
            Controls.Add(InclanationVal);
            Controls.Add(OrbitalPosVal);
            Controls.Add(OrbitalScroll);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(MinorAxisBox);
            Controls.Add(MajorAxisBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(GalaxyZCord);
            Controls.Add(GalaxyYCord);
            Controls.Add(GalaxyXCord);
            Controls.Add(SysName);
            Controls.Add(label1);
            Controls.Add(DatabseFileName);
            Controls.Add(GetDBPath);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "Starship Simulator Database Viewer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

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
        private System.Windows.Forms.TextBox RingSeedBox;
        private System.Windows.Forms.TextBox ObjFriendlyName;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ComboBox PlanetTypeBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox TiltBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox MassBx;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox RadiusBx;
        private System.Windows.Forms.HScrollBar TiltScrollBar;
        private System.Windows.Forms.Label label25;
    }
}

