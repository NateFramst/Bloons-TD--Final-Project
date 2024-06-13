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
    public partial class Form1 : Form
    {
       public static List<Highscore> highscores = new List<Highscore>();
        public Form1()
        {
            InitializeComponent();

            ChangeScreen(this, new TitleScreen());

        }
        public static void ChangeScreen(object sender, UserControl next)
        {
            Form form;
            if (sender is Form)
            {
                form = sender as Form;
            }
            else
            {
                UserControl currenet = sender as UserControl;
                form = currenet.FindForm();
                form.Controls.Remove(currenet);
            }

            next.Location = new Point(0, (form.Height - next.Height) / 2);

            form.Controls.Add(next);
        }
    }
}
