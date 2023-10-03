
System.Console.Write("Введите количество строк в массиве: ");
int n = int.Parse(Console.ReadLine()!);

string[] originalArray = new string[n];

for (int i = 0; i < n; i++)
{
    System.Console.Write($"Введите строку {i + 1}: ");
    originalArray[i] = Console.ReadLine()!;
}

System.Console.WriteLine("Исходный массив строк:");
PrintArray(originalArray);
System.Console.WriteLine("Для продолжения нажмите Enter:");
System.Console.ReadLine();

string[] newArray = FilterArray(originalArray);

if (newArray.Length == 0)
{
    Console.WriteLine("Нет строк, удовлетворяющих условию.");
}
else
{
    Console.WriteLine("Новый массив из строк, длина которых меньше или равна 3 символам:");
    PrintArray(newArray);
}

string[] FilterArray(string[] originalArray)
{
    int count = 0;

    for (int i = 0; i < originalArray.Length; i++)
    {
        if (IsShortString(originalArray[i]))
        {
            count++;
        }
    }

    string[] newArray = new string[count];
    int newIndex = 0;

    for (int i = 0; i < originalArray.Length; i++)
    {
        if (IsShortString(originalArray[i]))
        {
            newArray[newIndex] = originalArray[i];
            newIndex++;
        }
    }

    return newArray;
}

bool IsShortString(string str)
{
    return str.Length <= 3;
}

void PrintArray(string[] array)
{
    foreach (string str in array)
    {
        Console.Write($"{str} ");

    }
    System.Console.WriteLine();
}

