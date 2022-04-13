using System;
using NSMoney;


namespace Purse
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Money m = new Money(Money.Currency.USD, 200);

            m.PrintValue();
        }
    }
}
