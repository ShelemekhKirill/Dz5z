/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2  */
/*
 int size = ReadInt("Введите размерность массива: ");
int [] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int result = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        result++;
    }
}
if (result % 10 == 1)
{
    Console.WriteLine($"В массиве {result} четное число");
}
if (result % 10 == 2 || result % 10 == 3 || result % 10 == 4)
{
    Console.WriteLine($"В массиве {result} четных числа");
}
else
    Console.WriteLine($"В массиве {result} четных чисел");
//--------------------Методы-------------------------------
void FillArrayRandomNumbers(int [] array) //Заполнение массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(99, 999);
    }
}
void PrintArray(int[] array) //Вывод массива на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int ReadInt(string message)  //Функция ввода
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} */



/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
(индексы элементов должны быть нечетными(1,3,5 и тд)
[3, 7, 23, 12] -> 19   [-4, -6, 89, 6] -> 0 */

/* int size = ReadInt("Введите размерность массива: ");
int min = ReadInt("Введите минимальное число массива: ");
int max = ReadInt("Введите максимальное число массива: ");
int [] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int result = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 != 0)
    {
        result += numbers[i];
    }
}
Console.WriteLine($"Сумма элементов нечетных позиций = {result}");
// ---------------------------Методы---------------------------------------------
void FillArrayRandomNumbers(int [] array) //Заполнение массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}
void PrintArray(int[] array) //Вывод массива на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int ReadInt(string message)  //Функция ввода
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} */



/*  Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3   [6 7 3 6] -> 36 21 */

/* Console.Write("Введите размерность массива:  ");
int size = int.Parse(Console.ReadLine()!);

int[] array = GetArray(size);
Console.WriteLine($"Массив - [{String.Join(", ", array)}]");
Console.WriteLine($"Массив - [{String.Join(", ", PairInArray(array))}]");
//--------------------методы------------------------
int[] PairInArray(int[] array)
{
    int l =array.Length, size = l/2;
    int[]array2;
    if (l % 2 == 0)
        array2 = new int[size];
        else
        {
            array2 = new int[(size +1)];
            array2[size] = array[size];            
        }
        for (int i = 0; i< size; i++, l--)
             array2[i] = array[l-1];
        return array2;     
}
//-----------------методы------------------------

int[] GetArray(int seze, int minVal = 0, int maxVal = 10)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
         array[i] = new Random().Next(minVal, maxVal);
    return array;     
} */



// Задайте массив целых чисел от -10 до 10. Найдите разницу между максимальным и минимальным элементами массива.

/* int size = ReadInt("Введите размерность массива: ");
int min = -10; //ReadInt("Введите минимальное число массива: ");
int max = 10;  //ReadInt("Введите максимальное число массива: ");
int [] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int maxFillarray = numbers[0];
int minFillarray = numbers[0];
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > maxFillarray)
    {
        maxFillarray = numbers[i];
    }
    if (numbers[i] < minFillarray)
    {
        minFillarray = numbers[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным числом = {maxFillarray - minFillarray}");
// ---------------------------------------Методы--------------------------------------
void FillArrayRandomNumbers(int [] array) //Заполнение массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}
void PrintArray(int[] array) //Вывод массива на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int ReadInt(string message)  //Функция ввода
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} */
