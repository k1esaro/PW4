int[] nums = new int[8];
Console.WriteLine("Введите значения массива");
for (int i = 0 ; i < 8; i++)
    {
        nums[i] = Convert.ToInt32(Console.ReadLine());
    }
Console.WriteLine($"[{string.Join(", ", nums)}]");

