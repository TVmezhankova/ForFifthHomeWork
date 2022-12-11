// Задать массив, заполненный случайными положительными числами.
// Написать программу. которая покажет количество четных чисел в массиве.





int[] startArray = getArray(6, 100, 999);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Количество четных элементов в массиве = {GetEvenCount(startArray)}");

int[] getArray(int  size, int  MinValue, int  MaxValue)
{
    int[] res =new  int[size];

   for (int  i = 0; i < size; i++)
    {
        res[i] = new  Random ().Next(MinValue, MaxValue+1);
    }
    return res ;
}

int GetEvenCount( int[]Array )
{
   int count =0  ;
    foreach (var item in Array)
    {
        if (item % 2 == 0) count++;
    }
    return count ;
}
