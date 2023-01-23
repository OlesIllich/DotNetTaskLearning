namespace immitation
{
    internal class Program
    {
        public class A
        {
            public virtual void Method()
            {
                Console.WriteLine("A");
            }
        }


        public class B : A
        {
            public virtual new void Method()
            { 
                Console.WriteLine("B");
            }
        }

        public class C : B
        {
            public override void Method()
            {
                Console.WriteLine("C");
            }
        }

        static void Main(string[] args)
        {
            A a = new B();
            B b = new B();
            B b2 = new C();
            A c = new C();
            a.Method();
            b.Method(); 
            b2.Method();
            c.Method();
            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());
            Console.WriteLine(b2.GetType());
            Console.WriteLine(c.GetType());

        }
    }
}