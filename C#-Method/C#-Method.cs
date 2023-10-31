#region task-1
//Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.
/*Console.WriteLine(DivideNum(25)); 
string DivideNum(int num)
{
    return num % 3 == 0 && num % 7 == 0 ? "Divided" : "Not divided";
}*/
#endregion
#region task-2
//n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.
/*Console.WriteLine(SumTwoNumbers(8, 18));
string SumTwoNumbers(int n, int m = 12)
{
    if (n % 2 == 0 && m % 2 == 0)
        return $"{ n + m}";
    else
    {
        $"Not even numbers";
    }
}*/
#endregion
#region task-3
//Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.
/*Console.WriteLine(CounterNum(18, 23));
string CounterNum(int n, int m = 12)
{
    int count = 0;
    if (n < m)
    {
        for (int i = n; i <= m; i++)
        {
            if(i % 2 == 1) 
               count++;
        }
    }
    return $"{count}";
}*/
#endregion
#region task-4
//Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.
/*Console.WriteLine(SumOddNumbers(7, 17));
int SumOddNumbers(int n, int m)
{
    int sum = 0;
    int res = default;
    if (n < m) {
    for (int i = n; i <= m; i++)
    {
        res = i % 2 != 0 ? sum += i : -1;
    }
    }
    return res;
}*/
#endregion
