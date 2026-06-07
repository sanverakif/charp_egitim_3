namespace test1
{
    public class A { }
}
namespace test2
{
    public class B { }
}



namespace test3
{
    public class CA : test1.A
    {
        public void x()
        {
            Console.WriteLine("");
        }
    }
}