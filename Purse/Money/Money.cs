using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSMoney
{
    public class Money
    {
        public enum Currency
        {
            USD,
            EUR,
            RUB,
            UAH
        }
        Currency _cur;
        decimal _value;


        public Money(Currency currency, decimal value)
        {
            _cur=currency;
            _value=value;
        }

        public void PrintValue()
        {
            Console.WriteLine(_value.ToString() + _cur.ToString());
        }


    }
}
