int number = 15002900;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();

int numerator0 = 0;
int numerator1 = 0;
int numerator2 = 0;
int numerator3 = 0;
int numerator4 = 0;
int numerator5 = 0;
int numerator6 = 0;
int numerator7 = 0;
int numerator8 = 0;
int numerator9 = 0;

foreach (char letter in letters)
{
    if (letter == '0')
    {
        numerator0++;
    }
    else if (letter == '1')
    {
        numerator1++;
    }
    else if (letter == '2')
    {
        numerator2++;
    }
    else if (letter == '3')
    {
        numerator3++;
    }
    else if (letter == '4')
    {
        numerator4++;
    }
    else if (letter == '5')
    {
        numerator5++;
    }
    else if (letter == '6')
    {
        numerator6++;
    }
    else if (letter == '7')
    {
        numerator7++;
    }
    else if (letter == '8')
    {
        numerator8++;
    }
    else if (letter == '9')
    {
        numerator9++;
    }
}
Console.WriteLine(number);
{
    Console.WriteLine("W podanej liczbie cyfry występują:");
}
{
    if (numerator0 != 0)
        Console.WriteLine("0 w ilości: " + numerator0);
}
{
    if (numerator1 != 0)
        Console.WriteLine("1 w ilości: " + numerator1);
}
{
    if (numerator2 != 0)
        Console.WriteLine("2 w ilości: " + numerator2);
}
{
    if (numerator3 != 0)
        Console.WriteLine("3 w ilości: " + numerator3);
}
{
    if (numerator4 != 0)
        Console.WriteLine("4 w ilości: " + numerator4);
}
{
    if (numerator5 != 0)
        Console.WriteLine("5 w ilości: " + numerator5);
}
{
    if (numerator6 != 0)
        Console.WriteLine("6 w ilości: " + numerator6);
}
{
    if (numerator7 != 0)
        Console.WriteLine("7 w ilości: " + numerator7);
}
{
    if (numerator8 != 0)
        Console.WriteLine("8 w ilości: " + numerator8);
}
{
    if (numerator9 != 0)
        Console.WriteLine("9 w ilości: " + numerator9);
}