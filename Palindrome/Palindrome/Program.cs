int n,rem,s=0,t;
Console.WriteLine("Enter a number");
n= Convert.ToInt32(Console.ReadLine());
t = n;
while (n > 0)
{
    rem = (n % 10);
    s = (s * 10) + rem;
    n = n / 10;
}

if (s == t)
{
    Console.Write("Palindrome");
}
else
{
    Console.WriteLine("Not a palindrome");
}
   
