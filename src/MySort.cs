using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosOrdenacao.src
{
    internal class MySort
    {
        public static void BubbleSort(int[] vector)
        {
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
        }

        public static void ImprovedBubbleSort(int[] vector)
        {
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
        }

        public static void InsertionSort(int[] vector)
        {
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
        }

        public static void SelectionSort(int[] vector)
        {
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
        }

        public static void MergeSort(int[] vector)
        {
            MergeSort(vector, 0, vector.Length - 1);
        }

        private static void MergeSort(int[] vector, int left, int right)
        {
            if (left < right)
            {
                int midle = (left + (right - 1)) / 2;
                MergeSort(vector, left, midle);
                MergeSort(vector, midle + 1, right);
                MergeSortMerge(vector, left, midle, right);
            }
        }

        private static void MergeSortMerge(int[] vector, int left, int midle, int right)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            int[] vectorleft = new int[midle - left + 1];
            int[] vectorright = new int[right - midle];
            for (i = 0; i < vectorleft.Length; i++)
            {
                vectorleft[i] = vector[left + i];
            }
            for (i = 0; i < vectorleft.Length; i++)
            {
                vectorright[i] = vector[midle + 1 + i];
            }
            i = 0;
            j = 0;
            k = left;
            while (i < vectorleft.Length && j < vectorright.Length)
            {
                if (vectorleft[i] <= vectorright[j])
                {
                    vector[k] = vectorleft[i];
                    i++;
                }
                else
                {
                    vector[k] = vectorright[j];
                    j++;
                }
                k++;
            }
            while (i < vectorleft.Length)
            {
                vector[k] = vectorleft[i];
                i++;
                k++;
            }
            while (j < vectorright.Length)
            {
                vector[k] = vectorright[j];
                j++;
                k++;
            }
        }

        public static void QuickSort(int[] vector)
        {
            QuickSort(vector, 0, vector.Length - 1);
        }

        private static void QuickSort(int[] vector, int left, int right)
        {
            int pivot = 0;
            if (left < right)
            {
                pivot = QuickSortPatition(vector, left, right);
                if (pivot > 1)
                {
                    QuickSort(vector, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(vector, pivot + 1, right);
                }
            }
        }

        private static int QuickSortPatition(int[] vector, int left, int right)
        {
            int pivot = 0;
            int aux = 0;
            pivot = vector[left];
            while (true)
            {
                while (vector[left] < pivot)
                {
                    left++;
                }
                while (vector[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    aux = vector[right];
                    vector[right] = vector[left];
                    vector[left] = aux;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
