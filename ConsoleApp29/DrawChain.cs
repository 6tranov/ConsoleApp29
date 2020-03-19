using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp29
{
    class DrawChain : Chain
    {

        protected override Result[] Do(Hand[] hands)
        {
            var result = new Result[hands.Length];
            for (int i = 0; i < hands.Length; i++)
            {
                result[i] = Result.Draw;
            }
            return result;
        }

        protected override bool Solvable(Hand[] hands)
        {
            var handSet = hands.ToHashSet();
            return handSet.Count == 1 || handSet.Count == 3;
        }
    }
}
