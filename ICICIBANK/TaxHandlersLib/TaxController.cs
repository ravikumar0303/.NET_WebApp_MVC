namespace TaxHandlersLib {  

    public class TaxController {

        public double PayIncomeTax(double amount) {

            double finalAmount = (0.70) * amount;
            Console.WriteLine("Deduting IncomeTax ={0}",finalAmount);
            return finalAmount;
            
        
        }

        public double PaySalesTax(double amount)
        {
            //setting tax 5%
            double finalAmount = (0.95) * amount;
            Console.WriteLine("Final Amount after deducting SalesTax={0}", finalAmount);
            return finalAmount;
        }


        public double PayProfessionalTax(double amount)
        {
            //setting tax 5%
            double finalAmount = (0.90) * amount;
            Console.WriteLine("Final Amount after deducting Professional Tax={0}", finalAmount);
            return finalAmount;
        }

    }

}