using System;
using System.Collections.Generic;
using System.Text;

namespace OOPC
{

class TestStaticMethods
   {
public static void Main()
{
   MyMath myMath = new MyMath();
   Console.WriteLine(myMath.Abs(-3));

   MyString myString = new MyString();
   Console.WriteLine(myString.
      Concatenate("Hello", "DipSA"));
}
   }

class MyMath
{
   public double Abs(double n)
   {
      if (n > 0) return n;
      return -n;
   }
}

class MyString
{
   public string Concatenate(
      string s1, string s2)
   {
      return s1 + " " + s2;
   }
}

   class SomeClass1
{
   public static void AStaticMethod()
   {
      // Implementation
   }
}

class SomeClass2
{
   public static void Method1()
   {
      SomeClass1.AStaticMethod();
   }
   public static void Method2()
   {
      SomeClass1.AStaticMethod();
   }
}



class TestStaticVariables
{
public static void Main()
{
   SavingsAccount sa1 = new SavingsAccount(
      "Harry Potter", 1000f);
   SavingsAccount sa2 = new SavingsAccount(
      "Ron Weasley", 500f);

   sa1.EarnInterest();
   sa2.EarnInterest();

   sa1.Print();
   sa2.Print();

   SavingsAccount.basisInterestRate = 0.1f;
   SavingsAccount sa3 = new SavingsAccount(
      "Albus Dumbledore", 1000f);
   SavingsAccount sa4 = new SavingsAccount(
      "You Know Who", 500f);

   sa3.EarnInterest();
   sa4.EarnInterest();

   sa3.Print();
   sa4.Print();
      }
}

public class SavingsAccount
{
   public static float basisInterestRate = 0.05f;

   private string name;
   private float balance;

   public SavingsAccount(string name, float initBalance)
   {
      this.name = name;
      this.balance = initBalance;
   }

   public void EarnInterest()
   {
      balance = balance + balance * basisInterestRate;
   }

   public void Print()
   {
      Console.WriteLine("SavingsAccount[name=" + name 
         + ", balance=" + balance + "]");
   }
}

class TestThisReference
{
   public static void Main()
   {
      //ThisReferenceExample ex =
      //      new ThisReferenceExample(1);
      //ThisReferenceExample2 ex =
      //   new ThisReferenceExample2(1);
      //ex.Method1();

      new ThisReferenceExample3().Print();
      new ThisReferenceExample3(2).Print();

      //Car car = new Car("Audi A4");
      //Driver driver = new Driver("Alex");
      //driver.BuyCar(car);

      //Console.WriteLine("Driver name: " +
      //   driver.Name);
      //Console.WriteLine("Car model: " +
      //   car.Model + " and owner: " +
      //   car.Owner.Name);

    }
   }

public class Car
{
   public Car(string model)
   {
      Model = model;
   }

   public string Model {set; get;}

   public Driver Owner {set; get;}
}

public class Driver
{
   public Driver(string name)
   {
      Name = name;
   }

   public string Name {set; get;}

   public Car MyCar {set; get;}

   public void BuyCar(Car car)
   {
      MyCar = car;
      MyCar.Owner = this;
   }
}

   class ThisReferenceExample
   {
      private int number;

      public ThisReferenceExample(int number)
      {
         this.number = number;
      }
      public void Method1()
      {
         Console.WriteLine("Start Method1");
         this.Method2();
      }
      public void Method2()
      {
         Console.WriteLine("Start Method2");
         Console.WriteLine(this.number);
      }
   }

   class ThisReferenceExample2
   {
      private int number;

      public ThisReferenceExample2(int number)
      {
         number = number;
      }
      public void Method1()
      {
         Console.WriteLine("Start Method1");
         Method2();
      }
      public void Method2()
      {
         Console.WriteLine("Start Method2");
         Console.WriteLine(number);
      }
   }

   class ThisReferenceExample3
   {
      private int number1;
      private int number2;
      public ThisReferenceExample3() 
         : this(-1, 1)
      {
      }
      public ThisReferenceExample3(int number1) 
         : this(number1, 1)
      {
      }
      public ThisReferenceExample3(
            int number1, int number2)
      {
         this.number1 = number1;
         this.number2 = number2;
      }
      public void Print()
      {
         Console.WriteLine("number1 is " + 
            number1 + " and number2 is " + number2);
      }
   }




   class TestPassArguments
   {
   /*
      public static void Main()
      {
         int num = 1;

         changeValue(num);
         Console.WriteLine("After calling the method, " +
            " num is " + num);
      }

      public static void changeValue(int n)
      {
         n = n + 1;
         Console.WriteLine("n is " + n);
      }
   */
public static void Main()
{
   Student student = new Student("Monica");
   Console.WriteLine("Before calling the method, " +
      "name is " + student.Name);
            
   ChangeValue(student);
   Console.WriteLine("After calling the method, " +
      " name is " + student.Name);
}

public static void ChangeValue(Student student) 
{
   student.Name = "Phoebe";
   Console.WriteLine(student.Name);
}

   }

class Person
{
   private string name;
   private string country;
   private int age;
   // Getters and Setters
      
   public static void Main() {
      Person person1 = new Person();
      person1.SetName("Arian");
      person1.SetCountry("USA");
      person1.SetAge(24);

      Person person2 = new Person();
      person2.SetName("Bryan");
      person2.SetAge(20);

      Person person3 = person1;
   }

      public string GetName() {
         return name;
      }

      public void SetName(string name) {
         this.name = name;
      }

      public string GetCountry() {
         return country;
      }

      public void SetCountry(string country) {
         this.country = country;
      }
      
      public void SetAge(int age) {
         this.age = age;
      }

      public int GetAge() {
         return age;
      }

   }

class Student {
   private string name;
   public Student(string name) {
      this.name = name;
   }
   public string Name {
      get {
         return name;
      }
      set {
         name = value;
      }
   }
}

class TestAlias { 
   public static void Main() {
      Student student1 = new Student("Chandler");
      Student student2 = new Student("Joey");

      student2 = student1;
      student2.Name = "Ross";

      Console.WriteLine(student1.Name);
      Console.WriteLine(student2.Name);
   }
}

    
}

namespace OOPC_ObjectConcepts_this
{
public class Circle
{
   private double radius;
   public Circle(double radius)
   {
      this.radius = radius;
   }

   public Circle() : this(0.0) {
      // More code can be executed here   
   }

   public double GetArea()
   {
      return this.radius * 
            this.radius * Math.PI;
   }

   public void Print()
   {
      Console.WriteLine(
         "radius: {0}, area: {1}", 
            this.radius, this.GetArea());
   }
}

public class Circle2
{
   private double radius;

   public double GetArea()
   {
      return radius *
            radius * Math.PI;
   }

   public void Print()
   {
      Console.WriteLine(
         "radius: {0}, area: {1}",
            radius, GetArea());
   }
}
}