# LeetCode-Two Sum
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

 

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
 

Constraints:

2 <= nums.length <= 104
-109 <= nums[i] <= 109
-109 <= target <= 109
Only one valid answer exists.
 

Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?

Solutions: 
Two solutions provided 

Approach 1: Brute Force
The brute force approach is simple. Loop through each element xx and find if there is another value that equals to target - xtarget−x.
- Time complexity: O(n^2)O(n 
2
 ). For each element, we try to find its complement by looping through the rest of the array which takes O(n)O(n) time. Therefore, the time complexity is O(n^2)O(n 
2
 ).
- Space complexity: O(1)O(1). The space required does not depend on the size of the input array, so only constant space is used.

Approach 2: Dictionary
While we are iterating and inserting elements into a dictionary, we also look back to check if current element's complement already exists in the dictionary. If it exists, we have found a solution and return the indices immediately.

- Time complexity: O(n)O(n). We traverse the list containing nn elements only once. Each lookup in the table costs only O(1)O(1) time.
- Space complexity: O(n)O(n). The extra space required depends on the number of items stored in the hash table, which stores at most nn elements.

