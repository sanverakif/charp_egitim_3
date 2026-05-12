namespace charp_egitim_3
{
    struct StructWork
    {
        public int age;
        public string name { get; set; }
        public string nurmaname { get; set; }
        static public int sadasd { get; set; }
        public void metotornek() { Console.WriteLine("hello"); }
    }

    public class teststruct
    {
        public int age;
        public void deneme()
        {
            StructWork structWork = new StructWork()
            {
                name = "emre",
                nurmaname = "şanver"
            };

            StructWork structWork1 = new StructWork()
            {
                name = "emre",
                nurmaname = "şanver"
            };

            structWork1.Equals(structWork);
        }
    }
}
