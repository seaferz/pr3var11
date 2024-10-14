//Вывести заданные числа a, b, c в порядке убывания их значений.
Console.Write("Введи a = ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введи b = ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введи c = ");
double c = Convert.ToDouble(Console.ReadLine());

//проверка условия
if (a < b && a < c && b < c)
{
    Console.WriteLine("{0}, {1}, {2}", c, b, a);
}
else if (a > b && a > c && c > b)
{
    Console.WriteLine("{0}, {1}, {2}", a, c, b);
}
else if (a > b && a > c && b > c)
{
    Console.WriteLine("{0}, {1}, {2}", a, b, c);
}
else if (c > a && c > b && a > b)
{
    Console.WriteLine("{0}, {1}, {2}", c, a, b);
}
else if (b > a && b > c && a > c)
{
    Console.WriteLine("{0}, {1}, {2}", b, a, c);
}
else
{
    Console.WriteLine("{0}, {1}, {2}", b, c, a);
}