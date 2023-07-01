//? Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//? Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] GetArray()
{
    Console.WriteLine("Please, input your array");

    string inputtedString = Console.ReadLine();
    
    if (inputtedString.Length > 0) return inputtedString.Split(",");
    else return null;
}

string GetNewArray(string[] arr)
{
    var newArray = new string[arr.Length];
    int newArraySize = 0;
    foreach(var str in arr)
    {
        if (str.Length < 4) 
        {
            newArray[newArraySize] = str;
            newArraySize ++;
        }
    }

    return string.Join(',', newArray);
}

string[] arr = GetArray();

Console.WriteLine(string.Join(',', arr));

Console.WriteLine($"Новый массив - {GetNewArray(arr)}");


