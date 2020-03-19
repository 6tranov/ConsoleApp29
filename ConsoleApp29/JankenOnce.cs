using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp29
{
    class JankenOnce
    {

        private AbstractHandInput HI { get; }
        private Chain Chain { get; }
        private IResultPrint IRP { get; }

        public JankenOnce(AbstractHandInput hi, Chain chain, IResultPrint irp)
        {
            this.HI = hi;
            this.Chain = chain;
            this.IRP = irp;
        }
        public void Do()
        {
            var hands = HI.Hands();
            var results = Chain.Support(hands);
            IRP.Print(results);
        }
    }
}
