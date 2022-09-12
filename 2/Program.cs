// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] array = GetArray(4, -6, 6);
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
  // Метод, который возвращает сумму элементов на нечетных позициях

int SumOddPlace(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
            sum += array[i];
            return sum;
}
Console.WriteLine($"Сумма элементов на нечетных позициях = {SumOddPlace(array)}");
