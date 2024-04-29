// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


// функция вычисляет, сколько строк массива удовлетворяет требованиям задания и возвращает количество этих строк
int numberRequiredString(string[] inputArrayString) 
{
    int count = 0;
    foreach (string str in inputArrayString)
    {
        if (str.Length <= 3)
        {
            count++;
        }
    }
    return count;
}


// Функция формирует из имеющегося массива строк новый массив из строк, длина которых меньше, либо равна 3 символам.
string[] resultArrayString(string[] inputArrayString, int count)
{
    string[] result = new string[count];
    count = 0;
    foreach (string str in inputArrayString)
    {
        if (str.Length <= 3)
        {
            result[count] = str;
            count++;
        }
    }
    return result;
}