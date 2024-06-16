using System;
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
   

        int counter;

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

            titleLabel.Location = new Point((this.Width / 2) - (titleLabel.Width / 2), 20);

            usernameLabel.Location = new Point((this.Width / 2) - (usernameLabel.Width / 2), 120);

            usernameTextBox.Location = new Point((this.Width / 2) - (usernameTextBox.Width / 2), 140);

            passwordLabel.Location = new Point((this.Width / 2) - (passwordLabel.Width / 2), 240);

            passwordTextbox.Location = new Point((this.Width / 2) - (passwordTextbox.Width / 2), 260);

            signUpButton.Location = new Point((this.Width / 2) - (signUpButton.Width / 2), 360);

            BackButton.Location = new Point((this.Width / 2) - (BackButton.Width / 2), 420);

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if (TitleScreen.signUp)
            {
                counter = 0;
                if (usernameTextBox.Text.Length > 7 && usernameTextBox.Text.Length < 17 && passwordTextbox.Text.Length > 7 && passwordTextbox.Text.Length < 17)
                {
                    foreach (Highscore h in Form1.highscores)
                    {
                        if (h.userName != usernameTextBox.Text)
                        {
                            counter++;
                        }
                    }
                    if (counter == Form1.highscores.Count)
                    {
                        Highscore highscore = new Highscore(usernameTextBox.Text, passwordTextbox.Text, 0);
                        Form1.highscores.Add(highscore);

                        GameScreen.trackingHighscore = highscore;

                        Form1.ChangeScreen(this, new GameScreen(), true);
                    }
                    else
                    {
                        usernameTextBox.Text = "This username is already in use";
                    }

                }
                else
                {
                    usernameTextBox.Text = "Please enter a valid username and password combo";
                }

            }
            else
            {
                for(int i = 0; i < Form1.highscores.Count; i++)
                {
                    if (Form1.highscores[i].userName == usernameTextBox.Text && Form1.highscores[i].password == passwordTextbox.Text)
                    {
                        GameScreen.trackingHighscore = Form1.highscores[i];
                        Form1.ChangeScreen(this, new GameScreen(), true);
                        
                    }
                    if (i + 1 == Form1.highscores.Count)
                    {
                        usernameTextBox.Text = "No accounts have this username and password combo";
                    }
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new TitleScreen(), false);
        }
    }
}
