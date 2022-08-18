// Методы

// 1) Метод не принимает и не возвращает
void Method1()
{
    Console.WriteLine("пишу, Метод1");
}
// // Как вызывается метод?
Method1();
Console.WriteLine("_________________________________________");

// 2) Что-то принимают, нчего не возвращают

void Method2 (string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения, Метод 2");
Console.WriteLine("_________________________________________");
// Если есть аргументы именнованные, когда у нас явно мб указано,
// какому аргументу, какое значение мы хотим указать.

void Method21 (string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Текст", count = 4);
// не обязательно по порядку, можно и так:
Method21(count: 4, msg: "Текст новый, Метод 2.1");
Console.WriteLine("_________________________________________");

// 3) Ничего не принимают, что-то возвращают
// Если метод что-то возвращает, мы должны указать тип данных!

int Method3()
{
    return DateTime.Now.Year;
}
int Year = Method3();
Console.WriteLine("Method3: ");
Console.WriteLine(Year);
Console.WriteLine("_________________________________________");

// 4) Что-то принимают, что-то возвращают
string Mehod4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Mehod4(10, "Method4|");
Console.WriteLine(res);
Console.WriteLine("_________________________________________");