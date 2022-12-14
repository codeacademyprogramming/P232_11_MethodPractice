using System;

namespace Homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //task1
            //var result = FindIndex(new char[] { 'a', 'b', 'c' }, 'f');

            //if(result != -1)
            //{
            //    Console.WriteLine("axtardiginiz deyer siyahida var");
            //}
            //else
            //{
            //    Console.WriteLine("Axtardiginiz deyer siyahida yoxdur");
            //}

            //task2
            //var result = IsDigit('a');

            //if(result)
            //{
            //    Console.WriteLine("Reqemdir");
            //}
            //else
            //{
            //    Console.WriteLine("Reqem deyil");
            //}


            //task3,task4
            //Layihe use dusdukde console-dan ad daxil edilir, eger adda reqem varsa yeniden
            //daxil etmeyimizi isteyir reqemsiz yazanadek

            //string name;
            //do
            //{
            //    Console.WriteLine("Yazini daxil edin");
            //    name = Console.ReadLine();

            //} while (HasDigit(name)==true);


            //task 5

            string[] names = { "Abbas", "Hik34met", "Salam1", "Sagol2", "Nermin" };

            string sentence = "";

            for (int i = 0; i < names.Length; i++)
            {
                sentence += names[i];
            }

            Console.WriteLine(sentence);
            Console.WriteLine(CountWords(names));

            //task 6

            int[] numbers = { 3, 6, 98, -2, -4, 344, -65 };

            var newNums = FilterPositive(numbers);

            Console.WriteLine("Positive numbers");
            for (int i = 0; i < newNums.Length; i++)
            {
                Console.WriteLine(newNums[i]);
            }


            string str = "   " + 'a'+'b';//ab


            Console.WriteLine(TrimLeft("                salam  sag ol  "));

        }



        //Task1 - Verilmis char arrayindeki verilmis charin indexini tapan metod.Eger yoxdursa -1 qaytarir
        static int FindIndex(char[] arr, char wantedChar)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == wantedChar)
                    return i;
            }

            return -1;
        }

        // Task-2 Verilmis charin reqem olub olmadigini tapan metod
        static bool IsDigit(char chr)
        {
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            return FindIndex(digits, chr) != -1;
        }

        //task3 - Verilmis yazida reqem olub olmadigini tapan metod
        static bool HasDigit(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (IsDigit(str[i]))
                {
                    return true;
                }
            }

            return false;
        }

        //Layihe use dusdukde console-dan ad daxil edilir, eger adda reqem varsa yeniden
        //daxil etmeyimizi isteyir reqemsiz yazanadek

        static void ShowHello(string name)
        {
            Console.WriteLine(name + " Hello!");
        }


        //task 5 Verilmis yazi siyahisinda nece yazida reqem oldugunu tapan metod

        static int CountWords(string[] strArr)
        {
            int count = 0;
            for (int i = 0; i < strArr.Length; i++)
            {
                if (HasDigit(strArr[i]))
                {
                    count++;
                }
            }

            return count;
        }

        //task6 - Verilmiş ədədlər siyahısındaki ədədlərin yalnız müsbət olanlarından ibarət yeni bir array qaytaran metod

        static int[] FilterPositive(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                    count++;

            }

            int j = 0;
            int[] positiveNumbers = new int[count];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    positiveNumbers[j] = numbers[i];
                    j++;
                }
            }

            return positiveNumbers;
        }

        static int FindIndex(string[] arr, string wantedStr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == wantedStr)
                    return i;
            }

            return -1;
        }

        //Verilmsi stringdeki ilk space olmayan charin indexini tapan metod

        static int FindFirstNonSpaceIndex(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                    return i;
            }
            return -1;
        }

        //Verilmis string deyerinden evvelinde bosluqlar olmayan yeni bir string duzeldib qaytaran metod

        static string TrimLeft(string str)
        {
            var startIndex = FindFirstNonSpaceIndex(str);
            string newStr = "";
            for (int i = startIndex; i < str.Length; i++)
            {
                newStr += str[i];
            }

            return newStr;
        }

    }


}

