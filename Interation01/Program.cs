﻿Console.WriteLine("Введите первое число" ); // Прога на вход принимает два числа и проверяет, является ли первое число квадратом второго.
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Первое число = " + a );
Console.WriteLine("Введите второе число" );
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Второе число = " + b );

if( b*b == a )
{

Console.WriteLine( "Первое число является квадратом второго числа" );

}
else
{
Console.WriteLine( "Первое число не является квадратом второго числа" );
}