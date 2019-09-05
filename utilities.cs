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
        // Your code here
        // Determine whether user has input a word or number
        // Return the string 'word' if word (anything with letters)
        // Return 'number' if number (includes decimals)

        if (double.TryParse(input, out double result))
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

        return inputType;
    }
}
