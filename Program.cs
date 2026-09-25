Console.WriteLine("Enter first number: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Enter action (+,-,*,/) : ");
string action  = Console.ReadLine();

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