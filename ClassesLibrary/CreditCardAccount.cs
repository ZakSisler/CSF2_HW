using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class CreditCardAccount
    {
        private int _accountNumber;
        //public Customer _customerInfo;//source control probs?
        private decimal _balance;
        private bool _isPastDue;
        private decimal _annualInterestRate;

        public int AccountNumber { get { return _accountNumber; } set { _accountNumber = value; } }
        //public Customer { get {return _customer; } set { _customer = value;} }
        public decimal Balance { get { return _balance; } set { _balance = value; } }
        public bool IsPastDue { get { return _isPastDue; } set { _isPastDue = value; } }
        public decimal AnnualInterestRate { get { return _annualInterestRate; } set { _annualInterestRate = value; } }

        public CreditCardAccount(int accountNumber, /*Customer customerInfo,*/ decimal balance, bool isPastDue, decimal annualInterestRate)
        {
            AccountNumber = accountNumber;
           //CustomerInfo = customerInfo;
            Balance = balance;
            IsPastDue = isPastDue;
            AnnualInterestRate = annualInterestRate;
        }

        public CreditCardAccount() { }

        public override string ToString()
        {
            //return base.ToString();
            return string.Format("Account Number: {0} \nCustomer Info:" /*{1}*/ + "\nBalance: {2} \nPast Due: {3} \nAnnual Interest Rate: {4}",
               AccountNumber,
               /*CustomerInfo,*/
               Balance,
               IsPastDue ? "Yes" : "No",
               AnnualInterestRate);
        }
    }
}
