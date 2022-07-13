// Пользователь вводит с клавиатуры М чисел. Посчитать, сколько чисел больше 0 ввел пользователь
int [] CreateNewArray (int N)
{
    int [] massive = new int [N];
    return massive;
}

void FillArray (int [] mas)
{
    for (int j = 0; j < mas.Length; j++)
    {
        Console.Write ("Введите число: ");
        mas [j] = Convert.ToInt32 (Console.ReadLine ());
    }
}

int PositiveNumbers (int [] array1)
{
    int sum = 0;
    for (int k = 0; k < array1.Length; k++)
    {
        if (array1 [k] > 0)
        {
            sum = sum + 1;
        }
    }
    return sum;
}

void ShowArray (int [] array2)
{
    for (int index = 0; index < array2.Length - 1; index++)
    {
        Console.Write (array2 [index] + ",");
    }
    Console.Write (array2 [array2.Length - 1]);
}

Console.WriteLine ("Сколько чисел вы хотите ввести?");
int number = Convert.ToInt32 (Console.ReadLine ());
int [] array = CreateNewArray (number);
FillArray (array);
int result = PositiveNumbers (array);
ShowArray (array);
Console.Write ($" -> {result}");