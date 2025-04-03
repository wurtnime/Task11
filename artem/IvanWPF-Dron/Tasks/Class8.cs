using System.Linq;

namespace Practical11.Tasks
{
    public class Task8 : ITask
    {
        public string Solve(string input)
        {
            double[] array = input.Split(' ').Select(double.Parse).ToArray();
            if (array.Length != 16) throw new ArgumentException("Нужно 16 чисел");

            int maxIndex = Array.IndexOf(array, array.Max());
            int minIndex = Array.IndexOf(array, array.Min());

            return $"Индекс max: {maxIndex}, Индекс min: {minIndex}";
        }
    }
}