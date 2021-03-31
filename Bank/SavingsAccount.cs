namespace Bank
{
    public class SavingsAccount
    {
        static float annualInterest;
        static float AnnualInterestRate { get {return annualInterest;} 
                                            set { if (value >= 0) {annualInterest = value;} } 
                                        }
        private double savingBalance;
        public double SavingBalance
        {
            get { return savingBalance; }
            private set { if (value > 0) {savingBalance = value;} }
        }

        public SavingsAccount(double saving, float annualInterestRate = 0)
        {
            AnnualInterestRate = annualInterestRate;
            SavingBalance = saving;
        }

        public static void ModifyInterestRate(float rate)
        {
            AnnualInterestRate = rate;
        }

        public void CalculateMonthlyInterest()
        {
            savingBalance = AnnualInterestRate * savingBalance / 1200 + savingBalance;
        }
        

    }
}