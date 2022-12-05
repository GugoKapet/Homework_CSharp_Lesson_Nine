// // Задача 66. Напишите программу, которая найдёт сумму натуральных значений в промежутке от M до N

bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Error! Enter number!");
}

int sum = CountSumOfNumbersBetweenMAndN(m,n);
Console.WriteLine(sum);
int CountSumOfNumbersBetweenMAndN(int m,int n)
{
    if (m==n)
    {
        return n;
    }
    int sum = m;
    sum += CountSumOfNumbersBetweenMAndN(m+1,n);
    return sum;
}
