/*
Задача 3: **(Дополнительное, не обязательно)
Назовём число «интересным» если его произведение цифр делится на их сумму. Напишите программу, 
которая заполняет массив на 10 «интересных» случайных целых чисел от 10 до 1000. (каждый эл-т массива – сгенерирован случайно)
[591, 532, 189, 523, 333, 546, 527, 275, 456, 264]
*/

//int range = 1;
//while(range <= 10)

//int N = new Random().Next(10,1000);
//Console.WriteLine(N);

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
        while(Num2 > 0)
        {
            Array[i-1] = Num2 % 10; 
            Num2 = Num2 / 10;  
            i--;
        }

int sum = 0;
int index = 0;
while(index < Count)
{
    sum = sum + Array[index];
    index++;
}

int product = 1;
int position = 0;
while(position < Count)
{
    if(Array[position]>0)
    {
    product = product * Array[position];
    position++;
    }
    else
    {
    position++;
    }
}
int resultat = N;
if(product % sum == 0)
{
    Console.WriteLine(resultat);
}
else
{
    Console.WriteLine("Нет");
}


