using System.Linq;

namespace Practical11.Tasks
{
    public class Task3 : ITask
    {
        public string Solve(string input)
        {
            int[] array = input.Split(' ').Select(int.Parse).ToArray();
            if (array.Length != 11) throw new ArgumentException("Нужно 11 чисел");

            double average = array.Average();
            int count = array.Count(n => Math.Abs(n) > average);

            return $"Количество элементов: {count}";
        }
    }
}