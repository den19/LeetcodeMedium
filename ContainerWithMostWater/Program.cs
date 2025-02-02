namespace ContainerWithMostWater
{
    /*
    You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).
    Find two lines that together with the x-axis form a container, such that the container contains the most water.
    Return the maximum amount of water a container can store.
    Notice that you may not slant the container. 
    --
    Давайте разберём этот код подробнее:

    Дана последовательность ненулевых целых чисел height, представляющая высоты стен контейнеров.
    Найти две линии, которые вместе с основанием образуют наибольшую площадь прямоугольника, заполненного водой,
    и вернуть эту максимальную площадь.

    Для решения данной задачи обычно используют подход двух указателей, которые начинают двигаться навстречу друг другу
    с концов массива, выбирая максимальную возможную площадь на каждом шаге.

    Мы инициализируем переменную maxArea для хранения максимального значения площади, которое мы найдем.
    Используем два указателя: left указывает на начало массива, а right — на конец.
    Пока left меньше right, мы вычисляем текущую площадь, используя минимальную высоту между height[left] и height[right], умноженную на расстояние между этими индексами (right - left).
    Если высота слева меньше, чем справа, то мы сдвигаем левый указатель вправо, иначе — правый указатель влево.
    После завершения цикла возвращаем максимальное значение площади.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7  };

            // Вызываем функцию для нахождения максимального объема воды
            int maxArea = MaxArea(height);

            Console.WriteLine("Максимальный объем воды: " + maxArea);
            Console.ReadLine();
        }

        public static int MaxArea(int[] height)
        {
            if (height == null || height.Length < 2)
            {
                return 0;
            }

            int left = 0;
            int right = height.Length - 1;
            int maxArea = 0;

            while (left < right)
            {
                maxArea = Math.Max(maxArea, Math.Min(height[left], height[right]) * (right - left));

                if (height[left] <= height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return maxArea;
        }
    }
}
