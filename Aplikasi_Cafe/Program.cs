using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_Cafe
{
    //membuat kelas Menu
    public class Menu
    {
        //deklarasi variabel global
        public double gls1, hKoptam;

        //membuat method berupa prosedur untuk input variabel yang diketahui
        public void satuanKoptam()
        {
            Console.Write("berapa gelas yang anda ingin? ");
            gls1 = Convert.ToDouble(Console.ReadLine());
        }

        //Membuat method berupa fungsi untuk menghitung Harga
        public double HargaKoptam(double gls1)
        {
            hKoptam = 15000 * gls1;
            return hKoptam;
        }

        //membuat method berupa prosedur untuk menampilkan jumlah yang dibeli
        public void TampilKoptam()
        {
            Console.WriteLine("{0} Gelas Kopi hitam ditambahkan ke pesanan anda", gls1);
            Console.ReadKey();
        }

        //Membuat method berupa fungsi untuk menghitung Harga dari data yang diinput
        public void HitungKoptam(double gls1)
        {
            Console.Write("{0} gls Kopi Hitam = Rp.{1}", this.gls1, this.HargaKoptam(gls1));
        }
        public double gls2,hKopsus;
        public void satuanKopsus()
        {
            Console.Write("berapa gelas yang anda inginkan? ");
            gls2 = Convert.ToDouble(Console.ReadLine());
        }
        public double HargaKopsus(double gls)
        {
            hKopsus = 13000 * gls;
            return hKopsus;
        }
        public void TampilKopsus()
        {
            Console.WriteLine("{0} Gelas Kopi susu ditambahkan ke pesanan anda", gls2);
            Console.ReadKey();
        }
        public void HitungKopsus(double gls2)
        {
            Console.Write("{0} gls Kopi Susu = Rp.{1}", this.gls2, this.HargaKopsus(gls2));
        }
        public double prs, hNasgor;
        public void satuanNasgor()
        {
            Console.Write("berapa porsi yang anda inginkan? ");
            prs = Convert.ToDouble(Console.ReadLine());
        }
        public double HargaNasgor(double prs)
        {
            hNasgor = 12000 * prs;
            return hNasgor;
        }
        public void TampilNasgor()
        {
            Console.WriteLine("{0} Porsi Nasi goreng ditambahkan ke pesanan anda", prs);
            Console.ReadKey();
        }
        public void HitungNasgor(double prs)
        {
            Console.Write("{0} prs Nasi Goreng = Rp.{1}", this.prs, this.HargaNasgor(prs));
        }
        public double gls3, hKoprang;
        public void satuanKoprang()
        {
            Console.Write("berapa gelas yang anda inginkan? ");
            gls3 = Convert.ToDouble(Console.ReadLine());
        }
        public double HargaKoprang(double gls3)
        {
            hKoprang = 10000 * gls3;
            return hKoprang;
        }
        public void TampilKoprang()
        {
            Console.WriteLine("{0} Gelas Kopi arang ditambahkan ke pesanan anda", gls3);
            Console.ReadKey();
        }
        public void HitungKoprang(double gls3)
        {
            Console.Write("{0} gls Kopi Arang = Rp.{1}", this.gls3, this.HargaKoprang(gls3));
        }
    }
    //membuat kelas Pembayaran
    public class pembayaran
    {
        public double Totalbayar;

        //membuat method untuk menginput uang yang dibayarkan
        public void jumlahbayar()
        {
            Console.Write("jumlah uang yang dibayarkan : Rp.");
            Totalbayar = Convert.ToDouble(Console.ReadLine());
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            string nama, kasir;

            Console.Write("\nMasukkan Nama Pembeli : ");
            nama = Convert.ToString(Console.ReadLine());
            Console.Write("Masukkan Nama Kasir : ");
            kasir = Convert.ToString(Console.ReadLine());
            Console.Write("Masukkan Tanggal Transaksi : ");
            Console.Clear();

            //membuat instance untuk kelas Menu dan kelas Pembayaran
            Menu mn = new Menu();
            pembayaran pb = new pembayaran();

            //deklarasi variabel untuk ekspresi Switch
            int pilih;

            //membuat Perulangan
            do
            {
                //membuat tampilan Menu
                Console.WriteLine("");
                Console.WriteLine("Pembeli : {0}", nama);
                Console.WriteLine("Kasir   : {0}", kasir);
                Console.WriteLine("");
                Console.WriteLine("          Selamat Datang Di Cafe Lokal");
                Console.WriteLine("        Silahkan Plih Item Yang Akan Dibeli");
                Console.WriteLine("       =====================================");
                Console.WriteLine("");
                Console.WriteLine(" MENU ");
                Console.WriteLine("======");
                Console.WriteLine("1. Kopi Hitam     Rp. 15.000");
                Console.WriteLine("2. Kopi Susu      Rp. 13.000");
                Console.WriteLine("3. Nasi Goreng    Rp. 12.000");
                Console.WriteLine("3. Kopi Arang     Rp. 10.000");
                Console.WriteLine("5. Selesai");
                Console.Write("Pilih (1/2/3/4/5) : ");
                pilih = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                switch (pilih)
                {
                    case 1:
                        mn.satuanKoptam();
                        mn.HargaKoptam(mn.gls1);
                        mn.TampilKoptam();
                        break;
                    case 2:
                        mn.satuanKopsus();
                        mn.HargaKopsus(mn.gls2);
                        mn.TampilKopsus();
                        break;
                    case 3:
                        mn.satuanNasgor();
                        mn.HargaNasgor(mn.prs);
                        mn.TampilNasgor();
                        break;
                    case 4:
                        mn.satuanKoprang();
                        mn.HargaKoprang(mn.gls3);
                        mn.TampilKoprang();
                        break;
                    case 5:
                        pb.jumlahbayar();
                        break;

                    default:
                        pb.jumlahbayar();
                        break;
                }
            }
            while (pilih < 5);
            {
                //deklarasikan variabel untuk memberi nama file
                string namafile;

                try
                {
                    //membaca nama file dan disimpan di variabel namaFile
                    namafile = Console.ReadLine();

                    //deklarasi string untuk menyimpan path di drive C pada folder mydocument
                    string path = Environment.GetFolderPath
                    (Environment.SpecialFolder.MyDocuments);

                    //Lewatkan folder dan nama file ynag digunakan untuk menyimpan data di drive C
                    StreamWriter sw = new StreamWriter(Path.Combine(path, $"Struk.txt"));

                    //Masukkan Kalimat kedalam file
                    sw.WriteLine("Nama Pembeli  : {0}", nama);
                    sw.WriteLine("Nama Kasir    : {0}", kasir);
                    sw.WriteLine("Jam Transaksi : {0}", DateTime.Now);
                    sw.WriteLine("");
                    sw.WriteLine("Struk Belanja:");
                    sw.Write("\n{0} Gelas Kopi Hitam   = Rp.{1} ", mn.gls1, mn.HargaKoptam(mn.gls1));
                    sw.Write("\n{0} Gelas Kopi Susu    = Rp.{1} ", mn.gls2, mn.HargaKopsus(mn.gls2));
                    sw.Write("\n{0} Porsi Nasi Goreng  = Rp.{1} ", mn.prs, mn.HargaNasgor(mn.prs));
                    sw.Write("\n{0} Gelas Kopi Arang   = Rp.{1} ", mn.gls3, mn.HargaKoprang(mn.gls3));
                    sw.Write("\n");
                    sw.Write("---------------------------------");
                    sw.Write("\n              Total      = Rp.{0} ", mn.hKoptam + mn.hKopsus + mn.hNasgor + mn.hKoprang);
                    sw.Write("\n              Kembalian  = Rp.{0} ", (mn.hKoptam + mn.hKopsus + mn.hNasgor + mn.hKoprang)
                        - (pb.Totalbayar));
                    Console.Write("");

                    //Menutup file
                    sw.Close();
                }

                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                finally
                {
                    Console.WriteLine("Nota Telah Dicetak.");
                }
            }
        }
    }
}