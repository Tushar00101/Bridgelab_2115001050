using System;

class RemoveDuplicate{

    static void RemoveDuplicateMethod(string str,out string newString){

        newString = "";

        int[] nums = new int[256];

        foreach(char ch in str){
            if(ch>='a' && ch<='z'){
                
                if (nums[ch - 'a'] == 0)
                {
                    nums[ch - 'a']++;
                    newString += ch + "";
                }
            }
            else if(ch>='A' && ch<='Z'){

                if (nums[ch - 'A'] == 0)
                {
                    nums[ch - 'A']++;
                    newString += ch + "";
                }
            }
        }
    }
    static void Main(string[] args){

        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        string newString;

        RemoveDuplicateMethod(str,out newString);

        Console.WriteLine("String after removing the duplicates values is: " + newString);
    }
}