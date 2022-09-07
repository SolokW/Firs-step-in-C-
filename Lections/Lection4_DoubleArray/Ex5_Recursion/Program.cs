// Метод, принимающий число, факториал которого нужно вычислить


int Factorial (int n)
{
    // 1! = 1
    // 0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n - 1); // Не забываем возвращать!! RETURN
}

System.Console.WriteLine(Factorial(3)); // 1*2*3 = 6

System.Console.WriteLine("______________");

int Factorial1 (int m)
{
    // 1! = 1
    // 0! = 1
    if(m == 1) return 1;
    else return m * Factorial1(m - 1); // Не забываем возвращать!! RETURN
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial1(i)}");
}
// Случилось переполнение данных

System.Console.WriteLine("______________");


double Factorial2 (int o)
{
    // 1! = 1
    // 0! = 1
    if(o == 1) return 1;
    else return o * Factorial2(o - 1); // Не забываем возвращать!! RETURN
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial2(i)}");
}