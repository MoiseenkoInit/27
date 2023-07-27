//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.Clear();
Console.WriteLine("введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число b");
int b = Convert.ToInt32(Console.ReadLine());
int grade = a;

for (int i = 1; i < b; i++)
{
grade = grade * a;
}
Console.WriteLine("a в степени b равно: " + grade);
