using System.Linq;

namespace Practical11.Tasks
{
    public class Task6 : ITask
    {
        public string Solve(string input)
        {
            int[] array = input.Split(' ').Select(int.Parse).ToArray();
            if (array.Length != 20) throw new ArgumentException("Нужно 20 чисел");

            int evenCount = array.Count(n => n % 2 == 0);
            int oddCount = array.Length - evenCount;

            return evenCount > oddCount
                ? "Четных больше"
                : "Нечетных больше";
        }
    }
}