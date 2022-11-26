using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AlgoritmosOrdenacao.src
{
    internal class Teste
    {
        private VectorGenerator vg = new();
        private int[] best_reference;
        private int[] normal_reference;
        private int[] worst_reference;
        private List<Ficha> resultado = new();
        private Stopwatch sw = new Stopwatch();
        private int range;

        public Teste(int range)
        {
            this.best_reference = vg.AscendingOrder(range);
            this.normal_reference = vg.RandomOrder(range);
            this.worst_reference = vg.DescendingOrder(range);
            this.range = range;
        }

        public void RunAllCases()
        {
            InsertionSortCases();
            BubbleSortCases();
            SelectionSortCases();
            MergeSortCases();
            ImprovedBubbleSortCases();
            QuickSortCases();

        }

        public  void BubbleSortCases()
        {
            int[] best = this.best_reference;
            int[] normal = this.normal_reference;
            int[] worst = this.worst_reference;
            sw.Reset();
            sw.Start();
            MySort.BubbleSort(best);
            sw.Stop();
            resultado.Add(new Ficha($"Bubble Sort", "Best Case", range, sw.ElapsedMilliseconds.ToString()));

            sw.Restart();
            MySort.BubbleSort(normal);
            sw.Stop();
            resultado.Add(new Ficha($"Bubble Sort range", "Random Case", range, sw.ElapsedMilliseconds.ToString()));

            sw.Restart();
            MySort.BubbleSort(worst);
            sw.Stop();
            resultado.Add(new Ficha($"Bubble Sort range", "Worst Case", range, sw.ElapsedMilliseconds.ToString()));
        }

        public  void ImprovedBubbleSortCases()
        {
            int[] best = this.best_reference;
            int[] normal = this.normal_reference;
            int[] worst = this.worst_reference;
            sw.Reset();
            sw.Start();
            MySort.ImprovedBubbleSort(best);
            sw.Stop();
            resultado.Add(new Ficha($"Improved Bubble Sort", "Best Case", range, sw.ElapsedMilliseconds.ToString()));

            sw.Restart();
            MySort.ImprovedBubbleSort(normal);
            sw.Stop();
            resultado.Add(new Ficha($"Improved Bubble Sort", "Random Case", range, sw.ElapsedMilliseconds.ToString()));

            sw.Restart();
            MySort.ImprovedBubbleSort(worst);
            sw.Stop();
            resultado.Add(new Ficha($"Improved Bubble Sort", "Worst Case", range, sw.ElapsedMilliseconds.ToString()));
        }

        public  void InsertionSortCases()
        {
            int[] best = this.best_reference;
            int[] normal = this.normal_reference;
            int[] worst = this.worst_reference;
            sw.Reset();
            sw.Start();
            MySort.InsertionSort(best);
            sw.Stop();
            resultado.Add(new Ficha($"Insertion Sort", "Best Case", range, sw.ElapsedMilliseconds.ToString()));

            sw.Restart();
            MySort.InsertionSort(normal);
            sw.Stop();
            resultado.Add(new Ficha($"Insertion Sort", "Random Case", range, sw.ElapsedMilliseconds.ToString()));

            sw.Restart();
            MySort.InsertionSort(worst);
            sw.Stop();
            resultado.Add(new Ficha($"Insertion Sort", "Worst Case", range, sw.ElapsedMilliseconds.ToString()));
        }

        public  void SelectionSortCases()
        {
            int[] best = this.best_reference;
            int[] normal = this.normal_reference;
            int[] worst = this.worst_reference;
            sw.Reset();
            sw.Start();
            MySort.SelectionSort(best);
            sw.Stop();
            resultado.Add(new Ficha($"Selection Sort", "Best Case", range, sw.ElapsedMilliseconds.ToString()));

            sw.Restart();
            MySort.SelectionSort(normal);
            sw.Stop();
            resultado.Add(new Ficha($"Selection Sort", "Random Case", range, sw.ElapsedMilliseconds.ToString()));

            sw.Restart();
            MySort.SelectionSort(worst);
            sw.Stop();
            resultado.Add(new Ficha($"Selection Sort", "Worst Case", range, sw.ElapsedMilliseconds.ToString()));
        }

        public  void MergeSortCases() 
        {
            Thread thread = new(MergeSort, 20000000);
            thread.Start();
        }

        private void MergeSort()
        {
            int[] best = this.best_reference;
            int[] normal = this.normal_reference;
            int[] worst = this.worst_reference;
            sw.Reset();
            sw.Start();
            MySort.MergeSort(best);
            sw.Stop();
            resultado.Add(new Ficha($"Merge Sort", "Best Case", range, sw.ElapsedMilliseconds.ToString()));

            sw.Restart();
            MySort.MergeSort(normal);
            sw.Stop();
            resultado.Add(new Ficha($"Merge Sort", "Random Case", range, sw.ElapsedMilliseconds.ToString()));

            sw.Restart();
            MySort.MergeSort(worst);
            sw.Stop();
            resultado.Add(new Ficha($"Merge Sort", "Worst Case", range, sw.ElapsedMilliseconds.ToString()));
        }

        public  void QuickSortCases() 
        {
            int[] best = this.best_reference;
            int[] normal = this.normal_reference;
            int[] worst = this.worst_reference;
            sw.Reset();
            sw.Start();
            MySort.QuickSort(best);
            sw.Stop();
            resultado.Add(new Ficha($"Quick Sort", "Best Case", range, sw.ElapsedMilliseconds.ToString()));

            sw.Restart();
            MySort.QuickSort(normal);
            sw.Stop();
            resultado.Add(new Ficha($"Quick Sort", "Random Case", range, sw.ElapsedMilliseconds.ToString()));
 
            sw.Restart();
            MySort.QuickSort(worst);
            sw.Stop();
            resultado.Add(new Ficha($"Quick Sort", "Best Case", range, sw.ElapsedMilliseconds.ToString()));
        }

        public  List<Ficha> GetResultado() 
        {
            return this.resultado;
        }
    }
}
