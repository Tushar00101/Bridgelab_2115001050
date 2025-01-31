using System;
class Fibonacci {

    static void calFibonacci(int n){
        if (n <= 1) return;
        int[] nums = new int[n];
        nums[0] = 0;
        nums[1] = 1;
        for(int i=2;i<n;i++){
            nums[i] = nums[i - 1] + nums[i - 2];
        }
        foreach(int i in nums){
            Console.Write(i + " ");
        }
    }
    static void Main(string[] args){
        
        Console.Write("Enter number of terms for Fibonacci : ");

        int n = Convert.ToInt32(Console.ReadLine());

        calFibonacci(n);

    }
}