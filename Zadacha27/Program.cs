void Zadacha27()
{
    //Напишите программу, которая принимает на вход число
    //и выдаёт сумму цифр в числе

    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    int i = 0;

    while (num > 0)
    {
        i = num % 10;
        sum = sum + i;
        num = num / 10;
    }
    Console.WriteLine($"Сумма цифр введенного числа равна {sum}");
}

Zadacha27();