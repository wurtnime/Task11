using System.Linq;

namespace Practical11.Tasks
{
    public class Task17 : ITask
    {
        public string Solve(string input)
        {
            int[] array = input.Split(' ').Select(int.Parse).ToArray();
            if (array.Length != 15) throw new ArgumentException("Нужно 15 чисел");
            return $"Отрицательных: {array.Count(n => n < 0)}, Произведение: {array.Where(n => n > 0).Aggregate(1, (a, b) => a * b)}, Нулей: {array.Count(n => n == 0)}";
        }
    }
}