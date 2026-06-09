namespace egitim_3tekrar
{
    struct Deneme1
    {
        public int D; //struct newlenirse bu fieldlar varsayılan değerleri alırlar
        public int MyProperty { get; set; }
        public int MyProperty2 { get; set; }
        public static int A = 5;
        public int AKA() { return 5; }
    }

    struct Dene
    {
        public int A { get; set; }
        public int B { get; set; }
    }

    class GetMember
    {
        public void X()
        {
            Deneme1 deneme1 = new Deneme1();
            Deneme1 deneme2;
            deneme2.D = 5;
            deneme2.MyProperty;
        }
    }
}
