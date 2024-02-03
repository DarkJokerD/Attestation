//Задача 1: Задайте значения M и N. Напишите
//программу, которая выведет все натуральные числа
//в промежутке от M до N. Использовать рекурсию, не
//использовать циклы.

//string rec(int n)
//{
//    if (m > n)
//        return "";
//    return rec(n - 1) + $" {n}";
//}

//Console.Clear();
//Console.Write("Введите начальное число: ");
//int m = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите конечное число: ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(rec(n));

//Задача 3
//void Print (int array [], i = 0) 
//{
//    if (i < array.Length ) 
//    {
//        Console.WriteLine(array[i]);
//        Print(array, i + 1);
//    }
//}
//int [] array ={random,random,random};
//Print(array);

//Задача 2
Console.Clear();
int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  if (m > 0 && n == 0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}

int m = Prompt("Введите число M: ");
int n = Prompt("Введите число N: ");

Console.WriteLine($"A({m},{n}) = {Akkerman(m, n)}");