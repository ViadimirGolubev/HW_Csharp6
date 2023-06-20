// // See https://aka.ms/new-console-template for more information
//  Console.WriteLine("Hello, World!");



// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите числа через запятую: ");

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");


int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество значений больше 0 = {sum}");


int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}


// void PrintArray(int[] array)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.Write("]");
// }














// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// Чтобы найти координаты точки пересечения графиков функций нужно 
// приравнять обе функции друг к другу, перенести в левую часть все члена, 
// содержащие x, а в правую остальные и найти корни, полученного уравнения. 
// Если система уравнений:
// имеет единственное решение, то прямые пересекаются;
// имеет бесконечное множество решений, то прямые совпадают;
// не имеет решений, то прямые не пересекаются (прямые параллельны между собой)

// void IntersectionPoint()
// {
// Console.Write("Введите коэффициент k1 = ");
// double k1 = Convert.ToInt32(Console. ReadLine());
// Console.Write("Введите коэффициент b1 = ");
// double b1 = Convert.ToInt32(Console. ReadLine());
// Console.Write("Введите коэффициент k2 = ");
// double k2 = Convert.ToInt32(Console. ReadLine());
// Console.Write("Введите коэффициент b2 = ");
// double b2 = Convert.ToInt32(Console. ReadLine());

// if(k1!=k2)
// {
// double x = - (b1-b2)/(k1-k2);
// double y = k1*x+b1;
// Console.WriteLine($"Точка пересечения cо следующими координатами = ({x};{y})");
// }
// else if(k1==k2)
// {
// Console.WriteLine ($"Прямые параллельны");
// }
// }
// IntersectionPoint();пш