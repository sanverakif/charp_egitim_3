using charp_egitim_3;

new GenericListWork().ListT();

#region anonim tip dynamic keyword
var anon = new
{
    sayi1 = 1,
    sayi2 = true,
    sayi3 = "3",
    sayi4 = 4,
};

void Dynma(dynamic x)
{
    Console.WriteLine(anon.sayi4);
}

Dynma(anon.sayi4);
#endregion

new NullConditional().Kontrol();
new NullCoalescing().Kontrol();

void XMetot()
{
    DatabaseType _databaseType = DatabaseType.SQL;
    DatabaseType vvv = (DatabaseType)Enum.Parse(typeof(DatabaseType), _databaseType.ToString());
    var asdasd = Enum.GetValues(typeof(DatabaseType));

    foreach (var item in asdasd)
    {
        Console.WriteLine(item);
    }
}


teststruct ccc = new teststruct();
ccc.age = 10;

StructWork sss = new StructWork();
sss.age = 15;

//sss.metotornek(); //hata verir newlenmesi gerek

