using BankingLib;
using TaxHandlersLib;
using TaxPolicyLib;

Account acct=new Account();
acct.Balance=89000;
double amount=45000;
TaxController controller=new TaxController();
acct.Deposit(amount);
Console.WriteLine(" Balance={0}",acct.Balance);
//Direct Call
//Early Binding
//Static Linking (Compile time function call is resolved)
//Association of PayIncomeTax at Compile Time
Console.WriteLine("Static linked function invocation");
double calculatedAmount=controller.PayIncomeTax(acct.Balance);

//Dynamic Linking
//Indirect Call (At runtime function call is resolved)
//Late Binding

//Dynamic association of PayIncomeTax method(at runtime)
TaxOperation operation1=new TaxOperation(controller.PayIncomeTax);
TaxOperation operation2=new TaxOperation(controller.PaySalesTax);
TaxOperation operation3=new TaxOperation(controller.PayProfessionalTax);

TaxOperation managingOperation=operation1;
managingOperation+=operation2;
managingOperation+=operation3;


//Indirect Call
//double latestCaluculatedValue=operation1(acct.Balance);
Console.WriteLine("Dynamic linked function invocation (Runtime)");

double latestCaluculatedValue=managingOperation(acct.Balance);
acct.Balance=latestCaluculatedValue;
Console.WriteLine("Remaining  Balance={0}",acct.Balance);

managingOperation-=operation3;
latestCaluculatedValue=managingOperation(acct.Balance);
acct.Balance=latestCaluculatedValue;
Console.WriteLine("Remaining  Balance={0} ",acct.Balance,56);
