//Author: Bochen Huang
//FullStack June 2021
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Solution
    {
        public int solution(int[] A)
        {
            Array.Sort(A);

            int result = A[0];
            int max_count = 1, curr_count = 1;

            for (int i = 1; i < A.Length; i++)
            {
                if(A[i] == A[i - 1])
                {
                    curr_count++;
                }
                else
                {
                    if(curr_count > max_count)
                    {
                        max_count = curr_count;
                        result = A[i - 1];
                    }
                    curr_count = 1;
                }
            }

            if (curr_count > max_count)
            {
                max_count = curr_count;
                result = A[A.Length - 1];
            }

            return result;
        }

    }
}
