using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Bloons_TD__Final_Project
{
    internal class Balloon
    {


       public int x, y, width, height, colour, xDirection, yDirection, blackBalloonHealth;

        public double MOABhealth;

        public Image image;

        public double xSpeed, ySpeed;

        public Rectangle hitBox, rec;

        public static bool bePopped;

        public bool slow = false;


        public Balloon(int _colour, int _x, int _y, int _width, int _height, double _xSpeed, double _ySpeed, bool _slow)
        {
            colour = _colour;
            x = _x;
            y = _y;
            width = _width;
            height = _height;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            slow = _slow;

            xDirection = 1;
            yDirection = 0;


            hitBox = new Rectangle(x, y, width, height);

            if (colour == 2)
            {
                image = Properties.Resources.RedBalloon;
            }
            if (colour == 3)
            {
                image = Properties.Resources.BlueBalloon;
            }
            if(colour == 4)
            {
                image = Properties.Resources.GreenBalloon;
            }
            if(colour == 5)
            {
                image = Properties.Resources.YellowBalloon;
            }
            if(colour == 6)
            {
                image= Properties.Resources.PinkBalloon;   
            }
            if(colour == 7)
            {
                image = Properties.Resources.BlackBalloon;
                blackBalloonHealth = 20;
            }
            if(colour == 1)
            {
                image = Properties.Resources.MOABRIGHT;
                MOABhealth = 100;
            }
        }

        public void move(Balloon b)
        {
            b.x += (int)xSpeed;
            b.y += (int)ySpeed;

            b.hitBox = new Rectangle(b.x, b.y, b.width, b.height);

            if(b.xSpeed > 0 && b.colour == 1)
            {
                b.image = Properties.Resources.MOABRIGHT;
            }
            else if (b.xSpeed < 0 && b.colour == 1)
            {
                b.image = Properties.Resources.MOABLEFT;
            }
            else if (b.ySpeed < 0 && b.colour == 1)
            {
                b.image = Properties.Resources.MOABUP;
            }
            if (b.ySpeed > 0 && b.colour == 1)
            {
                b.image = Properties.Resources.MOABDOWN;
            }
        }

        public void popped(Balloon b)
        {

            b.colour -= 1;



            if (b.colour == 1 || b.colour == 0)
            {
                bePopped = true;
            }

            if (b.colour == 2)
            {
                b.image = Properties.Resources.RedBalloon;
            }

            if (b.colour == 3)
            {
                b.image = Properties.Resources.BlueBalloon;
            }

            if (b.colour == 4)
            {
                b.image = Properties.Resources.GreenBalloon;
            }
            if (b.colour == 5)
            {
                b.image = Properties.Resources.YellowBalloon;
            }
            if(b.colour == 6)
            {
                b.image = Properties.Resources.PinkBalloon;
            }



        }


    }
}
