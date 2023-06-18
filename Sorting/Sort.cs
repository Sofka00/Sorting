using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class Sort
    {
        static void Main (int[] args)
        {
            Sort sort = new Sort();
            int[] a = Sort.Generatot(20, 0, 10);
            
            sort.Write(a);
            a = ViborSort(a);
            sort.Write(a);

          }

        static int[] ViborSort(int[] array)
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
        void Write(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}");
            }
            Console.WriteLine();
        }
        static int[] Generatot(int n, int min, int max)
        {
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(min, max);
            }

            return array;
        }
        static int[] SelectSort(int[] array)
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

