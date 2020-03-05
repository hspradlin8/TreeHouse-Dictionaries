using System.Collections.Generic;
using System.Linq;

namespace Treehouse.CodeChallenges
{
    public class LexicalAnalysis
    {
        public Dictionary<string, int> WordCount = new Dictionary<string, int>();
        //Question 1
        public void AddWord(string word)
        {
            if (WordCount.ContainsKey(word))
            {
                WordCount[word]++;
            }
            else
            {
                WordCount.Add(word, 1);
            }
        }
        //Question 2
        public Dictionary<string, int> WordsWithCountGreaterThan(int count)
        {
            var resultSet = new Dictionary<string, int>();
            foreach (KeyValuePair<string, int> entry in WordCount)
            {
                if (entry.Value > count)
                {
                    resultSet.Add(entry.Key, entry.Value);

                }
                return resultSet;
            }

        }
    }
}
// Question 1
// Code the AddWord method such that, WordCount will contain the number of times the AddWord 
// method has been called with a given word.

// For example, if AddWord is called twice with the word "rock" then WordCount["rock"] will be 2.

// Question 2
// Create a method named WordsWithCountGreaterThan that takes an integer as a parameter. 
// The method should return a dictionary of all of the words that have a count greater than the parameter passed in. 
// The dictionary should contain the word and the word's count.