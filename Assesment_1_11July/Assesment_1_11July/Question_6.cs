using System.Collections;

namespace Assesment_1_11July
{
    public class Question_6
    {
        public  void ListCitySorting()
        {
            ArrayList arr = new ArrayList();
            arr.Add("Delhi");
            arr.Add("Mumbai");
            arr.Add("Kolkata");
            arr.Add("Chennai");
            Console.WriteLine("This ArrayList Contain : ");
            foreach (string i in arr)
            {
                Console.WriteLine(i);
            }
            arr.Sort();
            Console.WriteLine("\nSorted Array List :");
            foreach (string i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}