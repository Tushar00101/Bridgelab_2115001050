using System;
class VowelAndConsonant{

    static void CountVowelAndConsonant(string str){
        int vowel = 0;
        int consonant = 0;

        //Checking foreach character and comparing it.
        foreach(char ch in str){
            if(ch>='a'&&ch<='z' || ch>='A'&& ch<='Z' ){
                if(ch=='a'||ch=='e' || ch=='i' ||  ch=='o' || ch=='u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'u'){
                    vowel++;
                }else{
                    consonant++;
                }
            }
        }

        Console.WriteLine("Total vowel are: " + vowel);
        Console.WriteLine("Total consonants are: " + consonant);

    }
    static void Main(string[] args){

        //Asking for input from user
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        CountVowelAndConsonant(str);
    }
}