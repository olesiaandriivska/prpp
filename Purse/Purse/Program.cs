using System;

namespace Purse
{
    class Program
    {
        static void Main(string[] args)
        {
            Money.Money m = new Money.Money(Money.Money.Currency.USD, 200);
            m.PrintValue();
        }
    }
}
