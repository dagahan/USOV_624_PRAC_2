using System;
using System.Collections.Generic;

class MainClass {
    public static void Main (string[] args) {
        int[] nums1 = {1, 2, 3, 4};
        Console.WriteLine("nums = [1,2,3,4] => " + ContainsDuplicate(nums1));

        int[] nums2 = {1, 1, 1, 3, 3, 4, 3, 2, 4, 2};
        Console.WriteLine("nums = [1,1,1,3,3,4,3,2,4,2] => " + ContainsDuplicate(nums2));

        int[] nums3 = {1, 2, 3, 1};
        Console.WriteLine("nums = [1,2,3,1] => " + ContainsDuplicate(nums3));
    }

    public static bool ContainsDuplicate(int[] nums) {
        HashSet<int> set = new HashSet<int>();
        foreach (int num in nums) {
            if (!set.Add(num))
                return true;
        }
        return false;
    }
}