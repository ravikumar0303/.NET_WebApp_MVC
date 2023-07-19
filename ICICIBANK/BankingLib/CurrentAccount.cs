using TaxPolicyLib;
namespace BankingLib {

    public class CurrentAccount {


        public event TaxOperation overBalance;

        public double Balance { get; set; }

        public void Deposit(double amount) { 
        
        this .Balance = this .Balance + amount;

            if (this.Balance >= 200000) {

                this.Balance = overBalance(this.Balance);

            }     
        
        }
        public void WithDraw(double amount) {

            this.Balance = this.Balance - amount;
        }

    
    }


}