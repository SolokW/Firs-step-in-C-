// ЦИКЛ "FOR"

// for(int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }

// string Mehod4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Mehod4(10, "FOR.");
// Console.WriteLine(res); 
// Console.WriteLine("___________________________________________________________");

for (int a = 2; a <= 10; a++)
{
    for (int b = 2; b <= 10; b++)
    {
        Console.WriteLine($"{a} * {b} = {a*b}");
    }
    Console.WriteLine();
}