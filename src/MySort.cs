using System.Diagnostics;

namespace AlgoritmosOrdenacao.src
{
    internal class MySort
    {
        public static long BubbleSort(int[] vector)
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();
            int aux = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = 0; j < vector.Length - 1; j++)
                {
                    if (vector[j] > vector[j + 1])
                    {
                        aux = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = aux;
                    }
                }
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        public static long ImprovedBubbleSort(int[] vector)
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();
            int aux = 0;
            bool indicator = true;
            for (int i = 0; i < vector.Length && indicator == true; i++)
            {
                indicator = false;
                for (int j = 0; j < vector.Length - 1; j++)
                {
                    if (vector[j] > vector[j + 1])
                    {
                        aux = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = aux;
                        indicator = true;
                    }
                }
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        public static long InsertionSort(int[] vector)
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();
            int aux = 0;
            int j = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                j = i - 1;
                while (j >= 0 && vector[j] > vector[j + 1])
                {
                    aux = vector[j];
                    vector[j] = vector[j + 1];
                    vector[j + 1] = aux;
                    j--;
                }
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        public static long SelectionSort(int[] vector)
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();
            int aux = 0;
            int jmin = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                jmin = i;
                for (int j = i + 1; j < vector.Length; j++)
                {
                    if (vector[j] < vector[jmin])
                    {
                        jmin = j;
                    }
                }
                if (i != jmin)
                {
                    aux  = vector[i];
                    vector[i] = vector[jmin];
                    vector[jmin] = aux;
                }
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        public static long MergeSort(int[] vector)
        {
            try
            {
                Stopwatch stopwatch = new();
                stopwatch.Start();
                MergeSort(vector, 0, vector.Length - 1);
                stopwatch.Stop();
                return stopwatch.ElapsedMilliseconds;
            }
            catch (StackOverflowException)
            {
                return -1;
            }
        }

        private static void MergeSort(int[] vector, int left, int right)
        {
            if (right > left)
            {
                int midle = (right + left) / 2;
                MergeSort(vector, left, midle);
                MergeSort(vector, (midle + 1), right);
                MergeSortMerge(vector, left, (midle + 1), right);
            }
        }

        private static void MergeSortMerge(int[] vector, int left, int midle, int right)
        {
            int[] aux = new int[vector.Length];
            int i = 0;
            int eol = (midle - 1);
            int pos = left;
            int num = (right - left + 1);
            while ((left <= eol) && (midle <= right))
            {
                if (vector[left] <= vector[midle])
                {
                    aux[pos++] = vector[left++];
                }
                else
                {
                    aux[pos++] = vector[midle++];
                }
            }
            while (left <= eol)
            {
                aux[pos++] = vector[left++];
            }
            while (midle <= right)
            {
                aux[pos++] = vector[midle++];
            }
            for (i = 0; i < num; i++)
            {
                vector[right] = aux[right];
                right--;
            }
        }

        public static long QuickSort(int[] vector)
        {
            try
            {
                Stopwatch stopwatch = new();
                stopwatch.Start();
                QuickSort(vector, 0, vector.Length - 1);
                stopwatch.Stop();
                return stopwatch.ElapsedMilliseconds;
            }
            catch (StackOverflowException)
            {
                return -1;
            }
        }

        private static void QuickSort(int[] vector, int left, int right)
        {
            if (left < right)
            {
                int pivot = QuickSortPatition(vector, left, right);
                QuickSort(vector, left, pivot - 1);
                QuickSort(vector, pivot + 1, right);
            }
        }

        private static int QuickSortPatition(int[] vector, int left, int right)
        {
            int pivot = vector[right];
            int i = (left - 1);
            int aux = 0;
            for (int j = left; j <= right - 1; j++)
            {
                if (vector[j] < pivot)
                {
                    i++;
                    aux = vector[i];
                    vector[i] = vector[j];
                    vector[j] = aux;
                }
            }
            aux = vector[i + 1];
            vector[i + 1] = vector[right];
            vector[right] = aux;
            return (i + 1);
        }
    }
}
