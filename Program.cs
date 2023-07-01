//? Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//? Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] GetArray()
{
    Console.WriteLine("Please, input your array troughout the comma, eg 1, 3, 5");

    string inputtedString = Console.ReadLine();

    string[] newString = inputtedString.Trim( new Char[] { '\"', '\"', '[', ']' } ).Split(",");
    
    return  newString;
}

void GetNewArray(string[] arr)
{
    string[] newArray = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {   string inf = arr[i].Trim();
        Console.WriteLine($"string {inf}, Lenght - {inf.Length}");
        if (inf.Length < 4) 
        {
            newArray[i] = inf;
        }
    }
    string[] res = newArray.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
    Console.WriteLine($"Новый массив - {string.Join(',', res)}");
}

string[] arr = GetArray();
Console.WriteLine($"Старый массив - {string.Join(',', arr)}");

GetNewArray(arr);