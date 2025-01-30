using System;
class ReplaceWord{
    static void Main(string[] args){

        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        Console.Write("Which word do you want to replace: ");
        string givenWord = Console.ReadLine();

        Console.Write("The word you want to replace with: ");
        string replace = Console.ReadLine();

        string[] nums = str.Split(' ');

        for (int i=0; i < nums.Length;i++){

            if(nums[i]==givenWord){
                nums[i] = replace;
                break;
            }
        }
        Console.WriteLine(string.Join(" ", nums));
    }
}