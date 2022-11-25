using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace AlgoritmosOrdenacao.src
{
    internal class Teste
    {
        System.Timers.Timer teste = new();
        public List<Ficha> SortTeste(int range) 
        {
            VectorGenerator vg = new();
            int[] best = vg.AscendingOrder(range);
            int[] normal = vg.RandomOrder(range);
            int[] worst = vg.DescendingOrder(range);
            
            List<Ficha> resultado = new();
            float aux = 0.0f;

            MySort.BubbleSort(best);
            resultado.Add(new Ficha($"Bubble Sort", "Best Case", range, aux));

            aux = 0.0f;
            MySort.BubbleSort(normal);
            resultado.Add(new Ficha($"Bubble Sort {range}", "Random Case", range, aux));

            aux = 0.0f;
            MySort.BubbleSort(worst);
            resultado.Add(new Ficha($"Bubble Sort {range}", "Worst Case", range, aux));

            aux = 0.0f;
            MySort.ImprovedBubbleSort(best);
            resultado.Add(new Ficha($"Improved Bubble Sort", "Best Case", range, aux));

            aux = 0.0f;
            MySort.ImprovedBubbleSort(normal);
            resultado.Add(new Ficha($"Improved Bubble Sort", "Random Case", range, aux));

            aux = 0.0f;
            MySort.ImprovedBubbleSort(worst);
            resultado.Add(new Ficha($"Improved Bubble Sort", "Worst Case", range, aux));

            aux = 0.0f;
            MySort.InsertionSort(best);
            resultado.Add(new Ficha($"Insertion Sort", "Best Case", range, aux));

            aux = 0.0f;
            MySort.InsertionSort(normal);
            resultado.Add(new Ficha($"Insertion Sort", "Random Case", range, aux));

            aux = 0.0f;
            MySort.InsertionSort(worst);
            resultado.Add(new Ficha($"Insertion Sort", "Worst Case", range, aux));

            aux = 0.0f;
            MySort.SelectionSort(best);
            resultado.Add(new Ficha($"Selection Sort", "Best Case", range, aux));

            aux = 0.0f;
            MySort.SelectionSort(normal);
            resultado.Add(new Ficha($"Selection Sort", "Random Case", range, aux));

            aux = 0.0f;
            MySort.SelectionSort(worst);
            resultado.Add(new Ficha($"Selection Sort", "Worst Case", range, aux));

            aux = 0.0f;
            MySort.MergeSort(best);
            resultado.Add(new Ficha($"Merge Sort", "Best Case", range, aux));

            aux = 0.0f;
            MySort.MergeSort(normal);
            resultado.Add(new Ficha($"Merge Sort", "Random Case", range, aux));

            aux = 0.0f;
            MySort.MergeSort(worst);
            resultado.Add(new Ficha($"Merge Sort", "Worst Case", range, aux));

            aux = 0.0f;
            MySort.QuickSort(best);
            resultado.Add(new Ficha($"Quick Sort", "Best Case", range, aux));

            aux = 0.0f;
            MySort.QuickSort(normal);
            resultado.Add(new Ficha($"Quick Sort", "Random Case", range, aux));

            aux = 0.0f;
            MySort.QuickSort(worst);
            resultado.Add(new Ficha($"Quick Sort", "Best Case", range, aux));

            return resultado;
        }
    }
}
