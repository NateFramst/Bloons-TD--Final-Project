using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Timers;

namespace Bloons_TD__Final_Project
{
    internal class Defender
    {
        int x, y, width, height;

        public Image image;

        public Rectangle hitBox, turnRec;

        public int type;

        public int shotTimer, defualtTimer, rad;

        public bool upgrade = false;

        public bool trackingBalloon, shootingBalloon;

        public int rotationAngle;

        public float RotationAngle { get; set; }


        public Defender(int _x, int _y, int _width, int _height, int _type, Image _image, bool _upgrade)
        {
            x = _x;
            y = _y;
            width = _width;
            height = _height;
            image = _image;
            type = _type;
            upgrade = _upgrade;

            trackingBalloon = false ;
            shootingBalloon = false ;

            rotationAngle = 0;

            hitBox = new Rectangle(x, y, width, height);

            turnRec = new Rectangle(x, y, width, height);

            if (type == 1)
            {
                shotTimer = 40;
                defualtTimer = 40;
                rad = 150;
                
            }
            if (type == 2)
            {
                shotTimer = 60;
                defualtTimer = 60;
                rad = 80;
            }
            if (type == 3)
            {
                shotTimer = 5;
                defualtTimer = 5;
                rad = 200;
            }
            if(type == 4)
            {
                shotTimer = 50;
                defualtTimer = 50;
                rad = 130;
            }
            if (type == 5)
            {
                shotTimer = 22;
                defualtTimer = 22;
                rad = 180;
            }
        }



    }
}
