// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int[] array = GetArray(4, 100, 999);
Console.WriteLine(String.Join(", ", array));

  // Метод, который возвращает массив заполненный случайными числами
  // из заданного промежутка

int[] GetArray(int count, int minValue, int maxValue)
{
    int[] array = new int[count];

    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
  // Метод, который возвращает количество чётных чисел в массиве
  
int countEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;
            return count;
}
Console.WriteLine($"Количество четных чисел {countEven(array)}");




