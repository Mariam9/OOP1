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

        }

        interface IWow
        {
            int[] GetTreatedArray(int[] arr, int a);
        }

        public class FirstArray : IWow
        {
            int[] GetTreatedArray(int[] arr, int a)
            {
                
                    if ( a == 1 ) 
                 {
                    for (int i = 0; i < arr.Length; i++)
                    {
                                
                    } 
                 }

                    if(a == 2)
                {
                    for(int i = 0; i<arr.Length; i++)
                    {

                    }
                }
                    
                    

            }
        }

    }
}
