using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Solution
    {
        public void Take2DToSpiral(int[,]A)
        {
            int row_start = 0, col_start = 0;
            int row_end = A.GetLength(0);
            int col_end = A.GetLength(1);
            int iterator;

            while(row_start < row_end && col_start < col_end)
            {
                for(iterator = col_start; iterator < col_end; ++iterator)
                {
                    Console.Write(A[row_start, iterator] + " ");
                }
                row_start++;

                for(iterator = row_start; iterator < row_end; ++iterator)
                {
                    Console.Write(A[iterator, col_end - 1] + " ");
                }
                col_end--;

                if(row_start < row_end)
                {
                    for(iterator = col_end - 1; iterator >= col_start; --iterator)
                    {
                        Console.Write(A[row_end - 1, iterator] + " ");
                    }
                    row_end--;
                }

                if(col_start < col_end)
                {
                    for (iterator = row_end - 1; iterator >= row_start; --iterator)
                    {
                        Console.Write(A[iterator, col_start] + " ");
                    }
                    col_start++;
                }
            }
        }
    }
}
