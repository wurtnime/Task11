using System.Linq;

namespace Practical11.Tasks
{
    public class Task28 : ITask
    {
        public string Solve(string input)
        {
            int[] array = input.Split(' ').Select(int.Parse).ToArray();
            if (array.Length != 17) throw new ArgumentException("Нужно 17 чисел");
            double avg = array.Where(n => n > 0).Average();
            var filtered = array.Where(n => Math.Abs(n) > avg).ToList();
            return $"Сумма: {filtered.Sum()}, Количество: {filtered.Count}";
        }
    }
}