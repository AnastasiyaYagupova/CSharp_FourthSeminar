/*
Задача 3: **(Дополнительное, не обязательно)
Назовём число «интересным» если его произведение цифр делится на их сумму. Напишите программу, 
которая заполняет массив на 10 «интересных» случайных целых чисел от 10 до 1000. (каждый эл-т массива – сгенерирован случайно)
[591, 532, 189, 523, 333, 546, 527, 275, 456, 264]
*/

int[] Array = new int[10];
int index = 0;
Random random = new Random();
            while (index < 10)
            {
                int z = random.Next(1,1000);
                int Num = z;
                int Num2 = z;
                int Count = 0;
                while(Num > 0)
                {
                    Num = Num / 10;
                    Count++;
                }

                int [] Array2_0 = new int [Count];

                int i = Count;
                 while(Num2 > 0)
                {
                    Array2_0[i-1] = Num2 % 10; 
                    Num2 = Num2 / 10;  
                     i--;
                }
                int sum = 0;
                int ind = 0;
                while(ind < Count)
                {
                    sum = sum + Array2_0[ind];
                    ind++;
                }

                int product = 1;
                int position = 0;
                while(position < Count)
                {
                    if(Array2_0[position]>0)
                    {
                        product = product * Array2_0[position];
                        position++;
                    }
                    else
                    {
                        position++;
                    }
                }
                if(product % sum == 0)
                {
                    Array[index] = z;
                    index++;
                }
                else
                {
                    continue;
                }
            }

var str = string.Join(" ", Array);
Console.WriteLine($"10 интересных чисел: {str}");


