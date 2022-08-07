void Zadacha29()
{
//Напишите программу, которая задаёт массив из 8 случайных целых
//чисел и выводит отсортированный по модулю массив.

    int size = 8;
    int[] array = new int[size];

    Random rand = new Random();
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-20, 21);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine( "изначальный массив");

    for (int i = array.Length - 1; i > 0; i--)
    {
        for (int j = 0; j < i; j++)
        {
            if (Math.Abs(array[j]) > Math.Abs(array[j + 1]))
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine( "отсортированный массив по модулю");
}

Zadacha29();