namespace IncreasingTripletSubsequence
{
    /*
      Given an integer array nums, return true if there exists a triple of indices (i, j, k)
      such that i < j < k and nums[i] < nums[j] < nums[k]. If no such indices exists, return false.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static bool IncreasingTriplet(int[] nums)
        {
            // Инициализация указателей
            int first = Int32.MaxValue;
            int second = Int32.MaxValue;

            foreach (var num in nums)
            {
                // Если текущий элемент меньше первого, обновляем первое значение
                if (num <= first)
                {
                    first = num;
                }
                // Если текущий элемент больше первого, но
                // меньше второго, обновляем второе значение
                else if (num <= second)
                {
                    second = num;
                }
                // Если текущий элемент больше второго,
                // нашли увеличивающуюся тройку
                else
                {
                    return true;
                }
            }

            // Если дошли до конца массива и не нашли тройку, возвращаем false
            return false;
    }
}
