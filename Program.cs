using System;

namespace Max_Subarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите массив чисел:");
            var strArr = Console.ReadLine().Split();
            Console.WriteLine("Введите длину подмассива:");
            int m = Convert.ToInt32(Console.ReadLine());
            var intArr = new int[strArr.Length];
            int currSum = 0;
            int maxSum = 0;
            int startIndex = 0;
            int endIndex = 0;
            for (int i = 0; i < strArr.Length; i++)
            {
                intArr[i] = Convert.ToInt32(strArr[i]);
                currSum += intArr[i];
                if (i - startIndex == m - 1)
                {
                    if (maxSum < currSum)
                    {
                        maxSum = currSum;
                        endIndex = i;
                    }
                    currSum = currSum - intArr[startIndex];
                    startIndex++;
                }
            }
            Console.WriteLine("Подмассив с максимальной суммой от {0} до {1}", endIndex - m + 1, endIndex);
            Console.WriteLine("Сумма равна {0}", maxSum);
        }
    }
}
