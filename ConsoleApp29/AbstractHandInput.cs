using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp29
{
    abstract class AbstractHandInput : IHandsInput
    {
        abstract protected Hand[] RawHands();
        public Hand[] Hands()
        {
            if (RawHands().Length < 2)
            {
                throw new Exception("RawHands()の数が2より小さいです。");
            }
            return RawHands();
        }
    }
}
