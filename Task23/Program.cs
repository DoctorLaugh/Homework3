Console.Clear();
Console.WriteLine("Введите натуральное число");
int num = int.Parse(Console.ReadLine());
if (num <= 0)
{
    Console.WriteLine("Ошибка ввода");
    return;
}
int[] result = new int[num];
for(int i=1; i<=num; i++)
result[i-1] = Convert.ToInt32(Math.Pow(i, 3));
for(int i=0; i<num; i++)
Console.Write($"{result[i]} ");