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
    public partial class GameScreen : UserControl
    {
        List<Balloon> balloons = new List<Balloon>();

        List<Rectangle> CornerRects = new List<Rectangle>();

        Rectangle cornerRect1 = new Rectangle();
        Rectangle cornerRect2 = new Rectangle();
        Rectangle cornerRect3 = new Rectangle();
        Rectangle cornerRect4 = new Rectangle();
        Rectangle cornerRect5 = new Rectangle();
        Rectangle cornerRect6 = new Rectangle();
        Rectangle cornerRect7 = new Rectangle();
        Rectangle cornerRect8 = new Rectangle();
        Rectangle cornerRect9 = new Rectangle();
        Rectangle cornerRect10 = new Rectangle();
        Rectangle cornerRect11 = new Rectangle();

        int bpl;
        int bloonSpawner;

        int bloonSpawnTimer;

        int lives = 100;

        Random Random = new Random();

        public GameScreen()
        {
            InitializeComponent();

            #region balloon stuff
            cornerRect1 = new Rectangle(420, 215, 10, 10);
            cornerRect2 = new Rectangle(405, 75, 10, 10);
            cornerRect3= new Rectangle(240, 100, 10, 10);
            cornerRect4 = new Rectangle(260, 440, 10, 10);
            cornerRect5 = new Rectangle(115, 425, 10, 10);
            cornerRect6 = new Rectangle(140, 285, 10, 10);
            cornerRect7 = new Rectangle(535, 295, 10, 10);
            cornerRect8 = new Rectangle(535, 160, 10, 10);
            cornerRect9 = new Rectangle(635, 185, 10, 10);
            cornerRect10 = new Rectangle(620, 400, 10, 10);
            cornerRect11 = new Rectangle(340, 395, 10, 10);

            CornerRects.Add(cornerRect1);
            CornerRects.Add(cornerRect2);
            CornerRects.Add(cornerRect3);
            CornerRects.Add(cornerRect4);
            CornerRects.Add(cornerRect5);
            CornerRects.Add(cornerRect6);
            CornerRects.Add(cornerRect7);
            CornerRects.Add(cornerRect8);
            CornerRects.Add(cornerRect9);
            CornerRects.Add(cornerRect10);
            CornerRects.Add(cornerRect11);
            #endregion


            bpl = 100;
            

        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (Balloon balloon in balloons)
            {
                e.Graphics.DrawImage(balloon.image, balloon.hitBox);
                //e.Graphics.DrawRectangle(Pens.White, balloon.hitBox);
            }
            foreach (Rectangle rect in CornerRects)
            {
                //e.Graphics.DrawRectangle(Pens.White, rect);
            }

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            label1.Text = this.PointToClient(Cursor.Position).ToString();
            livesLabel.Text = lives.ToString();

            if (bloonSpawnTimer % 10 == 0)
            {
                if (bloonSpawner < bpl)
                {
                    Balloon bloon = new Balloon(2, 0, 210, 30, 30, 5, 0);
                    balloons.Add(bloon);
                }
                bloonSpawner++;
                
            }
            if (bloonSpawnTimer < 1000 && bloonSpawnTimer >= 0)
            {
                bloonSpawnTimer++;
            }
            else
            {
                bloonSpawnTimer = -1;
            }
            
                
            

            foreach (Balloon b in balloons)
            {
                b.move(b);
            }
            #region Balloons be movin
            foreach (Balloon b in balloons)
            {
                if (b.hitBox.IntersectsWith(cornerRect1))
                {
                    b.xSpeed = 0;
                    b.ySpeed = -5;
                }
                if (b.hitBox.IntersectsWith(cornerRect2))
                {
                    b.xSpeed = -5;
                    b.ySpeed = 0;
                }
                if (b.hitBox.IntersectsWith(cornerRect3))
                {
                    b.xSpeed = 0;
                    b.ySpeed = 5;
                }
                if (b.hitBox.IntersectsWith(cornerRect4))
                {
                    b.xSpeed = -5;
                    b.ySpeed = 0;
                }
                if (b.hitBox.IntersectsWith(cornerRect5))
                {
                    b.xSpeed = 0;
                    b.ySpeed = -5;
                }
                if (b.hitBox.IntersectsWith(cornerRect6))
                {
                    b.xSpeed = 5;
                    b.ySpeed = 0;
                }
                if (b.hitBox.IntersectsWith(cornerRect7))
                {
                    b.xSpeed = 0;
                    b.ySpeed = -5;
                }
                if (b.hitBox.IntersectsWith(cornerRect8))
                {
                    b.xSpeed = 5;
                    b.ySpeed = 0;
                }
                if (b.hitBox.IntersectsWith(cornerRect9))
                {
                    b.xSpeed = 0;
                    b.ySpeed = 5;
                }
                if (b.hitBox.IntersectsWith(cornerRect10))
                {
                    b.xSpeed = -5;
                    b.ySpeed = 0;
                }
                if (b.hitBox.IntersectsWith(cornerRect11))
                {
                    b.xSpeed = 0;
                    b.ySpeed = 5;
                }
            }
            for (int i = 0; i < balloons.Count; i++)
            {
                if (balloons[i].hitBox.Y > this.Height)
                {
                    balloons.RemoveAt(i);
                    lives--;
                }
            }


            for (int i = 0; i <= balloons.Count - 1; i++)
            {
                if (Random.Next(1, 1000) == 5)
                {
                    balloons[i].popped(balloons[i]);
                    if (Balloon.bePopped)
                    {
                        balloons.RemoveAt(i);
                        Balloon.bePopped = false;
                    }
                }
            }
            



            Refresh();
            #endregion
        }
    }
}
