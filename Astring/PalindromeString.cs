using System;

class PalindromeString{
    static bool IsPlaindrome(string str){
        
        for(int i=0,j=str.Length-1; i<str.Length/2;i++,j--){
            if(str[i]!=str[j]) {
                return false;
            }
        }
        return true;
    }
    static void Main(string[] args){

        Console.Write("Enter a string: ");
        string str=Console.ReadLine();

        if(IsPlaindrome(str)){
            Console.WriteLine("The given string is a palindrome");
        }else{
            Console.WriteLine("The given string is not a palindrome");
        }
    }
}