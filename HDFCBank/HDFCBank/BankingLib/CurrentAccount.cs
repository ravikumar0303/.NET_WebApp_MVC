namespace BankingLib;
using TaxPolicyLib;


public class CurrentAccount
{

    public event TaxOperation overBalance;

    public double Balance{get;set;}
    public void Deposit(double amount){
        this.Balance=this.Balance+amount;
        if(this.Balance >=250000){
            //Tax should be deducted from Balance
            //raise an event called overBalance
           this.Balance= overBalance(this.Balance);
        }
    }

    public void WithDraw(double amount){
        this.Balance=this.Balance-amount;
    }

}
