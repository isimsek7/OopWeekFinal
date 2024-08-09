using OopEndProject;
bool tekrar = true;
while (tekrar)
{
    Console.Write("Telefon icin 1, Bilgisayar icin 2'yi tuslayiniz. =");
    int userInput = Convert.ToInt32(Console.ReadLine());
    if (userInput == 1)
    {
        Telefon telefon1 = new Telefon();
        Console.WriteLine("Lutfen telefonun bilgilerini giriniz.");
        Console.Write("Seri Numarasi= ");
        telefon1._seriNo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ismi= ");
        telefon1._ad = Console.ReadLine();
        Console.Write("Isletim sistemi= ");
        telefon1._isletimSistemi = Console.ReadLine();
        Console.Write("Cihaz lisansa sahip mi ? (Evet,Hayir)= ");
        string lisans = Console.ReadLine().ToLower().Trim();
        if (lisans == "hayir")
            telefon1._lisans = false;
        else if (lisans == "evet")
            telefon1._lisans = true;
        Console.WriteLine("Lutfen cihaz hakkinda bir aciklama giriniz.");
        telefon1._aciklama = Console.ReadLine();
        telefon1.Ozet();
    }
    else if (userInput == 2)
    {
        Bilgisayar pc = new Bilgisayar();
        Console.WriteLine("Lutfen bilgisayarin bilgilerini giriniz.");
        Console.Write("Seri Numarasi= ");
        pc._seriNo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ismi= ");
        pc._ad = Console.ReadLine();
        Console.Write("Isletim sistemi= ");
        pc._isletimSistemi = Console.ReadLine();
        Console.Write("Cihazin kac usb girisi var= ");
        pc.UsbGirisSayisi = Convert.ToInt32(Console.ReadLine());
        Console.Write("Bluetooth var mi (Evet,Hayir)= ");
        string bluetooth = Console.ReadLine().ToLower().Trim();
        if (bluetooth == "hayir")
            pc._bluetooth = false;
        else if (bluetooth == "evet")
            pc._bluetooth = true;
        Console.WriteLine("Lutfen cihaz hakkinda bir aciklama giriniz.");
        pc._aciklama = Console.ReadLine();
        pc.Ozet();
    }

    Console.Write("Yeni bir urun kaydetmek ister misiniz ? (Evet/Hayir)= ");
    string goOrNo = Console.ReadLine().ToLower().Trim();
    if (goOrNo == "hayir")
        tekrar = false;
    else if (goOrNo == "evet")
        continue;
    else
    {
        Console.WriteLine("Kullanimi olmayan bir giris yapildi.");
    }
}