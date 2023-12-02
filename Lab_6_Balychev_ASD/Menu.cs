using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_Balychev_ASD
{
    public static class Menu
    {
        static public void Name()
        {
            Console.WriteLine("Balychev Kiril 623p ");
        }
        public static void ProgramMenu() 
        {
            Console.WriteLine("1 - Fill array (From 1 to length)");
            Console.WriteLine("2 - Randomize array");
            Console.WriteLine("3 - Selection Sort");
            Console.WriteLine("4 - Print Array");
            Console.WriteLine("5 - Exit");
        }
    }
}
