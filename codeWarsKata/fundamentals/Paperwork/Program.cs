// See https://aka.ms/new-console-template for more information
static int Paperwork(int n, int m)
{
    if (n < 0 || m < 0)
    {
        return 0;
    }
    else
    {
        return n * m;
    }
}

Console.WriteLine(Paperwork(5, 5));