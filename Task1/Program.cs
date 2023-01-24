// Составить алгоритм: если введенное число больше 7, то вывести “Привет”

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if( num > 7)
{
    Console.WriteLine("Привет");
}
else if ( num == 7)
{
    Console.Write("Уже близко");
}
else
{
    Console.Write("Попытайся снова");
}
