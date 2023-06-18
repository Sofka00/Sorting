using Sorting;
using System;


public static class Program
{
     static void Main(string[] args)
    {
        
            Sort sort = new Sort();
            int[] a = Sort.Generatot(20, 0, 10);

            sort.Write(a);
            a =sort.ViborSort(a);
            sort.Write(a);

        
    }
}