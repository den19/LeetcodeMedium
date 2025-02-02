namespace MaxNumberOfK_SumPairs
{
    /*
    Задача "Max Number of K-Sum Pairs" на LeetCode требует найти количество пар элементов в массиве,
    сумма которых равна целевому значению k 

    Временная сложность: O(N*log N)
    Вспомогательное пространство: O(1)

    Эффективный подход: Чтобы оптимизировать вышеуказанный подход, идея заключается в использовании хеширования.
    Выполните следующие шаги, чтобы решить проблему:

    Инициализируйте переменную, скажем, ans, для хранения максимального количества пар с суммой K.
    Инициализируйте хеш-таблицу, скажем, S, для хранения частоты элементов в arr[].
    Пройдитесь по массиву arr[], используя переменную, скажем i , и выполните следующие шаги:
    Если частота (K – arr[i]) положительная, то увеличьте ans на 1 и уменьшите частоту (K – arr[i]) на 1 .
    В противном случае вставьте arr[i] с частотой 1 в хэш-таблицу.
    После выполнения вышеуказанных шагов выведите значение ans в качестве результата. */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            int K = 5;

            Console.WriteLine(Solution.MaxPairs(arr, K));
        }
    }

    public static class Solution
    {
        public static int MaxPairs(int[] nums, int k)
        {
            // Sort array in increasing order
            Array.Sort(nums);

            // Stores the final result
            int result = 0;

            // Initialize the left and right pointers
            int start = 0, end = nums.Length - 1;

            // Traverse array until start < end
            while (start < end)
            {

                if (nums[start] + nums[end] > k)
                {
                    // Decrement right by 1
                    end--;
                }

                else if (nums[start] + nums[end] < k)
                {
                    // Increment left by 1
                    start++;
                }
                // Increment result and left
                // pointer by 1 and decrement
                // right pointer by 1
                else
                {
                    start++;
                    end--;
                    result++;
                }
            }
            return result;
        }
    }
}
