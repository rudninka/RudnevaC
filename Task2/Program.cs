//Составить алгоритм: если введенное имя совпадает с Вячеслав, то вывести “Привет, Вячеслав”, если нет, то вывести "Нет такого имени"

Console.Write ("Введите имя: ");
string username = Console.ReadLine();
if (username == "Вячеслав")
Console.WriteLine ("Привет, " + username);
else
Console.WriteLine ("Нет такого имени");