using System.Linq;

namespace Practical11.Tasks
{
    public class Task24 : ITask
    {
        public string Solve(string input)
        {
            double[] array = input.Split(' ').Select(double.Parse).ToArray();
            if (array.Length != 12) throw new ArgumentException("Нужно 12 чисел");
            double last = array[^1];
            var filtered = array.Where(n => n < last).ToList();
            return $"Количество: {filtered.Count}, Сумма: {filtered.Sum()}";
        }
    }
}