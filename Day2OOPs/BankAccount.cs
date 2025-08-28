namespace Day2OOPs
{
    internal class BankAccount
    {
        //Properties
        private string accHolderName;
        private int accNumber;
        private string pan;


        //Constructors
        public BankAccount()
        {
            AccHolderName = string.Empty;
            AccNumber = 1111;
            Pan = string.Empty;
        }

        public BankAccount(string accHolderName, int accNumber, string pan)
        {
            AccHolderName = accHolderName;
            AccNumber = accNumber;
            Pan = pan;
        }


        //Getters and Setters
        public string AccHolderName
        {
            get { return accHolderName; }
            set 
            {
                if(value.Length > 0)
                {
                    accHolderName = value; 
                }
                else
                {
                    Console.WriteLine("Invalid Account Holder Name");
                }
            }
        }

        public int AccNumber
        {
            get { return accNumber; }
            set 
            {
                if(value > 0)
                {
                    accNumber = value;
                }
                else
                {
                    Console.WriteLine("Invalid Account Number");
                }
            }
        }

        public string Pan
        {
            get { return pan; }
            set { pan = value; }
        }



        public override string ToString()
        {
            return $"HolderName - {accHolderName} - Account Number - {accNumber} - PAN - {pan}";
        }
    }

    class SavingAccount : BankAccount
    {
        public int AccBalance { get; set; }
        public static double InterestRate = 7.25;

        public SavingAccount(string accHolderName, int accNumber, string pan, int accBalance)
            :base(accHolderName, accNumber, pan)
        {
            AccBalance = accBalance;
        }


        public override string ToString()
        {
            return base.ToString() + $" - Interest Rate - {InterestRate} - Balance - {AccBalance}";
        }

    }

    class BankSavingAccount
    {
        static void Main(string[] args)
        {
            SavingAccount savingAccount = new SavingAccount("Haripriya", 2222, "BUR10000", 1000);
            Console.WriteLine(savingAccount);

            SavingAccount savingAccount1 = new SavingAccount("", 0, "PHY10000", 1000);
            Console.WriteLine(savingAccount1);
            
        }
    }

}
