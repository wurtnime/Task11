using System.Linq;

namespace Practical11.Tasks
{
    public class Task27 : ITask
    {
        public string Solve(string input)
        {
            int[] array = input.Split(' ').Select(int.Parse).ToArray();
            if (array.Length != 19) throw new ArgumentException("Нужно 19 чисел");
            int max = array.Max();
            for (int i = 0; i < array.Length; i++)
                if (array[i] % 2 == 0) array[i] = max;
            return $"Новый массив: {string.Join(" ", array)}";
        }
    }
}