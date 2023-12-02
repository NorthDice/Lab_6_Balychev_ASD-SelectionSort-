using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_Balychev_ASD
{
    public static class MyArray
    {
        public static void FillArray(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
        }

        public static void Randomize(ref int[] arr)
        {
            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                int randomIndex = random.Next(0, arr.Length - 1);
                Swap(ref arr, i, randomIndex);
            }
        }
        /* 
        Алгоритм сортування вибором (Selection Sort) працює шляхом пошуку найменшого
        (або найбільшого, залежно від напрямку сортування)
        елемента в масиві і обміну його з першим елементом,
        Потім алгоритм повторює цей процес для залишкової частини масиву,
        тобто для усіх елементів, крім вже відсортованих.
         */
        public static void SelectionSort(ref int[] arr)
        {
            // Цикл для кожного елементу, крім останнього
            for (int i = 0; i < arr.Length - 1; i++)
            {
                // Знаходження індексу мінімального елементу в залишку масиву
                int minIndex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    // Порівняння поточного елементу з мінімальним
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Обмін знайденого мінімуму із першим елементом у залишку
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

        private static void Swap(ref int[] arr, int FirstIndex, int SecondIndex)
        {
            int temp = arr[FirstIndex];
            arr[FirstIndex] = arr[SecondIndex];
            arr[SecondIndex] = temp;
        }

        public static string ToString(int[] arr)
        {
            string result = string.Empty;

            foreach (int item in arr)
            {
                result += $"{item} ";
            }

            return result.Substring(0, result.Length - 1);
        }
    }
}

