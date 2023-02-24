// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.Write("Введите целое число или текст: ");
string number = Console.ReadLine()?? String.Empty;;
int length = number.Length;
// string txtToCheck = number.Replace(""," "); // для проверки текста на палиндром
bool IsPalindrome()
{
    for (int i = 0; i < length / 2; i ++)
    while(number[i] == number[length - 1])

{
    return true;
}
return false;
}

if (IsPalindrome()) System.Console.WriteLine($"Введенный текст/число - {number} - является палиндромом");
else System.Console.WriteLine($"Число {number} не является палиндромом");
System.Console.WriteLine();