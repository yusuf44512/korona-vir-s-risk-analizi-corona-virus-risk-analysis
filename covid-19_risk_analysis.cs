using System;

namespace covid_19_risk_analizi
{
    class Program
    {

        static void Main(string[] args)
        {
            ///// YUSUF AKPINAR G190100022
            // hastane, klinik, eczane,banka,berber,havalimanı,havaalanı,pazar  
            int yaş, evdeki_hasta_sayısı, risk_derecesi, x, y, z, t, m, n,b, yaşadığı_bölge_nüfusu, genel_risk_toplamı, çalışılan_yer;
            string ad, pozitif_tanı_cavabı;
            Console.WriteLine("********KORONA VİRÜS RİSK ANALİZ PROGRAMINA HOŞGELDİNİZ/Welcome to the Corona Virus Risk Analysis Program*********");
            Console.WriteLine("HER SORUDA VERİLEN SONUÇLAR GERÇEK RİSK GRUBUNUZU BELİRLEMEZ. LÜTFEN SONUCU BEKLEYİNİZ!");
            Console.WriteLine("Lütfen küçük harflere dikkat ediniz");
            Console.WriteLine("Lütfen sayı ile yazmanız gereken yerlerde sayı karakterlerini kullanınız");
            Console.Write("(AD/SOYAD)-(NAME/SURNAME)=");
            Console.ReadLine();
            Console.Write("kaç yaşındasınız=");
            yaş = Convert.ToInt32(Console.ReadLine());
            if (yaş >= 65 || yaş <= 5)

                Console.WriteLine("{0}.derece risk grubu", x = 1);

            else if (yaş <= 64 && yaş >= 40)

                Console.WriteLine("{0}.dereceden risk grubu", x = 2);

            else if (yaş <= 39 && yaş >= 20)

                Console.WriteLine("{0}. derece risk grubu", x = 3);
            else
                Console.WriteLine("{0}. derece risk grubu", x = 4);
            Console.WriteLine();
            Console.Write("Yaşanılan Bölge Nüfusu=");

            yaşadığı_bölge_nüfusu = Convert.ToInt32(Console.ReadLine());
            if (yaşadığı_bölge_nüfusu >= 5000000)
                Console.WriteLine("{0}.derece risk grubu", y = 1);
            else if (yaşadığı_bölge_nüfusu >= 2000000)
                Console.WriteLine("{0}.derece risk grubu", y = 2);
            else if (yaşadığı_bölge_nüfusu >= 500000)
                Console.WriteLine("{0}.derece risk grubu", y = 3);
            else
                Console.WriteLine("{0}.derece risk grubu", y = 4);

            Console.Write("Çalışılan Yer(Mekan)= (hastane(1), pazar(2), klinik(3), eczane(4), banka(5), berber(6), havaalanı(7), diğer(8)) ");
            çalışılan_yer = Convert.ToInt32(Console.ReadLine());
            int hastane = 1, pazar = 2, klinik = 3, eczane = 4, banka = 5, berber = 6, havalimanı = 7, havaalanı = 7, diğer = 8;
            {
                if (çalışılan_yer == 1)
                    Console.Write("{0}.derece risk grubu", z = 1);
                else if (çalışılan_yer == 2)
                    Console.WriteLine("{0}.derece risk grubu", z = 1);
                else if (çalışılan_yer == 3)
                    Console.WriteLine("{0}.derece risk grubu", z = 1);
                else if (çalışılan_yer == 4)
                    Console.WriteLine("{0}.derece risk grubu", z = 1);
                else if (çalışılan_yer == 5)
                    Console.WriteLine("{0}.derece risk grubu", z = 1);
                else if (çalışılan_yer == 6)
                    Console.WriteLine("{0}.derece risk grubu", z = 1);
                else if (çalışılan_yer == 7)
                    Console.WriteLine("{0}.derece risk grubu", z = 1);
                else
                    Console.WriteLine("{0}.derece risk grubu", z = 4);

            }
        
            string gösterilen_semptomlar;
            Console.WriteLine();
            Console.WriteLine("Gösterdiğiniz semptomlar seviyesi0(ağır-orta-iyi-yok):");
            gösterilen_semptomlar = Console.ReadLine();
            {
                if (gösterilen_semptomlar == "ağır")
                    Console.WriteLine("{0}.derece risk grubu:", m = 1);

                else if (gösterilen_semptomlar == "orta")
                    Console.WriteLine("{0}.derece risk grubu", m = 2);
                else if (gösterilen_semptomlar == "iyi")
                    Console.WriteLine("{0}.derece risk grubu", m = 3);
                else
                    Console.WriteLine("{0}.derece risk grubu", m = 4);

            }  
            
            string cevap;
           
            Console.WriteLine("Kronik rahatsızlığınız varmı(e-h):");
            cevap = Console.ReadLine();

            switch (cevap)

            {
               
                case "e":Console.WriteLine("{0}.derece risk grubu", b= 1);
                    
                    break;
                case "h": Console.WriteLine("{0}.derece risk grubu", b= 4);
                    break;
                default: Console.WriteLine("Hatalı cevap girişi");
                    break;
                
            }

            Console.Write("Evde pozitif tanı konulan birey mevcutmu(E/H)? ");
            pozitif_tanı_cavabı = Console.ReadLine();


            {
                if (pozitif_tanı_cavabı == "e")
                {
                    t = Convert.ToInt32(Console.Read());
                    Console.WriteLine("{0}.derece risk grubu", t = 1);
                    Console.Read();
                    Console.Write("Hasta sayısını giriniz: ");
                    evdeki_hasta_sayısı = Convert.ToInt32(Console.ReadLine());

                    int[] tane = new int[evdeki_hasta_sayısı];


                    string[] ad_soyad = new string[evdeki_hasta_sayısı];
                    int[] hastanın_yaşı = new int[evdeki_hasta_sayısı];
                    string[] akraba_durumu = new string[evdeki_hasta_sayısı];

                    for (int a = 0; a < evdeki_hasta_sayısı; a++)
                    {
                        Console.Write("Hastanın ad/soyad giriniz : ");
                        ad_soyad[a] = Console.ReadLine();

                        Console.Write("Hastanın yaşını giriniz : ");
                        hastanın_yaşı[a] = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Akrabalık durumunu giriniz : ");
                        akraba_durumu[a] = Console.ReadLine();

                    }

                    Console.WriteLine();

                    Console.WriteLine("Yakın Hastaların:        Adı/Soyadı       Akrabalık Durumu      Yaşı");
                    Console.WriteLine();
                    for (int a = 0; a < evdeki_hasta_sayısı; a++)
                    {

                        Console.WriteLine("                             " + ad_soyad[a] + "                 " + akraba_durumu[a] + "                        " + hastanın_yaşı[a]);
                    }

                }
                else
                {
                    Console.WriteLine("{0}.derece risk grubu", t = 3);

                }
            }
            {
                int sıcaklık;
                Console.Write("Vucut sıcaklığınız:");
                sıcaklık = Convert.ToInt32(Console.ReadLine());
                if (sıcaklık <= 37 && sıcaklık >= 34)
                    Console.WriteLine("{0}.derece risk grubu", n = 4);
                else
                    Console.WriteLine("{0}.derece risk grubu", n = 1);
            }

            
            genel_risk_toplamı = x + y + z + t+ m+ n ;
                   Console.ReadKey();
            Console.Clear();
            if (genel_risk_toplamı <= 8)
                Console.WriteLine("ACİL HASTANEYE KALDIRILMALI VE TEST YAPILMALI !!!");
            else if (genel_risk_toplamı >= 9 && genel_risk_toplamı <= 16)
                Console.Write("SAHSİ İZOLASYON SAĞLANMALI !! ");
            else
                Console.WriteLine("SOSYAL MESAFEYE DİKKAT EDEREK GÜNLÜK YAŞANTIYA DİKKAT EDİLMELİ");
            Console.ReadKey();

                }
            
    } }
