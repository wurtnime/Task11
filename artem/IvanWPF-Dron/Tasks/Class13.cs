using System.Linq;

namespace Practical11.Tasks
{
    public class Task13 : ITask
    {
        public string Solve(string input)
        {
            int[] array = input.Split(' ').Select(int.Parse).ToArray();
            if (array.Length != 15) throw new ArgumentException("Нужно 15 чисел");
            int max = array.Max(), min = array.Min();
            return $"Сумма: {max + min}, Разность: {max - min}";
        }
    }
}