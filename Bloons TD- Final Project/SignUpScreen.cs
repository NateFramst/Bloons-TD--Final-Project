﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bloons_TD__Final_Project
{
    public partial class SignUpScreen : UserControl
    {
        int prevHighscore;

        int x;

        Highscore trackingHighscore;

        public SignUpScreen()
        {
            InitializeComponent();

            if (TitleScreen.signUp)
            {
                titleLabel.Text = "Sign Up";
            }
            else
            {
                titleLabel.Text = "Login";
            }
            
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if (TitleScreen.signUp)
            {
                if (usernameTextBox.Text.Length > 7 && usernameTextBox.Text.Length < 17 && passwordTextbox.Text.Length > 7 && passwordTextbox.Text.Length < 17)
                {
                    Highscore highscore = new Highscore(usernameTextBox.Text, passwordTextbox.Text, 0);
                    Form1.highscores.Add(highscore);

                    GameScreen.trackingHighscore = highscore;

                    Form1.ChangeScreen(this, new GameScreen());
                }
                else
                {
                    usernameTextBox.Text = "Please enter a valid username and password combo";
                }

            }
            else
            {
                foreach (Highscore h in Form1.highscores)
                {
                    if (h.userName == usernameTextBox.Text && h.password == passwordTextbox.Text)
                    {
                        GameScreen.trackingHighscore = h;
                        Form1.ChangeScreen(this, new GameScreen());
                        x = 1;
                    }
                    if (x == 0)
                    {
                        usernameTextBox.Text = "No accounts have this username and password combo";
                    }
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new TitleScreen());
        }
    }
}
