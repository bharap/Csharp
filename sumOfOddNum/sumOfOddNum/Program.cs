int n, i, sum = 0;
n = Convert.ToInt32(Console.ReadLine());
for (i = 1;i<n;i++)
{
    if (i % 2 == 1)
    {
        Console.WriteLine(i);
        sum = sum + i;
    }
}
Console.WriteLine(sum);
