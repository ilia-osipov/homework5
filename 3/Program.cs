// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
int[] array = GetArray(5, 1, 10);
Console.WriteLine(String.Join(", ", array));


  // Метод, который возвращает массив заполненный случайными числами
  // из заданного промежутк

int[] GetArray(int count, int minValue, int maxValue)
{
    int[] array = new int[count];

    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
  // Метод, который возвращает максимум

int GetMaxNum(int[] array)
{
    int i = 0;
    int max = array[i];
        for (int j = i + 1; j < array.Length; j++)
    {
        if (array[j] > max) max = array[j];
    }
    return max;
}
Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {GetMaxNum(array) - GetMinNum(array)}");

// Метод, который возвращает минимум
int GetMinNum(int[] array)
{
    int i = 0;
    int min = array[i];
    for (int k = i + 1; k < array.Length; k++)
    {
        if (array[k] < min) min = array[k];
    }
    return min;
}

