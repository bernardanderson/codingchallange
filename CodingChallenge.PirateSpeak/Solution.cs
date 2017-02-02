using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.PirateSpeak
{
    public class Solution
    {
        public string[] GetPossibleWords(string jumble, string[] dictionary)
        {
            List<string> foundWords = new List<string>();

            foreach (string word in dictionary)
            {
                List<char> tempJumble = jumble.ToList();

                //Checks to see if the jumble is less than the letters in the word
                if (tempJumble.Count != word.Length) {}
                else
                {
                    foreach (char letter in word)
                    {
                        if (tempJumble.Contains(letter))
                        {
                            tempJumble.Remove(letter);
                        }

                        if (tempJumble.Count == 0)
                        {
                            foundWords.Add(word);
                            break;
                        }
                    }
                }
            }

            return foundWords.ToArray();
        }
    }
}