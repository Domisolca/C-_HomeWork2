int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool IsBetween(int number, int min, int max)
{
    return number >= min && number <= max;
}


int number = ReadInt("Введите трехзначное число: ");
int min = 100, max = 999;

if(IsBetween(number, min, max))
{
    int secondDigit = number / 10 % 10;
    Console.WriteLine(secondDigit);
}
else
{
    Console.WriteLine("Число не трехзначное!");
}
