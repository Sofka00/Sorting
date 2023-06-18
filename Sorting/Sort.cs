using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class Sort
    {
      
        public int[] ViborSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                int tmp = array[min];
                array[min] = array[i];
                array[i] = tmp;
            }

            return array;

        }
        public void Write(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}");
            }
            Console.WriteLine();
        }
        public static int[] Generatot(int n, int min, int max)
        {
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(min, max);
            }

            return array;
        }
        public static int[] SelectSort(int[] array)
        {
            for (int i = 0; i > array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                int tmp = array[min];
                array[min] = array[i];
                array[i] = tmp;
            }

            return array;

        }
    }
}

