while (true)
{
    Console.WriteLine("Print sing or end to exit: ");
    string Sing = Console.ReadLine();
    if (Sing == "end")
    {
        break;
    }
    Console.WriteLine("Print first number: ");
    double number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Print second numder: ");
    double number2 = Convert.ToInt32(Console.ReadLine());
    if (Sing == "+")
    {
        Console.Write("Result: ");
        Console.WriteLine(number1 + number2);
    }
    else if (Sing == "-")
    {
        Console.Write("Result: ");
        Console.WriteLine(number1 - number2);
    }
    else if (Sing == "*")
    {
        Console.Write("Result: ");
        Console.WriteLine(number1 * number2);
    }
    else if (Sing == "/")
    {
        Console.Write("Result: ");
        Console.WriteLine(number1 / number2);
    }
}

