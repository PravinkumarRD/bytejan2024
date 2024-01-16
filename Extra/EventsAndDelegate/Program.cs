namespace EventsAndDelegate
{
    //Account
    internal class Program
    {
        //ATM Machine
        static void Main(string[] args)
        {
            Account account = new Account();
            account.SendSMS += SendSmsToClient;
            account.SendWhatsAppMessage += SendWhatsAppMessageToClient;
            account.SendWhatsAppMessage += SendMarkingWhatsAppMessageToClient;
            account.PrintTransSlip += PrintSlipOfClient;
            //Aryajeet
            //account.SendSMS -= SendSmsToClient;
            account.PrintTransSlip -= PrintSlipOfClient;

            account.Debit(10000);
        }

        private static void PrintSlipOfClient()
        {
            Console.WriteLine("This is your transaction Slip!");
        }
        private static void SendSmsToClient()
        {
            Console.WriteLine("This is your transaction SMS!");
        }
        private static void SendWhatsAppMessageToClient()
        {
            Console.WriteLine("This is your transaction WhatsApp Message!");
        }
        private static void SendMarkingWhatsAppMessageToClient()
        {
            Console.WriteLine("This is your Marketing WhatsApp Message!");
        }
    }
}
