Console.Clear();
Console.WriteLine("Введите пятизначное число");
int num = int.Parse(Console.ReadLine());
if (num<10000 || num>99999)
{
    Console.WriteLine("Ошибка ввода");
    return;
}
int num5 = num%10;
int num4 = (num/10)%10;
int num2 = (num/1000)%10;
int num1 = num/10000;
if(num5==num1 && num4==num2)
{
    Console.WriteLine("Число - палиндром");
}
else
{
    Console.WriteLine("Число - не палиндром");
}