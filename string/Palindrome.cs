using System;
class Palindrome{
    static void isPalindrome(string str){
        for(int i=0;i<str.Length/2;i++){
            if(str[i]!=str[str.Length-i-1]){
                Console.WriteLine("Given string not a palindrome string.");
                return;
            }
        }
        Console.WriteLine("Given string a palindrome string.");
        return;
    }
    static void Main(string[] args){
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        isPalindrome(str);
    }
}