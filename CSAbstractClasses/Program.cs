using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAbstractClasses
{
    sealed class MyClass
    {
        private void Howdy()
        {
            Console.WriteLine("Hello from MyClass");
        }
    }

    interface TestInterface
    {
        void getMethod();
        string getName();

    }

    abstract class TestAbstractClass
    {
        int i = 4;
        int k = 3;
        public abstract void getClassName();
        public void HelloFromAbstract()
        {
            Console.WriteLine("Some Method");
        }
    }

    class Program : TestAbstractClass, TestInterface
    {
        static void Main(string[] args)
        {


            Console.ReadLine();
        }

        public override void getClassName()
        {
            Console.WriteLine("Programming Class");
        }

        public void getMethod()
        {
            Console.WriteLine("Get Method");
        }

        public string getName()
        {
            return "some name";
        }
    }

    class Test1 : MyClass 
    {
        
        public void Example()
        {
            MyClass mc1 = new MyClass();
            //Howdy();
            Console.WriteLine("Hello");
        }
    }
}
