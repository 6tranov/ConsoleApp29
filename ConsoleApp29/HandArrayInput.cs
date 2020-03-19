using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp29
{
    class HandArrayInput : AbstractHandInput
    {
        private Hand[] HandArray { get; }
        public HandArrayInput(Hand[] handArray)
        {
            this.HandArray = handArray;
        }

        protected override Hand[] RawHands()
        {
            return HandArray;
        }
    }
}
