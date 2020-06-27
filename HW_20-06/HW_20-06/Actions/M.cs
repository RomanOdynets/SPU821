using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_20_06.Actions
{
    static class M
    {
        public static int Add(int[] nums)
        {
            int res = 0;
            foreach (int i in nums) res += i;
            return res;
        }

        public static int Tru(int[] nums)
        {
            int res = nums[0];
            for (int i = 1; i < nums.Length; i++) res -= nums[i]; 
            return res;
        }

        public static int Mul(int[] nums)
        {
            int res = nums[0];
            for (int i = 1; i < nums.Length; i++) res *= nums[i];
            return res;
        }

        public static int Div(int[] nums)
        {
            int res = nums[0];
            for (int i = 1; i < nums.Length; i++) res /= nums[i] == 0 ? nums[i] : 1;
            return res;
        }
    }
}
