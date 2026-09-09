Console.WriteLine("Введите первое число"); double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число"); double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите действие (+,-,*,/)"); string operation = Console.ReadLine();
if (operation == "+")
{
    Console.WriteLine(num1 + num2);
}
else if (operation == "-")
{
    Console.WriteLine(num1 - num2);
}
else if (operation == "*")
{
    Console.WriteLine(num1 * num2);
}

else if (operation == "/")
{
    Console.WriteLine(num1 / num2);
}
else
{
    Console.WriteLine("Ошибочка");
} 

