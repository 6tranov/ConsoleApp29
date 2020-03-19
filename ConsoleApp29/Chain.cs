using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp29
{
    abstract class Chain
    {
        protected Chain NextChain { get; private set; }
        public Chain SetNext(Chain chain)
        {
            this.NextChain = chain;
            return this.NextChain;
        }
        protected abstract bool Solvable(Hand[] hands);
        protected abstract Result[] Do(Hand[] hands);
        public Result[] Support(Hand[] hands)
        {
            if (Solvable(hands))
            {
                return Do(hands);
            }
            else if (NextChain != null)
            {
                return NextChain.Support(hands);
            }
            else
            {
                throw new NullReferenceException("Next chain is null");
            }
        }
    }
}
