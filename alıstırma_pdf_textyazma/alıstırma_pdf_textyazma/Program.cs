//using System;
//using System.IO;
//using System.Linq;
//using UglyToad.PdfPig;
//using UglyToad.PdfPig.Content;

//class Program
//{

//    static void Main(string[] args)
//    {

//        string pdfPath = @"C:\Users\myusu\OneDrive\Masaüstü\yaz_okulu.pdf"; // PDF dosya yolu
//        string outputPath = @"C:\Users\myusu\OneDrive\Masaüstü\tablolar.txt";

//        try
//        {
//            using (PdfDocument document = PdfDocument.Open(pdfPath))
//            {
//                using (StreamWriter writer = new StreamWriter(outputPath))
//                {
//                    foreach (Page page in document.GetPages())
//                    {
//                        // PDF'deki her satırı oku
//                        var textLines = page.Text.Split('\n');

//                        foreach (var line in textLines)
//                        {
//                            // Ders kodu ile başlayan satırları filtrele
//                            var parts = line.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);

//                            if (parts.Length > 4 && parts[0].Length >= 6 && char.IsLetter(parts[0][0]) && char.IsDigit(parts[0][parts[0].Length - 1]))
//                            {
//                                // Ders kodu, adı ve AKTS'yi ayır
//                                string dersKodu = parts[0];
//                                string dersAdi = string.Join(" ", parts.Skip(1).TakeWhile(p => !char.IsDigit(p[0])));
//                                string akts = parts.Last();

//                                // Çıktıya yaz
//                                writer.WriteLine($"{dersKodu} - {dersAdi} - {akts}");
//                            }
//                        }
//                    }
//                }
//            }

//            Console.WriteLine("Ders bilgileri başarıyla dosyaya kaydedildi.");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Bir hata oluştu: " + ex.Message);
//        }
//    }
//}


using System;
using System.Collections.Generic;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;

class Program
{
    static void Main()
    {
        string pdfPath = @"C:\Users\myusu\OneDrive\Masaüstü\yaz_okulu.pdf";  // PDF dosyanızın yolu
        List<string> dersAdlari = new List<string>();
        bool dersAdiBasladi = false;

        using (PdfDocument document = PdfDocument.Open(pdfPath))
        {
            foreach (Page page in document.GetPages())
            {
                string[] lines = page.Text.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var line in lines)
                {
                    // Dersin Adı başlığını bulduktan sonra okumaya başlar
                    if (line.Contains("DERSİN ADI"))
                    {
                        dersAdiBasladi = true;
                        continue; // Başlığı atla
                    }

                    // Başlık bulunduktan sonra sadece ders adlarını ekler
                    if (dersAdiBasladi)
                    {
                        // Ders adı dışında olan satırları (örneğin fakülte adı) engelle
                        // "Z/S" gibi belirli bir formatı kontrol ederek sadece ders adlarını al
                        if (line.Contains("Z/S") || string.IsNullOrWhiteSpace(line) || line.Contains("DERSİN KODU") || line.StartsWith("TIP") || line.Contains("AKTS") || line.Contains("FAKÜLTE/KONSERVATUVAR/MYO")|| line.Contains("İKTİSADİ VE İDARİ BİLİMLER FAKÜLTESİ")|| line.Contains("MÜHENDİSLİK FAKÜLTESİ"))  
                        {
                            continue; // Eğer gereksiz satırsa atla
                        }

                        // Ders adı kısmını ekle
                        dersAdlari.Add(line.Trim());
                    }
                }
            }
        }

        // Console ekranına yazdır
        Console.WriteLine("Ders Adları:");
        foreach (var ders in dersAdlari)
        {
            Console.WriteLine(ders);
        }

        Console.ReadLine();
    }
}
