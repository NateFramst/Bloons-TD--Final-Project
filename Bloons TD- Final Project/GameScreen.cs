#region code
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
//using System.⚡;

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
        bool moabDeathSpawn = true;

        int lives = 1;

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

        bool spawn = false;

        int money = 440;

        int superRange;

        double roundNumber = 1;

        bool inBetweenRounds = true;

        SolidBrush transRed = new SolidBrush(Color.FromArgb(100, 255, 0, 0));
        SolidBrush transGray = new SolidBrush(Color.FromArgb(100, 182, 172, 172));

        //Label upgradeMenuBackgroundLabel = new Label();

        Defender menuMonkey;

        int price;

        bool menuOpen;

        int speedFlip;

        int lightningShot;

        List<Balloon> LightningBalloons = new List<Balloon>();

        int lightningCount;

        int wizardMonkeyPrice = 500;

        int dartMonkeyPrice = 170;

        int tackShooterPrice = 220;

        int iceMonkeyPrice = 450;

        int superMonkeyPrice = 2000;

        int wizardMonkeySellPrice = 400;

        int dartMonkeySellPrice = 136;

        int tackShooterSellPrice = 176;

        int iceMonkeySellPrice = 360;

        int superMonkeySellPrice = 1600;

        int wizardMonkeyUpgradePrice = 600;

        int dartMonkeyUpgradePrice = 150;

        int tackShooterUpgradePrice = 250;

        int iceMonkeyUpgradePrice = 400;

        int superMonkeyUpgradePrice = 1000;

        public static Highscore trackingHighscore;

        int xDirection = 1;
        int yDirection = 0;

        bool MOABspawn = true;

        Rectangle rec;

        bool keepBalloon = false;

        Balloon newB;

        bool speedUp = false;


        public GameScreen()
        {
            InitializeComponent();

            #region balloon stuff
            cornerRect1 = new Rectangle(420, 215, 10, 10);
            cornerRect2 = new Rectangle(405, 75, 10, 10);
            cornerRect3 = new Rectangle(250, 90, 10, 10);
            cornerRect4 = new Rectangle(260, 440, 10, 10);
            cornerRect5 = new Rectangle(115, 425, 10, 10);
            cornerRect6 = new Rectangle(140, 290, 10, 10);
            cornerRect7 = new Rectangle(535, 295, 10, 10);
            cornerRect8 = new Rectangle(520, 165, 10, 10);
            cornerRect9 = new Rectangle(635, 185, 10, 10);
            cornerRect10 = new Rectangle(620, 400, 10, 10);
            cornerRect11 = new Rectangle(345, 380, 10, 10);

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
            pathRect2 = new Rectangle(390, 80, 40, 130);
            pathRect3 = new Rectangle(250, 80, 165, 30);
            pathRect4 = new Rectangle(250, 85, 40, 350);
            pathRect5 = new Rectangle(120, 410, 150, 30);
            pathRect6 = new Rectangle(115, 300, 40, 120);
            pathRect7 = new Rectangle(115, 295, 410, 30);
            pathRect8 = new Rectangle(505, 165, 40, 130);
            pathRect9 = new Rectangle(505, 165, 100, 30);
            pathRect10 = new Rectangle(605, 165, 35, 230);
            pathRect11 = new Rectangle(355, 370, 255, 30);
            pathRect12 = new Rectangle(350, 370, 40, 170);

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

            MoneyLabel1.Text = dartMonkeyPrice.ToString();
            MoneyLabel2.Text = tackShooterPrice.ToString();
            MoneyLabel3.Text = superMonkeyPrice.ToString();
            MoneyLabel4.Text = wizardMonkeyPrice.ToString();
            MoneyLabel5.Text = iceMonkeyPrice.ToString();


            gameTimer.Enabled = true;


        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (Defender defender in defenders)
            {
                e.Graphics.DrawImage(defender.image, defender.hitBox);
                //e.Graphics.DrawRectangle(Pens.Red, defender.hitBox);
            }
            foreach (Balloon balloon in balloons)
            {
                if (balloon.colour != 1)
                {
                    e.Graphics.DrawImage(balloon.image, balloon.hitBox);
                }
                else if (balloon.colour == 1)
                {

                    if (balloon.xDirection != 0)
                    {
                        rec = new Rectangle(balloon.hitBox.X - 80 + 15, balloon.hitBox.Y - 40 + 15, 160, 80);
                    }
                    else
                    {
                        rec = new Rectangle(balloon.hitBox.X - 40 + 15, balloon.hitBox.Y - 80 + 15, 80, 160);
                    }
                    e.Graphics.DrawImage(balloon.image, rec);
                }

                //e.Graphics.DrawRectangle(Pens.White, balloon.hitBox);
            }
            foreach (Rectangle rect in CornerRects)
            {
                //e.Graphics.DrawRectangle(Pens.White, rect);
            }

            foreach (Dart d in darts)
            {
                e.Graphics.DrawImage(d.image, d.hitBox);
            }
            foreach (Rectangle rect in pathRects)
            {
                /// e.Graphics.DrawRectangle(Pens.White, rect);
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

                //e.Graphics.DrawRectangle(Pens.Red, dms);
                e.Graphics.DrawEllipse(Pens.Black, mouse.X - rad, mouse.Y - rad, 2 * rad, 2 * rad);

                if (drawRed == false)
                {

                    e.Graphics.FillEllipse(transRed, mouse.X - rad, mouse.Y - rad, 2 * rad, 2 * rad);
                }
                if (drawRed)
                {
                    e.Graphics.FillEllipse(transGray, mouse.X - rad, mouse.Y - rad, 2 * rad, 2 * rad);
                }

                e.Graphics.DrawImage(spawnImage, dms.X - 10, dms.Y - 10, 60, 60);
            }

            if (menuOpen)
            {
                e.Graphics.DrawEllipse(Pens.Black, menuMonkey.hitBox.X - menuMonkey.rad + 30, menuMonkey.hitBox.Y - menuMonkey.rad + 30, 2 * menuMonkey.rad, 2 * menuMonkey.rad);
                e.Graphics.FillEllipse(transGray, menuMonkey.hitBox.X - menuMonkey.rad + 30, menuMonkey.hitBox.Y - menuMonkey.rad + 30, 2 * menuMonkey.rad, 2 * menuMonkey.rad);

                foreach (Defender d in defenders)
                {
                    if (d == menuMonkey)
                    {
                        e.Graphics.DrawImage(d.image, d.hitBox);
                        break;
                    }
                }
            }



        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            label1.Text = this.PointToClient(Cursor.Position).ToString();
            livesLabel.Text = lives.ToString();
            moneyLabel.Text = money.ToString();
            keepBalloon = false;
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
                            type = 2;
                        }
                        else if (bloonSpawner < 20)
                        {
                            type = 3;
                        }
                        else if (bloonSpawner < 30)
                        {
                            type = 4;
                        }
                        else if (bloonSpawner < 40)
                        {
                            type = 5;
                        }
                        else if (bloonSpawner < 50)
                        {
                            type = 6;
                        }
                        else
                        {
                            type = 6;
                        }

                        Balloon bloon = new Balloon(type, 0, 210, 30, 30, balloonSpeed + type, 0, false);
                        balloons.Add(bloon);

                    }
                    bloonSpawner++;

                    if (roundNumber % 5 == 0)
                    {
                        balloonSpeed++;
                        if (speedUp && bloonSpawner > bpl)
                        {
                            Balloon bloon = new Balloon(1, 0, 210, 30, 30, 1, 0, false);
                            balloons.Add(bloon);
                            speedUp = false;
                        }
                    }
                    if (roundNumber % 10 == 0)
                    {
                        if (MOABspawn && bloonSpawner > bpl)
                        {
                            Balloon bloon = new Balloon(1, 0, 210, 30, 30, 1, 0, false);
                            balloons.Add(bloon);
                            MOABspawn = false;
                        }
                    }

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
                            if (!d.upgrade)
                            {
                                Dart dart = new Dart(def.hitBox.X + (def.hitBox.Width / 2), def.hitBox.Y + (def.hitBox.Height / 2), 20, 20, (x1 - x2) * 0.25, (y1 - y2) * 0.25, 1, Properties.Resources.Dart);
                                darts.Add(dart);
                            }
                            if (d.upgrade)
                            {
                                Dart dart = new Dart(def.hitBox.X + (def.hitBox.Width / 2), def.hitBox.Y + (def.hitBox.Height / 2), 20, 20, (x1 - x2) * 0.25, (y1 - y2) * 0.25, 6, Properties.Resources.Dart);
                                darts.Add(dart);
                            }
                        }
                        if (d.type == 2)
                        {
                            if (!d.upgrade)
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
                            if (d.upgrade)
                            {
                                double xStep = Math.Cos(45 * Math.PI / 180.0);
                                double yStep = Math.Sin(45 * Math.PI / 180.0);

                                Dart dart1 = new Dart(def.hitBox.X + (def.hitBox.Width / 2), def.hitBox.Y + (def.hitBox.Height / 2), 20, 20, 10, 0, 8, Properties.Resources.Tack);
                                Dart dart2 = new Dart(def.hitBox.X + (def.hitBox.Width / 2), def.hitBox.Y + (def.hitBox.Height / 2), 20, 20, 0, 10, 8, Properties.Resources.Tack);
                                Dart dart3 = new Dart(def.hitBox.X + (def.hitBox.Width / 2), def.hitBox.Y + (def.hitBox.Height / 2), 20, 20, -10, 0, 8, Properties.Resources.Tack);
                                Dart dart4 = new Dart(def.hitBox.X + (def.hitBox.Width / 2), def.hitBox.Y + (def.hitBox.Height / 2), 20, 20, 0, -10, 8, Properties.Resources.Tack);
                                Dart dart5 = new Dart(def.hitBox.X + (def.hitBox.Width / 2), def.hitBox.Y + (def.hitBox.Height / 2), 20, 20, 10 * xStep, 10 * yStep, 8, Properties.Resources.Tack);
                                Dart dart6 = new Dart(def.hitBox.X + (def.hitBox.Width / 2), def.hitBox.Y + (def.hitBox.Height / 2), 20, 20, 10 * xStep, -10 * yStep, 8, Properties.Resources.Tack);
                                Dart dart7 = new Dart(def.hitBox.X + (def.hitBox.Width / 2), def.hitBox.Y + (def.hitBox.Height / 2), 20, 20, -10 * xStep, 10 * yStep, 8, Properties.Resources.Tack);
                                Dart dart8 = new Dart(def.hitBox.X + (def.hitBox.Width / 2), def.hitBox.Y + (def.hitBox.Height / 2), 20, 20, -10 * xStep, -10 * yStep, 8, Properties.Resources.Tack);

                                darts.Add(dart1);
                                darts.Add(dart2);
                                darts.Add(dart3);
                                darts.Add(dart4);
                                darts.Add(dart5);
                                darts.Add(dart6);
                                darts.Add(dart7);
                                darts.Add(dart8);
                            }

                        }
                        if (d.type == 3)
                        {
                            Dart dart = new Dart(def.hitBox.X + (def.hitBox.Width / 2), def.hitBox.Y + (def.hitBox.Height / 2), 20, 20, (x1 - x2) * 0.25, (y1 - y2) * 0.25, 3, Properties.Resources.Dart);
                            darts.Add(dart);
                        }
                        if (d.type == 4)
                        {
                            if (!d.upgrade)
                            {
                                Dart dart = new Dart(def.hitBox.X + (def.hitBox.Width / 2), def.hitBox.Y + (def.hitBox.Height / 2), 20, 20, (x1 - x2) * 0.25, (y1 - y2) * 0.25, 4, Properties.Resources.Magic);
                                darts.Add(dart);
                            }
                            if (d.upgrade)
                            {
                                Dart dart = new Dart(def.hitBox.X + (def.hitBox.Width / 2), def.hitBox.Y + (def.hitBox.Height / 2), 20, 20, (x1 - x2) * 0.25, (y1 - y2) * 0.25, 9, Properties.Resources.Magic);
                                darts.Add(dart);
                            }

                        }
                        if (d.type == 5)
                        {
                            if (!d.upgrade)
                            {
                                Dart dart = new Dart(def.hitBox.X + (def.hitBox.Width / 2), def.hitBox.Y + (def.hitBox.Height / 2), 20, 20, (x1 - x2) * 0.25, (y1 - y2) * 0.25, 5, Properties.Resources.ICEBALL);
                                darts.Add(dart);
                            }

                            if (d.upgrade)
                            {
                                Dart dart = new Dart(def.hitBox.X + (def.hitBox.Width / 2), def.hitBox.Y + (def.hitBox.Height / 2), 20, 20, (x1 - x2) * 0.25, (y1 - y2) * 0.25, 7, Properties.Resources.ICEBALL);
                                darts.Add(dart);
                            }
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
                    else
                    {
                        darts.RemoveAt(i);
                    }
                }


                for (int i = 0; i < balloons.Count; i++)
                {
                    if (onScreen.Contains(balloons[i].hitBox.X, balloons[i].hitBox.Y))
                    {
                        //nada
                    }
                    else
                    {
                        balloons.RemoveAt(i);
                    }
                }


                for (int i = 0; i < balloons.Count; i++)
                {
                    foreach (Rectangle rec in pathRects)
                    {
                        if (rec.Contains(balloons[i].hitBox.X, balloons[i].hitBox.Y))
                        {
                            keepBalloon = true;
                        }
                    }



                    if (!keepBalloon)
                    {
                        balloons.RemoveAt(i);
                    }

                }



                for (int i = 0; i < balloons.Count; i++)
                {
                    for (int j = 0; j < darts.Count; j++)
                    {
                        if (i < balloons.Count)
                        {
                            if (darts[j].hitBox.IntersectsWith(balloons[i].hitBox) && balloons[i].colour != 1)
                            {

                                money++;
                                trackingHighscore.score++;
                                if (darts[j].type == 4 || (darts[j].type == 9 && lightningShot < 3))
                                {
                                    if (darts[j].type == 9)
                                    {
                                        lightningShot++;
                                    }

                                    Balloon.bePopped = true;
                                }
                                else if (darts[j].type == 5)
                                {
                                    balloons[i].slow = true;
                                }
                                else if (darts[j].type == 7)
                                {
                                    balloons[i].slow = true;
                                    balloons[i].popped(balloons[i]);
                                }
                                else if (darts[j].type == 9 && lightningShot >= 3)
                                {
                                    lightningShot = 0;

                                    Balloon.bePopped = true;
                                    balloons.RemoveAt(i);
                                    Balloon.bePopped = false;

                                    int x = i;
                                    for (int k = 0; k < 4; k++)
                                    {
                                        if (balloons.Count > x)
                                        {
                                            if (balloons[x].colour == 1)
                                            {
                                                balloons[x].image = Properties.Resources.RedLightningBalloon;
                                            }
                                            if (balloons[x].colour == 2)
                                            {
                                                balloons[x].image = Properties.Resources.BlueLightningBalloon;
                                            }
                                            if (balloons[x].colour == 3)
                                            {
                                                balloons[x].image = Properties.Resources.GreenLightningBalloon;
                                            }
                                            if (balloons[x].colour == 4)
                                            {
                                                balloons[x].image = Properties.Resources.YellowLightningBalloon;
                                            }
                                            if (balloons[x].colour == 5)
                                            {
                                                balloons[x].image = Properties.Resources.PinkLightningBalloon;
                                            }

                                            LightningBalloons.Add(balloons[x]);

                                            x++;

                                        }
                                    }

                                }
                                else
                                {
                                    balloons[i].slow = false;
                                    balloons[i].popped(balloons[i]);
                                }




                                if (balloons.Count > i)
                                {
                                    if (balloons[i].slow)
                                    {
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
                                }

                                if (Balloon.bePopped)
                                {
                                    if (darts[j].type == 6)
                                    {
                                        darts.RemoveAt(j);
                                    }
                                    balloons.RemoveAt(i);
                                    Balloon.bePopped = false;
                                }
                                if (darts.Count > j)
                                {
                                    if (darts[j].type != 6)
                                    {
                                        darts.RemoveAt(j);
                                    }
                                }



                            }
                            else
                            {
                                if (darts[j].hitBox.IntersectsWith(rec))
                                {
                                    if (darts[j].type == 1 || darts[j].type == 3 || darts[j].type == 5)
                                    {
                                        balloons[i].MOABhealth -= 3;
                                    }
                                    else if (darts[j].type == 2)
                                    {
                                        balloons[i].MOABhealth -= 1;
                                    }
                                    else if (darts[j].type == 4)
                                    {
                                        balloons[i].MOABhealth -= 5;
                                    }
                                    darts.RemoveAt(j);
                                }


                                if (balloons[i].MOABhealth < 0 && moabDeathSpawn)
                                {
                                    int bloonDisperser = 0;
                                    for (int k = 0; k < 10; k++)
                                    {
                                        bloonDisperser += 20;
                                        if (balloons[i].xDirection > 0)
                                        {
                                            newB = new Balloon(6, balloons[i].hitBox.X - bloonDisperser, balloons[i].hitBox.Y, 30, 30, balloons[i].xSpeed, balloons[i].ySpeed, false);
                                            newB.xDirection = 1;
                                            newB.yDirection = 0;

                                        }
                                        else if (balloons[i].xDirection < 0)
                                        {
                                            newB = new Balloon(6, balloons[i].hitBox.X - bloonDisperser, balloons[i].hitBox.Y, 30, 30, balloons[i].xSpeed, balloons[i].ySpeed, false);
                                            newB.xDirection = -1;
                                            newB.yDirection = 0;

                                        }
                                        else if (balloons[i].yDirection > 0)
                                        {
                                            newB = new Balloon(6, balloons[i].hitBox.X, balloons[i].hitBox.Y - bloonDisperser, 30, 30, balloons[i].xSpeed, balloons[i].ySpeed, false);
                                            newB.xDirection = 0;
                                            newB.yDirection = 1;

                                        }
                                        else if (balloons[i].yDirection < 0)
                                        {
                                            newB = new Balloon(6, balloons[i].hitBox.X, balloons[i].hitBox.Y - bloonDisperser, 30, 30, balloons[i].xSpeed, balloons[i].ySpeed, false);
                                            newB.xDirection = 0;
                                            newB.yDirection = -1;

                                        }

                                        balloons.Add(newB);
                                    }
                                    moabDeathSpawn = false;
                                    balloons.RemoveAt(i);
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

                        b.xDirection = 0;
                        b.yDirection = -1;

                    }

                    if (b.hitBox.IntersectsWith(cornerRect2))
                    {


                        b.xDirection = -1;
                        b.yDirection = 0;

                    }

                    if (b.hitBox.IntersectsWith(cornerRect3))
                    {


                        b.xDirection = 0;
                        b.yDirection = 1;

                    }

                    if (b.hitBox.IntersectsWith(cornerRect4))
                    {


                        b.xDirection = -1;
                        b.yDirection = 0;

                    }

                    if (b.hitBox.IntersectsWith(cornerRect5))
                    {


                        b.xDirection = 0;
                        b.yDirection = -1;

                    }

                    if (b.hitBox.IntersectsWith(cornerRect6))
                    {


                        b.xDirection = 1;
                        b.yDirection = 0;


                    }

                    if (b.hitBox.IntersectsWith(cornerRect7))
                    {


                        b.xDirection = 0;
                        b.yDirection = -1;

                    }

                    if (b.hitBox.IntersectsWith(cornerRect8))
                    {


                        b.xDirection = 1;
                        b.yDirection = 0;

                    }

                    if (b.hitBox.IntersectsWith(cornerRect9))
                    {


                        b.xDirection = 0;
                        b.yDirection = 1;

                    }

                    if (b.hitBox.IntersectsWith(cornerRect10))
                    {


                        b.xDirection = -1;
                        b.yDirection = 0;

                    }

                    if (b.hitBox.IntersectsWith(cornerRect11))
                    {


                        b.xDirection = 0;
                        b.yDirection = 1;

                    }

                    b.xSpeed = (balloonSpeed + b.colour) * b.xDirection;
                    b.ySpeed = (balloonSpeed + b.colour) * b.yDirection;

                    if (b.slow)
                    {
                        if (b.xSpeed > 0)
                        {
                            b.xSpeed = (balloonSpeed + b.colour) * 0.5;
                        }
                        else if (b.xSpeed < 0)
                        {
                            b.xSpeed = -(balloonSpeed + b.colour) * 0.5;
                        }

                        if (b.ySpeed > 0)
                        {
                            b.ySpeed = (balloonSpeed + b.colour) * 0.5;
                        }
                        else if (b.ySpeed < 0)
                        {
                            b.ySpeed = -(balloonSpeed + b.colour) * 0.5;
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
                    gameTimer.Enabled = false;
                    Form1.ChangeScreen(this, new EndScreen());
                }

                if (balloons.Count == 0 && bloonSpawner >= bpl)
                {
                    inBetweenRounds = true;
                    MOABspawn = true;
                    speedUp = true;
                    bloonSpawnTimer = 10;
                    bloonSpawner = 0;
                    roundNumber++;
                    darts.Clear();
                    // money += (100 * (int)roundNumber);
                    money += 200;

                    bpl = (int)(Math.Pow(roundNumber, 2) + 10);
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
                else if (darts[i].type == 8 && darts[i].timer >= 10)
                {
                    darts.RemoveAt(i);
                }



            }

            if (LightningBalloons.Count > 0)
            {
                lightningCount++;
                if (lightningCount >= 5)
                {
                    for (int i = 0; i < balloons.Count; i++)
                    {
                        for (int j = 0; j < LightningBalloons.Count; j++)
                        {
                            if (LightningBalloons[j] == balloons[i])
                            {
                                balloons[i].popped(balloons[i]);

                                if (Balloon.bePopped)
                                {
                                    balloons.RemoveAt(i);
                                    Balloon.bePopped = false;
                                }

                            }
                        }
                    }
                    LightningBalloons.Clear();
                    lightningCount = 0;
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
            if (e.Button == MouseButtons.Left)
            {
                Point clicked = new Point(mouse.X, mouse.Y);

                foreach (Defender d in defenders)
                {
                    if (d.hitBox.Contains(clicked) && spawnSelect == false)
                    {
                        menuMonkey = d;

                        openMenu(d.type, d.hitBox);

                        break;
                    }
                    else
                    {
                        closeMenu();
                    }
                }

                if (spawn)
                {
                    Defender defenderNew = new Defender(mouse.X - 30, mouse.Y - 30, 60, 60, spawnType, spawnImage, false);
                    defenders.Add(defenderNew);
                    money -= price;
                    spawn = false;
                    spawnSelect = false;
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                spawnSelect = false;
                spawn = false;
            }

        }


        public void openMenu(int type, Rectangle rec)
        {
            if (rec.X < this.Width / 2)
            {
                if (menuMonkey.upgrade == false)
                {
                    upgradeButton.Enabled = true;
                    upgradeButton.BackColor = Color.White;
                }
                else if (menuMonkey.upgrade)
                {
                    upgradeButton.Enabled = false;
                    upgradeButton.BackColor = Color.Gray;
                }
                menuOpen = true;
                upgradeMenuBackgroundLabel.Location = new Point(595, 45);
                upgradeButton.Location = new Point(631, 284);
                upgradeMenuNameLabel.Location = new Point(639, 171);
                upgradeMenuPictureBox.Location = new Point(615, 67);
                sellButton.Location = new Point(631, 397);
                sellButtonLabel.Location = new Point(648, 381);
                upgradeButtonLabel.Location = new Point(648, 255);


                upgradeMenuBackgroundLabel.Visible = true;

                upgradeMenuPictureBox.Visible = true;

                if (type == 1)
                {
                    upgradeMenuPictureBox.Image = Properties.Resources.Dart_Monkey;
                    upgradeMenuNameLabel.Text = "Dart Monkey";
                    upgradeButtonLabel.Text = dartMonkeyUpgradePrice.ToString();
                    if (menuMonkey.upgrade)
                    {
                        sellButtonLabel.Text = dartMonkeyPrice.ToString();
                    }
                    if (!menuMonkey.upgrade)
                    {
                        sellButtonLabel.Text = dartMonkeySellPrice.ToString();
                    }

                }
                if (type == 2)
                {
                    upgradeMenuPictureBox.Image = Properties.Resources.TackShooter;
                    upgradeMenuNameLabel.Text = "Tack Shooter";
                    upgradeButtonLabel.Text = tackShooterUpgradePrice.ToString();
                    if (menuMonkey.upgrade)
                    {
                        sellButtonLabel.Text = tackShooterPrice.ToString();
                    }
                    if (!menuMonkey.upgrade)
                    {
                        sellButtonLabel.Text = tackShooterSellPrice.ToString();
                    }
                }
                if (type == 3)
                {
                    upgradeMenuPictureBox.Image = Properties.Resources.SuperMonkey;
                    upgradeMenuNameLabel.Text = "Super Monkey";
                    upgradeButtonLabel.Text = superMonkeyUpgradePrice.ToString();
                    if (menuMonkey.upgrade)
                    {
                        sellButtonLabel.Text = superMonkeyPrice.ToString();
                    }
                    if (!menuMonkey.upgrade)
                    {
                        sellButtonLabel.Text = superMonkeySellPrice.ToString();
                    }
                }
                if (type == 4)
                {
                    upgradeMenuPictureBox.Image = Properties.Resources.WizardMonkey;
                    upgradeMenuNameLabel.Text = "Wizard Monkey";
                    upgradeButtonLabel.Text = wizardMonkeyUpgradePrice.ToString();
                    if (menuMonkey.upgrade)
                    {
                        sellButtonLabel.Text = wizardMonkeyPrice.ToString();
                    }
                    if (!menuMonkey.upgrade)
                    {
                        sellButtonLabel.Text = wizardMonkeySellPrice.ToString();
                    }
                }
                if (type == 5)
                {
                    upgradeMenuPictureBox.Image = Properties.Resources.IceMonkey;
                    upgradeMenuNameLabel.Text = "Ice Monkey";
                    upgradeButtonLabel.Text = iceMonkeyUpgradePrice.ToString();
                    if (menuMonkey.upgrade)
                    {
                        sellButtonLabel.Text = iceMonkeyPrice.ToString();
                    }
                    if (!menuMonkey.upgrade)
                    {
                        sellButtonLabel.Text = iceMonkeySellPrice.ToString();
                    }
                }

                upgradeButton.Visible = true;
                sellButton.Visible = true;

                sellButtonLabel.Visible = true;
                upgradeButtonLabel.Visible = true;

                upgradeMenuNameLabel.Visible = true;


                upgradeMenuPictureBox.BringToFront();
                upgradeButton.BringToFront();
                sellButton.BringToFront();
                sellButtonLabel.BringToFront();
                upgradeButtonLabel.BringToFront();
                upgradeMenuNameLabel.BringToFront();

            }
            else
            {
                if (menuMonkey.upgrade == false)
                {
                    upgradeButton.Enabled = true;
                    upgradeButton.BackColor = Color.White;
                }
                else if (menuMonkey.upgrade)
                {
                    upgradeButton.Enabled = false;
                    upgradeButton.BackColor = Color.Gray;
                }


                menuOpen = true;
                upgradeMenuBackgroundLabel.Location = new Point(0, 45);
                upgradeButton.Location = new Point(36, 284);
                upgradeMenuNameLabel.Location = new Point(44, 171);
                upgradeMenuPictureBox.Location = new Point(20, 67);
                sellButton.Location = new Point(36, 397);
                sellButtonLabel.Location = new Point(53, 381);
                upgradeButtonLabel.Location = new Point(53, 255);


                upgradeMenuBackgroundLabel.Visible = true;

                upgradeMenuPictureBox.Visible = true;

                if (type == 1)
                {
                    upgradeMenuPictureBox.Image = Properties.Resources.Dart_Monkey;
                    upgradeMenuNameLabel.Text = "Dart Monkey";
                    upgradeButtonLabel.Text = dartMonkeyUpgradePrice.ToString();
                    if (menuMonkey.upgrade)
                    {
                        sellButtonLabel.Text = dartMonkeyPrice.ToString();
                    }
                    if (!menuMonkey.upgrade)
                    {
                        sellButtonLabel.Text = dartMonkeySellPrice.ToString();
                    }

                }
                if (type == 2)
                {
                    upgradeMenuPictureBox.Image = Properties.Resources.TackShooter;
                    upgradeMenuNameLabel.Text = "Tack Shooter";
                    upgradeButtonLabel.Text = tackShooterUpgradePrice.ToString();
                    if (menuMonkey.upgrade)
                    {
                        sellButtonLabel.Text = tackShooterPrice.ToString();
                    }
                    if (!menuMonkey.upgrade)
                    {
                        sellButtonLabel.Text = tackShooterSellPrice.ToString();
                    }
                }
                if (type == 3)
                {
                    upgradeMenuPictureBox.Image = Properties.Resources.SuperMonkey;
                    upgradeMenuNameLabel.Text = "Super Monkey";
                    upgradeButtonLabel.Text = superMonkeyUpgradePrice.ToString();
                    if (menuMonkey.upgrade)
                    {
                        sellButtonLabel.Text = superMonkeyPrice.ToString();
                    }
                    if (!menuMonkey.upgrade)
                    {
                        sellButtonLabel.Text = superMonkeySellPrice.ToString();
                    }
                }
                if (type == 4)
                {
                    upgradeMenuPictureBox.Image = Properties.Resources.WizardMonkey;
                    upgradeMenuNameLabel.Text = "Wizard Monkey";
                    upgradeButtonLabel.Text = wizardMonkeyUpgradePrice.ToString();
                    if (menuMonkey.upgrade)
                    {
                        sellButtonLabel.Text = wizardMonkeyPrice.ToString();
                    }
                    if (!menuMonkey.upgrade)
                    {
                        sellButtonLabel.Text = wizardMonkeySellPrice.ToString();
                    }
                }
                if (type == 5)
                {
                    upgradeMenuPictureBox.Image = Properties.Resources.IceMonkey;
                    upgradeMenuNameLabel.Text = "Ice Monkey";
                    upgradeButtonLabel.Text = iceMonkeyUpgradePrice.ToString();
                    if (menuMonkey.upgrade)
                    {
                        sellButtonLabel.Text = iceMonkeyPrice.ToString();
                    }
                    if (!menuMonkey.upgrade)
                    {
                        sellButtonLabel.Text = iceMonkeySellPrice.ToString();
                    }
                }

                upgradeButton.Visible = true;
                sellButton.Visible = true;

                sellButtonLabel.Visible = true;
                upgradeButtonLabel.Visible = true;

                upgradeMenuNameLabel.Visible = true;


                upgradeMenuPictureBox.BringToFront();
                upgradeButton.BringToFront();
                sellButton.BringToFront();
                sellButtonLabel.BringToFront();
                upgradeButtonLabel.BringToFront();
                upgradeMenuNameLabel.BringToFront();

            }

        }

        public void closeMenu()
        {

            menuOpen = false;
            upgradeMenuBackgroundLabel.Visible = false;

            upgradeMenuPictureBox.Visible = false;

            upgradeButton.Visible = false;
            sellButton.Visible = false;

            sellButtonLabel.Visible = false;
            upgradeButtonLabel.Visible = false;

            upgradeMenuNameLabel.Visible = false;

            upgradeMenuBackgroundLabel.Visible = false;
        }







        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (money >= dartMonkeyPrice)
            {
                spawnSelect = true;
                spawnImage = Properties.Resources.Dart_Monkey;
                spawnType = 1;
                price = dartMonkeyPrice;
                rad = 150;
                closeMenu();
            }

        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (money >= tackShooterPrice)
            {
                spawnSelect = true;
                spawnImage = Properties.Resources.TackShooter;
                spawnType = 2;
                price = tackShooterPrice;
                rad = 80;
                closeMenu();
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (money >= superMonkeyPrice)
            {
                spawnSelect = true;
                spawnImage = Properties.Resources.SuperMonkey;
                spawnType = 3;
                price = superMonkeyPrice;
                rad = 200;
                closeMenu();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (money >= wizardMonkeyPrice)
            {
                spawnSelect = true;
                spawnImage = Properties.Resources.WizardMonkey;
                spawnType = 4;
                price = wizardMonkeyPrice;
                rad = 130;
                closeMenu();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (money >= iceMonkeyPrice)
            {
                spawnSelect = true;
                spawnImage = Properties.Resources.IceMonkey;
                spawnType = 5;
                price = iceMonkeyPrice;
                rad = 160;
                closeMenu();
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            inBetweenRounds = false;
        }



        private void sellButton_Click(object sender, EventArgs e)
        {
            defenders.Remove(menuMonkey);
            closeMenu();
            if (menuMonkey.type == 1)
            {
                if (menuMonkey.upgrade)
                {
                    money += dartMonkeyPrice;
                }
                else
                {
                    money += dartMonkeySellPrice;
                }

            }
            if (menuMonkey.type == 2)
            {
                if (menuMonkey.upgrade)
                {
                    money += tackShooterPrice;
                }
                else
                {
                    money += tackShooterSellPrice;
                }
            }
            if (menuMonkey.type == 3)
            {
                if (menuMonkey.upgrade)
                {
                    money += superMonkeyPrice;
                }
                else
                {
                    money += superMonkeySellPrice;
                }

            }
            if (menuMonkey.type == 4)
            {
                if (menuMonkey.upgrade)
                {
                    money += wizardMonkeyPrice;
                }
                else
                {
                    money += wizardMonkeySellPrice;
                }
            }
            if (menuMonkey.type == 5)
            {
                if (menuMonkey.upgrade)
                {
                    money += iceMonkeyPrice;
                }
                else
                {
                    money += iceMonkeySellPrice;
                }
            }


        }

        private void upgradeButton_Click(object sender, EventArgs e)
        {
            foreach (Defender d in defenders)
            {
                if (d == menuMonkey)
                {
                    if (d.type == 1 && money >= 150)
                    {
                        d.upgrade = true;
                        upgradeButton.Enabled = false;
                        upgradeButton.BackColor = Color.Gray;
                        money -= dartMonkeyUpgradePrice;
                        sellButtonLabel.Text = dartMonkeyPrice.ToString();
                    }
                    if (d.type == 3 && money >= 600)
                    {
                        d.upgrade = true;
                        upgradeButton.Enabled = false;
                        upgradeButton.BackColor = Color.Gray;
                        money -= superMonkeyUpgradePrice;
                        sellButtonLabel.Text = superMonkeyPrice.ToString();
                    }
                    if (d.type == 5 && money >= 250)
                    {
                        d.upgrade = true;
                        upgradeButton.Enabled = false;
                        upgradeButton.BackColor = Color.Gray;
                        money -= iceMonkeyUpgradePrice;
                        sellButtonLabel.Text = iceMonkeyPrice.ToString();
                    }
                    if (d.type == 2 && money >= 200)
                    {
                        d.upgrade = true;
                        upgradeButton.Enabled = false;
                        upgradeButton.BackColor = Color.Gray;
                        money -= tackShooterUpgradePrice;
                        sellButtonLabel.Text = tackShooterPrice.ToString();
                    }
                    if (d.type == 4 && money >= 300)
                    {
                        d.upgrade = true;
                        upgradeButton.Enabled = false;
                        upgradeButton.BackColor = Color.Gray;
                        money -= wizardMonkeyUpgradePrice;
                        sellButtonLabel.Text = wizardMonkeyPrice.ToString();
                    }

                }
                if (d.upgrade && d.type == 3 && d.defualtTimer != 3)
                {
                    d.rad = 250;
                    d.shotTimer = 3;
                    d.defualtTimer = 3;
                }
                if (d.upgrade && d.type == 2 && d.defualtTimer != 37)
                {
                    d.rad = 100;
                    d.shotTimer = 37;
                    d.defualtTimer = 37;
                }
            }
        }

        private void SpeedUpButton_Click(object sender, EventArgs e)
        {
            //if (speedFlip == 0)
            //{
            //    gameTimer.Interval = 10;
            //    speedFlip = 1;
            //}
            //else if (speedFlip == 1)
            //{
            //    gameTimer.Interval = 20;
            //    speedFlip = 0;
            //}
            gameTimer.Enabled = false;
            Form1.ChangeScreen(this, new TitleScreen());
        }
    }
}
// monkey rotate
#endregion
