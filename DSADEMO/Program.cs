namespace DSADEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = [1, 2, 3, 4, 5, 6, 7];
            int windowSize = 2;

            Console.WriteLine(
                $"Max Sum with brute force = {MaxSumWithBruteForce(numbers, windowSize)}"
            );
            Console.WriteLine(
                $"Max Sum with fixed sliding window = {MaxSumWithSlidingWindow(numbers, windowSize)}"
            );
        }

        static int MaxSumWithBruteForce(int[] numbers, int windowSize)
        {
            int maxSum = int.MinValue;
            for (int i = 0; i <= numbers.Length - windowSize; i++)
            {
                int currentSum = 0;
                for (int j = i; j < i + windowSize; j++)
                {
                    currentSum += numbers[j];
                }
                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;
        }

        static int MaxSumWithSlidingWindow(int[] numbers, int windowSize)
        {
            int maxSum = 0,
                windowSum = 0;

            for (int i = 0; i < windowSize; i++)
                windowSum += numbers[i];

            maxSum = windowSum;

            for (int i = windowSize; i < numbers.Length; i++)
            {
                windowSum += numbers[i] - numbers[i - windowSize];
                maxSum = Math.Max(maxSum, windowSum);
            }
            return maxSum;
        }
    }
}
