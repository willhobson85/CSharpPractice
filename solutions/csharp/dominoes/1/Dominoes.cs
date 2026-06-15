using System.Collections.Generic;
using System.Linq;

public static class Dominoes
{
    public static bool CanChain(IEnumerable<(int, int)> dominoes)
    {
        var list = dominoes.ToList();

        // An empty set of dominoes forms a valid loop.
        if (list.Count == 0)
        {
            return true;
        }

        bool[] used = new bool[list.Count];

        // Start with the first domino.
        used[0] = true;

        return CanChain(
            list,
            used,
            usedCount: 1,
            startValue: list[0].Item1,
            currentEnd: list[0].Item2);
    }

    private static bool CanChain(
        List<(int, int)> dominoes,
        bool[] used,
        int usedCount,
        int startValue,
        int currentEnd)
    {
        // Have we used all dominoes?
        if (usedCount == dominoes.Count)
        {
            // Does the chain close into a loop?
            return currentEnd == startValue;
        }

        for (int i = 0; i < dominoes.Count; i++)
        {
            if (used[i])
            {
                continue;
            }

            var (left, right) = dominoes[i];

            // Try the domino in its original orientation.
            if (left == currentEnd)
            {
                used[i] = true;

                if (CanChain(dominoes, used, usedCount + 1, startValue, right))
                {
                    return true;
                }

                used[i] = false;
            }

            // Try the domino flipped.
            if (right == currentEnd)
            {
                used[i] = true;

                if (CanChain(dominoes, used, usedCount + 1, startValue, left))
                {
                    return true;
                }

                used[i] = false;
            }
        }

        return false;
    }
}