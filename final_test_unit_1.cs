﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


Console.WriteLine("Введите элементы массива через пробел:");
string input = Console.ReadLine();
string[] inputArray = input.Split(' ');
int index = 0;
int len = 0;
for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length <= 3)
        {
            len++;
        }
}
string[] resultArray = new string[len];
for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                resultArray[index] = inputArray[i];
                index++;
            }
        }
System.Console.WriteLine("Результат");
System.Console.WriteLine(string.Join(", ", resultArray));