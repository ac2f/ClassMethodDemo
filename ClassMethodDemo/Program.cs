namespace ClassMethodDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Eylemler:\n0  -  Müşterileri listele\n1  -  Müşteri sil\n2  -  Müşteri güncelle\n3  -  Müşteri ekle\nEylem seçiniz: ");
                switch (Console.ReadLine())
                {
                    case "0":
                        Console.Write("Eylemler:\n0  -  Herkesi listele\n1  -   Filtreleyerek listele");
                        switch (Console.ReadLine())
                        {
                            case "0":
                                MusteriYonetim.MusteriListele();
                                break;
                            case "1":
                                Console.Write("Filtre ID(Boş bırakabilirsiniz): ");
                                string strId = Console.ReadLine();
                                Console.Write("Filtre AD(Boş bırakabilirsiniz): ");
                                string ad = Console.ReadLine();
                                Console.Write("Filtre SOYAD(Boş bırakabilirsiniz): ");
                                string soyad = Console.ReadLine();
                                Console.Write("Filtre CINSIYET(Boş bırakabilirsiniz): ");
                                string strCinsiyet= Console.ReadLine();
                                Console.Write("Filtre BAKIYE(Boş bırakabilirsiniz): ");
                                string strBakiye = Console.ReadLine();
                                int id = strId!=""?int.Parse(strId):-1, cinsiyet = strCinsiyet!=""?int.Parse(strCinsiyet):-1, bakiye = strBakiye!=""?int.Parse(strBakiye):-1;
                                ad = ad == "" ? null : ad;
                                soyad = soyad == "" ? null : soyad;
                                MusteriYonetim.MusteriBul(id, ad, soyad, cinsiyet, bakiye);
                                break;
                            default:
                                break;
                        }
                        break;
                    case "1":

                        break;
                    default:
                        Console.WriteLine("\nHatalı bilgi girdiniz! Tekrar deneyiniz.");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}