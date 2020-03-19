using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp29
{
    class NoGooChain : Chain
    {
        protected override Result[] Do(Hand[] hands)
        {
            var result = new Result[hands.Length];
            for (int i = 0; i < hands.Length; i++)
            {
                if (hands[i] == Hand.Choki)
                {
                    result[i] = Result.Win;
                }
                else if (hands[i] == Hand.Par)
                {
                    result[i] = Result.Lose;
                }
                else
                {
                    throw new Exception("エラー");
                }
            }
            return result;
        }

        protected override bool Solvable(Hand[] hands)
        {
            return !hands.Contains(Hand.Goo);
        }
    }
}
