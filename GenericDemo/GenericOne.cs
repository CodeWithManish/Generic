using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class GenericOne
    {
        public void Print<T>(T[] Array)
        {
            foreach (var item in Array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n==============\n");
        }
    }
}
