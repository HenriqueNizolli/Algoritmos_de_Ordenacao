namespace AlgoritmosOrdenacao.src
{
    internal class Teste
    {
        private VectorGenerator vg = new();
        private int[] best_reference;
        private int[] normal_reference;
        private int[] worst_reference;
        private List<Ficha> resultado = new();
        private int range;

        public Teste(int range)
        {
            this.best_reference = vg.AscendingOrder(range);
            this.normal_reference = vg.RandomOrder(range);
            this.worst_reference = vg.DescendingOrder(range);
            this.range = range;
        }

        public  void BubbleSortCases()
        {
            int[] best = this.best_reference;
            int[] normal = this.normal_reference;
            int[] worst = this.worst_reference;
            resultado.Add(new Ficha($"Bubble Sort", "Best Case", range, MySort.BubbleSort(best)));
            resultado.Add(new Ficha($"Bubble Sort", "Random Case", range, MySort.BubbleSort(normal)));
            resultado.Add(new Ficha($"Bubble Sort", "Worst Case", range, MySort.BubbleSort(worst)));
        }

        public  void ImprovedBubbleSortCases()
        {
            int[] best = this.best_reference;
            int[] normal = this.normal_reference;
            int[] worst = this.worst_reference;
            resultado.Add(new Ficha($"Improved Bubble Sort", "Best Case", range, MySort.ImprovedBubbleSort(best)));
            resultado.Add(new Ficha($"Improved Bubble Sort", "Random Case", range, MySort.ImprovedBubbleSort(normal)));
            resultado.Add(new Ficha($"Improved Bubble Sort", "Worst Case", range, MySort.ImprovedBubbleSort(worst)));
        }

        public  void InsertionSortCases()
        {
            int[] best = this.best_reference;
            int[] normal = this.normal_reference;
            int[] worst = this.worst_reference;
            resultado.Add(new Ficha($"Insertion Sort", "Best Case", range, MySort.InsertionSort(best)));
            resultado.Add(new Ficha($"Insertion Sort", "Random Case", range, MySort.InsertionSort(normal)));
            resultado.Add(new Ficha($"Insertion Sort", "Worst Case", range, MySort.InsertionSort(worst)));
        }

        public  void SelectionSortCases()
        {
            int[] best = this.best_reference;
            int[] normal = this.normal_reference;
            int[] worst = this.worst_reference;
            resultado.Add(new Ficha($"Selection Sort", "Best Case", range, MySort.SelectionSort(best)));
            resultado.Add(new Ficha($"Selection Sort", "Random Case", range, MySort.SelectionSort(normal)));
            resultado.Add(new Ficha($"Selection Sort", "Worst Case", range, MySort.SelectionSort(worst)));
        }

        public void MergeSortCases()
        {
            try
            {
                int[] best = this.best_reference;
                int[] normal = this.normal_reference;
                int[] worst = this.worst_reference;
                resultado.Add(new Ficha($"Merge Sort", "Best Case", range, MySort.MergeSort(best)));
                resultado.Add(new Ficha($"Merge Sort", "Random Case", range, MySort.MergeSort(normal)));
                resultado.Add(new Ficha($"Merge Sort", "Worst Case", range, MySort.MergeSort(worst)));
            }
            catch (StackOverflowException)
            {
                Console.WriteLine("Erro!");
            }
        }

        public  void QuickSortCases() 
        {
            try
            {
                int[] best = this.best_reference;
                int[] normal = this.normal_reference;
                int[] worst = this.worst_reference;
                resultado.Add(new Ficha($"Quick Sort", "Best Case", range, MySort.QuickSort(best)));
                resultado.Add(new Ficha($"Quick Sort", "Random Case", range, MySort.QuickSort(normal)));
                resultado.Add(new Ficha($"Quick Sort", "Best Case", range, MySort.QuickSort(worst)));
            }
            catch (StackOverflowException)
            {
                Console.WriteLine("Erro!");
            }
        }

        public  List<Ficha> GetResultado() 
        {
            return this.resultado;
        }
    }
}
