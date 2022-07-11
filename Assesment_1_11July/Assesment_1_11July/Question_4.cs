using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_1_11July
{
    public class Question_4
    {
        public void OddNo()
        {
            int i = 0;
            Console.WriteLine("\nOdd Numbers :");
            for (i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();


        }

    }
}
