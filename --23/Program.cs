//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
//кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.Clear();
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());
int number = 1;
int index=N;
while (index>0)
{
    double d=Math.Pow(number,3);
    index--;
    number++;
    Console.Write($"{d}," );
}


//double d=Math.Pow(N,3);
//Console.Write(d);