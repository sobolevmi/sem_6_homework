// Вывести первые N чисел Фибоначчи
int [] CreateArray (int N)
{
    int [] massive = new int [N];
    massive [0] = 0;
    massive [1] = 1;
    for (int i = 2; i < massive.Length; i++)
    {
        massive [i] = massive [i - 2] + massive [i - 1];
    }
    return massive;
}

void ShowArray (int [] mas)
{
    for (int j = 0; j < mas.Length; j++)
    {
        Console.Write (mas [j] + " ");
    }
}

Console.Write ("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine ());
int [] array = CreateArray (number);
Console.Write ($"{number} -> ");
ShowArray (array);