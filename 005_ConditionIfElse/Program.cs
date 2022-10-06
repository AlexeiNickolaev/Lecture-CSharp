Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() = "маша")  // ToLower позволяет не задумыватся какой регистр применяется при записи username
{
    Console.WriteLine("Ура, это же МАША");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}