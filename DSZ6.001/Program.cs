// Задача 1: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] ReadArray(int n) 
{
    int[] array = new int[n];
    for (int i = 0; i < n; ++i) 
   
    {
        int x;
        string input = Console.ReadLine(); 
        x = Convert.ToInt32(input);
        array[i] = x;
    }   
    return array;
}
int Prompt(string messege)
{
    System.Console.WriteLine(messege);
    return Convert.ToInt32(Console.ReadLine());
}

int CountPositiveNumbers(int[] array)
{
    int cnt = 0; // cnt - количество положительных элементов
    for (int i = 0; i < array.Length; i++) // (создали перем., условие, как изменить значение и)
    {
        // i - позиция в массиве
        // i = 0, 1, 2, 3, ..., array.Length
        if (array[i] > 0) 
        {
            ++cnt;
        }
    }
    return cnt;
    //          0  1 2   3
    // array = {1, 2 32, 0}

}
int m = Prompt("Введите размер массива");
int[] array = ReadArray(m);

int result = CountPositiveNumbers(array);
Console.WriteLine(result);
