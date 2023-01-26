// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



Console.WriteLine("Введите первое натуральное число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число");
int b = Convert.ToInt32(Console.ReadLine());

if (a<1 || b<1) Console.WriteLine("Введены некорректные данные");
double result = Math.Pow(a,b);
int count = 1;
while (count<=b) 
{
    Console.WriteLine($"Ответ: {result}");
    break;
}
