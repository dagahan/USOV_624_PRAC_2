using System;
using System.Collections.Generic;
using System.Linq;

class MainClass 
{
    public static void Main (string[] args) 
    {
        int[] candidates1 = {2, 5, 2, 1, 2};
        int target1 = 5;
        Console.WriteLine("candidates = [2,5,2,1,2]");
        Console.WriteLine("target = 5");
        Console.WriteLine("Result:");
        foreach (var combination in CombinationSum(candidates1, target1))
            Console.WriteLine($"[{string.Join(",", combination)}]");

        int[] candidates2 = {10, 1, 2, 7, 6, 1, 5};
        int target2 = 8;
        Console.WriteLine("\ncandidates = [10,1,2,7,6,1,5]");
        Console.WriteLine("target = 8");
        Console.WriteLine("Result:");
        foreach (var combination in CombinationSum(candidates2, target2))
            Console.WriteLine($"[{string.Join(",", combination)}]");
    }

    public static IList<IList<int>> CombinationSum(int[] candidates, int target) 
    {
        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(candidates);
        Backtrack(result, new List<int>(), candidates, target, 0);
        return result;
    }

    private static void Backtrack(IList<IList<int>> result, List<int> tempList, int[] candidates, int remain, int start) 
    {
        if (remain < 0) return;
        else if (remain == 0) result.Add(new List<int>(tempList));
        else 
        {
            for (int i = start; i < candidates.Length; i++) 
            {
                if (i > start && candidates[i] == candidates[i - 1]) continue;
                tempList.Add(candidates[i]);
                Backtrack(result, tempList, candidates, remain - candidates[i], i + 1);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }
    }
}