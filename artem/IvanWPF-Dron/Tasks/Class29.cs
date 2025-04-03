using System.Linq;

namespace Practical11.Tasks
{
    public class Task29 : ITask
    {
        public string Solve(string input)
        {
            double[] array = input.Split(' ').Select(double.Parse).ToArray();
            if (array.Length != 18) throw new ArgumentException("Нужно 18 чисел");
            double product = array.Where(n => n > 0).Aggregate(1.0, (a, b) => a * b);
            double sum = array.Where(n => n < 0).Sum(n => Math.Abs(n));
            return sum == 0 ? "Ошибка: сумма модулей 0" : $"Результат: {product / sum:F2}";
        }
    }
}