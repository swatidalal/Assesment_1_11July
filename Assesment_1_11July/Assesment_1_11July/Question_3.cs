using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_1_11July
{
    public class Question_3
    {
        public void LargestNo()
        {
            int a = 900;
            int b = 750;
            int c = 478;
            if (a > b)
            {
                if (a> c)
                {
                    Console.Write("Number one 900 is the largest!\n");
                }
                else
                {
                    Console.Write("Number three 478 is the largest!\n");
                }
            }
            else if (b> c)
                Console.Write("Number two 750 is the largest!\n");
            else
                Console.Write("Number three 478 is the largest!\n");

        }

    }
}
