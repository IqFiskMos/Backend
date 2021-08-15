using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Guessing_Game.Models
{
    
    public class GuessingGameModel
    {
        public static List<int> StoreNums = new List<int>();   
        
        public static int GetGuessNumber()
        {
            var random = new Random();
            int num = random.Next(1, 100);
            StoreNums.Clear();
            return num;
        }
        public static string CheckGuess(int userInput, int guess)
        {            
            if (userInput <= 100 && userInput >= 1)
            {
                StoreNums.Add(userInput);
                if (userInput > guess)
                {
                   return "Your guess is too high!";
                }
                else if (userInput < guess)
                {
                    return "Your guess is too low!";
                }
                else
                {
                    return "Congratulations! Your guess is correct.";
                }                
            }
            else
            {
                return "Please enter a valid number!";
            }            
        }
    }
}
