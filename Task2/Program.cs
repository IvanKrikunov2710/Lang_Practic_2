// Программа выбирает рандомное трехзначное число,
// в ответ выводит двузначное число, состоящее из первой и 
// последней цифры этого числа

Random random = new Random();
int number = 0;
number = random.Next(99,1000);
Console.WriteLine(number);
int a = number / 100;
int b = number % 10;
Console.Write(a);
Console.Write(b);