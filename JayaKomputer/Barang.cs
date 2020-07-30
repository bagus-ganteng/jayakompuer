using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JayaKomputer
{
    public class Barang
    {
        public List<Aksesoris> _aksesoris;
        public string KodeBarang { get; set; }
        public string NamaBarang { get; set; }
        public int StockBarang { get; set; }

        public static void showDaftarBarang() {
            if (GlobalVariable.daftarLaptop.Count >= 1)
            {
                Console.Clear();
                Console.WriteLine("Kode\tNama Barang\tStok\tMerk");
                foreach (var item in GlobalVariable.daftarLaptop)
                {

                    Console.Write(item.DescBarang.KodeBarang);
                    Console.Write("\t");
                    Console.Write(item.DescBarang.NamaBarang);
                    Console.Write("\t\t");
                    Console.Write(item.DescBarang.StockBarang);
                    Console.Write("\t");
                    Console.WriteLine(item.Merk);

                    Console.WriteLine("Tekan Enter untuk kembali ke Menu");
                    Console.ReadLine();
                    Menu.showMenuUtama();
                }
            }

            if (GlobalVariable.daftarAksesoris.Count >= 1)
            {
                Console.Clear();
                Console.WriteLine("Kode\tNama Barang\tStok\tMerk");
                foreach (var item in GlobalVariable.daftarAksesoris)
                {
                    Console.Write(item.DescBarang.KodeBarang);
                    Console.Write("\t");
                    Console.Write(item.DescBarang.NamaBarang);
                    Console.Write("\t\t");
                    Console.Write(item.DescBarang.StockBarang);
                    Console.Write("\t");
                    Console.WriteLine(item.MerkBarang);

                    Console.WriteLine("Tekan Enter untuk kembali ke Menu");
                    Console.ReadLine();
                    Menu.showMenuUtama();
                }

            }

            if (GlobalVariable.daftarPrinter.Count >= 1)
            {
                Console.Clear();
                Console.WriteLine("Kode\tNama Barang\tStok\tMerk");
                foreach (var item in GlobalVariable.daftarPrinter)
                {
                    
                    Console.Write(item.DescBarang.KodeBarang);
                    Console.Write("\t");
                    Console.Write(item.DescBarang.NamaBarang);
                    Console.Write("\t\t ");
                    Console.Write(item.DescBarang.StockBarang);
                    Console.Write("\t");
                    Console.WriteLine(item.Merkprinter);

                    Console.WriteLine("Tekan Enter untuk kembali ke Menu");
                    Console.ReadLine();
                    Menu.showMenuUtama();
                }
            }

        }
        }
}
