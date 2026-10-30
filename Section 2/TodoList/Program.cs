Console.WriteLine("What do you want to see?");
Console.WriteLine("[S] See all todos");
Console.WriteLine("[A] Add a todo");
Console.WriteLine("[R] Remove a todo");
Console.WriteLine("[E] Exit");


string userChoice = Console.ReadLine();


static void PrintSelectedOption(string option)
{
    Console.WriteLine("Selected option :" + option);
}

static string? LabelUserInput(string userChoice)
{
    if (userChoice == "S") return "See all todos";
    else if (userChoice == "A") return "Add a todo";
}


namespace Coding.Exercise
{
    public class Exercise
    {
        public static int AbsoluteOfSum(int num1, int num2)
        {
            var sum = num1 + num2;
            return +sum;
        }
    }
}