namespace Bloons_TD__Final_Project
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.livesLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.MoneyLabel1 = new System.Windows.Forms.Label();
            this.MoneyLabel2 = new System.Windows.Forms.Label();
            this.MoneyLabel3 = new System.Windows.Forms.Label();
            this.MoneyLabel4 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.MoneyLabel5 = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.upgradeMenuBackgroundLabel = new System.Windows.Forms.Label();
            this.upgradeMenuPictureBox = new System.Windows.Forms.PictureBox();
            this.upgradeMenuNameLabel = new System.Windows.Forms.Label();
            this.upgradeButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.upgradeButtonLabel = new System.Windows.Forms.Label();
            this.sellButtonLabel = new System.Windows.Forms.Label();
            this.SpeedUpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upgradeMenuPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // livesLabel
            // 
            this.livesLabel.AutoSize = true;
            this.livesLabel.BackColor = System.Drawing.Color.Transparent;
            this.livesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.livesLabel.Location = new System.Drawing.Point(657, 11);
            this.livesLabel.Name = "livesLabel";
            this.livesLabel.Size = new System.Drawing.Size(60, 24);
            this.livesLabel.TabIndex = 1;
            this.livesLabel.Text = "label2";
            this.livesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Location = new System.Drawing.Point(572, 486);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(35, 13);
            this.tempLabel.TabIndex = 2;
            this.tempLabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(739, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 510);
            this.label2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bloons_TD__Final_Project.Properties.Resources.Dart_Monkey;
            this.pictureBox1.Location = new System.Drawing.Point(754, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Bloons_TD__Final_Project.Properties.Resources.TackShooter;
            this.pictureBox2.Location = new System.Drawing.Point(827, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // moneyLabel
            // 
            this.moneyLabel.BackColor = System.Drawing.Color.Transparent;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel.Location = new System.Drawing.Point(3, 11);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(75, 27);
            this.moneyLabel.TabIndex = 6;
            this.moneyLabel.Text = "label3";
            this.moneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Bloons_TD__Final_Project.Properties.Resources.Banana;
            this.pictureBox3.Location = new System.Drawing.Point(84, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Bloons_TD__Final_Project.Properties.Resources.SuperMonkey;
            this.pictureBox4.Location = new System.Drawing.Point(754, 113);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 55);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Bloons_TD__Final_Project.Properties.Resources.WizardMonkey;
            this.pictureBox5.Location = new System.Drawing.Point(827, 113);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(55, 55);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // MoneyLabel1
            // 
            this.MoneyLabel1.AutoSize = true;
            this.MoneyLabel1.Location = new System.Drawing.Point(768, 87);
            this.MoneyLabel1.Name = "MoneyLabel1";
            this.MoneyLabel1.Size = new System.Drawing.Size(25, 13);
            this.MoneyLabel1.TabIndex = 10;
            this.MoneyLabel1.Text = "170";
            // 
            // MoneyLabel2
            // 
            this.MoneyLabel2.AutoSize = true;
            this.MoneyLabel2.Location = new System.Drawing.Point(842, 87);
            this.MoneyLabel2.Name = "MoneyLabel2";
            this.MoneyLabel2.Size = new System.Drawing.Size(25, 13);
            this.MoneyLabel2.TabIndex = 11;
            this.MoneyLabel2.Text = "220";
            // 
            // MoneyLabel3
            // 
            this.MoneyLabel3.AutoSize = true;
            this.MoneyLabel3.Location = new System.Drawing.Point(768, 171);
            this.MoneyLabel3.Name = "MoneyLabel3";
            this.MoneyLabel3.Size = new System.Drawing.Size(31, 13);
            this.MoneyLabel3.TabIndex = 12;
            this.MoneyLabel3.Text = "1000";
            // 
            // MoneyLabel4
            // 
            this.MoneyLabel4.AutoSize = true;
            this.MoneyLabel4.Location = new System.Drawing.Point(842, 171);
            this.MoneyLabel4.Name = "MoneyLabel4";
            this.MoneyLabel4.Size = new System.Drawing.Size(25, 13);
            this.MoneyLabel4.TabIndex = 13;
            this.MoneyLabel4.Text = "500";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Bloons_TD__Final_Project.Properties.Resources.IceMonkey;
            this.pictureBox6.Location = new System.Drawing.Point(754, 197);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(55, 55);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // MoneyLabel5
            // 
            this.MoneyLabel5.AutoSize = true;
            this.MoneyLabel5.Location = new System.Drawing.Point(768, 255);
            this.MoneyLabel5.Name = "MoneyLabel5";
            this.MoneyLabel5.Size = new System.Drawing.Size(25, 13);
            this.MoneyLabel5.TabIndex = 15;
            this.MoneyLabel5.Text = "425";
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(631, 474);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(73, 47);
            this.playButton.TabIndex = 16;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // upgradeMenuBackgroundLabel
            // 
            this.upgradeMenuBackgroundLabel.Location = new System.Drawing.Point(586, 40);
            this.upgradeMenuBackgroundLabel.Name = "upgradeMenuBackgroundLabel";
            this.upgradeMenuBackgroundLabel.Size = new System.Drawing.Size(162, 431);
            this.upgradeMenuBackgroundLabel.TabIndex = 17;
            this.upgradeMenuBackgroundLabel.Visible = false;
            // 
            // upgradeMenuPictureBox
            // 
            this.upgradeMenuPictureBox.Location = new System.Drawing.Point(615, 67);
            this.upgradeMenuPictureBox.Name = "upgradeMenuPictureBox";
            this.upgradeMenuPictureBox.Size = new System.Drawing.Size(102, 101);
            this.upgradeMenuPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upgradeMenuPictureBox.TabIndex = 18;
            this.upgradeMenuPictureBox.TabStop = false;
            this.upgradeMenuPictureBox.Visible = false;
            // 
            // upgradeMenuNameLabel
            // 
            this.upgradeMenuNameLabel.AutoSize = true;
            this.upgradeMenuNameLabel.Location = new System.Drawing.Point(639, 171);
            this.upgradeMenuNameLabel.Name = "upgradeMenuNameLabel";
            this.upgradeMenuNameLabel.Size = new System.Drawing.Size(27, 13);
            this.upgradeMenuNameLabel.TabIndex = 19;
            this.upgradeMenuNameLabel.Text = "ants";
            this.upgradeMenuNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.upgradeMenuNameLabel.Visible = false;
            // 
            // upgradeButton
            // 
            this.upgradeButton.Location = new System.Drawing.Point(631, 284);
            this.upgradeButton.Name = "upgradeButton";
            this.upgradeButton.Size = new System.Drawing.Size(73, 47);
            this.upgradeButton.TabIndex = 20;
            this.upgradeButton.Text = "Upgrade";
            this.upgradeButton.UseVisualStyleBackColor = true;
            this.upgradeButton.Visible = false;
            this.upgradeButton.Click += new System.EventHandler(this.upgradeButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(631, 397);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(73, 47);
            this.sellButton.TabIndex = 21;
            this.sellButton.Text = "SELL";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Visible = false;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // upgradeButtonLabel
            // 
            this.upgradeButtonLabel.Location = new System.Drawing.Point(648, 255);
            this.upgradeButtonLabel.Name = "upgradeButtonLabel";
            this.upgradeButtonLabel.Size = new System.Drawing.Size(31, 13);
            this.upgradeButtonLabel.TabIndex = 22;
            this.upgradeButtonLabel.Text = "ant";
            this.upgradeButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.upgradeButtonLabel.Visible = false;
            // 
            // sellButtonLabel
            // 
            this.sellButtonLabel.Location = new System.Drawing.Point(648, 381);
            this.sellButtonLabel.Name = "sellButtonLabel";
            this.sellButtonLabel.Size = new System.Drawing.Size(31, 13);
            this.sellButtonLabel.TabIndex = 23;
            this.sellButtonLabel.Text = "ant";
            this.sellButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sellButtonLabel.Visible = false;
            // 
            // SpeedUpButton
            // 
            this.SpeedUpButton.Location = new System.Drawing.Point(481, 474);
            this.SpeedUpButton.Name = "SpeedUpButton";
            this.SpeedUpButton.Size = new System.Drawing.Size(73, 47);
            this.SpeedUpButton.TabIndex = 24;
            this.SpeedUpButton.Text = "Speed";
            this.SpeedUpButton.UseVisualStyleBackColor = true;
            this.SpeedUpButton.Click += new System.EventHandler(this.SpeedUpButton_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImage = global::Bloons_TD__Final_Project.Properties.Resources.MonkeyMeadow;
            this.Controls.Add(this.SpeedUpButton);
            this.Controls.Add(this.sellButtonLabel);
            this.Controls.Add(this.upgradeButtonLabel);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.upgradeButton);
            this.Controls.Add(this.upgradeMenuNameLabel);
            this.Controls.Add(this.upgradeMenuPictureBox);
            this.Controls.Add(this.upgradeMenuBackgroundLabel);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.MoneyLabel5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.MoneyLabel4);
            this.Controls.Add(this.MoneyLabel3);
            this.Controls.Add(this.MoneyLabel2);
            this.Controls.Add(this.MoneyLabel1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.livesLabel);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(900, 532);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameScreen_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upgradeMenuPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label livesLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label MoneyLabel1;
        private System.Windows.Forms.Label MoneyLabel2;
        private System.Windows.Forms.Label MoneyLabel3;
        private System.Windows.Forms.Label MoneyLabel4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label MoneyLabel5;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label upgradeMenuBackgroundLabel;
        private System.Windows.Forms.PictureBox upgradeMenuPictureBox;
        private System.Windows.Forms.Label upgradeMenuNameLabel;
        private System.Windows.Forms.Button upgradeButton;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Label upgradeButtonLabel;
        private System.Windows.Forms.Label sellButtonLabel;
        private System.Windows.Forms.Button SpeedUpButton;
    }
}
