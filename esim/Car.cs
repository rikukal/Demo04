using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esim
{
    class Car
    {   //field variables
        private readonly int maxSpeed = 200;
        private readonly double maxHeight = 4.5;

        private int speed;
        private double height;

        //Height property 
        public double Height
        {
            get
            {
                return height; 
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Too small heigt - set to zero at least");
                    height = 0;
                }
                else if (value < maxHeight)
                        {
                    Console.WriteLine("Too hight - set to max");
                        height = maxHeight;
                }
                else
                {
                    height = value;
                }
            }
        }
        //property variables
        public int Speed {
            get
            {
                return speed;
            }

            set
            {
                if (value <= maxSpeed) speed = value;
                else
                {
                    Console.WriteLine("Too much Speed - set to max");
                    speed = maxSpeed;
                }
            }


        }


    }

}
