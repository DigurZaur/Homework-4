// Задача 3: Напишите программу, которая перевернёт одномерный 
// массив (первый элемент станет последним, второй – предпоследним и т.д.)

System.Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] CreateArray()                             // Функция создает, заполняет массиви и вовзвращает его
{
    int[] new_array = new int[size];
    System.Console.Write("Ваш массив: ");
    for (int i = 0; i < new_array.Length; i++)
    {
        new_array[i] = new Random().Next(1,1000);
        System.Console.Write($"{new_array[i]} ");
    }
    return new_array;
}

int[] CreateAroundArray(int[] last_array)           // Функция создает зеркальный массив и возвращает его
{
    int[] around_array = new int[last_array.Length];
    int last_ind = last_array.Length - 1;
    System.Console.Write("Обратный массив: ");
    for (int i = 0; i < size; i++)
    {
        around_array[i] = last_array[last_ind];
        last_ind = last_ind - 1;
        System.Console.Write($"{around_array[i]} ");
    }
    return around_array;
}

int[] array = CreateArray();
System.Console.WriteLine();
int[] array_2 = CreateAroundArray(array);

