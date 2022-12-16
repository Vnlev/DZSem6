// Задача 2: Напишите программу, которая найдёт 
// точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double ReadDouble() 
{
    double x;
    string input = Console.ReadLine();
    x = Convert.ToDouble(input);
    return x;                                //возвращает(передает) значение
}

double k1, b1, k2, b2;
b1 = ReadDouble(); 
k1 = ReadDouble(); 
b2 = ReadDouble(); 
k2 = ReadDouble(); 

double x = (b2 - b1)/(k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($" x = {x}");
Console.WriteLine($" y = {y}");


