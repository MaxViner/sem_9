Console.WriteLine("Введите число: ");
int count = Convert.ToInt32(Console.ReadLine());
int finish =1;
void Didgit_Lint(int finish, int count)
{
    if (count < finish)
    {
        return;
    }
    else
    {
        Didgit_Lint(finish, count  - 1);
        Console.Write (count + " ");
    }
}
try
{
    Didgit_Lint(finish,count);
}
catch 
{
    Console.WriteLine("oh...something wrong");
}