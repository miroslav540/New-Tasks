void findSecondNumber(int start, int finish)
{
    int num = new Random().Next(start, finish);
    Console.WriteLine(num);
    int secondnum = num % 10;
    int thirdnum = num / 100 % 10;
    int justnum = num % 100 / 10;
    if (num > 9999)
    {
        Console.WriteLine(thirdnum);
    }
    else if (num > 999)
    {
        Console.WriteLine(justnum);
    }
    else if (num > 99)
    {
        Console.WriteLine(secondnum);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}

findSecondNumber(10, 99999);
