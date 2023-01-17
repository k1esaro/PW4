Console.Write("Введите число A = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B = ");
int b = Convert.ToInt32(Console.ReadLine());
int result = a;
if (b>0)
{
    for (int i = 1 ; i < b;i++ )
    {
        result = result * a; 
    }
    Console.Write("Отвеn : ");
    Console.WriteLine(result); 
}
else
{
   Console.WriteLine("Ошибка"); 
}
