int n, i;
Console.WriteLine("Enter a number");
n = Convert.ToInt32(Console.ReadLine());
for(i = 0; i <= 20;i++)
{
    Console.Write("{0} X {1} = {2}\n", n, i, n * i);
}

