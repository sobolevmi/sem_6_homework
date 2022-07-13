// Создать копию заданного массива с помощью поэлементного копирования
int [] CreateNewRandomArray (int size, int start, int end)
// метод по генерированию массива случайным образом
{
    int [] massive = new int [size];
    for (int j = 0; j < size; j++)
    {
    massive [j] = new Random().Next (start, end + 1);
    }
    return massive;
}

int [] CreateUserArray (int n)
// метод по созданию пользовательского массива, куда впоследствии пользователь поместит введенные с
// клавиатуры числа
{
    int [] massive1 = new int [n];
    return massive1;
}

void FillUserArray (int [] massive2)
// метод по заполнению пользовательского массива числами, введенными пользователем с клавиатуры
{
    for (int k = 0; k < massive2.Length; k++)
    {
        Console.Write ("Введите элемент массива: ");
        massive2 [k] = Convert.ToInt32 (Console.ReadLine ());
    }
}

int [] CopyArray (int [] massive3)
// метод по копированию элементов массива (как заполненного случайно сгенерированными числами, так и 
// заполненного числами, введенными пользователем с клавиатуры)
{
    int [] massive4 = new int [massive3.Length];
    for (int index = 0; index < massive4.Length; index++)
    {
        massive4 [index] = massive3 [index];
    }
    return massive4;
}

void ShowArray (int [] massive5)
// метод по выводу любого массива на экран
{
    for (int i = 0; i < massive5.Length; i++)
    {
        Console.Write (massive5 [i] + " ");
    }
} 

Console.WriteLine ("Какой массив вы хотите создать? Нажмите 1, если вы хотите заполнить массив случайно сгенерированными числами, или нажмите 2, если хотите заполнить массив своими числами");
string userChoice = Console.ReadLine ();
if (userChoice == "1")
    {
        Console.Write ("Введите размер случайно генерируемого массива: ");
        int length = Convert.ToInt32 (Console.ReadLine ());
        Console.Write ("Введите начальное диапазона чисел, генерируемых в массив: ");
        int startNumber = Convert.ToInt32 (Console.ReadLine ());
        Console.Write ("Введите конечное число диапазона чисел, генерируемых в массив: ");
        int endNumber = Convert.ToInt32 (Console.ReadLine ());
        int [] array = CreateNewRandomArray (length, startNumber, endNumber);
        ShowArray (array);
        int [] arrayCopy = CopyArray (array);
        Console.Write ("-> ");
        ShowArray (arrayCopy);
    }
else if (userChoice == "2")
    {
        Console.Write ("Введите размер вашего массива: ");
        int lengthArray = Convert.ToInt32 (Console.ReadLine ());
        int [] userArray = CreateUserArray (lengthArray);
        FillUserArray (userArray);
        ShowArray (userArray);
        int [] userArrayCopy = CopyArray (userArray);
        Console.Write ("-> ");
        ShowArray (userArrayCopy);
    }
else 
    {
        Console.WriteLine ("Вы ввели неправильное число. Попробуйте еще раз");
    }    