namespace GenericProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FindMax
            /*int firstNumber = 120;
            int secondNumber = 80;
            int thirdNumber = 90;

            int maxNumber = FindMax.MaxNumber(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine($"The maximum number is: {maxNumber}");*/

            //FindMaxDouble
            /*double num1 = 5.5;
            double num2 = 10.2;
            double num3 = 7.8;

            double maxNumber = FindMaxDouble.MaxNumber(num1, num2, num3);
            Console.WriteLine($"The maximum number is: {maxNumber}");*/

            //FindMaxString
            /*string str1 = "apple";
            string str2 = "banana";
            string str3 = "orange";

            string maxString = FindMaxString.MaxString(str1, str2, str3);
            Console.WriteLine($"The maximum string is: {maxString}");*/

            //MaxMethod
            string maxString = GenericMaxMethod.MaxString("apple", "banana", "orange", "grape");
            Console.WriteLine($"The maximum string is: {maxString}");

            
        }
    }
}