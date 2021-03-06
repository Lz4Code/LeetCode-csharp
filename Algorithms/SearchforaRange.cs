// Source : https://leetcode.com/problems/search-for-a-range/ 
// Author : codeyu 
// Date : Monday, October 17, 2016 7:37:08 PM 

/**********************************************************************************
*
* Given a sorted array of integers, find the starting and ending position of a given target value.
* 
* Your algorithm's runtime complexity must be in the order of O(log n).
* 
* If the target is not found in the array, return [-1, -1].
* 
* 
* For example,
* Given [5, 7, 7, 8, 8, 10] and target value 8,
* return [3, 4].
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    public class Solution034 
    {
        public static int[] SearchRange(int[] nums, int target) 
        {
            var start = -1;
            var end = -1;
            if(nums != null && nums.Length > 0)
            {
                int left = 0, right = nums.Length - 1;
                while(left < right-1)
                {
                    var mid = left + (right - left) / 2;
                    if(nums[mid] == target)
                    {
                        right = mid;
                    }
                    else if(nums[mid] < target)
                    {
                        left = mid;
                    }
                    else
                    {
                        right = mid;
                    }
                }
                if(nums[left] ==target)
                {
                    start = left;
                }
                else if(nums[right] == target)
                {
                    start = right;
                }

                left = 0;
                right = nums.Length - 1;
                while(left < right-1)
                {
                    var mid = left + (right - left) / 2;
                    if(nums[mid] == target)
                    {
                        left = mid;
                    }
                    else if(nums[mid] < target)
                    {
                        left = mid;
                    }
                    else
                    {
                        right = mid;
                    }
                }

                if(nums[right] == target)
                {
                    end = right;
                }
                else if(nums[left] == target)
                {
                    end = left;
                }
            } 
            return new []{start, end};       
        }
    }
}

