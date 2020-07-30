using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JayaKomputer
{
    public class Menu
    {
        public static void showMenuUtama()
        {
            //Begin Menu
            Console.WriteLine("SELAMAT DATANG DI TOKO JAYA KOMPUTER");
            Console.WriteLine();
            Console.WriteLine("1. Input Data Pelanggan");
            Console.WriteLine("2. Input Data Barang");
            Console.WriteLine("3. Tampilkan Semua Stok Barang");
            Console.WriteLine("4. Tampilkan Semua Data Pelanggan");
            Console.Write("Pilih Nomor Menu : ");
            int chooseMenu = Int32.Parse(Console.ReadLine());

            switch (chooseMenu)
            {
                case 1:
                    DataPelanggan();
                    break;
                case 2:
                    DataBarang();
                    break;
                case 3:
                    Barang.showDaftarBarang();
                    break;
                case 4:
                    Pelanggan.showDataPelanggan();
                    break;
               
            }
        }

        public static void DataPelanggan() //menu satu
        {
            Console.WriteLine();
            Console.Write("Masukan Kode Pelanggan : ");
            string KodePelanggan = Console.ReadLine();
            Console.Write("Masukan Nama : ");
            string NamaPelanggan = Console.ReadLine();
            Console.Write("Masukan No Telp : ");
            string ContactPelanggan = Console.ReadLine();
            

            Pelanggan pelanggan1 = new Pelanggan();
            pelanggan1.NamaPelanggan = NamaPelanggan;
            pelanggan1.KodePelanggan = KodePelanggan;
            
            pelanggan1.ContactPelanggan = ContactPelanggan;

            GlobalVariable.daftarPelanggan.Add(pelanggan1);
            Console.Clear();
            Console.WriteLine("Data Tersimpan .....");
            Console.WriteLine();
            showMenuUtama();

        }

        public static void DataBarang() //menu dua input barang
        {
            Console.WriteLine();
            string KodeBarang = "Kode Barang : ";
            string NamaBarang = "Nama Barang : ";
            string Stock = "Jumlah Stock : ";
            string DataTersimpan = "Data Tersimpan !";
           
            Console.WriteLine("Masukan Jenis Barang : ");
            Console.WriteLine("1. Aksesoris Komputer");
            Console.WriteLine("2. Laptop");
            Console.WriteLine("3. Printer");
            int typeBarang = Int16.Parse(Console.ReadLine());
            Console.Write(KodeBarang);
            string kodeBarang = Console.ReadLine();
            Console.Write(NamaBarang);
            string namaBarang = Console.ReadLine();
            Console.Write(Stock);
            int stock = Int16.Parse(Console.ReadLine());

            Barang barang1 = new Barang()
            {
                KodeBarang = kodeBarang,
                NamaBarang = namaBarang,
                StockBarang = stock
            };

            switch (typeBarang)
            {
                case 1:
                    //buat aksesoris
                    Console.Write("Merk Barang : ");
                    string merkBarang = Console.ReadLine();
                    
                    Aksesoris aksesoris = new Aksesoris();
                    aksesoris.DescBarang = barang1;
                    aksesoris.MerkBarang = merkBarang;

                    GlobalVariable.daftarAksesoris.Add(aksesoris);
                    break;
                case 2:
                    //buat laptop
                    Console.Write("Merk Barang : ");
                    string merk = Console.ReadLine();

                    Laptop laptop = new Laptop();
                    laptop.DescBarang = barang1;
                    laptop.Merk = merk;

                    GlobalVariable.daftarLaptop.Add(laptop);
                    break;
                case 3:
                    Console.Write("Merk Barang : ");
                    string merkPrinter = Console.ReadLine();
                    
                    //buat printer
                    Printer printer = new Printer();
                    printer.DescBarang = barang1;
                    printer.Merkprinter =  merkPrinter;

                    GlobalVariable.daftarPrinter.Add(printer);
                    break;
                default:
                    break;
            }
            
            
            Console.Clear();
            Console.WriteLine("Data tersimpan ....");
            
            showMenuUtama();

        }
    }


}
