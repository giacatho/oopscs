using System;
using System.Collections.Generic;
using System.Text;

namespace OOPC_Inheritance_No_Inheritence
   {
   public class CommissionEmployee
   {
      public CommissionEmployee(string name, string identityNumber, 
            double grossSales, double commisionRate) {
         Name = name;
         IdentityNumber = identityNumber;
         GrossSales = grossSales;
         CommissionRate = commisionRate;
      }

      public double Earnings() {
         return CommissionRate * GrossSales;
      }

      public string Name { get; set; }
      public string IdentityNumber { get; set; }
      public double GrossSales { get; set; }
      public double CommissionRate { get; set; }
   }

   public class BasePlusCommissionEmployee
   {
      public BasePlusCommissionEmployee(string name, string identityNumber,
            double grossSales, double commisionRate, double salary)
      {
         Name = name;
         IdentityNumber = identityNumber;
         GrossSales = grossSales;
         CommissionRate = commisionRate;
         Salary = salary;
      }

      public double Earnings()
      {
         return Salary + CommissionRate * GrossSales;
      }

      public string Name { get; set; }
      public string IdentityNumber { get; set; }
      public double GrossSales { get; set; }
      public double CommissionRate { get; set; }
      public double Salary { get; set; }
   }
}

namespace OOPC_Inheritance_Pre_Quiz_2
{
public class CommissionEmployee
{
   private string name;
   private string identityNumber;
   private double grossSales;
   private double commissionRate;

   public CommissionEmployee(
      string name, 
      string identityNumber,
      double grossSales, 
      double commisionRate)
   {
      this.name = name;
      this.identityNumber = identityNumber;
      this.grossSales = grossSales;
      this.commissionRate = commisionRate;
   }

   public double Earnings()
   {
      return commissionRate * grossSales;
   }
}

public class BasePlusCommissionEmployee
{
   private string name;
   private string identityNumber;
   private double grossSales;
   private double commissionRate;
   private double salary;
   public BasePlusCommissionEmployee(
      string name, 
      string identityNumber,
      double grossSales, 
      double commissionRate, 
      double salary)
   {
      this.name = name;
      this.identityNumber = identityNumber;
      this.grossSales = grossSales;
      this.commissionRate = commissionRate;
      this.salary = salary;
   }

   public double Earnings()
   {
      return salary + 
         commissionRate * grossSales;
   }
}
}

namespace OOPC_Inheritence_Plain
{
public class Employee
{
   private string name;
   private string identityNumber;
      
   public Employee() {}

      public Employee(string name, string identifyNumber) {
         Name = name;
         IdentityNumber = identifyNumber;
      }

      public string Name
   {
      get { return name; }
      set { name = value; }
   }
   public string IdentityNumber
   {
      get { return identityNumber; }
      set { identityNumber = value; }
   }
}

public class Test
{
   public static void Main()
   {
         //Employee e = new Employee();
         Employee emp = new Employee("John", "S1234568A");
      Console.WriteLine(emp.Name + " and " 
         + emp.IdentityNumber);
   }
}
}

namespace OOPC_Inheritance_Pre_Quiz_3
{
   

public class Employee
{
   private string name;
   private string identityNumber;
   private double grossSales;
   private double commissionRate;


   public Employee(
      string name,
      string identityNumber,
      double grossSales,
      double commissionRate)
   {
      this.name = name;
      this.identityNumber = identityNumber;
      this.grossSales = grossSales;
      this.commissionRate = commissionRate;
   }

public double GrossSales
{
   get { return grossSales;  }
   set { grossSales = value; }
}

public double CommissionRate
{
   get { return commissionRate; }
   set { commissionRate = value; }
}
}

//public class CommissionEmployee : Employee
//{
//   public double Earnings() {
//      return GrossSales * CommissionRate;
//   }
//}

//public class BasePlusCommissionEmployee : Employee
//{
//   private double salary;
//   public double Earnings()
//   {
//         return salary +
//            this.GrossSales;
//   }
//}
}


namespace OOPC_Inheritance_Pre_Quiz_Sol
{
   public class CommissionEmployee
   {
      public CommissionEmployee(string name, string identityNumber,
            double grossSales, double commisionRate)
      {
         Name = name;
         IdentityNumber = identityNumber;
         GrossSales = grossSales;
         CommissionRate = commisionRate;
      }

      public double Earnings()
      {
         return CommissionRate * GrossSales;
      }

      public string Name { get; set; }
      public string IdentityNumber { get; set; }
      public double GrossSales { get; set; }
      public double CommissionRate { get; set; }
   }

