using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Threading.Channels;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Metnin uzunluğunu ölçen --> Length;
            string text = "Hello 502";
            //Console.WriteLine(text.Length);

            // Bir metnin sadece belirli bir kısmını almak için substring metodu kullanılmaktadır.

            /*Console.WriteLine(text.Substring(0,6));*/ // 5'e kadar alıyor 6 dahil değil. "Hello "

            // Bu metinde Hello geçiyor mu bunun için.
            //bool sonuc = text.Contains("Hello"); // Output true veya false
            //Console.WriteLine(sonuc);

            //Console.WriteLine(text.IndexOf('5')); // Tek tırnak kullanıyoruz

            //Console.WriteLine(text.ToUpper());
            //Console.WriteLine(text.ToLower());

            // Belirli bir metni başka bir metin ile değiştirebilmek için
            //Console.WriteLine(text.Replace("Hello", "Selam"));

            // Boşlukları temizlemek için;
            //Console.WriteLine(text.Trim());

            // Metinsel ifadeyi belli bir karaktere göre bölmek için split metodu
            //string yazi = "HTML,CSS,Bootstrap,Tailwind,React,Redux";

            //string[] dizi = yazi.Split(",");

            //foreach (string x in dizi)
            //{
            //    Console.WriteLine(x.Trim());
            //}

            // Başlangıcı şununla mı başlıyor gibi bir soruya cevap veren metot.

            //Console.WriteLine(text.StartsWith("xKralTR"));
            //Console.WriteLine(text.EndsWith("xKralTR"));

            //string inserted = text.Insert(9, "!!!!"); // 9. indexten sonra uygula.
            //Console.WriteLine(inserted);

            // Stringten belirli bir kısmı çıkartmak istediğimizde.

            string removed = text.Remove(6, 3);
            Console.WriteLine(removed);

            // Kullanıcıdan bir e-mail adresi isteyen ve bu adresin geçerli mi yoksa geçersiz bir adres olduğunu fonksiyonlar aracılığı ile tespit eden, geçerli olmasi için içerisinde @ ifadesinin geçmesini zorunlu kılan. Aynı zamanda @ işaretinde sonra "." gelmesini zorunlu kılan bir validasyon hazırlayın.

            Console.WriteLine("E-mailinizi giriniz...");
            string email = Console.ReadLine();

            if (Validasyon(email))
            {
                Console.WriteLine("Başarılı!");
            }
            else
            {
                Console.WriteLine("Başarısız");
            }
        }

        public static bool Validasyon(string email)
        {
          
            
            bool isOkay = email.Contains("@");

            if (isOkay) {
            int atKacinci = email.IndexOf("@");
            bool kesAl = email.Substring(atKacinci).Contains(".");
                return kesAl;
            } else{
                return false;
            }
          
            
        }
    }
}