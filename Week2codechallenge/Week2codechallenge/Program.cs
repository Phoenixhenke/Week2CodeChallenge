using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2codechallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            
                FizzBuzz(i);

            Console.WriteLine();
            Console.WriteLine("I have bones.");
            textStats("I have bones.");
            Console.WriteLine();
                LetterCounter('I',"I love biscuits and gravy. It's the best breakfast ever.");
              LetterCounter('n',"Never gonna give you up. Never gonna let you down.");
                LetterCounter('s',"Sally sells seashells down by the seashore. She's from Sussex.");
            
            Console.ReadKey();
        }
        static void FizzBuzz(int number)// 1) FizzBuzz Reminder
        {
            if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
        }
        static void textStats(string input)// textstats Reminder
        {
            var myList = input;                         //puts the varible mylist as the input
           var count = myList.Count();                  
           int countwords = myList.Split(' ').Count();  //counts how many words are in the input
           int countvow = 0;                            //vowels
           int countcha = 0;                            //special charector
           int countcon = 0;                            //consonate
                                                      //shortest word
            string[] myArray = myList.Split(' ');              
           string longestword = "";                     //longest word
           string shortestword = myArray[0];             
            string output = string.Empty;                
           for (int g = 0; g < myArray.Count(); g++)       
          {
              if (myArray[g].Length > longestword.Length)//should show the longest word
                  {
                      longestword = myArray[g];
                  }
              else if (myArray[g].Length < shortestword.Length)// should show shortest word
              {
                  shortestword = myArray[g];
              }
          }
            for (int i = 0; i < myList.Length; i++)
            {
            if (myList[i] == 'e' || myList[i] == 'o' || myList[i] == 'i' || myList[i] == 'a' || myList[i] == 'u' ||myList [i] == 'I')// list the vowels so it can count them.
               {
                   countvow++;
               }
               else if (myList[i] == ' ' || myList[i] == '.')// list the special charector then counts them.
               {
                   countcha++;
               }
               else
               {
                   countcon++;// anything that aren't listed in vowels or charectors are consenats and will be counted.
               }
           }
           Console.WriteLine("Number of characters: " + count);
           Console.WriteLine("Number of words: " + countwords);
           Console.WriteLine("Number of vowels: " + countvow);
           Console.WriteLine("Number of consanants: " + countcon);
           Console.WriteLine("Number of special characters: " + countcha);
           Console.WriteLine("longest word: " + longestword);
           Console.WriteLine("shortest word: " + shortestword);
        }
        static void  LetterCounter(char letter, string instring)// letter counter
        {
        int tUp = 0;//total upper case
        int tdown = 0;//total lower case
        int tletter = 0;//total number of letters
        var letterlow = letter.ToString().ToLower();
        var letterup = letter.ToString().ToUpper();
        for (int i = 0; i < instring.Length; i++)
            if (instring[i].ToString() == letterup)
            {
            tUp++;
            tletter++;
            }
            else if (instring[i].ToString() == letterlow)
            {
                tdown++;
                tletter++;
            }
            Console.WriteLine("Input " + instring);
            Console.WriteLine("number of lower case " + letter + "s found: " + tdown + ".");
            Console.WriteLine("number of UPPERCASE " + letter + "s found: " + tUp + ".");
            Console.WriteLine("Total number of " + letter + "s found: " + tletter + ".");
    }
    }
}
