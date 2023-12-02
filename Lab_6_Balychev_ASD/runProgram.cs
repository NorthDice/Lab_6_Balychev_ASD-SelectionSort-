using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_Balychev_ASD
{
    public class runProgram
    {
        public void Run()
        {
            Menu.Name();

            Console.WriteLine("Input array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];

            byte mode;

            do
            {
                Menu.ProgramMenu();
                mode = byte.Parse(Console.ReadLine());
                switchMenu(mode,arr);
            }
            while(true);
            
        }


        void switchMenu(byte mode,int[] arr)
        {
            switch (mode)
            {
                case 1:
                    FillArray(arr);
                    break;
                case 2:
                    RandomizeArray(arr);
                    break;
                case 3:
                    SortArray(arr); 
                    break;
                case 4:
                    Console.WriteLine(ToString(arr)); 
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Choose one of the options above!");
                    break;
            }

        }



        public void FillArray(int[] arr)
        {
            MyArray.FillArray(ref arr);
        }
        
        public void RandomizeArray(int[] arr)
        {
            MyArray.Randomize(ref arr);
        }

        public void SortArray(int[] arr)
        {
            MyArray.SelectionSort(ref arr);
        }

        public string ToString(int[] arr)
        {
            return $"[{MyArray.ToString(arr)}]";
        }
    }
}
