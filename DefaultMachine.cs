using System;
namespace OopEndProject
{
	public abstract class DefaultMachine
	{
		public DefaultMachine()
		{
			string _uretimTarihi = DateTime.Now.ToLongDateString();
			Console.WriteLine("Uretim tarihi="+_uretimTarihi);
		}
		public int _seriNo { get; set; }
		public string _ad { get; set; }
		public string _aciklama { get; set; }
		public string _isletimSistemi { get; set; }
		public virtual void Ozet()
		{
		}


    }
	public class Telefon : DefaultMachine
	{
		public bool _lisans { get; set; }

        public override void Ozet()
        {
			if(_lisans)
            Console.WriteLine($"TR'de kullanim lisansina sahip, {_seriNo}'seri numarali,{_isletimSistemi}'isletim sistemli {_ad} telefonu. Detaylar={_aciklama}");
			else
            Console.WriteLine($"TR'de kullanim lisansina sahip olmayan, {_seriNo}'seri numarali,{_isletimSistemi}'isletim sistemli {_ad} telefonu. Detaylar={_aciklama}");

        }
    }
	public class Bilgisayar : DefaultMachine
	{
		int _usbGirisSayisi;

		public int UsbGirisSayisi
		{
			get
			{
				return _usbGirisSayisi;
			}
			set
			{
				if (value != 2 || value != 4)
				{
					Console.WriteLine("Gecersiz giris sayisi verildi.");
					_usbGirisSayisi = -1;
				}
				else
					_usbGirisSayisi = value;
			}

		}

		public bool _bluetooth { get; set; }
        public override void Ozet()
        {
			if(_bluetooth)
            Console.WriteLine($"{_seriNo}'seri numarali,{_isletimSistemi}'isletim sistemli,{_usbGirisSayisi}'usb girisli ve bluetooth'lu {_ad} bilgisayari. Detaylar={_aciklama}");
            else
            Console.WriteLine($"{_seriNo}'seri numarali,{_isletimSistemi}'isletim sistemli,{_usbGirisSayisi}'usb girisli {_ad} bilgisayari. Detaylar={_aciklama} \n (Bluetooth=Yok)");
        }
    }
}
