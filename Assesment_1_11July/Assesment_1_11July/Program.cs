namespace Assesment_1_11July
{
    public class Program
    {
        public static void Main(String[] args)
        {
        Portal:

            Console.WriteLine("**************************************Asessment 1************************************");
            Console.WriteLine("Please Select one of the Options :\n");
            Console.WriteLine("\t\tPress 1 For 1 Question");
            Console.WriteLine("\t\tPress 2 For 2 Question");
            Console.WriteLine("\t\tPress 3 For 3 Question");
            Console.WriteLine("\t\tPress 4 For 4 Question");
            Console.WriteLine("\t\tPress 5 For 5 Question");
            Console.WriteLine("\t\tPress 6 For 6 Question");
            Console.WriteLine("\t\tPress 7 For 7 Question");
            Console.WriteLine("\t\tPress 8 For 8 Question");
            Console.WriteLine("\t\tPress 9 For 9 Question");
            Console.WriteLine("\t\tPress 10 For 10 Question");
            Console.WriteLine("\t\tPress 11 For 11 Exit");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Question_1 obj = new Question_1();
                    obj.EvenOdd();
                    goto Portal;
                case 2:
                    Question_2 obj2 = new Question_2();
                    obj2.PrintFunction();
                    goto Portal;
                case 3:
                    Question_3 obj3 = new Question_3();
                    obj3.LargestNo();
                    goto Portal;
                case 4:
                    Question_4 obj4 = new Question_4();
                    obj4.OddNo();
                    goto Portal;
                case 5:
                    Question_5 obj5 = new Question_5();
                    obj5.Method(10, 15);
                    goto Portal;
                case 6:
                    Question_6 obj6 = new Question_6();
                    obj6.ListCitySorting();
                    goto Portal;
                case 7:
                    OverloadedConstructor obj7 = new OverloadedConstructor();
                    OverloadedConstructor obj7a = new OverloadedConstructor(10);
                    OverloadedConstructor obj7b = new OverloadedConstructor(10,20);

                    goto Portal;
                case 8:
                    Question_8 obj8 = new Question_8();
                    obj8.Add(20, 40);
                    obj8.Multiply(20, 4);
                    goto Portal;
                case 9:
                    Question_9 obj9 = new Question_9();
                    obj9.GenDic();
                    goto Portal;
                case 10:
                    Question_10 obj10 = new Question_10();
                    obj10.Query();
                    goto Portal;
                case 11:
                    break;

                default:
                    Console.WriteLine("Wrong Choice Try Again");
                    goto Portal;

            }
                    Console.ReadLine();
            }
        }

    }

