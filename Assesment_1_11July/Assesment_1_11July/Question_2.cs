using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_1_11July
{
    public class Question_2
    {

        static int i = 12345;
        static object obj = i; //Boxing int i
        static int j = (int)obj;
        public  void PrintFunction()
        {
            Console.WriteLine("Boxed Value " + obj);
            Console.WriteLine("Unboxed Value " + j);
        }
    }
}
