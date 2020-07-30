using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JayaKomputer
{
    public class Pelanggan
    {
        public string NamaPelanggan { get; set; }
        public string KodePelanggan { get; set; }
        public string ContactPelanggan { get; set; }


        public static void showDataPelanggan()
        {
            foreach (var item in GlobalVariable.daftarPelanggan)
            {
                Console.WriteLine(item.KodePelanggan);
                Console.WriteLine(item.NamaPelanggan);
                Console.WriteLine(item.ContactPelanggan);
            }
            Menu.showMenuUtama();

        }
    }
}
