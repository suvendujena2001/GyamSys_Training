using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public abstract class IBank
    {
        public abstract void ValidateCard();
        public virtual void WithdrawMoney() {
            Console.WriteLine("Its the withdraw from abstract class");
        }
        public abstract void CheckBalanace();
        public abstract void BankTransfer();
        public abstract void MiniStatement();
    }
    public class AbstractionDemo
    {
        public static IBank GetBankObject(string bankType)
        {
            IBank BankObject = null;
            if (bankType == "SBI")
            {
                BankObject = new SBI();
            }
            else if (bankType == "AXIX")
            {
                BankObject = new AXIX();
            }
            return BankObject;
        }

        public class SBI : IBank
        {
            public override void BankTransfer()
            {
                Console.WriteLine("SBI Bank Bank Transfer");
            }
            public override void CheckBalanace()
            {
                Console.WriteLine("SBI Bank Check Balanace");
            }
            public override void MiniStatement()
            {
                Console.WriteLine("SBI Bank Mini Statement");
            }
            public override void ValidateCard()
            {
                Console.WriteLine("SBI Bank Validate Card");
            }
            public override void WithdrawMoney()
            {
                Console.WriteLine("SBI Bank Withdraw Money");
            }
        }
        public class AXIX : IBank
        {
            public override void BankTransfer()
            {
                Console.WriteLine("AXIX Bank Bank Transfer");
            }
            public override void CheckBalanace()
            {
                Console.WriteLine("AXIX Bank Check Balanace");
            }
            public override void MiniStatement()
            {
                Console.WriteLine("AXIX Bank Mini Statement");
            }
            public override void ValidateCard()
            {
                Console.WriteLine("AXIX Bank Validate Card");
            }
            public override void WithdrawMoney()
            {
                Console.WriteLine("AXIX Bank Withdraw Money");
            }
        }
    }

}
