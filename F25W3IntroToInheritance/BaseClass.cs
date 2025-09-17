using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F25W3IntroToInheritance
{
    public class BaseClass
    {
        private int myPrivateVar;
        protected int myProtectedVar;
        public int myPublicVar;

        public BaseClass()
        {
            Console.WriteLine("Base class constructor called");
        }

        public BaseClass(string msg)
        {
            Console.WriteLine("Base class constructor with msg: " + msg);
        }
    }

    class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            Console.WriteLine("Derived class constructor called");
        }

        public DerivedClass(string msg) : base(msg)
        {
            Console.WriteLine("Derived class constructor with msg: " + msg);
        }

        public void MyMethod()
        {
            //myPrivateVar = 1;
            myProtectedVar = 2;
            myPublicVar = 3;
        }
    }
}
