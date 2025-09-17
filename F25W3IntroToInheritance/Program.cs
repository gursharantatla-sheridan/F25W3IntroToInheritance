namespace F25W3IntroToInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BaseClass objBase = new BaseClass();
            //objBase.myPublicVar = 1;
            ////objBase.myProtectedVar = 2;

            DerivedClass objDerived = new DerivedClass("hello");
            //objDerived.myPublicVar = 2;
        }
    }
}
