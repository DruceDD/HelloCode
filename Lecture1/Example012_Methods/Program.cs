// Вид1
// void Method1()
// {
//     Console.WriteLine("Автор Druce");
// }
// Method1();

// Вид2
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения");

//
// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i <count)
//     {
//     Console.WriteLine(msg);
//     i++;
//     }
// }
// Method21(msg: "Текст", count: 4);

// Вид3
// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

// Вид4
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "qwerty");
// Console.WriteLine(res);

//

// string Method41(int count, string text)
// {
//     string result = String.Empty;
//     for( int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res1 = Method41(10, "qwerty");
// Console.WriteLine(res1);


// for (int i = 2; i <= 10; i++)
// {
//     for(int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }

//Замена символов в тексте

// string text = "- Я думаю, - сказал княз, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нешего милого Винцегероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int lenght = text.Length;
//     for (int i = 0; i < lenght; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSortFromMinToMax(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPos = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPos]) minPos = j;
        }
        int temp = array[i];
        array[i] = array[minPos];
        array[minPos] = temp;
    }
}

void SelectionSortFromMaxToMin(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPos = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPos]) maxPos = j;
        }
        int temp = array[i];
        array[i] = array[maxPos];
        array[maxPos] = temp;
    }
}

PrintArray(arr);
SelectionSortFromMinToMax(arr);
PrintArray(arr);
SelectionSortFromMaxToMin(arr);
PrintArray(arr);