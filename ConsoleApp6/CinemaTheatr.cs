using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class CinemaTheatr
    {
        public char[,] CinemaPlaces = new char[,]
            {
                 { 'O','O','O','O','O','O','O','O','O','O' },
                 { 'O','O','O','O','O','O','O','O','O','O' },
                 { 'O','O','O','O','O','O','O','O','O','O' },
                 { 'O','O','O','O','O','O','O','O','O','O' },
                 { 'O','O','O','O','O','O','O','O','O','O' },
                 { 'O','O','O','O','O','O','O','O','O','O' },
                 { 'O','O','O','O','O','O','O','O','O','O' },
                 { 'O','O','O','O','O','O','O','O','O','O' },
                 { 'O','O','O','O','O','O','O','O','O','O' },
                 { 'O','O','O','O','O','O','O','O','O','O' },
            };
        public void CinemaPlacePrint()
        {
            Console.Clear();
            for (int i = 0; i < CinemaPlaces.GetLength(0); i++) 
            {
                for (int j = 0; j< CinemaPlaces.GetLength(1); j++)
                {
                    Console.Write($"{ CinemaPlaces[i, j]}  " + "|" + "  ");
                }
            Console.WriteLine();
            }
        }
    }
}
