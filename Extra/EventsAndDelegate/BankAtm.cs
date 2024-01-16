using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegate
{
    public delegate void LetterBox();
    internal class Account
    {
        public event LetterBox SendSMS;
        public event LetterBox SendWhatsAppMessage;
        public event LetterBox PrintTransSlip;
        public int AccountNo { get; set; }
        public double TotalBalance { get; set; }
        public bool Debit(double amount)
        {
            TotalBalance=TotalBalance-amount;
            if (SendSMS!=null)
            {
                SendSMS();
            }
            if (SendWhatsAppMessage!=null)
            {
                SendWhatsAppMessage();
            }
            if (PrintTransSlip!=null)
            {
                PrintTransSlip();
            }
            return true;
        }
    }
}
