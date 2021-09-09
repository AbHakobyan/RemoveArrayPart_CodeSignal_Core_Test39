using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveArrayPart_CodeSignal_Core_Test39
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] array2 = removeArrayPart(array,3,5);
            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }
        }

        static int[] removeArrayPart(int[] inputArray, int l, int r)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i <= r && i >= l)
                {

                }
                else
                {
                    list.Add(inputArray[i]);
                }
            }
            int[] array = list.ToArray();
            return array;
        }

    }
}
