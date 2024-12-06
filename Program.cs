

using System;
class Program
{
    static void Main(string[] args)
    {
        int n = 7;
        int num = 1;
        int left = 0, right = n - 1, bottom = n - 1, top = 0;
        int[,] matrix = new int[n, n];
        while (right >= left && bottom >= top)
        {

            for (int i = right; i >= left; i--)
            {
                matrix[top, i] = num++;
            }
            top++;


            for (int i = top; i <= bottom; i++)
            {
                matrix[i, left] = num++;
            }
            left++;


            for (int i = left; i <= right; i++)
            {
                matrix[bottom, i] = num++;
            }
            bottom--;


            for (int i = bottom; i >= top; i--)
            {
                matrix[i, right] = num++;
            }
            right--;
        }


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



















