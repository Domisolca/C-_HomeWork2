int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadInt("Введите трехзначное число: ");
int min = 100, max = 999;

if(number >= min && number <= max)
{
    int secondDigit = number / 10 % 10;
    Console.WriteLine(secondDigit);
}
else
{
    Console.WriteLine("Число не трехзначное!");
}
