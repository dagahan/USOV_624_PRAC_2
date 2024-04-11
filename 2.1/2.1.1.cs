using System;
using System.Linq;

class one
{
    static void Main(string[] args)
    {
        string J = "ab";
        string S = "aabbccd";
        int countJewels = CountJewels(J, S);
        Console.WriteLine(countJewels);
    }

    static int CountJewels(string J, string S)
    {
        return S.Count(ch => J.Contains(ch));
    }
}