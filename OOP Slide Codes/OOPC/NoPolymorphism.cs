using System;

namespace OOPC.NoPolymorphism
{
public class Employee
{
   public string Name 
   { 
      set; get; 
   }
   public Employee(string name)
   {
      Name = name;
   }
   public virtual double Earnings()
   {
      return 0;
   }
}

public class SalariedEmployee : Employee
{
   public double WeeklySalary { 
      get; set; 
   }

   public SalariedEmployee(
      string name, double weeklySalary)
                        : base(name) {
      WeeklySalary = weeklySalary;
   }

   public override double Earnings() {
      return WeeklySalary;
   }
}

public class HourlyEmployee : Employee
{
   public double WagePerHour { 
      set; get; 
   }
   private double Hours { 
      set; get; 
   }

   public HourlyEmployee(
         string name, 
         double wagePerHour, 
         double hours)
               : base (name)
   {
      WagePerHour = wagePerHour;
      Hours = hours;
   }
   public override 
         double Earnings()
   {
      return WagePerHour * Hours;
   }
}

public class PayCalculator
{
   private SalariedEmployee[] salariedEmployees;
   private HourlyEmployee[] hourlyEmployees;
   //...

      public PayCalculator(SalariedEmployee[] salariedEmployees,
          HourlyEmployee[] hourlyEmployees)
      {
         this.salariedEmployees = salariedEmployees;
         this.hourlyEmployees = hourlyEmployees;
      }

      public double CalculatePay()
      {
         double totalPay = 0;

         foreach (SalariedEmployee se in salariedEmployees)
         {
            totalPay += se.Earnings();
         }

         foreach (HourlyEmployee he in hourlyEmployees)
         {
            totalPay += he.Earnings();
         }

         return totalPay;
      }
   }

   class NoPolymorphismTest
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Let's test our pay calculator!");
         SalariedEmployee[] salariedEmployees =
         {
            new SalariedEmployee("Aaron", 1000),
            new SalariedEmployee("Bryan", 1500)
        };

         HourlyEmployee[] hourlyEmployees =
         {
            new HourlyEmployee("Chris", 30, 30),
            new HourlyEmployee("Diana", 20, 40)
        };

         PayCalculator payCalculator = new PayCalculator(salariedEmployees, hourlyEmployees);
         Console.WriteLine(payCalculator.CalculatePay());


         Console.ReadKey();
      }
   }


}
