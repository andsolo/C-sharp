// 4. На вход N, на выход все четные числа от 1 до N

int count = 1;

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

while (count <= num)
{
	if (count % 2 ==0)
	{
		Console.WriteLine(count);
	}
	count ++;
}