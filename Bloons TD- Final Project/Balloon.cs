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


       public int x, y, width, height, colour;

        public Image image;

        public double xSpeed, ySpeed;

        public Rectangle hitBox;

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


            hitBox = new Rectangle(x, y, width, height);

            if (colour == 1)
            {
                image = Properties.Resources.RedBalloon;
            }
            if (colour == 2)
            {
                image = Properties.Resources.BlueBalloon;
            }
            if(colour == 3)
            {
                image = Properties.Resources.GreenBalloon;
            }
            if(colour == 4)
            {
                image = Properties.Resources.YellowBalloon;
            }
            if(colour == 5)
            {
                image= Properties.Resources.PinkBalloon;   
            }
        }

        public void move(Balloon b)
        {
            b.x += (int)xSpeed;
            b.y += (int)ySpeed;

            b.hitBox = new Rectangle(b.x, b.y, b.width, b.height);
        }

        public void popped(Balloon b)
        {

            b.colour -= 1;



            if (b.colour == 0)
            {
                bePopped = true;
            }

            if (b.colour == 1)
            {
                b.image = Properties.Resources.RedBalloon;
            }

            if (b.colour == 2)
            {
                b.image = Properties.Resources.BlueBalloon;
            }

            if (b.colour == 3)
            {
                b.image = Properties.Resources.GreenBalloon;
            }
            if (b.colour == 4)
            {
                b.image = Properties.Resources.YellowBalloon;
            }



        }


    }
}
