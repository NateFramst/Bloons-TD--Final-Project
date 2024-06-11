using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Bloons_TD__Final_Project
{
    internal class Dart
    {
        double x, y;
        int width, height;

        double ySpeed;
        double xSpeed;
        public Image image;
        public int type;

        public int timer;

        public Rectangle hitBox;

        public Dart(double _x, double _y, int _width, int _height, double _xSpeed, double _ySpeed, int _type, Image _image)
        {
            x = _x;
            y = _y;
            width = _width;
            height = _height;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            image = _image;
            type = _type;

            hitBox = new Rectangle((int)(x), (int)(y), width, height);

            timer = 0;

        }

        public void move()
        {
            x += xSpeed;
            y += ySpeed;

            hitBox.X = (int)(x);
            hitBox.Y = (int)(y);
        }




    }
}
