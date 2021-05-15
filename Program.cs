using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberList nmb = new NumberList();
            int[] array = { 25, 85, 95, 87, 25, 87, 96, 25, 45 };
            nmb.sumArray(array);
            nmb.productArray(array);
            nmb.reverseArray(array);
            Console.WriteLine("Main method is called for all there ");
            Console.ReadKey();
        }


    }
}
