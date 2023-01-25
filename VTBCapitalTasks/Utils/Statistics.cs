namespace VTBCapitalTasks.Utils;

public static class Statistics
{
    /// <summary>
    /// Method get array of numbers and count a standard deviation of them
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static double StandardDeviation(double[] numbers)
    {
        if (numbers.Length == 0) throw new ArgumentException("Array must contain one or more elements.");
        var average = numbers.Average();
        var variance = numbers.Sum(el => Math.Pow(el - average, 2)) / numbers.Length;
        return Math.Sqrt(variance);
    }
}