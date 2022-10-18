int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool IsBetween(int number, int min, int max)
{
    return number >= min && number <= max;
}

void PrintWeekend(int day)
{
    int sut = 6, sun = 7;

    if(day == sut || day == sun)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}

int day = ReadInt("Введите цифру: ");
int min = 1, max = 7;

if(IsBetween(day, min, max))
{
     PrintWeekend(day);
}
else
{
    Console.WriteLine("Такого дня не существует!");
}