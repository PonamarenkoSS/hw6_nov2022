// Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов 
// (не менее 6) в промежутке от 0 до 100, а на выходе выводит этот же массив, 
// но отсортированный по возрастанию(от меньшего числа к большему).

// int[] GetArray(int size)
// {
//     int[] array = new int[size];
//     for(int i = 0; i<size; i++)
//     {
//         array[i] = new Random().Next(0,101);
//     }
//     return array;
// }

// int[] Sorting(int[] array)
// {
//     for(int i=0; i<array.Length-1; i++)
//     {
//         int min = i;
//         for (int j=i+1; j<array.Length; j++)
//         {
//             if (array[j]<array[min]) { min = j;}
//         }
//         int temporary = array[i];
//         array[i]=array[min];
//         array[min]=temporary;
//     }
//     return array;
// }

// int sizeOfArray = new Random().Next(6,11);
// int[] ARRAY = GetArray(sizeOfArray);
// Console.WriteLine($"Первоначальный массив: [{String.Join(",", ARRAY)}]");
// int[] sortingArray = Sorting(ARRAY);
// Console.WriteLine($"Отсортированный массив: [{String.Join(",", sortingArray)}]");

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел строго больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

// Console.WriteLine("Укажите, какое количество чисел Вы хотите ввести в программу:");
// int number = int.Parse(Console.ReadLine()!);
// int COUNT = InputNumber(number);
// Console.WriteLine($"Количество введённых Вами чисеk больше нуля составляет {COUNT}");

// int InputNumber(int n)
// {
//     int count = 0;
//     for (int i=1; i<=n; i++)
//     {
//         Console.WriteLine($"Введите {i} число");
//         int N = int.Parse(Console.ReadLine()!);
//         if (N>0) {count++;}
//     }
//     return count;
// }


