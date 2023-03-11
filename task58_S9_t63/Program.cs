// 63

void NaturalValue(uint n)
{
    if (n > 1)
    {
        NaturalValue(n - 1);
    }
    Console.Write(n + " ");
}
NaturalValue(9);
System.Console.WriteLine();
NaturalValue(11);





