namespace LeetcodeMedium
{
    /*
     Given an input string s, reverse the order of the words.
     A word is defined as a sequence of non-space characters. The words in s will be separated by at least one space.
     Return a string of the words in reverse order concatenated by a single space.
     Note that s may contain leading or trailing spaces or multiple spaces between two words. The returned string should only have a single space separating the words. Do not include any extra spaces.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            var str = "Hello, World!";
            Console.WriteLine(str);
            Console.WriteLine(ReverseWords(str));
            Console.ReadLine();
        }

        public static string ReverseWords(string s)
        {
            // Разделение строк на слова
            string[] words = s.Split(' ');

            // Создание новой строки для результата
            string result = "";

            // Проходим по словам в обратном порядке
            for (int i = words.Length - 1; i >= 0; i--)
            {
                // Пропускаем пустые слова
                if (!string.IsNullOrEmpty(words[i]))
                {
                    result += words[i].Trim() + " ";
                }
            }

            // Удаляем лишний пробел в конце строки
            return result.TrimEnd();
        }
    }
}
