using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class SmsMessage
    {
        static void Main(string[] args)
        {
            SmsMessage sms = new SmsMessage("я невероятно люблю Сон Минги из эйтиз");
            sms.Send();
            Console.ReadKey(true);
        }

        private string sms;
        public string SMS
        {
            get
            {
                return sms;
            }
            set
            {
                sms = NormalizeMessageText(value);
            }
        }

        private double Price
        {
            get
            {
                return CalculatePrice();
            }
        }

        public SmsMessage(string sms)
        {
            SMS = sms;
        }
        public void Send()
        {
            Console.WriteLine($"было отправлено смс '{sms}' длиной, {sms.Length} кол-вом символов и стоимостью {Price} рублей");
        }

        private string NormalizeMessageText(string sms)
        {
            if (sms.Length > 250)
            {
                return sms.Substring(0, sms.Length - 250);
            }
            return sms;
        }

        private double CalculatePrice()
        {
            if (sms.Length < 65)
            {
                return 1.5;
            }
            else
            {
                int length = SMS.Length - 65;
                return 1.5 + length * 0.5;
            }
        }

    }
}
