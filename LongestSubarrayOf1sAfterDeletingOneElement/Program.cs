namespace LongestSubarrayOf1sAfterDeletingOneElement
{
    /*
    Longest subarray of 1's after deleting  one element.
    Given a binary array nums, you should delete one element from it.
    Return the size of the longest non-empty subarray containing only 1's in the resulting array. Return 0 if there is no such subarray.

    Example 1:

    Input: nums = [1,1,0,1]
    Output: 3
    Explanation: After deleting the number in position 2, [1,1,1] contains 3 numbers with value of 1's.

    Example 2:

    Input: nums = [0,1,1,1,0,1,1,0,1]
    Output: 5
    Explanation: After deleting the number in position 4, [0,1,1,1,1,1,0,1] longest subarray with value of 1's is [1,1,1,1,1].

    Example 3:

    Input: nums = [1,1,1]
    Output: 2
    Explanation: You must delete one element.

    Для решения этой задачи нам необходимо найти самую длинную последовательность единиц после удаления одного элемента из массива. 
    Это означает, что мы должны найти такую позицию, удаление которой приведет к максимальной длине непрерывной последовательности единиц.

    Time: O(n)
    Space: O(1)
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new[] { 1, 1, 0, 1 };
            var result = LongestSubarray(nums);
            Console.WriteLine(result);
        }

        public static int LongestSubarray(int[] nums)
        {
            int ans = 0;
            int zeros = 0;

            for (int l = 0, r = 0; r < nums.Length; ++r)
            {
                if (nums[r] == 0)
                    ++zeros;
                while (zeros == 2)
                    if (nums[l++] == 0)
                        --zeros;
                ans = Math.Max(ans, r - l);
            }

            return ans;
        }
    }
}
