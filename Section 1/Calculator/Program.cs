using System.Threading.Tasks.Dataflow;

Console.WriteLine("Give a number: ");
var num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Give a second number: ");
var num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Choose a method: ");
Console.WriteLine("[A] Add numbers");
Console.WriteLine("[S] Subtract numbers");
Console.WriteLine("[M] Multiply numbers");

var userChoice = Console.ReadLine().ToUpper();

if (userChoice == "A")
{
    PrintResult(num1, num2, num1 + num2, "+");
}
else if (userChoice == "S")
{
    PrintResult(num1, num2, num1 - num2, "-");
}
else if (userChoice == "M")
{
    PrintResult(num1, num2, num1 * num2, "*");
}
else
{
    Console.WriteLine("Invalid Input");
}

static void PrintResult(int num1, int num2, int result, string @operator)
{
    Console.WriteLine(num1 + " " + @operator + " " + num2 + " = " + result);
}