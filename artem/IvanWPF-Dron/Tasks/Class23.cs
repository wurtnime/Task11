using System.Linq;

namespace Practical11.Tasks
{
    public class Task23 : ITask
    {
        public string Solve(string input)
        {
            int[] array = input.Split(' ').Select(int.Parse).ToArray();
            if (array.Length != 14) throw new ArgumentException("Нужно 14 чисел");
            int sumEven = array.Where((n, i) => i % 2 == 0).Sum();
            int productOdd = array.Where(n => n % 2 != 0).Aggregate(1, (a, b) => a * b);
            return $"Сумма: {sumEven}, Произведение: {productOdd}";
        }
    }
}