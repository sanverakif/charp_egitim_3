using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charp_egitim_3
{
    public class GenericListWork
    {

        public void ListT()
        {
            //T parametresi türü temsil eder. Boyut otomatik olarak ayarlanır.
            #region List<T>
            List<int> numara = new List<int>();
            //eleman ekleme
            numara.Add(10);
            numara.Add(20);
            numara.Add(30);

            int df = numara[1];

            //eleman sayısı öğrenme
            int count = numara.Count;

            //eleman arama
            numara.Contains(30);

            //diziyi dönüştürme
            int[] asdasdsa = numara.ToArray();

            #endregion

            //key değerleri benzersizdir.
            #region Dictionary<key,value>
            Dictionary<int, string> keyValues = new Dictionary<int, string>();
            keyValues.Add(1, "akif");
            keyValues.Add(2, "emre");
            keyValues.Add(3, "akif");
            keyValues.Add(4, "akif");

            //value string olduğundan string türde değişken oluşturup değeri atadık.
            string x = keyValues[3];

            //değer değiştirildi.
            keyValues[3] = "ünal";

            //bu key var mı yok mu kontrol edildi.
            bool keykontrol = keyValues.ContainsKey(2);

            //bu value var mı yok mu kontrol edildi.
            bool valuekontrol = keyValues.ContainsValue("ünal");

            IEnumerable<KeyValuePair<int, string>> result = keyValues.Where(x => x.Value == "akif");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            #endregion

            //İlk giren ilk çıkar mantığında çalışır. Elemanların eklenme sırasına göre işlenir.
            #region Queue<T>
            Queue<int> list = new Queue<int>();
            #endregion


     
        }

        public void topla() => Console.WriteLine(5 + 5);
        public void cikar() => Console.WriteLine(5 -2);

    }
}
