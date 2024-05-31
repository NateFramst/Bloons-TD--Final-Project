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


        int x, y, width, height, colour;

        public Image image;

        public int xSpeed, ySpeed;

        public Rectangle hitBox;

        public static bool bePopped;


        public Balloon(int _colour, int _x, int _y, int _width, int _height, int _xSpeed, int _ySpeed)
        {
            colour = _colour;
            x = _x;
            y = _y;
            width = _width;
            height = _height;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;


            hitBox = new Rectangle(x, y, width, height);

            if (colour == 1)
            {
                image = Properties.Resources.RedBalloon;
            }
            if (colour == 2)
            {
                image = Properties.Resources.BlueBalloon;
            }

        }

        public void move(Balloon b)
        {
            b.x += xSpeed;
            b.y += ySpeed;

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



        }


    }
}
