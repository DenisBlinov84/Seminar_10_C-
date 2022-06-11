// 1. Напишите программу, которая на вход принимает два числа и выдаёт
//    первые N чисел, для которых каждое следующее равно сумме двух предыдущих.


int AllEvenNumers(int num_1, int num_2, int n)
{
    if (n == 1) return num_1;
    Console.Write($"{num_1} ");
    return AllEvenNumers(num_2, num_1 + num_2, n - 1);
}

Console.WriteLine(AllEvenNumers(3, 4, 5));
Console.WriteLine(AllEvenNumers(6, 10, 4));