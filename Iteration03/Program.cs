/* 
Выполнил Кошелев Андрей/ Группа GU | Разработчик | 2789 |
Напишите программу, которая на вход принимает два числа и выдаёт максимальное из этих чисел.
*/

 int a, b;
        Console.Write("Введите первое число: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        b = int.Parse(Console.ReadLine());
 
        if (a > b)
        {
            Console.WriteLine("Максимальное число " + a);
        }
        else
        {
            Console.WriteLine("Максимальное число " + b);
        }     