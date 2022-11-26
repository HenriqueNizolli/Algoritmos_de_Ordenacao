using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosOrdenacao.src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Teste first = new(1000);
            first.RunAllCases();
            List<Ficha> aux = new(first.GetResultado());
            foreach (Ficha item in aux)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
            Teste second = new(10000);
            second.RunAllCases();
            List<Ficha> auxs = new(second.GetResultado());
            foreach (Ficha item in auxs)
            {
                Console.WriteLine(item.ToString());
            }
            */
            Console.WriteLine();
            Teste th = new(10000);
            th.RunAllCases();
            List<Ficha> auxt = new(th.GetResultado());
            foreach (Ficha item in auxt)
            {
                Console.WriteLine(item.ToString());
            }
        }
    } 
}