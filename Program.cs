//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо 
//задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []



string[] fillArr(string[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
    string symb = Console.ReadLine()!;
            arr[i]  = symb;
    }
    return arr;
}

     Console.WriteLine("Введите количество эелементов массива");
    int start = int.Parse(Console.ReadLine()!);
    string[] arr = new string[start];
    Console.WriteLine("Введите элементы массива");
     fillArr(arr);
   
