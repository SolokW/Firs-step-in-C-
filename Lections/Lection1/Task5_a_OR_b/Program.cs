Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username == "Маша")
{
    Console.WriteLine("Ура, это же Маша!");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}

// Есть проблема, связанная с тем, что "Маша", можно написать иначе и код работать не будет.
// Чтобы это пофиксить, можно написать оператор "ToLower" в строке "if" после "username"
// Не забыть поставить "." Между ними!!!
