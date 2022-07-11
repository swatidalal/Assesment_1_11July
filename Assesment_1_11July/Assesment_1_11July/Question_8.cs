namespace Assesment_1_11July
{
    public interface IAdd
    {
        int Add(int num1, int num2);
    }
    public interface IMultiply
    {
        float Multiply(float num1, float num2);
    }
    public class Question_8:IAdd,IMultiply
    {
        int result1;
        float result2;
        public int Add(int a, int b)
        {
            result1 = a + b;
            Console.WriteLine("sum of two no.s" + result1);
            return result1;
        }
        public float Multiply(float num1,float num2)
        {
            result2 = num1 * num2;
            Console.WriteLine("Product of two no.s" +result2);
            return result2;
        }
    }
}
