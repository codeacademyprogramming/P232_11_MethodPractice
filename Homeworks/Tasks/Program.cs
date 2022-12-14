using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        //Verilmis char arrayinde verilmis charin yerlesdiyi indexi tapan metod

        //Verilmis charin digit olub olmadigini tapan metod

        //Verilmis yazida digit olub olmadigini tapan metod

        static int FindIndex(char[]arr,char chr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                if (chr == arr[i])
                    return i;
            }
            return -1;
        }
        static bool IsDigit(char givenchar)
        {
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            return (FindIndex(digits, givenchar) != -1);
                
               
               
               
        }
        static bool HasDigit(string word)
        {
            for (int i = 0; i < word.Length; i++)

            {
                if( IsDigit(word[i]))
                    return true;
            }
            return false;
        }
        
    }
}
