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