using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using static System.Net.Mime.MediaTypeNames;

namespace AlgoritmosOrdenacao.src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teste first = new(1000000);
            first.RunAllCases();
            first.ImprovedBubbleSortCases();
           

            List<Ficha> aux = new(first.GetResultado());
            foreach (Ficha item in aux)
            {
                Console.WriteLine(item.ToString());
            }
        }
    } 
}