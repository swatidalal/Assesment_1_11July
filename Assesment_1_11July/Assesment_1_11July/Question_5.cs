using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_1_11July
{
    public class Question_5
    {
        public void Method()
        {
            Console.WriteLine("Method With no Parameters");
        }
        public  void Method(int num)
        {
            int fact = 1;          
            for (int i = num; i > 0; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("Method With one Parameters gives factorial of num " + num + " = " + fact);

        }
        public void Method(int num1, int num2)
        {
            int sum;
            sum = num1 + num2;
            Console.WriteLine("Method With Two Parameters gives sum of two numbers " + num1 + " And " + num2 + " = " + sum);
        }
    }
}

