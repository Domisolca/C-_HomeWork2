int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool IsBetween(int number, int min, int max)
{
    return number >= min && number <= max;
}

int number = ReadInt("Введите число: ");
int min = 100, max = 999;

if(number >= min)
{
    int currentNumber = number;

    while(IsBetween(currentNumber, min, max) == false)
    {
        currentNumber = currentNumber / 10;
    }

    int lastDigit = currentNumber % 10;
    Console.WriteLine(lastDigit);
}
else
{
    Console.WriteLine("Третьей цифры нет!");
}