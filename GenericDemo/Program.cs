using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //GenericOne gen = new GenericOne();
            int[] intArr = { 1, 2, 3, 4, 5 };
            double[] doubleArr = { 1.3, 2.1, 3.1 };
            char[] charArr = { 'A', 'B', 'C' };
           /* gen.Print(intArr);
            gen.Print(doubleArr);
            gen.Print(charArr);*/

            PrintArray<int> printInt = new PrintArray<int>();
            printInt.printArr(intArr);

            PrintArray<double> printD = new PrintArray<double>();
            printD.printArr(doubleArr);

            PrintArray<char> printChar = new PrintArray<char>();
            printChar.printArr(charArr);  

            Console.ReadKey();
        }
    }
}
