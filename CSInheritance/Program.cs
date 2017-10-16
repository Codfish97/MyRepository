using System;

namespace CSInheritance
{
    class Parent
    {
        public int Age { get; set; }

        public Parent()
        {
            Console.WriteLine("Parent Constructor");

        }

        public void Talk()
        {
            Console.WriteLine("Blah Blah Blah!");
        }

        public virtual void Work()
        {
            Console.WriteLine("Work Work Work");
        }
    }

    class Child : Parent
    {
        public void Study()
        {
            Console.WriteLine("I am studying");
        }

        public override void Work()
        {
            Console.WriteLine("Stop working and play.");
        }
    }

    class DriverClass
    {
        static void Main(string[] args)
        {
            Parent p1 = new Parent();
            p1.Talk();
            p1.Age = 35;
            Console.WriteLine("Parent age = {0}", p1.Age);

            Child c1 = new Child();
            c1.Work();


            Console.ReadLine();
        }
    }
}
