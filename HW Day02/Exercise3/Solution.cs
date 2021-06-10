using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Solution
    {
        public int solution(int A, int B)
        {
            int count = 0;
            for (int i = A; i <= B; i++)
            {
                for(int j = 1; j*j <= i; j++)
                {
                    if(j*j == i)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
            
    }
}

