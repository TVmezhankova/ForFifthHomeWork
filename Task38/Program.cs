// Задать массив вещественных чисел.
// найти разницу между максимальным и минимальным элементом массива.

double[]StartArrayDouble=GetArrayDouble(6,0,999);
Console.WriteLine(String.Join("  ", StartArrayDouble));
Console.WriteLine($"Разница = {GetDif(StartArrayDouble)}");

double GetDif(double[]Array)
{
   double min = Array[0];
   double max = Array[0];
   foreach (var item in Array)
   {
    if(min > item) min=item;
    if(max < item) max= item;
   }
   return max-min;
}

double[]GetArrayDouble(int size, int minV, int maxV)
{
    double[]res = new double[size];
    var rand = new Random();
    for(int i=0; i<size; i++)
    {
        res[i]=rand.Next(minV,maxV+1)+rand.NextDouble();
    }
    return res;
}