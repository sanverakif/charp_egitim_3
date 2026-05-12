namespace charp_egitim_3
{
    //Static bir yapı içerisinde sadece statik yapılar çağrılabilir.
    //Örnek olarak static bir class varsa içerisindeki tüm memberlar static olmalıdır.
    static public class TestStaticClass
    {
        static public void TestMetot()
        {

        }
    }
    public class StaticKeywordWork
    {
        public int MyProperty { get; set; }
        static public int agefi;
        static public int Age { get; set; }
        static public void AgeMetot() { }

        static protected int kod { get; set; }

    }


    public class TestClassStatic : StaticKeywordWork
    {
        public void TestClass()
        {
            StaticKeywordWork staticKeywordWork = new StaticKeywordWork();
            staticKeywordWork.MyProperty = 15;

            StaticKeywordWork.Age = 15;

        }

    }

    public class AClass : StaticKeywordWork
    {
        public int say { get; set; }
        public int say2 { get; set; }

        public void aasdasd()
        {
            StaticKeywordWork keywordWork = new StaticKeywordWork();

        }
    }

    struct BClass
    {
        public int say { get; set; }
        public int say2 { get; set; }
    }
}
