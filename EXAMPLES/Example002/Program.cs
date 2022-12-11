/*
Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());

int Num = N;
int Count = 0;
    while(Num > 0)
    {
    Num = Num / 10;
    Count++;
    }

int [] Array = new int [Count];

    int i = Count;
        while(N > 0)
        {
            Array[i-1] = N % 10; 
            N = N / 10;  
            i--;
        }

int resultat = 0;
int index = 0;
while(index < Count)
{
    resultat = resultat + Array[index];
    index++;
}

Console.WriteLine(resultat);