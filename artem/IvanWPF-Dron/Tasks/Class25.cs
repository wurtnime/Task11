using System.Linq;

namespace Practical11.Tasks
{
    public class Task25 : ITask
    {
        public string Solve(string input)
        {
            int[] array = input.Split(' ').Select(int.Parse).ToArray();
            if (array.Length != 15) throw new ArgumentException("Нужно 15 чисел");
            int sum = array.Where(n => n > 0).Sum();
            return $"Новый массив: {string.Join(" ", array.Select(n => n - sum))}";
        }
    }
}