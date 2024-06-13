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
        int prevHighscore;

      

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
            if(TitleScreen.signUp)
            {
                Highscore highscore = new Highscore(usernameTextBox.Text, passwordTextbox.Text, 0);
                Form1.highscores.Add(highscore);

                Form1.ChangeScreen(this, new GameScreen());
            }
            else
            {
                foreach(Highscore h in Form1.highscores)
                {
                    if (h.userName == usernameTextBox.Text && h.password == passwordTextbox.Text)
                    {
                        GameScreen.trackingHighscore = h;
                        Form1.ChangeScreen(this, new GameScreen());
                    }
                }
            }








            Highscore highscore1 = new Highscore(usernameTextBox.Text, passwordTextbox.Text, prevHighscore);
        }
    }
}
