using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Bloons_TD__Final_Project
{ 
    public partial class Form1 : Form
    {
       public static List<Highscore> highscores = new List<Highscore>();

        public static int whatScreen = 0;
        public Form1()
        {
            InitializeComponent();

            loadDB();
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

        public void SaveHighScores()
        {
            XmlWriter writer = XmlWriter.Create("Highscores.xml", null);

            writer.WriteStartElement("Highscore");

            foreach (Highscore high in highscores)
            {
                writer.WriteStartElement("Highscore");

                writer.WriteElementString("username", high.userName);

                writer.WriteElementString("password", high.password);

                writer.WriteElementString("highscore", high.highscore.ToString());

                writer.WriteEndElement();
            }


            writer.WriteEndElement();
            writer.Close();
        }

        public void loadDB()
        {
            XmlReader reader = XmlReader.Create("Highscores.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    string username = reader.ReadString();

                    reader.ReadToNextSibling("password");
                    string password = reader.ReadString();

                    reader.ReadToNextSibling("highscore");
                    string highscore = reader.ReadString();

                    Highscore high = new Highscore(username, password, Convert.ToInt32(highscore));
                    highscores.Add(high);
                }
            }
            reader.Close();
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveHighScores();
        }

    }
}

