using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes_03242016 {
    public class Program {
        public static void Main(string[] args) {
            //TaxPractice();
            //Console.ReadLine();
            //CustExceptionPractice();
            //Console.ReadLine();
            Console.ReadLine();
        }

        public static void CustExceptionPractice() {
            Customer gary = new Customer("Gary", "Jones");
            Customer annie = new Customer("Annie", "");
            Customer antoinette = new Customer(" ", "Antoinette");
        }

        public static void TaxPractice() {
            decimal result = 0m;
            result = CalculateTotalPriceWithTax(5.3m, 0.05m);
            Console.WriteLine(result);
        }

        public static decimal CalculateTotalPriceWithTax(decimal price, decimal taxRate) {
            if(price < 0) {
                throw new ArgumentOutOfRangeException("price", "price cannot be less than zero.");
            }
            if(taxRate < 0 || taxRate > 0.1m) {
                throw new ArgumentOutOfRangeException("taxRate", "taxRate cannot be less than zero or greater than 10%.");
            }
            return price * taxRate * 100;
        }
    }

    public class Customer {
        private string _firstName;

        public string FirstName {
            get { return _firstName; }
            set {
                if(string.IsNullOrWhiteSpace(value)) {
                    throw new ArgumentNullException("FirstName", "Customer's must have a first name.");
                }
                _firstName = value;
            }
        }

        private string _lastName;

        public string LastName {
            get { return _lastName; }
            set {
                if(string.IsNullOrWhiteSpace(value)) {
                    throw new ArgumentNullException("LastName", "Customer's must have a last name.");
                }
                _lastName = value;
            }
        }

        public Customer(string fName, string lName) {
            FirstName = fName;
            LastName = lName;
        }
    }
}
