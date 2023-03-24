using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z5
{
    class Program
    {
        static void Main(string[] args)
        {
            SmsMessage sms = new SmsMessage("я невероятно люблю Сон Минги из эйтиз", 95, 5, 0.2);
            sms.Send();
            Console.ReadKey(true);
        }

        class SmsMessage
        {
            private string sms;
            private int length;
            private double price;
            private double in_price;

            public string MessageText
            {
                get
                {
                    return sms;
                }
                set
                {
                    sms = NormalizeMessageText(value, length);
                }
            }

            public int MaxLength
            {
                get
                {
                    return length;
                }
                set
                {
                    length = value;
                }
            }

            public double nachStoimost
            {
                get
                {
                    return price;
                }
                set
                {
                    price = value;
                }
            }

            public double SymbolPrice
            {
                get
                {
                    return in_price;
                }
                set
                {
                    in_price = value;
                }
            }

            private double Price
            {
                get
                {
                    return CalculatePrice(price, in_price);
                }
            }

            public void Send()
            {

                Console.WriteLine($"было отправлено смс '{sms}' длиной, {sms.Length} кол-вом символов и стоимостью {Price} рублей");
            }

            private string NormalizeMessageText(string sms, int length)
            {
                if (sms.Length > length)
                {
                    return sms.Substring(0, sms.Length - length);
                }
                return sms;
            }

            private double CalculatePrice(double price, double in_price)
            {
                if (sms.Length < 65)
                {
                    return price;
                }
                else
                {
                    int length = MessageText.Length - 65;
                    return price + length * in_price;
                }
            }
            public SmsMessage(string sms, int dlina, double price, double in_price)
            {
                MessageText = sms;
                MaxLength = dlina;
                nachStoimost = price;
                in_price = this.in_price;
            }
        }
    }
}
