Console.WriteLine("Lütfen Aşağıdaki Bilgileri Giriniz");

Console.WriteLine("T.C Kimlik Numarası:");
string tc = Console.ReadLine();

Console.WriteLine("Adınız:");
string isim = Console.ReadLine();

Console.WriteLine("Soyadınız:");
string soyisim = Console.ReadLine();

Console.WriteLine("Telefon Numaranız:");
string tel = Console.ReadLine();
// Telefon numarası üzerinde herhangi bir işlem yapılmayacağı için string veri tipi kullanılmıştır.

Console.WriteLine("Yaşınız:");
string yas = Console.ReadLine();
// Yaş üzerinde herhangi bir işlem yapılmayacağı için string veri tipi kullanılmıştır.

Console.WriteLine("İlk Alınan Ürünün Fiyatı:");
string ilkürün = Console.ReadLine();
int a =Convert.ToInt32(ilkürün);
//İlk ürün fiyatı üzerinde işlem yapılması gerekriği için string veri tipi int veri tipine convert yapılmıştır.

Console.WriteLine("İkinci Alınan Ürününün Fiyatı:");
string ikinciürün = Console.ReadLine();
int b =Convert.ToInt32(ikinciürün);
//İkinci ürün fiyatı üzerinde işlem yapılması gerekriği için string veri tipi int veri tipine convert yapılmıştır.

int ürüntoplamı = a + b;

int puan = (a + b) / 10;

Console.WriteLine($"{tc} TC numaralı {isim} {soyisim} isimli kişi için kayıt oluşturulmuştur.");
Console.WriteLine($"{tel} telefon numarasına bilgilendirme mesajı gönderilmiştir");
Console.WriteLine($"{ürüntoplamı} toplam harcama karşılığı 10% patika puan miktarı -> {puan}");

