// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.Write("Введите число: ");
string? number=Console.ReadLine();
if(number!.Length==5)
{
if(number[0]==number[4] && number[1]==number[3])
{
    System.Console.Write("Это число палиндром!");
}
else
{
    System.Console.Write("Это число НЕ палиндром!");
}
}
else
{
System.Console.Write("Это число не пятизначное!");
}