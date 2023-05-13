using System;
namespace ClassMetotDemo
{
	public class MusteriManager
	{
        List<Musteri> musteriList = new List<Musteri>();

        public void MusteriEkle(Musteri musteri)
		{
            musteriList.Add(musteri);
		}
        public void MusteriSil(Musteri musteri)
        {
            musteriList.Remove(musteri);
        }
        public void MusteriListele()
        {
            foreach (Musteri musteri in musteriList)
            {
                Console.WriteLine(musteri.Id+" "+musteri.Ad+" "+musteri.Soyad);
            }
        }
    }
}

