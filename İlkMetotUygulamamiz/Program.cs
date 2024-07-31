using System;
class Program
{    
    static void Main()
    {
        //Geriye Değer Döndürmeyen Bir void metot.
        FavSongLyric();
        Console.WriteLine(" ");

        // Geriye Tamsayı Döndüren Bir metot
        int kalan = RestOfRandomNumber();
        Console.WriteLine($"Rastgele sayının 2'ye bölümünden kalan: {kalan}");
        Console.WriteLine(" ");

        // Parametre Alan ve Geriye Değer Döndüren Bir Metot
        Console.WriteLine("Lütfen birinci sayıyı giriniz:");
        int num1 = Convert.ToInt32 (Console.ReadLine());
        Console.WriteLine("Lütfen ikinic sayıyı giriniz:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int sonuc = Multiply(num1, num2);
        Console.WriteLine($"{num1} ile {num2}'un çarpımı: {sonuc}");
        Console.WriteLine(" ");
        // Parametre Alan ve Geriye Değer Döndürmeyen bir Metot

        Console.WriteLine("Lütfen adınızı girin:");
        string name = Console.ReadLine();
        Console.WriteLine("Lütfen soyadınızı girin:");
        string surname = Console.ReadLine();
        WelcomeMsg(name, surname);
    }
    //Geriye Değer Döndürmeyen Bir void metot.
    static void FavSongLyric()
    {
        Console.WriteLine("Şu baş belası dilimi kesin!\nZilimi çalsın serzeniş, içime dolsun hüzüntü\nSüreklilik ne zor bir iş?!\nPerişanlık, pişmanlık çekilmesi en Güç dertmiş\nSabır tüm sıkıntıların anahtarıdır, doğrudur\nDüş kırıklıklarım sonucu ruhum yorgundur\nAğaçlarımdan pişmanlık meyveleri sarkıyor\nHaydi topla!\nGözlerimden uyku çalanı ara ve bul patakla\nGönlümün dipte kalan kısmında\nArşivlenmiş onca yara\nYılan ve akreplerle dolu\nIçinde bulunduğum yuva\nBirileri haddini bildirmeli ölüm okuna\nKafa tutan kalkanlara\nYaptıklarından sebep yapacaklarına hazırlıklı\nSago yüzün sadık köpek\nCüzün kedice pazarlıklı\nLan bi' sen mi kaldın tek akıllı\n(sen mi kaldın?)?\nBu tarla mayınlı! Ummadığın yer tuzaklı\nVesselam bu özleri bu şekilde altatlta gelecek çekilde yazarmısın");
    }
    // Geriye Tamsayı Döndüren Bir metot
    static int RestOfRandomNumber()
    {
        Random rndNum = new Random();
        int num = rndNum.Next(1, 100); // 1 ile 100 arasında rastgele bir sayı üretir
        return num % 2;
    }
    // Parametre Alan ve Geriye Değer Döndüren Bir Metot
    static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    // Parametre Alan ve Geriye Değer Döndürmeyen bir Metot
    static void WelcomeMsg(string name, string surname)
    {
        Console.WriteLine($"Hoş Geldiniz {name} {surname}");
    }
}
