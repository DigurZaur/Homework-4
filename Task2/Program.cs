// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

System.Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());

int[] CreateArray()                             // Функция создания и заполнения массива 3-хзначными числами
{
    int[] new_array = new int[size];
    for (int i = 0; i < new_array.Length; i++)
    {
        new_array[i] = new Random().Next(100,1000);
        System.Console.Write($"{new_array[i]} ");
    }
    return new_array;
}

int Even_Nums(int[] array)                                 // Функция подсчета четных числе в массиве 
{
    int Even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            Even++;
        }
    }
    return Even;
}


int[] array = CreateArray();
System.Console.WriteLine();
System.Console.WriteLine($"Количество четных чисел в массиве = {Even_Nums(array)}");



