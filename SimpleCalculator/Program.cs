namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write(" Enter a Number ");
            double num10 = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Enter a  Second Number ");
            double num20 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num10 + num20);


            Console.ReadLine();
        }
    }
}