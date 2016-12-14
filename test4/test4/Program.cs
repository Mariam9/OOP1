using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstArray newarr = new FirstArray();
            newarr.GetTreatedArray(new int[] { 3, 56, 2, 10, 55, 6 }, 1);
        }

        interface IWow
        {
            int[] GetTreatedArray(int[] arr, int a);
        }

        public class FirstArray : IWow
        {
           public int[] GetTreatedArray(int[] arr, int a)
            {
                int buffer = 0;
                int[] arr1 = (int[])arr.Clone();
                for (int limit = arr1.Length - 1; limit > 10; limit--)
                    for (int bubble = 10; bubble < limit; bubble++)
                        if ((a == 1 && arr1[bubble] > arr1[bubble + 1])
                            )
                        {
                            buffer = arr[bubble];
                            arr[bubble] = arr[bubble + 1];
                            arr[bubble + 1] = buffer;
                        }
                return arr1;
            }

             
        }

    }
}
