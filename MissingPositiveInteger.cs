using System;

class SearchNum
{
    static int FindMissing(int[] nums)
    {
        int n = nums.Length;
        bool[] visited = new bool[n + 1];

        foreach (int num in nums)
        {
            if (num > 0 && num <= n)
            {
                visited[num] = true;
            }
        }

        for (int i = 1; i <= n; i++)
        {
            if (!visited[i])
            {
                return i;
            }
        }

        return n + 1;
    }

    static int BinarySearch(int[] nums, int target)
    {
        Array.Sort(nums);
        int left = 0, right = nums.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
                return mid;

            if (nums[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter numbers separated by space:");
        int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        Console.WriteLine("First missing positive: " + FindMissing(nums));

        Console.WriteLine("Enter target number:");
        int target = int.Parse(Console.ReadLine());

        int index = BinarySearch(nums, target);
        Console.WriteLine(index != -1 ? "Target found at index: " + index : "Target not found");
    }
}
