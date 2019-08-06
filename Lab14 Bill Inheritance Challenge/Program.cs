using System;

namespace Lab14_Bill_Inheritance_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Bill bill = new Bill();
            bill.Subtotal = 15.80;
            bill.TaxRate = 0.06;
            Pay(bill);

            TippableBill tip = new TippableBill();
            tip.Subtotal = 8.50;
            tip.TaxRate = 0.06;
            tip.Tip = 2.00;
            Pay(tip);
        }
        public static void Pay(Bill bill)
        {
            Console.WriteLine($"${bill.CalcTotal()}");
        }
    }
}
