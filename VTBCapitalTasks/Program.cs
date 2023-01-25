using System.Text.RegularExpressions;
using VTBCapitalTasks.Extensions;
using VTBCapitalTasks.Models.Enums;
using VTBCapitalTasks.Utils;

namespace VTBCapitalTasks
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            FirstTask();
            ThirdTask();
            FourthTask();
        }

        /// <summary>
        /// 1.	There is an array of integer. Size of the array can vary from 0 to N where N is definitely less than int.MaxValue.
        /// Please write code that sorts a given array from max value to min. What is the complexity of the algorithm?
        /// ANSWER: Complexity O(nlog(n))
        /// </summary>
        public static void FirstTask()
        {
            var unsorted = new int[] { 0, 7, 99, -4, 6 };
            var sortred = unsorted.QuickSort();
            Console.WriteLine(string.Join(", ", sortred.Select(el=> el.ToString())));
        }

        /// <summary>
        /// 3.	Please write code that calculates standard deviation for a given list of values.
        /// </summary>
        public static void ThirdTask()
        {
            var data = new double[] { 2, 4, 4, 4, 5, 5, 7, 9 };
            var standardDeviation = Statistics.StandardDeviation(data);
            Console.WriteLine("Standart deviation is: {0}", standardDeviation);
        }

        /// <summary>
        /// 4.	There is a text that contains N symbols, N is definitely less than 2^16.
        /// Please write code that returns count of symbols “A” in the text where symbol “B” is 3 positions before “A” and symbol “C” is right next after “A”. 
        /// </summary>
        public static void FourthTask()
        {
            // expected 3 times 
            var input = "BjkdACfdsB123ACBBBBBAC";
            var regexp = new Regex(@"B[\w]{3}AC");
            var output = regexp.Matches(input).Count;
            Console.WriteLine("{0} contains the pattern {1} times.", input, output);
        }
    }
}