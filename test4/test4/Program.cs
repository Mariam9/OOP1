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
            newarr.GetTreatedArray();
        }

        interface IWow
        {
            int[] GetTreatedArray(int[] arr, int a);
        }

        public class FirstArray : IWow
        {
           public int[] GetTreatedArray(int[] arr, int a)
            {
                
                    if (a == 1) 
                 {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        int b = 10;
                        if (arr[i] >= b)
                        {
                           Console.Write("{0} ", arr[i]);
                        }
                        
                    } 
                 }

                    if(a == 2)
                {
                    for(int i = 0; i < arr.Length; i++)
                    {

                    }
                }
                    
                    

            }
        }

    }
}
