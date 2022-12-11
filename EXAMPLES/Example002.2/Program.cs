/*
Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе, 
которые являеются делителями этого числа
452 -> 6
82 -> 2
9012 -> 3
*/

Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());

int Num = N;
int Num2 = N;
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

int index = 0;
int resultat = 0;
while(index < Count)
{
    if(Array[index]>0 && Num2 % Array[index]==0)
    {
        resultat = resultat + Array[index];
        index++;
    }
    else
    {
        index++;
    }
}

Console.WriteLine(resultat);