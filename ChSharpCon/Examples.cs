using System;
using System.Collections.Generic;
using System.Text;

namespace Examples
{
    public class ExapmlesForValueType
    {
        public void ChecksIfTheInputCharacterIsALetter()
        {
            //Recieve the user input
            
            Console.WriteLine("Please input letter");
            char userInput = (char)Console.Read();
            if (Char.IsLetter(userInput))
            {
                if (Char.IsLower(userInput))
                {
                    Console.WriteLine("The character is lowecase");
                }
                else
                {
                    Console.WriteLine("The character is UPPRCASE.");
                }
            }
            else
            {
                Console.WriteLine("Not an alphabetic character.");
               
            }
        }
    }
}
