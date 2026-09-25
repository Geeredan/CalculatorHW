// Inputing first, second number and math action
Console.WriteLine("Enter first number: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Enter action (+,-,*,/) : ");
string action  = Console.ReadLine();

// Creating cases for 4 diffrent math actions and default case
switch (action)
{
    case "+":
        Console.WriteLine("Result : " + (a + b)); 
        break;

    case "-": 
        Console.WriteLine("Result : " + (a - b));
        break;

    case "*":
        Console.WriteLine("Result : " + (a * b));
        break;

    case "/":
        Console.WriteLine("Result : " + (a / b));
        break;

    default:
        Console.WriteLine("Incorrect action!");
        break;
}