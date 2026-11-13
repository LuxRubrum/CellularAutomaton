using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CellularAutomaton
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rbtConnect4 = new System.Windows.Forms.RadioButton();
            this.rbtConnect8 = new System.Windows.Forms.RadioButton();
            this.nudRad = new System.Windows.Forms.NumericUpDown();
            this.lblRad = new System.Windows.Forms.Label();
            this.lblRandom = new System.Windows.Forms.Label();
            this.trbRandom = new System.Windows.Forms.TrackBar();
            this.tbxRandom = new System.Windows.Forms.TextBox();
            this.lblLife = new System.Windows.Forms.Label();
            this.tbxLifeLow = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.tbxSize = new System.Windows.Forms.TextBox();
            this.btnInit = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.lblDeath = new System.Windows.Forms.Label();
            this.nudSpeed = new System.Windows.Forms.NumericUpDown();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.tbxLifeHigh = new System.Windows.Forms.TextBox();
            this.tbxDeathLow = new System.Windows.Forms.TextBox();
            this.tbxDeathHigh = new System.Windows.Forms.TextBox();
            this.pbxMain = new CellularAutomaton.PixelBox();
            this.lblPresets = new System.Windows.Forms.Label();
            this.cbxPresets = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbRandom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(11, 44);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(164, 26);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(182, 44);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(165, 26);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Enabled = false;
            this.btnRandom.Location = new System.Drawing.Point(11, 76);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(165, 26);
            this.btnRandom.TabIndex = 3;
            this.btnRandom.Text = "Заполнить случайно";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(182, 76);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(165, 26);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rbtConnect4
            // 
            this.rbtConnect4.AutoSize = true;
            this.rbtConnect4.Location = new System.Drawing.Point(12, 108);
            this.rbtConnect4.Name = "rbtConnect4";
            this.rbtConnect4.Size = new System.Drawing.Size(204, 17);
            this.rbtConnect4.TabIndex = 5;
            this.rbtConnect4.Text = "Соседство фон Неймана (4 клетки)";
            this.rbtConnect4.UseVisualStyleBackColor = true;
            this.rbtConnect4.CheckedChanged += new System.EventHandler(this.rbtConnect4_CheckedChanged);
            // 
            // rbtConnect8
            // 
            this.rbtConnect8.AutoSize = true;
            this.rbtConnect8.Checked = true;
            this.rbtConnect8.Location = new System.Drawing.Point(12, 131);
            this.rbtConnect8.Name = "rbtConnect8";
            this.rbtConnect8.Size = new System.Drawing.Size(161, 17);
            this.rbtConnect8.TabIndex = 6;
            this.rbtConnect8.TabStop = true;
            this.rbtConnect8.Text = "Соседство Мура (8 клеток)";
            this.rbtConnect8.UseVisualStyleBackColor = true;
            this.rbtConnect8.CheckedChanged += new System.EventHandler(this.rbtConnect8_CheckedChanged);
            // 
            // nudRad
            // 
            this.nudRad.Location = new System.Drawing.Point(12, 233);
            this.nudRad.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRad.Name = "nudRad";
            this.nudRad.Size = new System.Drawing.Size(144, 20);
            this.nudRad.TabIndex = 7;
            this.nudRad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRad.ValueChanged += new System.EventHandler(this.nudRad_ValueChanged);
            // 
            // lblRad
            // 
            this.lblRad.AutoSize = true;
            this.lblRad.Location = new System.Drawing.Point(9, 217);
            this.lblRad.Name = "lblRad";
            this.lblRad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRad.Size = new System.Drawing.Size(256, 13);
            this.lblRad.TabIndex = 8;
            this.lblRad.Text = "Расстояние Чебышёва (радиус взаимодействия)";
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Location = new System.Drawing.Point(12, 272);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(200, 13);
            this.lblRandom.TabIndex = 9;
            this.lblRandom.Text = "Коэффициент случайного заполнения";
            // 
            // trbRandom
            // 
            this.trbRandom.Location = new System.Drawing.Point(15, 288);
            this.trbRandom.Maximum = 100;
            this.trbRandom.Name = "trbRandom";
            this.trbRandom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trbRandom.Size = new System.Drawing.Size(240, 45);
            this.trbRandom.TabIndex = 10;
            this.trbRandom.TickFrequency = 5;
            this.trbRandom.Value = 30;
            this.trbRandom.Scroll += new System.EventHandler(this.trbRandom_Scroll);
            // 
            // tbxRandom
            // 
            this.tbxRandom.Location = new System.Drawing.Point(261, 288);
            this.tbxRandom.MaxLength = 3;
            this.tbxRandom.Name = "tbxRandom";
            this.tbxRandom.Size = new System.Drawing.Size(86, 20);
            this.tbxRandom.TabIndex = 11;
            this.tbxRandom.Text = "30";
            this.tbxRandom.TextChanged += new System.EventHandler(this.tbxRandom_TextChanged);
            // 
            // lblLife
            // 
            this.lblLife.AutoSize = true;
            this.lblLife.Location = new System.Drawing.Point(9, 164);
            this.lblLife.Name = "lblLife";
            this.lblLife.Size = new System.Drawing.Size(109, 13);
            this.lblLife.TabIndex = 12;
            this.lblLife.Text = "Интервал рождения";
            // 
            // tbxLifeLow
            // 
            this.tbxLifeLow.Location = new System.Drawing.Point(12, 181);
            this.tbxLifeLow.MaxLength = 1;
            this.tbxLifeLow.Name = "tbxLifeLow";
            this.tbxLifeLow.Size = new System.Drawing.Size(69, 20);
            this.tbxLifeLow.TabIndex = 13;
            this.tbxLifeLow.Text = "3";
            this.tbxLifeLow.TextChanged += new System.EventHandler(this.tbxLifeLow_TextChanged);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(8, 334);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(73, 13);
            this.lblSize.TabIndex = 14;
            this.lblSize.Text = "Размер поля";
            // 
            // tbxSize
            // 
            this.tbxSize.Location = new System.Drawing.Point(10, 350);
            this.tbxSize.MaxLength = 4;
            this.tbxSize.Name = "tbxSize";
            this.tbxSize.Size = new System.Drawing.Size(146, 20);
            this.tbxSize.TabIndex = 15;
            this.tbxSize.Text = "50";
            this.tbxSize.TextChanged += new System.EventHandler(this.tbxSize_TextChanged);
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(12, 12);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(335, 26);
            this.btnInit.TabIndex = 16;
            this.btnInit.Text = "Инициализация";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // tmrMain
            // 
            this.tmrMain.Interval = 500;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // lblDeath
            // 
            this.lblDeath.AutoSize = true;
            this.lblDeath.Location = new System.Drawing.Point(200, 164);
            this.lblDeath.Name = "lblDeath";
            this.lblDeath.Size = new System.Drawing.Size(117, 13);
            this.lblDeath.TabIndex = 17;
            this.lblDeath.Text = "Интервал выживания";
            // 
            // nudSpeed
            // 
            this.nudSpeed.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSpeed.Location = new System.Drawing.Point(203, 350);
            this.nudSpeed.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudSpeed.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.Size = new System.Drawing.Size(144, 20);
            this.nudSpeed.TabIndex = 19;
            this.nudSpeed.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudSpeed.ValueChanged += new System.EventHandler(this.nudSpeed_ValueChanged);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(200, 334);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(113, 13);
            this.lblSpeed.TabIndex = 20;
            this.lblSpeed.Text = "Скорость симуляции";
            // 
            // tbxLifeHigh
            // 
            this.tbxLifeHigh.Location = new System.Drawing.Point(87, 181);
            this.tbxLifeHigh.MaxLength = 1;
            this.tbxLifeHigh.Name = "tbxLifeHigh";
            this.tbxLifeHigh.Size = new System.Drawing.Size(69, 20);
            this.tbxLifeHigh.TabIndex = 21;
            this.tbxLifeHigh.Text = "3";
            this.tbxLifeHigh.TextChanged += new System.EventHandler(this.tbxLifeHigh_TextChanged);
            // 
            // tbxDeathLow
            // 
            this.tbxDeathLow.Location = new System.Drawing.Point(203, 180);
            this.tbxDeathLow.MaxLength = 1;
            this.tbxDeathLow.Name = "tbxDeathLow";
            this.tbxDeathLow.Size = new System.Drawing.Size(69, 20);
            this.tbxDeathLow.TabIndex = 22;
            this.tbxDeathLow.Text = "2";
            this.tbxDeathLow.TextChanged += new System.EventHandler(this.tbxDeathLow_TextChanged);
            // 
            // tbxDeathHigh
            // 
            this.tbxDeathHigh.Location = new System.Drawing.Point(278, 180);
            this.tbxDeathHigh.MaxLength = 1;
            this.tbxDeathHigh.Name = "tbxDeathHigh";
            this.tbxDeathHigh.Size = new System.Drawing.Size(69, 20);
            this.tbxDeathHigh.TabIndex = 23;
            this.tbxDeathHigh.Text = "3";
            this.tbxDeathHigh.TextChanged += new System.EventHandler(this.tbxDeathHigh_TextChanged);
            // 
            // pbxMain
            // 
            this.pbxMain.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbxMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxMain.Location = new System.Drawing.Point(379, 10);
            this.pbxMain.Name = "pbxMain";
            this.pbxMain.Size = new System.Drawing.Size(400, 400);
            this.pbxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMain.TabIndex = 0;
            this.pbxMain.TabStop = false;
            this.pbxMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxMain_MouseDown);
            // 
            // lblPresets
            // 
            this.lblPresets.AutoSize = true;
            this.lblPresets.Location = new System.Drawing.Point(8, 391);
            this.lblPresets.Name = "lblPresets";
            this.lblPresets.Size = new System.Drawing.Size(52, 13);
            this.lblPresets.TabIndex = 24;
            this.lblPresets.Text = "Пресеты";
            // 
            // cbxPresets
            // 
            this.cbxPresets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPresets.FormattingEnabled = true;
            this.cbxPresets.Items.AddRange(new object[] {
            "Игра \"Жизнь\" Джона Конвея - B3/S23",
            "Жизнь без смерти - B3/S012345678",
            "Коралл - B3/S45678",
            "Бактерия - B34/S456",
            "Ассимиляция - B345/S4567",
            "Лабиринт - B3/S12345",
            "Муравьиная колония - B3/S234",
            "Мир в огне - B34/S23",
            "Медленное угасание - B34/S2",
            "Пещеры - B5678/S45678",
            "Фрактал (Мур) - B1/S012345678",
            "Фрактал (фон Нейман) - B1/S012345678"});
            this.cbxPresets.Location = new System.Drawing.Point(70, 388);
            this.cbxPresets.Name = "cbxPresets";
            this.cbxPresets.Size = new System.Drawing.Size(277, 21);
            this.cbxPresets.TabIndex = 25;
            this.cbxPresets.SelectedIndexChanged += new System.EventHandler(this.cbxPresets_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 422);
            this.Controls.Add(this.cbxPresets);
            this.Controls.Add(this.lblPresets);
            this.Controls.Add(this.tbxDeathHigh);
            this.Controls.Add(this.tbxDeathLow);
            this.Controls.Add(this.tbxLifeHigh);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.nudSpeed);
            this.Controls.Add(this.lblDeath);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.tbxSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.tbxLifeLow);
            this.Controls.Add(this.lblLife);
            this.Controls.Add(this.tbxRandom);
            this.Controls.Add(this.trbRandom);
            this.Controls.Add(this.lblRandom);
            this.Controls.Add(this.lblRad);
            this.Controls.Add(this.nudRad);
            this.Controls.Add(this.rbtConnect8);
            this.Controls.Add(this.rbtConnect4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbxMain);
            this.Name = "frmMain";
            this.Text = "Клеточный автомат";
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.nudRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbRandom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PixelBox pbxMain;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rbtConnect4;
        private System.Windows.Forms.RadioButton rbtConnect8;
        private System.Windows.Forms.NumericUpDown nudRad;
        private System.Windows.Forms.Label lblRad;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.TrackBar trbRandom;
        private System.Windows.Forms.TextBox tbxRandom;
        private System.Windows.Forms.Label lblLife;
        private System.Windows.Forms.TextBox tbxLifeLow;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox tbxSize;
        private System.Windows.Forms.Button btnInit;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private Timer tmrMain;
        private Label lblDeath;
        private Label lblSpeed;
        private NumericUpDown nudSpeed;
        private TextBox tbxDeathHigh;
        private TextBox tbxDeathLow;
        private TextBox tbxLifeHigh;
        private ComboBox cbxPresets;
        private Label lblPresets;
    }
}

