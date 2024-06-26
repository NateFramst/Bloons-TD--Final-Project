﻿namespace Bloons_TD__Final_Project
{
    partial class EndScreen
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
            this.playAgainButton = new System.Windows.Forms.Button();
            this.highScoreButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.scoreTitleLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.usernameScore = new System.Windows.Forms.Label();
            this.highscorePrintLabel = new System.Windows.Forms.Label();
            this.highscoreTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playAgainButton
            // 
            this.playAgainButton.Location = new System.Drawing.Point(385, 254);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(112, 77);
            this.playAgainButton.TabIndex = 0;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // highScoreButton
            // 
            this.highScoreButton.Location = new System.Drawing.Point(385, 337);
            this.highScoreButton.Name = "highScoreButton";
            this.highScoreButton.Size = new System.Drawing.Size(112, 77);
            this.highScoreButton.TabIndex = 1;
            this.highScoreButton.Text = "HighScores";
            this.highScoreButton.UseVisualStyleBackColor = true;
            this.highScoreButton.Click += new System.EventHandler(this.highScoreButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(385, 420);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 77);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // scoreTitleLabel
            // 
            this.scoreTitleLabel.Font = new System.Drawing.Font("Ravie", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTitleLabel.Location = new System.Drawing.Point(16, 107);
            this.scoreTitleLabel.Name = "scoreTitleLabel";
            this.scoreTitleLabel.Size = new System.Drawing.Size(350, 131);
            this.scoreTitleLabel.TabIndex = 3;
            this.scoreTitleLabel.Text = "Your Score is";
            this.scoreTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // scoreLabel
            // 
            this.scoreLabel.Font = new System.Drawing.Font("Ravie", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(25, 219);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(341, 83);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // usernameScore
            // 
            this.usernameScore.AutoSize = true;
            this.usernameScore.Font = new System.Drawing.Font("Ravie", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameScore.Location = new System.Drawing.Point(16, 40);
            this.usernameScore.Name = "usernameScore";
            this.usernameScore.Size = new System.Drawing.Size(0, 50);
            this.usernameScore.TabIndex = 5;
            this.usernameScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highscorePrintLabel
            // 
            this.highscorePrintLabel.Font = new System.Drawing.Font("Ravie", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscorePrintLabel.Location = new System.Drawing.Point(25, 420);
            this.highscorePrintLabel.Name = "highscorePrintLabel";
            this.highscorePrintLabel.Size = new System.Drawing.Size(341, 67);
            this.highscorePrintLabel.TabIndex = 7;
            this.highscorePrintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highscoreTitleLabel
            // 
            this.highscoreTitleLabel.Font = new System.Drawing.Font("Ravie", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoreTitleLabel.Location = new System.Drawing.Point(3, 311);
            this.highscoreTitleLabel.Name = "highscoreTitleLabel";
            this.highscoreTitleLabel.Size = new System.Drawing.Size(363, 103);
            this.highscoreTitleLabel.TabIndex = 6;
            this.highscoreTitleLabel.Text = "Your Highscore is";
            this.highscoreTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.highscorePrintLabel);
            this.Controls.Add(this.highscoreTitleLabel);
            this.Controls.Add(this.usernameScore);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.scoreTitleLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.highScoreButton);
            this.Controls.Add(this.playAgainButton);
            this.Name = "EndScreen";
            this.Size = new System.Drawing.Size(500, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Button highScoreButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label scoreTitleLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label usernameScore;
        private System.Windows.Forms.Label highscorePrintLabel;
        private System.Windows.Forms.Label highscoreTitleLabel;
    }
}
