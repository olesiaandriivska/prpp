using System;
using NSMoney;
using NSBusinessCard;
using Cc;

namespace NSPurse
{
    
    class Purse
    {
        static void Main(string[] args)
        {
            Money m = new Money(Money.Currency.USD, 200);

            m.PrintValue();

            BusinessCard bs = new BusinessCard();

            bs.BCFunc();


            CreditCard _cc = new CreditCard();
            CreditCard.Test();


        }
    }
}
