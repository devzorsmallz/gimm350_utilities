using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utilities
{
    public static string inputType;

    public static bool ContainsLetters(string s)
    {
        foreach (char c in s)
        {
            if (char.IsLetter(c))
            {
                return true;
            }
        }

        return false;
    }

    public static string ProcessText(string input)
    {
        /* --- 09.05.2019 --- */

        // Your code here
        // Determine whether user has input a word or number
        // Return the string 'word' if word (anything with letters)
        // Return 'number' if number (includes decimals)

        /* if (double.TryParse(input, out double result))
        {
            inputType = "number";
        }

        else if (ContainsLetters(input) == true)
        {
            inputType = "word";
        }

        else
        {
            inputType = "neither";
        }

        return inputType.ToString(); */

        /* --- 09.12.2019 --- */

        // Return the average number of letters

        double numLetters = 0;
        double numWords = 1;
        double avgLetters = 0;

        foreach (char word in input)
        {
            if (char.IsSeparator(word))
            {
                numWords++;
            }
        }

        foreach (char c in input)
        {
            if (char.IsLetter(c) && !char.IsSeparator(c))
            {
                numLetters++;
            }
        }

        avgLetters = numLetters / numWords;
        return avgLetters.ToString();
    }
}