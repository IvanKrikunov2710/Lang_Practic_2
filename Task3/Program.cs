Console.WriteLine("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 % num2 == 0)
    Console.WriteLine("кратно");
else Console.WriteLine(num1 % num2);