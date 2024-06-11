using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Bloons_TD__Final_Project
{
    public partial class GameScreen : UserControl
    {
        List<Balloon> balloons = new List<Balloon>();

        List<Defender> defenders = new List<Defender>();

        List<Dart> darts = new List<Dart>();

        List<Rectangle> CornerRects = new List<Rectangle>();

        List<Rectangle> pathRects = new List<Rectangle>();

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

        Rectangle pathRect1 = new Rectangle();
        Rectangle pathRect2 = new Rectangle();
        Rectangle pathRect3 = new Rectangle();
        Rectangle pathRect4 = new Rectangle();
        Rectangle pathRect5 = new Rectangle();
        Rectangle pathRect6 = new Rectangle();
        Rectangle pathRect7 = new Rectangle();
        Rectangle pathRect8 = new Rectangle();
        Rectangle pathRect9 = new Rectangle();
        Rectangle pathRect10 = new Rectangle();
        Rectangle pathRect11 = new Rectangle();
        Rectangle pathRect12 = new Rectangle();

        int bpl;
        int bloonSpawner;

        int bloonSpawnTimer;

        bool drawRed = true;

        int lives = 100;

        double x1;
        double y1;
        double x2;
        double y2;

        Random Random = new Random();

        Defender def;
        Balloon bloon;

        double inRange;

        int rad;

        Boolean shoot;

        int shotTimer;

        Rectangle onScreen;

        int balloonSpeed = 2;

        bool spawnSelect = false;

        bool slowShot;

        Image spawnImage;
        int spawnType;

        Rectangle dms;

        Rectangle mouse;

        double dxs;
        double dys = 15;

        int angle = 0;

        bool spawn = true;

        int money = 1000;

        int superRange;

        double roundNumber = 1;

        bool inBetweenRounds = true;

        public GameScreen()
        {
            InitializeComponent();

            #region balloon stuff
            cornerRect1 = new Rectangle(420, 215, 10, 10);
            cornerRect2 = new Rectangle(405, 75, 10, 10);
            cornerRect3 = new Rectangle(240, 100, 10, 10);
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


            #region path stuff
            pathRect1 = new Rectangle(0, 210, 415, 30);
            pathRect2 = new Rectangle(390, 90, 40, 120);
            pathRect3 = new Rectangle(250, 85, 160, 30);
            pathRect4 = new Rectangle(250, 85, 40, 350);
            pathRect5 = new Rectangle(120, 410, 150, 30);
            pathRect6 = new Rectangle(115, 300, 40, 120);
            pathRect7 = new Rectangle(115, 295, 410, 30);
            pathRect8 = new Rectangle(505, 165, 40, 130);
            pathRect9 = new Rectangle(505, 165, 100, 30);
            pathRect10 = new Rectangle(605, 165, 35, 230);
            pathRect11 = new Rectangle(355, 375, 250, 30);
            pathRect12 = new Rectangle(350, 375, 40, 150);

            pathRects.Add(pathRect1);
            pathRects.Add(pathRect2);
            pathRects.Add(pathRect3);
            pathRects.Add(pathRect4);
            pathRects.Add(pathRect5);
            pathRects.Add(pathRect6);
            pathRects.Add(pathRect7);
            pathRects.Add(pathRect8);
            pathRects.Add(pathRect9);
            pathRects.Add(pathRect10);
            pathRects.Add(pathRect11);
            pathRects.Add(pathRect12);
            #endregion


            rad = 150;

            bpl = 10;

            //Defender defender = new Defender(180, 140, 60, 60, 2, Properties.Resources.TackShooter);

            //Defender defender2 = new Defender(555, 225, 60, 60, 2, Properties.Resources.Dart_Monkey);

            //Defender defender3 = new Defender(280, 450, 60, 60, 2, Properties.Resources.Dart_Monkey);

            // defenders.Add(defender);
            //defenders.Add(defender2);
            //defenders.Add(defender3);

            onScreen = new Rectangle(0, 0, this.Width, this.Height);
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
            foreach (Defender defender in defenders)
            {
                e.Graphics.DrawImage(defender.image, defender.hitBox);
                //e.Graphics.DrawRectangle(Pens.Red, defender.hitBox);
            }
            foreach (Dart d in darts)
            {
                e.Graphics.DrawImage(d.image, d.hitBox);
            }
            foreach (Rectangle rect in pathRects)
            {
                //  e.Graphics.DrawRectangle(Pens.White, rect);
            }


            //if (inRange < rad)
            //{
            //    if (def != null && bloon != null)
            //    {
            //        e.Graphics.DrawLine(Pens.Red, def.hitBox.X + (def.hitBox.Width / 2), def.hitBox.Y + (def.hitBox.Height / 2), bloon.hitBox.X + (bill.hitBox.Width / 2), bill.hitBox.Y + (bill.hitBox.Height / 2));
            //    }

            //}

            //e.Graphics.DrawEllipse(Pens.Black, defenders[0].hitBox.X + (defenders[0].hitBox.Width / 2) - rad, defenders[0].hitBox.Y + (defenders[0].hitBox.Height / 2) - rad, 2 * rad, 2 * rad);

            if (spawnSelect)
            {
                e.Graphics.DrawImage(spawnImage, dms.X - 10, dms.Y - 10, 60, 60);
                //e.Graphics.DrawRectangle(Pens.Red, dms);
                e.Graphics.DrawEllipse(Pens.White, mouse.X - rad, mouse.Y - rad, 2 * rad, 2 * rad);
            }

            if (drawRed == false)
            {
                e.Graphics.FillEllipse(Brushes.Red, mouse.X - rad, mouse.Y - rad, 2 * rad, 2 * rad);
            }




        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            label1.Text = this.PointToClient(Cursor.Position).ToString();
            livesLabel.Text = lives.ToString();
            moneyLabel.Text = money.ToString();

            Size mouseSize = new Size(1, 1);

            mouse = new Rectangle(this.PointToClient(Cursor.Position), mouseSize);
            if (!inBetweenRounds)
            {
                if (bloonSpawnTimer % 10 == 0)
                {
                    if (bloonSpawner < bpl)
                    {
                        int type;
                        if (bloonSpawner < 10)
                        {
                            type = 1;
                        }
                        else if (bloonSpawner < 20)
                        {
                            type = 2;
                        }
                        else if (bloonSpawner < 30)
                        {
                            type = 3;
                        }
                        else if (bloonSpawner < 40)
                        {
                            type = 4;
                        }
                        else if (bloonSpawner < 50)
                        {
                            type = 5;
                        }
                        else
                        {
                            type = 1;
                        }
                        Balloon bloon = new Balloon(type, 0, 210, 30, 30, balloonSpeed + type, 0, false);
                        balloons.Add(bloon);
                    }
                    bloonSpawner++;

                }
                if (bloonSpawnTimer < 100000000 && bloonSpawnTimer >= 0)
                {
                    bloonSpawnTimer++;
                }
                else
                {
                    bloonSpawnTimer = -1;
                }
                foreach (Defender d in defenders)
                {

                    d.shotTimer--;

                    foreach (Balloon b in balloons)
                    {
                        x1 = b.hitBox.X + (b.hitBox.Width / 2);
                        x2 = d.hitBox.X + (d.hitBox.Width / 2);

                        y1 = b.hitBox.Y + (b.hitBox.Height / 2);
                        y2 = d.hitBox.Y + (d.hitBox.Height / 2);

                        inRange = Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)));

                        tempLabel.Text = inRange.ToString();

                        if (Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2))) < d.rad)
                        {
                            if (d.type == 5 && b.slow == false)
                            {
                                def = d;
                                bloon = b;
                                if (d.shotTimer < 0)
                                {
                                    shoot = true;
                                }
                                break;
                            }
                            else if (d.type == 5 && b.slow == true)
                            {
                                //womp womp
                            }
                            else
                            {
                                def = d;
                                bloon = b;
                                if (d.shotTimer < 0)
                                {
                                    shoot = true;
                                }
                                break;
                            }

                        }

                    }
                    if (shoot)
                    {
                        if (d.type == 1)
                        {
                            Dart dart = new Dart(def.hitBox.X + (def.hitBox.Width / 2), def.hitBox.Y + (def.hitBox.Height / 2), 20, 20, (x1 - x2) * 0.25, (y1 - y2) * 0.25, 1, Properties.Resources.Dart);
                            darts.Add(dart);
                        }
                        if (d.type == 2)
                        {
                            double xStep = Math.Cos(45 * Math.PI / 180.0);
                            double yStep = Math.Sin(45 * Math.PI / 180.0);

                            Dart dart1 = new Dart(def.hitBox.X + (def.hitBox.Width / 2), def.hitBox.Y + (def.hitBox.Height / 2), 20, 20, 10, 0, 2, Properties.Resources.Tack);
                            Dart dart2 = new Dart(def.hitBox.X + (def.hitBox.Width / 2), def.hitBox.Y + (def.hitBox.Height / 2), 20, 20, 0, 10, 2, Properties.Resources.Tack);
                            Dart dart3 = new Dart(def.hitBox.X + (def.hitBox.Width / 2), def.hitBox.Y + (def.hitBox.Height / 2), 20, 20, -10, 0, 2, Properties.Resources.Tack);
                            Dart dart4 = new Dart(def.hitBox.X + (def.hitBox.Width / 2), def.hitBox.Y + (def.hitBox.Height / 2), 20, 20, 0, -10, 2, Properties.Resources.Tack);
                            Dart dart5 = new Dart(def.hitBox.X + (def.hitBox.Width / 2), def.hitBox.Y + (def.hitBox.Height / 2), 20, 20, 10 * xStep, 10 * yStep, 2, Properties.Resources.Tack);
                            Dart dart6 = new Dart(def.hitBox.X + (def.hitBox.Width / 2), def.hitBox.Y + (def.hitBox.Height / 2), 20, 20, 10 * xStep, -10 * yStep, 2, Properties.Resources.Tack);
                            Dart dart7 = new Dart(def.hitBox.X + (def.hitBox.Width / 2), def.hitBox.Y + (def.hitBox.Height / 2), 20, 20, -10 * xStep, 10 * yStep, 2, Properties.Resources.Tack);
                            Dart dart8 = new Dart(def.hitBox.X + (def.hitBox.Width / 2), def.hitBox.Y + (def.hitBox.Height / 2), 20, 20, -10 * xStep, -10 * yStep, 2, Properties.Resources.Tack);

                            darts.Add(dart1);
                            darts.Add(dart2);
                            darts.Add(dart3);
                            darts.Add(dart4);
                            darts.Add(dart5);
                            darts.Add(dart6);
                            darts.Add(dart7);
                            darts.Add(dart8);
                        }
                        if (d.type == 3)
                        {
                            Dart dart = new Dart(def.hitBox.X + (def.hitBox.Width / 2), def.hitBox.Y + (def.hitBox.Height / 2), 20, 20, (x1 - x2) * 0.25, (y1 - y2) * 0.25, 3, Properties.Resources.Dart);
                            darts.Add(dart);
                        }
                        if (d.type == 4)
                        {
                            Dart dart = new Dart(def.hitBox.X + (def.hitBox.Width / 2), def.hitBox.Y + (def.hitBox.Height / 2), 20, 20, (x1 - x2) * 0.25, (y1 - y2) * 0.25, 4, Properties.Resources.Magic);
                            darts.Add(dart);
                        }
                        if (d.type == 5)
                        {
                            Dart dart = new Dart(def.hitBox.X + (def.hitBox.Width / 2), def.hitBox.Y + (def.hitBox.Height / 2), 20, 20, (x1 - x2) * 0.25, (y1 - y2) * 0.25, 5, Properties.Resources.ICEBALL);
                            darts.Add(dart);
                        }

                        shoot = false;
                        d.shotTimer = d.defualtTimer;
                    }
                }

                foreach (Dart d in darts)
                {
                    d.move();
                }
                for (int i = 0; i < darts.Count; i++)
                {
                    if (onScreen.Contains(darts[i].hitBox.X, darts[i].hitBox.Y))
                    {
                        //nada
                    }
                    else if (darts[i].image == Properties.Resources.Tack)
                    {
                        //  darts.RemoveAt(i);
                    }
                    else
                    {
                        darts.RemoveAt(i);
                    }
                }

                for (int i = 0; i < balloons.Count; i++)
                {
                    for (int j = 0; j < darts.Count; j++)
                    {
                        if (i < balloons.Count)
                        {
                            if (darts[j].hitBox.IntersectsWith(balloons[i].hitBox))
                            {

                                money++;
                                if (darts[j].type == 4)
                                {
                                    Balloon.bePopped = true;
                                }
                                else if (darts[j].type == 5)
                                {
                                    balloons[i].slow = true;
                                    if (balloons[i].colour == 1)
                                    {
                                        balloons[i].image = Properties.Resources.Red_Ice_Balloon;
                                    }
                                    if (balloons[i].colour == 2)
                                    {
                                        balloons[i].image = Properties.Resources.Blue_Ice_Balloon;
                                    }
                                    if (balloons[i].colour == 3)
                                    {
                                        balloons[i].image = Properties.Resources.Green_Ice_Balloon;
                                    }
                                    if (balloons[i].colour == 4)
                                    {
                                        balloons[i].image = Properties.Resources.Yellow_Ice_Balloon;
                                    }
                                    if (balloons[i].colour == 5)
                                    {
                                        balloons[i].image = Properties.Resources.Pink_Ice_Balloon;
                                    }
                                }
                                else
                                {
                                    balloons[i].slow = false;
                                    balloons[i].popped(balloons[i]);
                                }
                                darts.RemoveAt(j);
                                if (Balloon.bePopped)
                                {
                                    balloons.RemoveAt(i);
                                    Balloon.bePopped = false;
                                }
                            }
                        }
                    }
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
                        b.ySpeed = -(balloonSpeed + b.colour);
                        if (b.slow)
                        {
                            b.xSpeed *= 0.5;
                            b.ySpeed *= 0.5;
                        }
                    }
                    if (b.hitBox.IntersectsWith(cornerRect2))
                    {
                        b.xSpeed = -(balloonSpeed + b.colour);
                        b.ySpeed = 0;
                        if (b.slow)
                        {
                            b.xSpeed *= 0.5;
                            b.ySpeed *= 0.5;
                        }
                    }
                    if (b.hitBox.IntersectsWith(cornerRect3))
                    {
                        b.xSpeed = 0;
                        b.ySpeed = balloonSpeed + b.colour;
                        if (b.slow)
                        {
                            b.xSpeed *= 0.5;
                            b.ySpeed *= 0.5;
                        }
                    }
                    if (b.hitBox.IntersectsWith(cornerRect4))
                    {
                        b.xSpeed = -(balloonSpeed + b.colour);
                        b.ySpeed = 0;
                        if (b.slow)
                        {
                            b.xSpeed *= 0.5;
                            b.ySpeed *= 0.5;
                        }
                    }
                    if (b.hitBox.IntersectsWith(cornerRect5))
                    {
                        b.xSpeed = 0;
                        b.ySpeed = -(balloonSpeed + b.colour);
                        if (b.slow)
                        {
                            b.xSpeed *= 0.5;
                            b.ySpeed *= 0.5;
                        }
                    }
                    if (b.hitBox.IntersectsWith(cornerRect6))
                    {
                        b.xSpeed = balloonSpeed + b.colour; ;
                        b.ySpeed = 0;
                        if (b.slow)
                        {
                            b.xSpeed *= 0.5;
                            b.ySpeed *= 0.5;
                        }
                    }
                    if (b.hitBox.IntersectsWith(cornerRect7))
                    {
                        b.xSpeed = 0;
                        b.ySpeed = -(balloonSpeed + b.colour);
                        if (b.slow)
                        {
                            b.xSpeed *= 0.5;
                            b.ySpeed *= 0.5;
                        }
                    }
                    if (b.hitBox.IntersectsWith(cornerRect8))
                    {
                        b.xSpeed = balloonSpeed + b.colour;
                        b.ySpeed = 0;
                        if (b.slow)
                        {
                            b.xSpeed *= 0.5;
                            b.ySpeed *= 0.5;
                        }
                    }
                    if (b.hitBox.IntersectsWith(cornerRect9))
                    {
                        b.xSpeed = 0;
                        b.ySpeed = balloonSpeed + b.colour;
                        if (b.slow)
                        {
                            b.xSpeed *= 0.5;
                            b.ySpeed *= 0.5;
                        }
                    }
                    if (b.hitBox.IntersectsWith(cornerRect10))
                    {
                        b.xSpeed = -(balloonSpeed + b.colour);
                        b.ySpeed = 0;
                        if (b.slow)
                        {
                            b.xSpeed *= 0.5;
                            b.ySpeed *= 0.5;
                        }
                    }
                    if (b.hitBox.IntersectsWith(cornerRect11))
                    {
                        b.xSpeed = 0;
                        b.ySpeed = balloonSpeed + b.colour;
                        if (b.slow)
                        {
                            b.xSpeed *= 0.5;
                            b.ySpeed *= 0.5;
                        }
                    }
                }
                for (int i = 0; i < balloons.Count; i++)
                {
                    if (balloons[i].hitBox.Y > this.Height)
                    {
                        lives -= balloons[i].colour;
                        balloons.RemoveAt(i);

                    }
                }



                #endregion


                if (lives <= 0)
                {
                    Application.Exit();
                }
                if (balloons.Count == 0)
                {
                    inBetweenRounds = true;
                    bloonSpawnTimer = 10;
                    bloonSpawner = 0;
                    roundNumber++;
                    darts.Clear();
                    money += (100 * (int)roundNumber);

                    bpl = (int)(Math.Pow(roundNumber, 2) + 15);
                }
            }


            if (spawnSelect)
            {
                dms = new Rectangle(mouse.X - 20, mouse.Y - 20, 40, 40);

                foreach (Defender d in defenders)
                {
                    foreach (Rectangle rect in pathRects)
                    {
                        if (dms.IntersectsWith(rect))
                        {
                            spawn = false;
                            drawRed = false;
                            goto BREAK;
                        }
                        else if (dms.IntersectsWith(d.hitBox))
                        {
                            spawn = false;
                            drawRed = false;
                            goto BREAK;
                        }
                        else
                        {
                            spawn = true;
                            drawRed = true;
                        }
                    }
                }
                if (defenders.Count == 0)
                {
                    foreach (Rectangle rect in pathRects)
                    {
                        if (dms.IntersectsWith(rect))
                        {
                            spawn = false;
                            drawRed = false;
                            goto BREAK;
                        }
                        else
                        {
                            drawRed = true;
                            spawn = true;
                        }
                    }
                }

            }
        BREAK:




            for (int i = 0; i < darts.Count; i++)
            {
                darts[i].timer++;

                if (darts[i].type == 1 && darts[i].timer >= 7)
                {
                    darts.RemoveAt(i);
                }
                else if (darts[i].type == 2 && darts[i].timer >= 7)
                {
                    darts.RemoveAt(i);
                }
                else if (darts[i].type == 3 && darts[i].timer >= 9)
                {
                    darts.RemoveAt(i);
                }
                else if (darts[i].type == 4 && darts[i].timer >= 7)
                {
                    darts.RemoveAt(i);
                }
                else if (darts[i].type == 5 && darts[i].timer >= 6)
                {
                    darts.RemoveAt(i);
                }



            }








            Refresh();
        }

        private void GameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.P:
                    if (true)
                    {

                    }
                    break;

            }
        }



        private void GameScreen_MouseClick(object sender, MouseEventArgs e)
        {
            if (spawn)
            {
                Defender defenderNew = new Defender(mouse.X - 30, mouse.Y - 30, 60, 60, spawnType, spawnImage, false);
                defenders.Add(defenderNew);
                //spawn = false;
                spawnSelect = false;
            }

            Point balls = new Point(mouse.X, mouse.Y);

            foreach (Defender d in defenders)
            {
                if (d.hitBox.Contains(balls) && spawn == false)
                {
                    //upgradeMenu
                }
            }




        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (money >= 170)
            {
                spawnSelect = true;
                spawnImage = Properties.Resources.Dart_Monkey;
                spawnType = 1;
                money -= 170;
                rad = 150;
            }

        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (money >= 220)
            {
                spawnSelect = true;
                spawnImage = Properties.Resources.TackShooter;
                spawnType = 2;
                money -= 220;
                rad = 80;
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (money >= 1000)
            {
                spawnSelect = true;
                spawnImage = Properties.Resources.SuperMonkey;
                spawnType = 3;
                money -= 1000;
                rad = 200;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (money >= 500)
            {
                spawnSelect = true;
                spawnImage = Properties.Resources.WizardMonkey;
                spawnType = 4;
                money -= 500;
                rad = 130;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (money >= 425)
            {
                spawnSelect = true;
                spawnImage = Properties.Resources.IceMonkey;
                spawnType = 5;
                money -= 425;
                rad = 160;
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            inBetweenRounds = false;
        }
    }
}
// monkey rotate