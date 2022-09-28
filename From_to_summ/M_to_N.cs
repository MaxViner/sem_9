Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int sum_from_to(int M, int N)
{
    int res = M;
    if (M == N)
        return 0;
    else
    {
        return N+sum_from_to(M,N-1);
    }
}
Console.WriteLine(sum_from_to(M,N));