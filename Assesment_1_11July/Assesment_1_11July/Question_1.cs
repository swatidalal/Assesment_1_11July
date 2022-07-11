namespace Assesment_1_11July
{
    public class Question_1
    {
        public void EvenOdd()
        {

            int even = 0, odd = 0;
            List<int> num = new List<int>();
            num.Add(50);
            num.Add(65);
            num.Add(56);
            num.Add(71);
            num.Add(81);
            Console.WriteLine("Printing Elements of list");
            for(int i = 0; i < num.Count; i++)
            {
                var list = num[i];
                Console.WriteLine(list);
            }
            //for finding no is even or odd
            foreach (int i in num)
            {
                if (i % 2 == 0)
                {
                    even++;
                }
                else if (i % 2 == 1)
                    odd++;
            }
            Console.WriteLine("There are  "  + even +  "even numbers");
            Console.WriteLine("There are  "  + odd +  "odd numbers");            
        }
    } 
}

