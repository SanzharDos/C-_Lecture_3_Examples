// Метод 1
// Ничего не принимают, ничего не возвращают

void Method1() // нет аргументов в скобках
{
    Console.WriteLine("Автор - Санжар Досекенов");
}
// Method1(); // вызов функции

// Метод 2
// Что-то принимают, но ничего не возвращают

void Method2(string msg, int count) // есть аргумент - тип данных string (символы), переменная msg
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method2("Текст", 4); // Выводим какие-то символы, повтор действия - 4 раза
// Method2(msg: "Текст", count: 4); // Указываем значение в определенных аргументах, count и msg можно менять местами
// Method2("Текст сообщения"); // выводим какие-то символы, заполняем в скобках вместо аргумента 

// Метод 3
// Ничего не принимают, что-то возвращают

int Method3()
{
    return DateTime.Now.DayOfYear;
}
int year = Method3();
// Console.WriteLine(year);

// Метод 4
// Что-то принимают, что-то возвращают

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // "";
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

// string res = Method4(10, "Текст ");
// Console.WriteLine(res);

// Цикл for

string Method44(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
        i++;
    }
    return result;
}

// string res = Method44(10, "Текст ");

// Цикл в цикле

// // for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine(); // переход на новую строку (искусственный разрыв)
// }

// ===== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,Ю
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue)
        {
            result = result + $"{newValue}";
        }
        else
        {
            result = result + $"{text[i]}";
        }
    }

    return result;
}

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);
// Console.WriteLine();

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSortMin(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

void SelectionSortMax(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSortMin(arr);
PrintArray(arr);
SelectionSortMax(arr);
PrintArray(arr);