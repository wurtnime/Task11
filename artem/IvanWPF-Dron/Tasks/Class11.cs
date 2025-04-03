using System.Linq;

namespace Practical11.Tasks
{
    public class Task11 : ITask
    {
        public string Solve(string input)
        {
            int[] array = input.Split(' ').Select(int.Parse).ToArray();
            if (array.Length != 14) throw new ArgumentException("Нужно 14 чисел");
            var filtered = array.Where(n => n > 0 && n % 2 == 0).ToList();
            return $"Количество: {filtered.Count}, Сумма: {filtered.Sum()}";
        }
    }
}