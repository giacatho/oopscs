using System;
using System.Collections.Generic;
using System.Text;

namespace OOPC_Polymorphism_ObjectReferences
{
   class Animal
   {
      public virtual void MakeNoise()
      {
         Console.WriteLine("Empty");
      }

      public virtual void Eat()
      {
         Console.WriteLine("Eat");
      }

      public virtual void Sleep()
      {
         Console.WriteLine("Sleep");
      }
   }

   class Cat : Animal
   {
      public override void MakeNoise()
      {
         Console.WriteLine("Meow");
      }

      public override void Eat()
      {
         Console.WriteLine("A cat eat small stuff");
      }

      public void CatchMouse()
      {
         Console.WriteLine("I can catch mouses");
      }
   }
   
   class Test
   {
      public static void Main()
      {
         Cat myCat1 = new Cat();
        
         Animal myCat2 = new Cat();
         
         Animal myAnimal; 
         
         myAnimal = new Animal();
         myAnimal.MakeNoise();

         myAnimal = new Cat();
         myAnimal.MakeNoise();

      }

      
   }




}

