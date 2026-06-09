namespace egitim_3tekrar
{
    class StaticKeyword
    {
        public int pro { get; set; }
        public static int MyProperty { get; set; }
        public static int Topla() { return 5; }

        public static void TEST()
        {
            int a = 5;
            Topla(); //sadece static memberlar gelebilir.
        }

    }

    public static class TEST
    {
        //buradaki tüm memberlar static tanımlanmaktadır.
    }
}
