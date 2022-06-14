using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class NobleInteger
    {
        public int solve(List<int> A)
        {
            A.Sort();// increasing order
            if (A[A.Count - 1] == 0) return 1;
            for (int i = 0; i < A.Count - 1; i++)
            {
                if (A[i] >= 0 && A[i] != A[i + 1] && A[i] == A.Count - i - 1) return 1;

            }
            return -1;
        }
    }
}
