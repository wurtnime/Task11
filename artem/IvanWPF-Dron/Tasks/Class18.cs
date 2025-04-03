using System.Linq;

namespace Practical11.Tasks
{
    public class Task18 : ITask
    {
        public string Solve(string input)
        {
            double[] array = input.Split(' ').Select(double.Parse).ToArray();
            if (array.Length != 12) throw new ArgumentException("Нужно 12 чисел");
            return $"Интервал: [{array.Min()}, {array.Max()}]";
        }
    }
}