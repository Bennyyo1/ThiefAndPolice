using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiefAndPolice
{
    internal class Helper
    {
       
        public static void Movement(Person person, int[,] matrix, int sizeX, int sizeY)
        {
            int newX = person.X + person.XDirection;
            int newY = person.Y + person.YDirection;

            if (newX >= sizeX)
            {
                newX = 0;
            }

            if (newX < 0)
            {
                newX = sizeX - 1;
            }

            if (newY >= sizeY)
            {
                newY = 0;
            }

            if (newY < 0)
            {
                newY = sizeY - 1;
            }

            if (person is Thief)
            {
                matrix[person.X, person.Y] = 0;

                matrix[newX, newY] = 1;

                person.X = newX;
                person.Y = newY;

                
            }
            else if (person is Police)
            {
                matrix[person.X, person.Y] = 0;

                matrix[newX, newY] = 2;

                person.X = newX;
                person.Y = newY;


            }
            else if (person is Citizen)
            {
                matrix[person.X, person.Y] = 0;

                matrix[newX, newY] = 3;

                person.X = newX;
                person.Y = newY;


            }

        }
    }
}
