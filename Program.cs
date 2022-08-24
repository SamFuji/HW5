// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
Console.Clear();

int[] CreateRandomArray(int N, int start, int end)
{
int[] array = new int[N];
for (int i = 0; i < N; i++)
{
array[i] = new Random().Next(start, end + 1);
}
return array;
}

void ShowArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}



Console.WriteLine("Введите количество элементов в массиве");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of start filling array by random numbers");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of end filling array by random numbers");
int max = Convert.ToInt32(Console.ReadLine());

int[] array2 = CreateRandomArray(num, min, max);
// Console.WriteLine(array);
ShowArray(array2);
// Console.WriteLine("-------");
// int[] myArray = CreateArray();
// ShowArray(myArray);
