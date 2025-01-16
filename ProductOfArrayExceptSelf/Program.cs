namespace ProductOfArrayExceptSelf
{
    /*
    Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
    The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
    You must write an algorithm that runs in O(n) time and without using the division operation. 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            Console.WriteLine("Input array is:");
            Array.ForEach(nums, (x) => Console.WriteLine(x));
            var result = ProductExceptSelf(nums);
            Console.WriteLine("Result is");
            Array.ForEach(result, (x) => Console.WriteLine(x));// Output: 24, 12, 8, 6
            Console.ReadLine();
        }

        public static int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] leftProducts = new int[n];
            int[] rightProducts = new int[n];
            int[] result = new int[n];

            // Заполнение массива префиксных произведений
            leftProducts[0] = 1;
            for (int i = 1; i < n; i++)
            {
                leftProducts[i] = leftProducts[i - 1] * nums[i - 1];
            }

            // Заполнение массива постфиксных произведений
            rightProducts[n - 1] = 1;
            for (int i = n - 2; i >= 0; i--)
            {
                rightProducts[i] = rightProducts[i + 1] * nums[i + 1];
            }

            // Перемножение соответствующих элементов
            for (int i = 0; i < n; i++)
            {
                result[i] = leftProducts[i] * rightProducts[i];
            }

            return result;
        }
    }
}
