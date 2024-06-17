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
    public partial class TitleScreen : UserControl
    {
        public static bool signUp;
        public TitleScreen()
        {
            InitializeComponent();

            gameTitleLabel.Location = new Point((this.Width / 2) - (gameTitleLabel.Width / 2), 20);

            signUpButton.Location = new Point((this.Width / 2) - (signUpButton.Width / 2), 200);

            loginButton.Location = new Point((this.Width / 2) - (loginButton.Width / 2), 300);

            highScores.Location = new Point((this.Width / 2) - (highScores.Width / 2), 400);


        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            signUp = true;
            Form1.ChangeScreen(this, new SignUpScreen(), false);
            //Form1.highscores.Add(new Highscore("Hellofffff", "aaaadfadfa", 5));
            //Form1.SaveHighScores();

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            signUp = false;
            Form1.ChangeScreen(this, new SignUpScreen(), false);

        }

        private void highScores_Click(object sender, EventArgs e)
        {
            Form1.whatScreen = 1;
            Form1.ChangeScreen(this, new HighscoreScreen(), false);
        }
    }
}
