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
/*Console.WriteLine(SumTwoNumbers(8,18));
int SumTwoNumbers(int n,int m=12)
{
    return n%2==0&&m%2==0?n+m:-1; //else hali olmadan yazmaq mumkun olmadigi uchun -1
}*/
#endregion
#region task-3
//Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.
/*Console.WriteLine(CounterNum(18,48));
int CounterNum(int n, int m = 12)
{
    int count=0;
    int res = default;
    for (int i = n; i <= m; i++)
    {
        res= i%2 == 1 ? count++:-1;
    }
    return res;
}*/
#endregion
#region task-4
//Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.
/*Console.WriteLine(SumOddNumbers(7, 17));
int SumOddNumbers(int n, int m)
{
    int sum = 0;
    int res = default;
    for (int i = n; i <= m; i++)
    {
        res = i%2!= 0 ? sum += i : -1;
    }
    return res;
}*/
/*int sum = 0;
int n = 7;
int m = 15;
for (int i = n; i <= m; i++)
{
    if (i%2!=0)
    {
        sum += i;
    }
}
Console.WriteLine(sum);*/

#endregion
