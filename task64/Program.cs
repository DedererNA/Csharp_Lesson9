int GetNumber()
{
    Console.WriteLine("Введите число:");
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

int Seq (int num)
{
    
    if (num!=1)
    {
        Console.Write($"{num}, ");
        return Seq(num-1);
    }
    else
    {
        Console.Write($"{num}.");
        return num;
    }   
}

int n = GetNumber();
Seq(n);