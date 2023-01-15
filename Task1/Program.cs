Random random = new Random();
int number = 0;
number = random.Next(10,100);
Console.WriteLine(number);
// 56 % 10 = 6
// 56 / 10 = 5
int a = number / 10;
int b = number % 10;
if (a > b)
Console.WriteLine("a > b");
else if (b > a)
Console.WriteLine("b > a");
else if (b == a)
Console.WriteLine("b == a");