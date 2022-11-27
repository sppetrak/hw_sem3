Console.WriteLine("Введите пятизначное число: ");
string num = Console.ReadLine()!;

if(num.Length == 5)
{
    if(num[0] == num[4] && num[1] == num[3])
    {
        Console.Write("Введенное число является полиндромом! ");
    }
    else 
    {
        Console.Write("Введенное число не является полиндромом! ");
    }
}
    else
    {
        Console.Write("Введено неверное число! ");
    }


