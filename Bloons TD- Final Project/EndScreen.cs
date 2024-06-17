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
    public partial class EndScreen : UserControl
    {
        public EndScreen()
        {
            InitializeComponent();

            usernameScore.Text = GameScreen.trackingHighscore.userName;

            scoreLabel.Text = GameScreen.trackingHighscore.score + "";

            

            foreach (Highscore h in Form1.highscores)
            {
                if (GameScreen.trackingHighscore.userName == h.userName && GameScreen.trackingHighscore.password == h.password)
                {
                    h.score = GameScreen.trackingHighscore.score;
                    if (h.score > h.highscore)
                    {
                        h.highscore = h.score;
                    }
                }
            }


            highscorePrintLabel.Text = GameScreen.trackingHighscore.highscore + "";

            //cheeseman : 2712

        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            GameScreen.trackingHighscore.score = 0;
            Form1.ChangeScreen(this, new GameScreen(), true);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void highScoreButton_Click(object sender, EventArgs e)
        {
            Form1.whatScreen = 2;
            Form1.ChangeScreen(this, new HighscoreScreen(), false);
        }

       
    }
}
