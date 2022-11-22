using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosOrdenacao.src
{
    internal class VectorGenerator
    {
        public int[] AscendingOrder(int range)
        {
            int[] result = new int[range];
            for (int i = 0; i < range; i++)
            {
                result[i] = i + 1;
            }
            return result;
        }

        public int[] DescendingOrder(int range)
        {
            int[] result = new int[range];
            int j = 0;
            for (int i = range; i > 0; i--)
            {
                result[j] = i;
                j++;
            }
            return result;
        }

        public int[] RandomOrder(int range)
        {
            Random rnd = new Random();
            int[] result = new int[range];
            for (int i = 0; i < range; i++)
            {
                result[i] = rnd.Next(1000000);
            }
            return result;
        }
    }
}
