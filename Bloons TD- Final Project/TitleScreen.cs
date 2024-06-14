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
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            signUp = true;
            Form1.ChangeScreen(this, new SignUpScreen());

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            signUp = false;
            Form1.ChangeScreen(this, new SignUpScreen());

        }

        private void highScores_Click(object sender, EventArgs e)
        {
            Form1.whatScreen = 1;
            Form1.ChangeScreen(this, new HighscoreScreen());
        }
    }
}
