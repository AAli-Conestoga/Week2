internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number : ");
        int firstNum =int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number : ");
        int secondNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third number :");
        int thirdNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the fourth number : ");
        int fourthNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the fifth number :");
        int fifthNum = int.Parse(Console.ReadLine());

        int sum = firstNum + secondNum + thirdNum + fourthNum + fifthNum;

        Console.WriteLine("The sum of the five numbers are : " + sum);
    }
}