using System;
using System.Collections.Generic;
using System.Text;

namespace OOPC_Polymorphism_Animal
{
   class Animal
   {
      public virtual void Sound()
      {
         Console.WriteLine("");
      }
   }
   class Cat : Animal
   {
      public override void Sound()
      {
         Console.WriteLine("Meow");
      }
   }
   class Dog : Animal
   {
      public override void Sound()
      {
         Console.WriteLine("Bark");
      }
   }
   class Pig : Animal
   {
      public override void Sound()
      {
         Console.WriteLine("Oink");
      }
   }
   class Cow : Animal
   {
      public override void Sound()
      {
         Console.WriteLine("Moo");
      }
   }
   class Test
   {
      public static void Main()
      {
         Animal animal;
         animal = new Cat();
         animal.Sound();

         animal = new Pig();
         animal.Sound();

         animal = new Cat();
         animal.Sound();

         Animal[] animals = new Animal[4];
         animals[0] = new Cat();
         animals[1] = new Cow();
         animals[2] = new Pig();
         animals[3] = new Cow();

         foreach (Animal ani in animals)
         {
            ani.Sound();
         }

         Cat cat = new Cat();
         MakeManySound(cat, 3);
         MakeManySound(new Cow(), 2);
         MakeManySound(new Pig(), 2);

         Animal ani1 = CreateAnimal("cat");
         Animal ani2 = CreateAnimal("cow");
         Animal ani3 = CreateAnimal("cat");

         ani1.Sound();
         ani2.Sound();
         ani3.Sound();

      }

      public static Animal CreateAnimal(string type)
      {
         switch (type)
         {
            case "cat":
               return new Cat();

            case "pig":
               return new Pig();

            case "cow":
               return new Cow();

            default:
               return null;
         }
      }

      public static void MakeManySound(Animal animal, int times)
      {
         for (int i = 0; i < times; i++)
         {
            animal.Sound();
         }
      }

   }




}

