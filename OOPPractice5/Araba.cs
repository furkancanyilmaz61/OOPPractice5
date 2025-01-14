using System;

class Araba
{
    // Özellikler
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }

    private int kapiSayisi;

    // KapiSayisi Özelliği (Encapsulation)
    public int KapiSayisi
    {
        get { return kapiSayisi; }
        set
        {
            if (value == 2 || value == 4)
            {
                kapiSayisi = value;
            }
            else
            {
                Console.WriteLine("Uyarı: Kapı sayısı yalnızca 2 veya 4 olabilir. Geçersiz değer atandı, Kapı Sayısı -1 olarak ayarlandı.");
                kapiSayisi = -1;
            }
        }
    }

    // Constructor
    public Araba(string marka, string model, string renk, int kapiSayisi)
    {
        Marka = marka;
        Model = model;
        Renk = renk;
        KapiSayisi = kapiSayisi; // Setter kontrol yapacak
    }
}