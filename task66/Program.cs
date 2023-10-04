int GetNumber(string mess)
{
    Console.WriteLine($"Введите число {mess}:");
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

int Sum (int m, int n, int res=0)
{
   
    if (m>=n)
    {
        res+=m;
        return Sum(m-1, n, res);
    }
    else
    {
        
        return res;
    }   
}

int m=GetNumber("M");
int n=GetNumber("N");
if (m<n)
    {
        int temp=n;
        n=m;
        m=temp;
    }
int res=Sum(m, n);
Console.WriteLine($"Сумма равна {res}.");
