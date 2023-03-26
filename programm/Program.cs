// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// Определим первоначальные массивы
string[] arr1 = { "Hello", "2", "world", ":-)" };
string[] arr2 = { "1234", "1567", "-2", "computer science" };
string[] arr3 = { "Russia", "Denmark", "Kazan" };

//Метод, который  находит строки в массиве длиной не больше 3 символов и возвращает новый массив из строк
string[] ArreayShortWords(string[] array)
{
    int length = array.Length;
    string[] result = new string[length];
    int count = 0;
    int maxWordLength = 3;
    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= maxWordLength)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);// изменяем размер искомого массива до размера равного count 

    return result;
}


//Печать одномерного массива 
void PrintArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("Искомый массив пустой, в исходном массиве все слова длинной более трех символов");
    }
    else
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.WriteLine($"[{array[i]}]\t");
        }

}
//Метод для печати искомого массива, который возвращает метод ArreayShortWords
void PrintTask(string[] array)
{
	Console.WriteLine("Исходный массив:");
	PrintArray(array);
    Console.WriteLine();
	string[] shortArray = ArreayShortWords(array);
	Console.WriteLine($"Массив из слов длинной не более трех символов :");
	PrintArray(shortArray);
	Console.WriteLine();
}
PrintTask(arr1);// вызов метода PrintTask
PrintTask(arr2);// вызов метода PrintTask
PrintTask(arr3);// вызов метода PrintTask