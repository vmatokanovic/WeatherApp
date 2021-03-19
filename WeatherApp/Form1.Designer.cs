
namespace WeatherApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.lbl_WeatherApp = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Recent = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_ThirdCity = new System.Windows.Forms.Button();
            this.btn_SecondCity = new System.Windows.Forms.Button();
            this.btn_FirstCity = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_WeatherNow = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.picture_now = new System.Windows.Forms.PictureBox();
            this.lbl_Pressure = new System.Windows.Forms.Label();
            this.lbl_Wind = new System.Windows.Forms.Label();
            this.lbl_Humidity = new System.Windows.Forms.Label();
            this.lbl_Condition = new System.Windows.Forms.Label();
            this.lbl_Temperature = new System.Windows.Forms.Label();
            this.lbl_cityName = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_windDay3 = new System.Windows.Forms.Label();
            this.lbl_condDay3 = new System.Windows.Forms.Label();
            this.picture_day3 = new System.Windows.Forms.PictureBox();
            this.lbl_windDay2 = new System.Windows.Forms.Label();
            this.lbl_condDay2 = new System.Windows.Forms.Label();
            this.picture_day2 = new System.Windows.Forms.PictureBox();
            this.lbl_tempDay3 = new System.Windows.Forms.Label();
            this.lbl_tempDay2 = new System.Windows.Forms.Label();
            this.lbl_windDay1 = new System.Windows.Forms.Label();
            this.lbl_condDay1 = new System.Windows.Forms.Label();
            this.picture_day1 = new System.Windows.Forms.PictureBox();
            this.lbl_tempDay1 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lbl_nameDay3 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lbl_nameDay2 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lbl_nameDay1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbl_nextDays = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_now)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_day3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_day2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_day1)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.textBox_Search);
            this.panel1.Controls.Add(this.lbl_WeatherApp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 68);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Bisque;
            this.button1.Location = new System.Drawing.Point(892, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Search.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Search.Location = new System.Drawing.Point(474, 20);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(34, 30);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = ">";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Search.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Search.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.textBox_Search.Location = new System.Drawing.Point(177, 20);
            this.textBox_Search.Multiline = true;
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(280, 30);
            this.textBox_Search.TabIndex = 0;
            this.textBox_Search.TabStop = false;
            this.textBox_Search.Text = "Search for a city...";
            this.textBox_Search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_Search_MouseClick);
            // 
            // lbl_WeatherApp
            // 
            this.lbl_WeatherApp.AutoSize = true;
            this.lbl_WeatherApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_WeatherApp.ForeColor = System.Drawing.Color.Lavender;
            this.lbl_WeatherApp.Location = new System.Drawing.Point(12, 20);
            this.lbl_WeatherApp.Name = "lbl_WeatherApp";
            this.lbl_WeatherApp.Size = new System.Drawing.Size(148, 25);
            this.lbl_WeatherApp.TabIndex = 0;
            this.lbl_WeatherApp.Text = "Weather App";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.lbl_Recent);
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 37);
            this.panel2.TabIndex = 1;
            // 
            // lbl_Recent
            // 
            this.lbl_Recent.AutoSize = true;
            this.lbl_Recent.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Recent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Recent.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_Recent.Location = new System.Drawing.Point(12, 8);
            this.lbl_Recent.Name = "lbl_Recent";
            this.lbl_Recent.Size = new System.Drawing.Size(145, 20);
            this.lbl_Recent.TabIndex = 0;
            this.lbl_Recent.Text = "Recent searches";
            this.lbl_Recent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.btn_ThirdCity);
            this.panel3.Controls.Add(this.btn_SecondCity);
            this.panel3.Controls.Add(this.btn_FirstCity);
            this.panel3.Location = new System.Drawing.Point(0, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 119);
            this.panel3.TabIndex = 2;
            // 
            // btn_ThirdCity
            // 
            this.btn_ThirdCity.FlatAppearance.BorderSize = 0;
            this.btn_ThirdCity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_ThirdCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThirdCity.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ThirdCity.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_ThirdCity.Location = new System.Drawing.Point(0, 80);
            this.btn_ThirdCity.Name = "btn_ThirdCity";
            this.btn_ThirdCity.Size = new System.Drawing.Size(175, 34);
            this.btn_ThirdCity.TabIndex = 2;
            this.btn_ThirdCity.Text = "Third City";
            this.btn_ThirdCity.UseVisualStyleBackColor = true;
            this.btn_ThirdCity.Click += new System.EventHandler(this.btn_ThirdCity_Click);
            // 
            // btn_SecondCity
            // 
            this.btn_SecondCity.FlatAppearance.BorderSize = 0;
            this.btn_SecondCity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_SecondCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SecondCity.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_SecondCity.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_SecondCity.Location = new System.Drawing.Point(0, 40);
            this.btn_SecondCity.Name = "btn_SecondCity";
            this.btn_SecondCity.Size = new System.Drawing.Size(175, 34);
            this.btn_SecondCity.TabIndex = 1;
            this.btn_SecondCity.Text = "Second City";
            this.btn_SecondCity.UseVisualStyleBackColor = true;
            this.btn_SecondCity.Click += new System.EventHandler(this.btn_SecondCity_Click);
            // 
            // btn_FirstCity
            // 
            this.btn_FirstCity.FlatAppearance.BorderSize = 0;
            this.btn_FirstCity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_FirstCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FirstCity.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_FirstCity.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_FirstCity.Location = new System.Drawing.Point(0, 0);
            this.btn_FirstCity.Name = "btn_FirstCity";
            this.btn_FirstCity.Size = new System.Drawing.Size(175, 34);
            this.btn_FirstCity.TabIndex = 0;
            this.btn_FirstCity.Text = "First City";
            this.btn_FirstCity.UseVisualStyleBackColor = true;
            this.btn_FirstCity.Click += new System.EventHandler(this.btn_FirstCity_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Controls.Add(this.lbl_WeatherNow);
            this.panel4.Location = new System.Drawing.Point(190, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(736, 37);
            this.panel4.TabIndex = 2;
            // 
            // lbl_WeatherNow
            // 
            this.lbl_WeatherNow.AutoSize = true;
            this.lbl_WeatherNow.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_WeatherNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_WeatherNow.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_WeatherNow.Location = new System.Drawing.Point(10, 8);
            this.lbl_WeatherNow.Name = "lbl_WeatherNow";
            this.lbl_WeatherNow.Size = new System.Drawing.Size(114, 20);
            this.lbl_WeatherNow.TabIndex = 1;
            this.lbl_WeatherNow.Text = "Weather now";
            this.lbl_WeatherNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel5.Controls.Add(this.picture_now);
            this.panel5.Controls.Add(this.lbl_Pressure);
            this.panel5.Controls.Add(this.lbl_Wind);
            this.panel5.Controls.Add(this.lbl_Humidity);
            this.panel5.Controls.Add(this.lbl_Condition);
            this.panel5.Controls.Add(this.lbl_Temperature);
            this.panel5.Controls.Add(this.lbl_cityName);
            this.panel5.Location = new System.Drawing.Point(190, 117);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(736, 119);
            this.panel5.TabIndex = 3;
            // 
            // picture_now
            // 
            this.picture_now.Image = global::WeatherApp.Properties.Resources.sunny_temperature_weather_icon_1320196637430890623_64;
            this.picture_now.Location = new System.Drawing.Point(241, 40);
            this.picture_now.Name = "picture_now";
            this.picture_now.Size = new System.Drawing.Size(64, 64);
            this.picture_now.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picture_now.TabIndex = 9;
            this.picture_now.TabStop = false;
            // 
            // lbl_Pressure
            // 
            this.lbl_Pressure.AutoSize = true;
            this.lbl_Pressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Pressure.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_Pressure.Location = new System.Drawing.Point(484, 80);
            this.lbl_Pressure.Name = "lbl_Pressure";
            this.lbl_Pressure.Size = new System.Drawing.Size(85, 20);
            this.lbl_Pressure.TabIndex = 8;
            this.lbl_Pressure.Text = "Pressure:";
            // 
            // lbl_Wind
            // 
            this.lbl_Wind.AutoSize = true;
            this.lbl_Wind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Wind.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_Wind.Location = new System.Drawing.Point(484, 48);
            this.lbl_Wind.Name = "lbl_Wind";
            this.lbl_Wind.Size = new System.Drawing.Size(108, 20);
            this.lbl_Wind.TabIndex = 7;
            this.lbl_Wind.Text = "Wind speed:";
            // 
            // lbl_Humidity
            // 
            this.lbl_Humidity.AutoSize = true;
            this.lbl_Humidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Humidity.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_Humidity.Location = new System.Drawing.Point(484, 13);
            this.lbl_Humidity.Name = "lbl_Humidity";
            this.lbl_Humidity.Size = new System.Drawing.Size(83, 20);
            this.lbl_Humidity.TabIndex = 6;
            this.lbl_Humidity.Text = "Humidity:";
            // 
            // lbl_Condition
            // 
            this.lbl_Condition.AutoSize = true;
            this.lbl_Condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Condition.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_Condition.Location = new System.Drawing.Point(241, 17);
            this.lbl_Condition.Name = "lbl_Condition";
            this.lbl_Condition.Size = new System.Drawing.Size(172, 20);
            this.lbl_Condition.TabIndex = 5;
            this.lbl_Condition.Text = "condition of weather";
            this.lbl_Condition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Temperature
            // 
            this.lbl_Temperature.AutoSize = true;
            this.lbl_Temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Temperature.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_Temperature.Location = new System.Drawing.Point(0, 49);
            this.lbl_Temperature.Name = "lbl_Temperature";
            this.lbl_Temperature.Size = new System.Drawing.Size(130, 55);
            this.lbl_Temperature.TabIndex = 4;
            this.lbl_Temperature.Text = "15 C";
            // 
            // lbl_cityName
            // 
            this.lbl_cityName.AutoSize = true;
            this.lbl_cityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cityName.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_cityName.Location = new System.Drawing.Point(10, 9);
            this.lbl_cityName.Name = "lbl_cityName";
            this.lbl_cityName.Size = new System.Drawing.Size(120, 25);
            this.lbl_cityName.TabIndex = 3;
            this.lbl_cityName.Text = "City Name";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel6.Location = new System.Drawing.Point(190, 242);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(358, 358);
            this.panel6.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel7.Controls.Add(this.lbl_windDay3);
            this.panel7.Controls.Add(this.lbl_condDay3);
            this.panel7.Controls.Add(this.picture_day3);
            this.panel7.Controls.Add(this.lbl_windDay2);
            this.panel7.Controls.Add(this.lbl_condDay2);
            this.panel7.Controls.Add(this.picture_day2);
            this.panel7.Controls.Add(this.lbl_tempDay3);
            this.panel7.Controls.Add(this.lbl_tempDay2);
            this.panel7.Controls.Add(this.lbl_windDay1);
            this.panel7.Controls.Add(this.lbl_condDay1);
            this.panel7.Controls.Add(this.picture_day1);
            this.panel7.Controls.Add(this.lbl_tempDay1);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel11);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Location = new System.Drawing.Point(568, 242);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(358, 358);
            this.panel7.TabIndex = 5;
            // 
            // lbl_windDay3
            // 
            this.lbl_windDay3.AutoSize = true;
            this.lbl_windDay3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_windDay3.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_windDay3.Location = new System.Drawing.Point(212, 324);
            this.lbl_windDay3.Name = "lbl_windDay3";
            this.lbl_windDay3.Size = new System.Drawing.Size(86, 15);
            this.lbl_windDay3.TabIndex = 16;
            this.lbl_windDay3.Text = "Wind speed:";
            // 
            // lbl_condDay3
            // 
            this.lbl_condDay3.AutoSize = true;
            this.lbl_condDay3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_condDay3.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_condDay3.Location = new System.Drawing.Point(155, 289);
            this.lbl_condDay3.Name = "lbl_condDay3";
            this.lbl_condDay3.Size = new System.Drawing.Size(169, 17);
            this.lbl_condDay3.TabIndex = 17;
            this.lbl_condDay3.Text = "condition of weather 3";
            this.lbl_condDay3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picture_day3
            // 
            this.picture_day3.Image = global::WeatherApp.Properties.Resources.sunny_temperature_weather_icon_1320196637430890623_64;
            this.picture_day3.Location = new System.Drawing.Point(155, 309);
            this.picture_day3.Name = "picture_day3";
            this.picture_day3.Size = new System.Drawing.Size(32, 32);
            this.picture_day3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_day3.TabIndex = 18;
            this.picture_day3.TabStop = false;
            // 
            // lbl_windDay2
            // 
            this.lbl_windDay2.AutoSize = true;
            this.lbl_windDay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_windDay2.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_windDay2.Location = new System.Drawing.Point(212, 219);
            this.lbl_windDay2.Name = "lbl_windDay2";
            this.lbl_windDay2.Size = new System.Drawing.Size(86, 15);
            this.lbl_windDay2.TabIndex = 13;
            this.lbl_windDay2.Text = "Wind speed:";
            // 
            // lbl_condDay2
            // 
            this.lbl_condDay2.AutoSize = true;
            this.lbl_condDay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_condDay2.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_condDay2.Location = new System.Drawing.Point(155, 184);
            this.lbl_condDay2.Name = "lbl_condDay2";
            this.lbl_condDay2.Size = new System.Drawing.Size(169, 17);
            this.lbl_condDay2.TabIndex = 14;
            this.lbl_condDay2.Text = "condition of weather 2";
            this.lbl_condDay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picture_day2
            // 
            this.picture_day2.Image = global::WeatherApp.Properties.Resources.sunny_temperature_weather_icon_1320196637430890623_64;
            this.picture_day2.Location = new System.Drawing.Point(155, 204);
            this.picture_day2.Name = "picture_day2";
            this.picture_day2.Size = new System.Drawing.Size(32, 32);
            this.picture_day2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_day2.TabIndex = 15;
            this.picture_day2.TabStop = false;
            // 
            // lbl_tempDay3
            // 
            this.lbl_tempDay3.AutoSize = true;
            this.lbl_tempDay3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_tempDay3.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_tempDay3.Location = new System.Drawing.Point(0, 297);
            this.lbl_tempDay3.Name = "lbl_tempDay3";
            this.lbl_tempDay3.Size = new System.Drawing.Size(102, 44);
            this.lbl_tempDay3.TabIndex = 12;
            this.lbl_tempDay3.Text = "25 C";
            // 
            // lbl_tempDay2
            // 
            this.lbl_tempDay2.AutoSize = true;
            this.lbl_tempDay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_tempDay2.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_tempDay2.Location = new System.Drawing.Point(0, 192);
            this.lbl_tempDay2.Name = "lbl_tempDay2";
            this.lbl_tempDay2.Size = new System.Drawing.Size(102, 44);
            this.lbl_tempDay2.TabIndex = 11;
            this.lbl_tempDay2.Text = "20 C";
            // 
            // lbl_windDay1
            // 
            this.lbl_windDay1.AutoSize = true;
            this.lbl_windDay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_windDay1.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_windDay1.Location = new System.Drawing.Point(212, 115);
            this.lbl_windDay1.Name = "lbl_windDay1";
            this.lbl_windDay1.Size = new System.Drawing.Size(86, 15);
            this.lbl_windDay1.TabIndex = 10;
            this.lbl_windDay1.Text = "Wind speed:";
            // 
            // lbl_condDay1
            // 
            this.lbl_condDay1.AutoSize = true;
            this.lbl_condDay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_condDay1.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_condDay1.Location = new System.Drawing.Point(155, 80);
            this.lbl_condDay1.Name = "lbl_condDay1";
            this.lbl_condDay1.Size = new System.Drawing.Size(169, 17);
            this.lbl_condDay1.TabIndex = 10;
            this.lbl_condDay1.Text = "condition of weather 1";
            this.lbl_condDay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picture_day1
            // 
            this.picture_day1.Image = global::WeatherApp.Properties.Resources.sunny_temperature_weather_icon_1320196637430890623_64;
            this.picture_day1.Location = new System.Drawing.Point(155, 100);
            this.picture_day1.Name = "picture_day1";
            this.picture_day1.Size = new System.Drawing.Size(32, 32);
            this.picture_day1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_day1.TabIndex = 10;
            this.picture_day1.TabStop = false;
            // 
            // lbl_tempDay1
            // 
            this.lbl_tempDay1.AutoSize = true;
            this.lbl_tempDay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_tempDay1.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_tempDay1.Location = new System.Drawing.Point(0, 84);
            this.lbl_tempDay1.Name = "lbl_tempDay1";
            this.lbl_tempDay1.Size = new System.Drawing.Size(102, 44);
            this.lbl_tempDay1.TabIndex = 10;
            this.lbl_tempDay1.Text = "15 C";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel10.Controls.Add(this.lbl_nameDay3);
            this.panel10.Location = new System.Drawing.Point(0, 251);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(358, 31);
            this.panel10.TabIndex = 6;
            // 
            // lbl_nameDay3
            // 
            this.lbl_nameDay3.AutoSize = true;
            this.lbl_nameDay3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nameDay3.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_nameDay3.Location = new System.Drawing.Point(0, 6);
            this.lbl_nameDay3.Name = "lbl_nameDay3";
            this.lbl_nameDay3.Size = new System.Drawing.Size(55, 20);
            this.lbl_nameDay3.TabIndex = 12;
            this.lbl_nameDay3.Text = "Day 3";
            this.lbl_nameDay3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel11.Controls.Add(this.lbl_nameDay2);
            this.panel11.Location = new System.Drawing.Point(0, 143);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(358, 31);
            this.panel11.TabIndex = 5;
            // 
            // lbl_nameDay2
            // 
            this.lbl_nameDay2.AutoSize = true;
            this.lbl_nameDay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nameDay2.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_nameDay2.Location = new System.Drawing.Point(0, 6);
            this.lbl_nameDay2.Name = "lbl_nameDay2";
            this.lbl_nameDay2.Size = new System.Drawing.Size(55, 20);
            this.lbl_nameDay2.TabIndex = 11;
            this.lbl_nameDay2.Text = "Day 2";
            this.lbl_nameDay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel9.Controls.Add(this.lbl_nameDay1);
            this.panel9.Location = new System.Drawing.Point(0, 31);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(358, 35);
            this.panel9.TabIndex = 4;
            // 
            // lbl_nameDay1
            // 
            this.lbl_nameDay1.AutoSize = true;
            this.lbl_nameDay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nameDay1.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_nameDay1.Location = new System.Drawing.Point(0, 9);
            this.lbl_nameDay1.Name = "lbl_nameDay1";
            this.lbl_nameDay1.Size = new System.Drawing.Size(55, 20);
            this.lbl_nameDay1.TabIndex = 10;
            this.lbl_nameDay1.Text = "Day 1";
            this.lbl_nameDay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel8.Controls.Add(this.lbl_nextDays);
            this.panel8.Location = new System.Drawing.Point(568, 242);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(358, 37);
            this.panel8.TabIndex = 3;
            // 
            // lbl_nextDays
            // 
            this.lbl_nextDays.AutoSize = true;
            this.lbl_nextDays.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_nextDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nextDays.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_nextDays.Location = new System.Drawing.Point(10, 8);
            this.lbl_nextDays.Name = "lbl_nextDays";
            this.lbl_nextDays.Size = new System.Drawing.Size(102, 20);
            this.lbl_nextDays.TabIndex = 1;
            this.lbl_nextDays.Text = "Next 3 days";
            this.lbl_nextDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(926, 612);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_now)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_day3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_day2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_day1)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_WeatherApp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Recent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_FirstCity;
        private System.Windows.Forms.Button btn_ThirdCity;
        private System.Windows.Forms.Button btn_SecondCity;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_WeatherNow;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox picture_now;
        private System.Windows.Forms.Label lbl_Pressure;
        private System.Windows.Forms.Label lbl_Wind;
        private System.Windows.Forms.Label lbl_Humidity;
        private System.Windows.Forms.Label lbl_Condition;
        private System.Windows.Forms.Label lbl_Temperature;
        private System.Windows.Forms.Label lbl_cityName;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbl_windDay1;
        private System.Windows.Forms.Label lbl_condDay1;
        private System.Windows.Forms.PictureBox picture_day1;
        private System.Windows.Forms.Label lbl_tempDay1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lbl_nameDay1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbl_nextDays;
        private System.Windows.Forms.Label lbl_windDay3;
        private System.Windows.Forms.Label lbl_condDay3;
        private System.Windows.Forms.PictureBox picture_day3;
        private System.Windows.Forms.Label lbl_windDay2;
        private System.Windows.Forms.Label lbl_condDay2;
        private System.Windows.Forms.PictureBox picture_day2;
        private System.Windows.Forms.Label lbl_tempDay3;
        private System.Windows.Forms.Label lbl_tempDay2;
        private System.Windows.Forms.Label lbl_nameDay3;
        private System.Windows.Forms.Label lbl_nameDay2;
        private System.Windows.Forms.Button button1;
    }
}

