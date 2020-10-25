using System;
using System.Collections.Generic;
using System.Text;

namespace FindMedianSortedArrays
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var result = 0D;

            // Merge arrays            
            int[] newArray = new int[nums1.Length + nums2.Length];
            Array.Copy(nums1, newArray, nums1.Length);
            Array.Copy(nums2, 0, newArray, nums1.Length, nums2.Length);
            List<int> sumNewArray = new List<int>(newArray);
            sumNewArray.Sort();

            result = 0.5 * ((sumNewArray[(int)Math.Floor(((double)(sumNewArray.Count  + 1) / 2)) - 1]) + (sumNewArray[(int)Math.Ceiling(((double)(sumNewArray.Count  + 1) / 2)) - 1]));
            
            return result;
        }
    }
}
