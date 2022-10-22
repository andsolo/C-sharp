// 2. На вход три числа, на выход максимальное из них 
int a, b, c, max;

Console.WriteLine("Введите три числа: ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());

max = a;
if (b > max)max = b;
if (c > max) max = c;

Console.WriteLine("Максимальное число: "+ max);