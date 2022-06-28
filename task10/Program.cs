void findSecondNumber(int start, int finish)
{
    int num = new Random().Next(start, finish);
    Console.WriteLine(num);
    int secondnum = num % 100 /10;
    Console.WriteLine(secondnum);
}

findSecondNumber(100, 999);