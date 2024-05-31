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
        public Form1()
        {
            InitializeComponent();

            ChangeScreen(this, new MenuScreen());

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

            next.Location = new Point((form.Width - next.Width) / 2, (form.Height - next.Height) / 2);

            form.Controls.Add(next);
        }
    }
}
