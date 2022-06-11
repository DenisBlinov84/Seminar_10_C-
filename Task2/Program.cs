// 3. Дано натуральное число N. Выведите все его цифры по одной,
//    в обратном порядке, разделяя их пробелами или новыми строками.


void LetterComb(char[] abc, char[] word, int N = 0)
{
    if (N == word.Length)
    {
        Console.WriteLine($"{new String(word)}"); return;
    }
    for (int i = 0; i < abc.Length; i++)
    {
        word[N] = abc[i];
        LetterComb(abc, word, N + 1);
    }
}
Console.Write("Enter the number N: ");
int N = int.Parse(Console.ReadLine());
char[] abc = { 'а', 'и', 'с', 'в' };
LetterComb(abc, new char[N]);