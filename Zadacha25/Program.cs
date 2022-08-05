void Zadacha25()
{
    Console.WriteLine("Введите первое число");
    int numA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int numB = Convert.ToInt32(Console.ReadLine());
    int prod = numA * numA;

    if (numB == 1)
    {
        Console.WriteLine($"число {numA} в степени {numB} равно {numA}");
    }
    else if (numB == 2)
    {
        Console.WriteLine($"число {numA} в степени {numB} равно {numA * numA}");
    }
    else
    {
        for (int i = 3; i <= numB; i++)
        {
            prod = prod * numA;
        }
        Console.WriteLine($"число {numA} в степени {numB} равно {prod}");
    }
}

Zadacha25();