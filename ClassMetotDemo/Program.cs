namespace ClassMetotDemo;
class Program
{
    static void Main(string[] args)
    {
        MusteriManager musteriManager = new MusteriManager();
        Musteri musteri1 = new Musteri();
        Musteri musteri2 = new Musteri();
        Musteri musteri3 = new Musteri();
        Musteri musteri4 = new Musteri();

        musteri1.Id = 1;
        musteri1.Ad = "Eyyüp";
        musteri1.Soyad = "Erdoğan";


        musteri2.Id = 2;
        musteri2.Ad = "Yakup";
        musteri2.Soyad = "Erdoğan";

        musteri3.Id = 3;
        musteri3.Ad = "irem";
        musteri3.Soyad = "derici";

        musteri4.Id = 4;
        musteri4.Ad = "serhat";
        musteri4.Soyad = "beştaş";

        musteriManager.MusteriEkle(musteri1);
        musteriManager.MusteriEkle(musteri2);
        musteriManager.MusteriEkle(musteri3);
        musteriManager.MusteriEkle(musteri4);

        musteriManager.MusteriSil(musteri2);
        musteriManager.MusteriListele();

        Console.Read();
    }
}

