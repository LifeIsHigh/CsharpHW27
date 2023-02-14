// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



int Nums(int Val)
{
    if (Val == 0)
        return 0;
    
    Console.WriteLine(Val);
    Val = Val - 1;
    
    return Nums(Val);
}
Console.Write("Enter Value --> ");
int Val = Convert.ToInt32(Console.ReadLine());
Nums(Val);
