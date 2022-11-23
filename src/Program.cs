using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosOrdenacao.src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VectorGenerator vg = new();

            int[] aux = vg.DescendingOrder(100000);

            MySort.QuickSort(aux);

            for (int i = 0; i < aux.Length; i++)
            {
                Console.WriteLine(aux[i]);
            }
            Console.Read();
        }
    }
}