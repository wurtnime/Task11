using System.Linq;

namespace Practical11.Tasks
{
    public class Task26 : ITask
    {
        public string Solve(string input)
        {
            double[] array = input.Split(' ').Select(double.Parse).ToArray();
            if (array.Length != 15) throw new ArgumentException("Нужно 15 чисел");
            double productPos = array.Where(n => n > 0).Aggregate(1.0, (a, b) => a * b);
            double productNeg = array.Where(n => n < 0).Select(Math.Abs).Aggregate(1.0, (a, b) => a * b);
            return $"Разность: {productPos - productNeg}";
        }
    }
}