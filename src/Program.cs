namespace AlgoritmosOrdenacao.src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Teste onek = new(1000);
            onek.ImprovedBubbleSortCases();
            onek.InsertionSortCases();
            onek.SelectionSortCases();
            onek.BubbleSortCases();
            onek.MergeSortCases();
            onek.QuickSortCases();
            foreach (Ficha item in onek.GetResultado())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
            */
            /*
            Teste tenk = new(10000);
            tenk.ImprovedBubbleSortCases();
            tenk.InsertionSortCases();
            tenk.SelectionSortCases();
            tenk.BubbleSortCases();
            tenk.MergeSortCases();
            tenk.QuickSortCases();
            foreach (Ficha item in tenk.GetResultado())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
            */
            /*
            Teste hundredk = new(100000);
            hundredk.ImprovedBubbleSortCases();
            hundredk.InsertionSortCases();
            hundredk.SelectionSortCases();
            hundredk.BubbleSortCases();
            hundredk.MergeSortCases();
            foreach (Ficha item in hundredk.GetResultado())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
            */
            Teste onek = new(1000);
            onek.MergeSortCases();
            onek.ImprovedBubbleSortCases();
            onek.InsertionSortCases();
            foreach (Ficha item in onek.GetResultado())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
        }
    } 
}