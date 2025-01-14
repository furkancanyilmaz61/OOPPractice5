class Program
{
    static void Main(string[] args)
    {
        // Geçerli kapı sayısı ile nesne oluşturma
        Araba araba1 = new Araba("Toyota", "Corolla", "Beyaz", 4);
        Console.WriteLine($"Araba 1 - Marka: {araba1.Marka}, Model: {araba1.Model}, Renk: {araba1.Renk}, Kapı Sayısı: {araba1.KapiSayisi}");

        // Geçersiz kapı sayısı ile nesne oluşturma
        Araba araba2 = new Araba("Honda", "Civic", "Siyah", 3);
        Console.WriteLine($"Araba 2 - Marka: {araba2.Marka}, Model: {araba2.Model}, Renk: {araba2.Renk}, Kapı Sayısı: {araba2.KapiSayisi}");
    }
}