using System;
using System.Net.Http.Headers;

namespace ThiefAndPolice
{
    internal class Program
    {

        static void Main(string[] args)
        {
            

            int SizeY = 100;
            int SizeX = 25;
            int[,] matrix = { };
            int amountOfThives = 20;
            int amountOfPolice = 10;
            int amountOfCitizen = 15;
            int thiefNr = 1;
            int policeNr = 2;
            int citizenNr = 3;


            Grid grid = new Grid(SizeX, SizeY);
            matrix = Grid.CreateGrid(SizeX, SizeY, matrix);

            

            //göra personlist

            List<Person> personList = new List<Person>(); //ini list

            Random rnd = new Random();
            int posX;
            int posY;
            int xDirection;
            int yDirection;
            for (int i = 0; i < amountOfThives; i++) //put thives in list
            {
                do
                {
                    posX = rnd.Next(SizeX);
                    posY = rnd.Next(SizeY);
                }
                while (matrix[posX, posY] != 0); //Check if empty else roll again
                matrix[posX, posY] = thiefNr;


                do
                {
                    xDirection = rnd.Next(-1, 2);
                    yDirection = rnd.Next(-1, 2);
                } while (xDirection == 0 && yDirection == 0); //check if empty roll again


                Thief thief = new Thief(posX, posY,xDirection,yDirection);
                personList.Add(thief);
            }

            for (int i = 0; i < amountOfPolice; i++)//put police in list
            {
                do
                {
                    posX = rnd.Next(SizeX);
                    posY = rnd.Next(SizeY);
                }
                while (matrix[posX, posY] != 0); //Check if empty else roll again
                matrix[posX, posY] = policeNr;


                do
                {
                    xDirection = rnd.Next(-1, 2);
                    yDirection = rnd.Next(-1, 2);
                } while (xDirection == 0 && yDirection == 0); //check if empty roll again

                Police police = new Police(posX, posY,xDirection,yDirection);
                personList.Add(police);
            }

            for (int i = 0; i < amountOfCitizen; i++) //add citizen to list
            {
                do
                {
                    posX = rnd.Next(SizeX);
                    posY = rnd.Next(SizeY);
                }
                while (matrix[posX, posY] != 0); //Check if empty else roll again
                matrix[posX, posY] = citizenNr;


                do
                {
                    xDirection = rnd.Next(-1, 2);
                    yDirection = rnd.Next(-1, 2);
                } while (xDirection == 0 && yDirection == 0); //check if empty roll again

                Citizen citizen = new Citizen(posX, posY, xDirection, yDirection);
                personList.Add(citizen);
            }
            
            while (true)
            {
                Grid.Print(SizeX, SizeY, matrix);

                
                    foreach (Person person in personList)
                    {
                    
                        Helper.Movement(person, matrix,SizeX,SizeY);
                    }
                
                Console.Clear();
                

            }
        }


    }
    
}