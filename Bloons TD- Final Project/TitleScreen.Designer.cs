namespace Bloons_TD__Final_Project
{
    partial class TitleScreen
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
            this.gameTitleLabel = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.highScores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameTitleLabel
            // 
            this.gameTitleLabel.AutoSize = true;
            this.gameTitleLabel.Font = new System.Drawing.Font("Ravie", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitleLabel.Location = new System.Drawing.Point(64, 42);
            this.gameTitleLabel.Name = "gameTitleLabel";
            this.gameTitleLabel.Size = new System.Drawing.Size(535, 129);
            this.gameTitleLabel.TabIndex = 0;
            this.gameTitleLabel.Text = "BTD 0.5";
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(233, 200);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(177, 53);
            this.signUpButton.TabIndex = 1;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(233, 273);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(177, 53);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // highScores
            // 
            this.highScores.Location = new System.Drawing.Point(233, 349);
            this.highScores.Name = "highScores";
            this.highScores.Size = new System.Drawing.Size(177, 53);
            this.highScores.TabIndex = 3;
            this.highScores.Text = "HighScores";
            this.highScores.UseVisualStyleBackColor = true;
            this.highScores.Click += new System.EventHandler(this.highScores_Click);
            // 
            // TitleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.highScores);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.gameTitleLabel);
            this.Name = "TitleScreen";
            this.Size = new System.Drawing.Size(656, 419);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameTitleLabel;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button highScores;
    }
}
