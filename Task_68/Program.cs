// Задача 68. Напишите программу вычисления функции 
//Аккермана с помочью рекурсии. Даны два неотрицательных числа
bool isParsedM = int.TryParse(Console.ReadLine(), out int n);
bool isParsedN = int.TryParse(Console.ReadLine(), out int m);

if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Error! Enter number!");
}
Console.WriteLine(akkermanF(n,m));
int akkermanF(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return akkermanF(n - 1, 1);
    else
        return akkermanF(n - 1, akkermanF(n, m - 1));
}

