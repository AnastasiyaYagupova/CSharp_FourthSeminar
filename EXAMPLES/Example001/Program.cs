/*
Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
Не использовать функцию Math.Pow
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

/*Console.WriteLine("Введите первое число ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int B = Convert.ToInt32(Console.ReadLine());
*/

int A = new Random().Next(0,10);
Console.WriteLine($"Значение первого числа: {A}");

int B = new Random().Next(0,10);
Console.WriteLine($"Значение второго числа: {B}");

int count = 1;
int resultat = 1;

while(count <= B)
{
    resultat = resultat * A;
    count++;
}

Console.WriteLine(resultat);