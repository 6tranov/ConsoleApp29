using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp29
{
    class HandListInput : AbstractHandInput
    {
        private List<Hand> HandList { get; }
        public HandListInput(List<Hand> handList)
        {
            this.HandList = handList;
        }

        protected override Hand[] RawHands()
        {
            return HandList.ToArray();
        }
    }
}
