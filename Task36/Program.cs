// Задать одномерный массив, заполненный случайными числами. 
//Найти сумму элементов, стоящих на нечетных позициях.

int[]StartArray=GetArray(10,0,999);
Console.WriteLine(String.Join("   ",StartArray));
Console.WriteLine($"Сумма элементов на нечетных позициях=  {GetSum(StartArray)}  ");

int[]GetArray (int size, int minV, int maxV)
{
    int[]res = new int[size];
    for(int i=0; i<size; i++)
    {
        res[i]=new Random().Next(minV, maxV+1);
    }
    return res;
}

int GetSum(int[]Array)
{
    int sum=0;
    for(int i=0;  i<Array.Length; i++ )
    {
        if(i%2==1) sum+=Array[i];
    }
    return sum;
}