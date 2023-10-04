int GetNumber(string mess)
{
    Console.WriteLine($"Введите число {mess}:");
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

int Akk (int m, int n, int res=0)
{
    
    if (m==0)
    {
        res=n+1;
    }
    else if (n==0)
    {
        res=Akk(m-1,1, res);
    }
    else
    {
        res=Akk(m-1,Akk(m,n-1, res), res);
    }
    return res;
}

int m=GetNumber("M");
int n=GetNumber("N");
Console.WriteLine($"{Akk(m,n)}");