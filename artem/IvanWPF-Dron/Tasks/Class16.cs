using System.Linq;

namespace Practical11.Tasks
{
    public class Task16 : ITask
    {
        public string Solve(string input)
        {
            double[] array = input.Split(' ').Select(double.Parse).ToArray();
            if (array.Length != 12) throw new ArgumentException("Нужно 12 чисел");
            int maxIndex = Array.IndexOf(array, array.Max());
            int minIndex = Array.IndexOf(array, array.Min());
            return $"Между ними: {Math.Abs(maxIndex - minIndex) - 1}";
        }
    }
}