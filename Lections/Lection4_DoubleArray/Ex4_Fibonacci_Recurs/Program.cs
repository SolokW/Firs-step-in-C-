// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

int Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 10; i++)
{
    System.Console.WriteLine(Fibonacci(i));
}

System.Console.WriteLine();

double Fibonac(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonac(n-1) + Fibonac(n-2);
}

for (int i = 1; i < 43; i++)
{
    System.Console.WriteLine($"f({i}) = {Fibonac(i)}");
}

System.Console.WriteLine();

// Очень долго считает, не запускать)))))