   public class BasePlusCommissionEmployee
   {
      public BasePlusCommissionEmployee(string name, string identityNumber,
            double grossSales, double commisionRate, double salary)
      {
         Name = name;
         IdentityNumber = identityNumber;
         GrossSales = grossSales;
         CommissionRate = commisionRate;
         Salary = salary;
      }

      public double Earnings()
      {
         return Salary + CommissionRate * GrossSales;
      }

      public string Name { get; set; }
      public string IdentityNumber { get; set; }
      public double GrossSales { get; set; }
      public double CommissionRate { get; set; }
      public double Salary { get; set; }
   }
}

namespace OOPC_Inheritance_Solution2
{
   public class CommissionEmployee
   {
      private string name;
      private string identityNumber;
      private double grossSales;
      private double commissionRate;

      public CommissionEmployee(
         string name,
         string identityNumber,
         double grossSales,
         double commisionRate)
      {
         this.name = name;
         this.identityNumber = identityNumber;
         this.grossSales = grossSales;
         this.commissionRate = commisionRate;
      }

      public string Name
      {
         get { return name; }
         set { name = value; }
      }

      public string IdentifyNumber
      {
         get { return identityNumber; }
         set { identityNumber = value; }
      }

      public double GrossSales
      {
         get { return grossSales; }
         set { grossSales = value; }
      }

      public double CommissionRate
      {
         get { return commissionRate; }
         set { commissionRate = value; }
      }

      public virtual double Earnings()
      {
         return CommissionRate * GrossSales;
      }
   }

   public class BasePlusCommissionEmployee :
         CommissionEmployee
   {
      private double salary;
      public BasePlusCommissionEmployee(
         string name,
         string identityNumber,
         double grossSales,
         double commissionRate,
         double salary) : base(name,
            identityNumber, grossSales,
            commissionRate)
      {
         this.salary = salary;
      }

      public double Salary
      {
         get { return salary; }
         set { salary = value; }
      }

      public override double Earnings()
      {
         return salary +
            CommissionRate * GrossSales;
      }
   }

namespace OOPC_Inheritance_Constructors
{
public class Employee
{
   private string name;
   private string identityNumber;
   private double grossSales;
   private double commissionRate;

   public Employee(
      string name,
      string identityNumber,
      double grossSales,
      double commisionRate)
   {
      this.name = name;
      this.identityNumber = identityNumber;
      this.grossSales = grossSales;
      this.commissionRate = commisionRate;
   }

   public string Name
   {
      get { return name; }
      set { name = value; }
   }

   public string IdentifyNumber
   {
      get { return identityNumber; }
      set { identityNumber = value; }
   }

   public double GrossSales
   {
      get { return grossSales; }
      set { grossSales = value; }
   }

   public double CommissionRate
   {
      get { return commissionRate; }
      set { commissionRate = value; }
   }
}

public class CommissionEmployee :
      Employee
{
   public CommissionEmployee(
      string name,
      string identityNumber,
      double grossSales,
      double commisionRate) :
         base(name, identityNumber,
            grossSales, commisionRate)
   { }

   public double Earnings()
   {
      return CommissionRate * GrossSales;
   }
}

public class BasePlusCommissionEmployee :
      Employee
{
   private double salary;
   public BasePlusCommissionEmployee(
      string name,
      string identityNumber,
      double grossSales,
      double commissionRate,
      double salary) : base(name,
         identityNumber, grossSales,
         commissionRate)
   {
      this.salary = salary;
   }

   public double Salary
   {
      get { return salary; }
      set { salary = value; }
   }

   public double Earnings()
   {
      return salary +
         CommissionRate * GrossSales;
   }
}
}
}
namespace OOPC_Inheritance_Class_Object
{
   public class Employee
   {
      private string name;

      public Employee(string name)
      {
         this.name = name;
      }

      public string Name
      {
         get { return name; }
         set { name = value; }
      }
   }

   public class Test
   {
      public static void Main()
      {
         Employee emp = new Employee("Alex");
         Console.WriteLine(emp.ToString());
      }
   }
}

namespace OOPC_Inheritance_Overload
{
class Number
{
   // Overloading
   public int add(int num1, int num2)
   {
      return num1 + num2;
   }

   public int add(int num1, int num2, int num3)
   {
      return num1 + num2 + num3;
   }
}

class Animal
{
   public virtual String sound()
   {
      return "";
   }
}

class Cat : Animal
{
   public override String sound()
   {
      return "meow";
   }
}

}