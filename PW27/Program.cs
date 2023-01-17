
int summ (int number)
{
    int sum = 0;
    int k = 0;
    while (number > 0)
    {
        k= number % 10;
        sum =sum + k;
        number = number / 10;
    }
    return sum;
}
Console.Write("Введите число = ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Ответ = ");
Console.Write(summ(number));