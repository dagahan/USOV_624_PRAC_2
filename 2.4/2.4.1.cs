using System;
using System.Collections.Generic;

class RomanToIntConverter 
{
    //Римские числа.....
    public int RomanToInt(string s) 
    {
        //словарь с короче говоря обозначением, какую цифру подразумевает буква
        Dictionary<char, int> romanValues = new Dictionary<char, int>() 
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        
        //начало калькулирования
        int result = 0;
        for (int i = 0; i < s.Length; i++) 
        {
            if (i > 0 && romanValues[s[i]] > romanValues[s[i - 1]]) 
            {
                result += romanValues[s[i]] - 2 * romanValues[s[i - 1]];
            } 
            else 
            {
                result += romanValues[s[i]];
            }
        }
        return result;
    }
}

class Program 
{
    
    static void Main(string[] args) 
    {
        RomanToIntConverter converter = new RomanToIntConverter();

        string input1 = "III";
        Console.WriteLine($"Input: \"{input1}\" Output: {converter.RomanToInt(input1)}"); //использует конвертор

        string input2 = "LVIII";
        Console.WriteLine($"Input: \"{input2}\" Output: {converter.RomanToInt(input2)}");

        string input3 = "MCMXCIV";
        Console.WriteLine($"Input: \"{input3}\" Output: {converter.RomanToInt(input3)}");
    }
}