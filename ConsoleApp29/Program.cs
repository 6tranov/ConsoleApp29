using System;
using System.Linq;

namespace ConsoleApp29
{
    public enum Hand { Goo, Choki, Par };
    public enum Result { Win, Lose, Draw };
    class Program
    {
        static void Main(string[] args)
        {
            ///inputの設定
            AbstractHandInput input = new HandArrayInput(new Hand[] { Hand.Goo, Hand.Goo, Hand.Choki, Hand.Par });
            ///chainの設定
            Chain chain = new DrawChain();
            Chain noGooChain = new NoGooChain();
            Chain noChokiChain = new NoChokiChain();
            Chain noParChain = new NoParChain();
            chain.SetNext(noGooChain).SetNext(noChokiChain).SetNext(noParChain);
            ///outputの設定
            IResultPrint output = new ResultConsolePrint();

            var jr = new JankenOnce(input, chain, output);
            jr.Do();
        }
    }

}
