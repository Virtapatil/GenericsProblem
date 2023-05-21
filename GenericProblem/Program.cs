namespace GenericProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 120;
            int secondNumber = 80;
            int thirdNumber = 90;

            int maxNumber = FindMax.MaxNumber(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine($"The maximum number is: {maxNumber}");
        }
    }
}