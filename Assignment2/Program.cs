using System;

namespace Assignment2
{
    internal class Program
    {
        static bool isVowel(char vowel)
        {

            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            bool result = false;

            foreach (char eachvowel in vowels)
            {
                if (eachvowel == vowel)
                    result = true;
            }
            return result;

        }



            static string RemoveVowels(string vowel)
            {
                string outputString = string.Empty;

                for (int i = 0; i < vowel.Length; i++)
                {
                    if (isVowel(vowel[i]))
                    {
                        outputString = outputString + "";
                    }
                    else
                    {
                        outputString = outputString + vowel[i];
                    }


                    
                }
                    return outputString;
        }

              static void Main(string[] args)
                {
                    string inputString = "Meisha Leigh Loff ";
                    

                    string outputString = RemoveVowels(inputString);
                    Console.WriteLine(outputString);

                }
            }
        }
    


