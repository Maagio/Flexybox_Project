using System;
using System.Linq;
using System.Collections.Generic;

namespace Flexybox_project
{
    public class Backend : IBackend
    {
        public string ReverseString (string s)
        {
            string tempString = "";
            for (int i = 0; i < s.Length; i++ )
            {
                tempString += s[s.Length - i - 1];
            }
            return tempString;
        }

        public bool IsPalindrome (string s)
        {
            bool palindrom = true;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != s[s.Length -i -1])
                {
                    palindrom = false;
                    break;
                }
            }
            return palindrom;
        }

        public IEnumerable<int> MissingElements(int[] arr)
        {
            arr = LowToHigh(arr);

            List<int> missingNumbers = new List<int>();
            int difference = 0;
            for (int t = 0; t < arr.Length; t++)
            {
                if (t + 1 == arr.Length){}
                else
                {

                difference = arr[t + 1] - arr[t];
                if (difference > 1)
                {
                    for (int p = 1; p < difference; p++)
                    {
                        missingNumbers.Add(arr[t] + p);
                    }
                }
                }
                difference = 0;
            }
            Console.WriteLine();
            Console.WriteLine("De manglede tal er:");

            return missingNumbers;
        }

        public int[] LowToHigh (int[] arr)
        {
            
            int len = arr.Length;
            int i = 0;

            while (i < len)
            {
                if (i + 1 == len)
                    i++;
                else if (arr[i] > arr[i + 1])
                {
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                    i = 0;
                }
                else
                    i++;
            }

            Console.WriteLine("Tallene efter sortering af størrelse er:");
            foreach (int nr in arr)
            {
                Console.Write(nr + " ");
            }

            return arr;
        }
    }
}