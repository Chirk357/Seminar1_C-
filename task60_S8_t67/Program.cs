


int sum = 0;
void SumOfNumbers(int n)
{
    if (n / 10 > 0)
    {
        SumOfNumbers(n / 10);
    }
    sum += n % 10;
}

SumOfNumbers(453);
System.Console.WriteLine(sum);