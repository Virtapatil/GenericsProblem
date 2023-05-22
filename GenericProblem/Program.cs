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
            /*string maxString = GenericMaxMethod.MaxString("apple", "banana", "orange", "grape");
            Console.WriteLine($"The maximum string is: {maxString}");*/
            // Example usage for integers
            int maxInt = MaxUsingGenericMethod<int>.MaxValue(10, 5, 8);
            Console.WriteLine("Max integer value: " + maxInt);

            // Example usage for strings
            string maxString = MaxUsingGenericMethod<string>.MaxValue("apple", "banana", "orange");
            Console.WriteLine("Max string value: " + maxString);

            // Example usage for custom objects
            var obj1 = new CustomObject(10);
            var obj2 = new CustomObject(5);
            var obj3 = new CustomObject(8);
            CustomObject maxObj = MaxUsingGenericMethod<CustomObject>.MaxValue(obj1, obj2, obj3);
            Console.WriteLine("Max custom object value: " + maxObj.Value);

            Console.ReadLine();
        }
    }

    // Example custom object for demonstration
    public class CustomObject : IComparable<CustomObject>
    {
        public int Value { get; set; }

        public CustomObject(int value)
        {
            Value = value;
        }

        public int CompareTo(CustomObject other)
        {
            if (other == null)
                return 1;
            else
                return Value.CompareTo(other.Value);
        }


    }
}