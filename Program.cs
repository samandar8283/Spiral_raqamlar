using System;

class Program
{
    static void Main()
    {
        int n = 7;  // Spiralni tashkil etadigan kvadratning o‘lchami
        int[,] matrix = new int[n, n];

        int num = 1;
        int top = 0, left = 0;
        int bottom = n - 1, right = n - 1;

        // Spiralni to‘ldirish
        while (top <= bottom && left <= right)
        {
            // Yuqoridan pastga to‘ldirish
            for (int i = left; i <= right; i++)
                matrix[top, i] = num++;

            top++;

            // O‘ngdan chapga to‘ldirish
            for (int i = top; i <= bottom; i++)
                matrix[i, right] = num++;

            right--;

            // Pastdan yuqoriga to‘ldirish
            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                    matrix[bottom, i] = num++;

                bottom--;
            }

            // Chapdan o‘ngga to‘ldirish
            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                    matrix[i, left] = num++;

                left++;
            }
        }

        // Spiralni konsolga chiqarish
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}



//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        int n = 7;
//        int num = 1;
//        int left = 0, right = n - 1, bottom = n - 1, top = 0;
//        int[,] matrix = new int[n, n];
//        while (right >= left && bottom >= top)
//        {

//            for (int i = right; i >= left; i--)
//            {
//                matrix[top, i] = num++;
//            }
//            top++;


//            for (int i = top; i <= bottom; i++)
//            {
//                matrix[i, left] = num++;
//            }
//            left++;


//            for (int i = left; i <= right; i++)
//            {
//                matrix[bottom, i] = num++;
//            }
//            bottom--;


//            for (int i = bottom; i >= top; i--)
//            {
//                matrix[i, right] = num++;
//            }
//            right--;
//        }


//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write(matrix[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }

//    }
//}




//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Solution solution = new Solution();
//        int[] result = solution.TwoSum(new int[] { 2, 3, 6 }, 9);
//        for (int i = 0; i < 2; i++)
//        {
//            Console.Write(result[i]+" ");
//        }
//    }
//}
//public class Solution
//{
//    public int[] TwoSum(int[] nums, int target)
//    {
//        int[] output = new int[2];
//        for (int i = 0; i < nums.Length; i++)
//        {
//            for (int j = i + 1; j < nums.Length; j++)
//            {
//                if (nums[i] + nums[j] == target)
//                {
//                    output[0] = i;
//                    output[1] = j;
//                    return output;
//                }
//            }
//        }

//        return output;
//    }
//}



//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Solution solution = new Solution();
//        int[] result = solution.TwoSum(new int[] { 2, 7, 11 }, 9);
//        for (int i = 0; i < result.Length; i++)
//        {
//            Console.Write(result[i] + " ");
//        }
//    }
//}

//public class Solution
//{
//    public int[] TwoSum(int[] nums, int target)
//    {
//        int[] output = new int[2];
//        for (int i = 0; i < nums.Length; i++)
//        {
//            for (int j = i + 1; j < nums.Length; j++) // 'j' ni 'i+1' dan boshlash
//            {
//                if (nums[i] + nums[j] == target)
//                {
//                    output[0] = i;
//                    output[1] = j;
//                    return output; // Topilgan juftlikni qaytarish
//                }
//            }
//        }
//        return output; // Agar yechim topilmasa, bo'sh massivni qaytarish
//    }
//}


















