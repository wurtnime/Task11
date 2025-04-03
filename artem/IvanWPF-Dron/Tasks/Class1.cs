using System.Linq;

namespace Practical11.Tasks
{
    public class Task1 : ITask
    {
        public string Solve(string input)
        {
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
            if (numbers.Length != 14) throw new ArgumentException("Нужно 14 чисел");

            int evenCount = numbers.Count(n => n % 2 == 0);
            return $"Количество четных элементов: {evenCount}";
        }
    }
}