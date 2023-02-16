using System;
using System.Collections.Generic;
using System.Text;

namespace OOPC_Workshop_Inheritence_BankApp
{

   public class Account
   {
      // Attributes
      private string acctNumber;
      private string acctHolderId;
      protected double balance;

      // Constructor
      public Account(string number, string holder, double bal)
      {
         acctNumber = number;
         acctHolderId = holder;
         balance = bal;
      }

      // Properties
      public string AccountNumber
      {
         get
         {
            return acctNumber;
         }
      }
      public string AccountHolderId
      {
         get
         {
            return acctHolderId;
         }
         set
         {
            acctHolderId = value;
         }
      }
      public double Balance
      {
         get
         {
            return balance;
         }
         protected set
         {
            balance = value;
         }
      }

      // Methods
      public void Deposit(double amount)
      {
         balance = balance + amount;
      }

      public virtual bool Withdraw(double amount)
      {
         balance = balance - amount;
         return true;
      }

      public bool TransferTo(double amount, Account another)
      {
         if (Withdraw(amount))
         {
            another.Deposit(amount);
            return true;
         }
         else
         {
            return false;
         }
      }

      public virtual double CalculateInterest()
      {
         return 0;
      }

      public void CreditInterest()
      {
         Deposit(CalculateInterest());
      }

      public override string ToString()
      {
         string m = String.Format
               ("[BankAccount:accountNumber={0},accountHolder={1},balance={2}]",
                        AccountNumber, AccountHolderId, Balance);
         return m;
      }
   }

   public class SavingsAccount : Account
   {
      private static double interestRate = 1;

      public SavingsAccount(string number, string holder, double bal)
          : base(number, holder, bal) { }

      public override double CalculateInterest()
      {
         return Balance * interestRate / 100;
      }

      public override bool Withdraw(double amount)
      {
         if (amount < Balance)
            return (base.Withdraw(amount));
         else
         {
            Console.WriteLine("Cannot withdraw");
            return (false);
         }
      }

      public override string ToString()
      {
         string m = String.Format("[SavingsAccount:accountNumber={0},accountHolder={1},balance={2}]",
             AccountNumber, AccountHolderId, Balance);
         return m;
      }

   }

   public class CurrentAccount : Account
   {
      private static double interestRate = 0.25;

      public CurrentAccount(string number, string holderId, double bal)
          : base(number, holderId, bal)
      {
      }

      public override double CalculateInterest()
      {
         return (Balance * interestRate / 100);
      }

      public override bool Withdraw(double amount)
      {
         if (amount < Balance)
            return (base.Withdraw(amount));
         else
         {
            Console.WriteLine("Cannot withdraw");
            return false;
         }
      }

      public override string ToString()
      {
         string m = String.Format("[CurrentAccount:accountNumber={0},accountHolder={1},balance={2}]",
             AccountNumber, AccountHolderId, Balance);
         return (m);
      }
   }

   public class OverdraftAccount : Account
   {
      private static double interestRate = 0.25;
      private static double overdraftInterest = 6;

      public OverdraftAccount(string number, string holderId, double bal)
          : base(number, holderId, bal)
      {
      }

      public override bool Withdraw(double amount)
      {
         balance = balance - amount;
         return true;
      }

      public override double CalculateInterest()
      {
         if (Balance > 0)
            return (Balance * interestRate / 100);

         else
            return (Balance * overdraftInterest / 100);
      }

      public override string ToString()
      {
         string m = String.Format("[OverdraftAccount:accountNumber={0},accountHolder={1},balance={2}]",
             AccountNumber, AccountHolderId, Balance);
         return (m);
      }

   }

   public class Test
   {
      public static void Main()
      {
         Account savingAccount = new SavingsAccount("S0000111", "S1111111A", 2000);
         Console.WriteLine(savingAccount.ToString());
         Console.WriteLine("Interest: {0}", savingAccount.CalculateInterest());
         savingAccount.CreditInterest();
         Console.WriteLine(savingAccount.ToString());
         savingAccount.Withdraw(3000);
         Console.WriteLine();

         CurrentAccount currentAccount = new CurrentAccount("S0000333", "S3333333B", 2000);
         Console.WriteLine(currentAccount.ToString());
         Console.WriteLine("Interest: {0}", currentAccount.CalculateInterest());
         currentAccount.CreditInterest();
         Console.WriteLine(currentAccount.ToString());
         currentAccount.Withdraw(3000);
         Console.WriteLine();

         OverdraftAccount overdraftAccount1 = new OverdraftAccount("S0000222", "S2222222B", 2000);
         Console.WriteLine(overdraftAccount1.ToString());
         Console.WriteLine("Interest: {0}", overdraftAccount1.CalculateInterest());
         overdraftAccount1.CreditInterest();
         Console.WriteLine(overdraftAccount1.ToString());
         overdraftAccount1.Withdraw(3000);
         Console.WriteLine(overdraftAccount1.ToString());
         Console.WriteLine();

         OverdraftAccount overdraftAccount2 = new OverdraftAccount("S0000222", "S2222222B", -2000);
         Console.WriteLine(overdraftAccount2.ToString());
         Console.WriteLine("Interest: {0}", overdraftAccount2.CalculateInterest());
         overdraftAccount2.CreditInterest();
         Console.WriteLine(overdraftAccount2.ToString());
         Console.WriteLine();

         Console.ReadLine();
      }
   }
}
