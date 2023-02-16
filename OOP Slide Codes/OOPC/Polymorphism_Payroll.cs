using System;
using System.Collections.Generic;
using System.Text;

namespace OOPCS_Polymorphism_Payroll
{
   public class Employee
   {
      public string Name { get; }
      public Employee(string name)
      {
         Name = name;
      }
      public virtual double Earnings()
      {
         return 0;
      }
   }

   class SalaryEmployee : Employee
   {
      public double Salary { get; }
      public SalaryEmployee(
         string name,
         double salary) : base(name)
      {
         Salary = salary;
      }
      public override double Earnings()
      {
         return Salary;
      }
   }

   class HourlyEmployee : Employee
   {
      public double WagePerHour { get; }
      public double Hours { get; }
      public HourlyEmployee(
         string name,
         double wagePerHour,
         double hours) : base(name)
      {
         WagePerHour = wagePerHour;
         Hours = hours;
      }
      public override double Earnings()
      {
         return WagePerHour * Hours;
      }
   }

   class CommissionEmployee : Employee
   {
      public double CommissionRate { get; }
      public double Sales { get; }
      public CommissionEmployee(
         string name,
         double commisionRate,
         double sales) : base(name)
      {
         CommissionRate = commisionRate;
         Sales = sales;
      }

      public override double Earnings()
      {
         return CommissionRate * Sales;
      }
   }

   class SalaryCommisionEmployee : CommissionEmployee
   {
      public double Salary { get; }
      public SalaryCommisionEmployee(
         string name,
         double salary,
         double commisionRate,
         double sales) : base(name, commisionRate, sales)
      {
         Salary = salary;
      }

      public override double Earnings()
      {
         return Salary + base.Earnings();
      }
   }

   public class PayCalculator
   {
      private Employee[] employees;

      public PayCalculator(Employee[] employees)
      {
         this.employees = employees;
      }

      public double CalculatePay()
      {
         double totalPay = 0;
         foreach (Employee e in employees)
         {
            totalPay += e.Earnings();
         }

         return totalPay;
      }
   }

   public class Test
   {
      public static void Main()
      {
         Employee[] emps = new Employee[5];
         emps[0] = new SalaryEmployee("A", 5000);
         emps[1] = new SalaryEmployee("B", 4000);
         emps[2] = new HourlyEmployee("C", 20, 100);
         emps[3] = new CommissionEmployee("D", 0.1, 30000);
         emps[4] = new SalaryCommisionEmployee("E", 2000, 0.2, 10000);

         PayCalculator calculator = new PayCalculator(emps);
         Console.WriteLine(calculator.CalculatePay());
      }
   }

}

