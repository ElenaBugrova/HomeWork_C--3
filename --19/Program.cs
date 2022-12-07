//Напишите программу, которая принимает на вход пятизначное число и
//проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine());
int n1=n/10000;
int n2=n/1000%10;
int n4=n/10%10;
int n5=n%10;

if (n<10000 || n>99999)
{
    Console.WriteLine("Вы ввели не пятизначное число, попробуйте еще раз");
}
else
{
    if (n1==n5 && n2==n4)
    {
        Console.WriteLine($"{n} -->Да");
    }else
    {
        Console.WriteLine($"{n} -->Нет");
    }
}

