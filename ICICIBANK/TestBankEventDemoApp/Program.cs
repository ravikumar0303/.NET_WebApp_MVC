using BankingLib;
using TaxPolicyLib;
using TaxHandlersLib;
Console.WriteLine("Welcome to State Bank of India !!");

TaxController controller = new TaxController();
CurrentAccount model = new CurrentAccount();
model.Balance = 90000;

//Event registration
//mapping event with event handlers
//Setting route for event to its respective event handlers

model.overBalance += controller.PayIncomeTax;
model.overBalance += controller.PayProfessionalTax;
model.overBalance += controller.PaySalesTax;




model.Deposit(350000);

Console.WriteLine("Latest Balance={0}", model.Balance);




