namespace MaximumNumberOfVowelsInASubstringOfGivenLength
{
    /*
    Given a string s and an integer k, return the maximum number of vowel letters in any substring of s
    with length k.

    Vowel letters in English are 'a', 'e', 'i', 'o', and 'u'.

    Разбор кода:
    Класс Solution: Содержит метод MaxVowels, который принимает строку s и длину подстроки k.
    Метод MaxVowels:
    Создаются вспомогательные массивы для подсчёта количества гласных букв и общего количества каждой буквы.
    Проход по строке s для обновления счётчиков.
    Поиск максимального количества гласных букв в подстроках длиной k.
    Возврат максимального найденного количества гласных букв.
    Функция Main: Создаётся экземпляр класса Solution, вызывается метод MaxVowels с тестовыми данными и результат выводится в консоль.
    Сложность:
    Время: 

    O(n), где n — длина строки s. Основной цикл проходит по всей строке один раз.
    Память: 
    O(n), где n — длина строки s. Используется дополнительный массив для хранения промежуточных результатов.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "abciiiiieea";
            int k = 3;
            int result = Solution.MaxVowels(s, k);
            Console.WriteLine(result);
        }
    }

    public static class Solution
    {
        public static int MaxVowels(string s, int k)
        {
            int n = s.Length;
            int[] vowelsCount = new int[n + 1]; // Массив для подсчёта гласных букв
            int[] chars = new int[26]; // Массив для подсчёта количества каждой буквы
            int vowelCount = 0;
            int maxVowelCount = 0;

            for (int i = 1; i < n; ++i)
            {
                int idx = s[i] - 'a'; // Индекс текущей буквы в алфавите
                chars[idx]++;
                if ("aeiou".IndexOf(s[i]) != -1)
                {
                    vowelCount++;
                }
                vowelsCount[i + 1] = vowelCount;
            }

            for (int i = k; i <= n; ++i)
            {
                int currentVowelCount = vowelsCount[i] - vowelsCount[i - k];
                maxVowelCount = Math.Max(maxVowelCount, currentVowelCount);
            }

            return maxVowelCount;
        }
    }
}
