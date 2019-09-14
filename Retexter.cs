//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            Console.WriteLine("Hello, world!");

            //C# can infer variable types.
            var meaningOfLife = 42;
            var smallPi = 3.14;
            var bigPi = 3.14159265359;
            var vaporWare = "Half Life 3";
            //const var likesPizza = true; - This will throw an error: You cannot make a variable with an inferred type constant.
            const bool likesPizza = true;
            //This creates an array of strings.
            string[] writers = { "Anthony", "Brian", "Eric", "Sean" };
            //This creates an array of strings with a capacity of 5 elements.
            string[] editors = new string[5];
            //This prints the third element in the array to the console.
            Console.WriteLine(writers[2]);
            //This replaces the first element in the array.
            writers[0] = "Ray";
            //If likesPizza is false, prints the message to the console.
            if (likesPizza == false)
            {
                Console.WriteLine("You monster!");
            }
            //This is another way to write an "If" statement.
            bool isMonster = (likesPizza == true) ? false : true;
            //The "for" loop initializes the variable i and sets it to 0; it then counts up by 1 each time the loop runs until i = 10.
            //It will write the message 10 times in the console.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("C# Rocks!");
            }
            //This "for" loop will write all of the elements in the writers array to the console, using the capacity of the array to determine how many times to loop.
            for (int i = 0; i < writers.Length; i++)
            {
                string writer = writers[i];
                Console.WriteLine(writer);
            }
            //"foreach" loops are useful for arrays.
            foreach (string writer in writers)
            {
                Console.WriteLine(writer);
            }
            if (meaningOfLife == 42)
            {
                bool inScope = true;
            }
            //inScope = false; - This will throw an error, because the variable "inScope" was defined within the scope of the "if" statement, and therefore does not exist outside of it.
            //This creates an instance of the struct.
            Point2D myPoint = new Point2D();
            //You can set the values of the instance by referencing its instance name.
            myPoint.X = 10;
            myPoint.Y = 20;
            Point2D anotherPoint = new Point2D();
            anotherPoint.X = 5;
            anotherPoint.Y = 15;
            //This will add the two points together.
            myPoint.AddPoint(anotherPoint);
            Console.WriteLine(myPoint.X);
            Console.WriteLine(myPoint.Y);
            //This creates another instance of Point2D based on myPoint.
            Point2D yetAnotherPoint = myPoint;
            //Then we can change any of the values while keeping the others the same.
            yetAnotherPoint.X = 100;
            Console.WriteLine(myPoint.X);
            Console.WriteLine(yetAnotherPoint.X);
            //This creates an instance of Point2DRef named pointRef and sets its X value to 20.
            Point2DRef pointRef = new Point2DRef();
            pointRef.X = 20;
            //This creates an instance of Point2DRef named anotherRef and sets its X value to 25.
            Point2DRef anotherRef = pointRef;
            anotherRef.X = 25;
            //When you assign null to a variable, the object is no longer accessible.
            //However, because there is another reference to pointRef, it is still in memory and thus accessible.
            pointRef = null;
            anotherRef.X = 125;
            Console.WriteLine(anotherRef.X);
            //Now that there are no more references to the object, garbage collection can occur, which removes objects from memory that do not have any references.
            anotherRef = null;
            RenFairePerson person = new RenFairePerson();
            person.Name = "Igor the Ratcatcher";
            person.SayHello();
        }
    }
    //Public variables can be referenced outside of the object in which they were defined.
    struct Point2D
    {
        public int X;
        public int Y;
        //Methods have return types; "void" indicates this method has no return. The parentheses contain the parameter(s) (if any) being passed into the method. 
        public void AddPoint(Point2D anotherPoint)
        {
            //This method is adding two points together.
            this.X = this.X + anotherPoint.X;
            this.Y = this.Y + anotherPoint.Y;
        }
    }
    //Structs are value types and classes are reference types. Classes are meant to last longer than structs.
    class Point2DRef
    {
        public int X;
        public int Y;
        public void AddPoint(Point2DRef anotherPoint)
        {
            this.X = this.X + anotherPoint.X;
            this.Y = this.Y + anotherPoint.Y;
        }
    }
    class Person
    {
        public string Name;
        //The method is marked virtual because it will be overridden.
        public virtual void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
    //The RenFairPerson method extends the Person class.
    class RenFairePerson : Person
    {
        public override void SayHello()
        {
            //"base" calls to the original method.
            base.SayHello();
            Console.Write("Huzzah!");
        }
    }
}