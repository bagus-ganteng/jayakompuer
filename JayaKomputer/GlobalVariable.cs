using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JayaKomputer
{
    public static class GlobalVariable
    {
        private static List<Aksesoris> _daftarAksesoris;
        private static List<Laptop> _daftarLaptop;
        private static List<Printer> _daftarPrinter;
        private static List<Pelanggan> _daftarPelanggan;
        public static List<Aksesoris> daftarAksesoris {
            get
            {
                if (_daftarAksesoris == null) {
                    _daftarAksesoris = new List<Aksesoris>();
                }
                return _daftarAksesoris;
            }
            set
            {
                _daftarAksesoris = value;
            }
        }
        public static List<Printer> daftarPrinter
        {
            get
            {
                if (_daftarPrinter == null) {
                    _daftarPrinter = new List<Printer>();
                }
                return _daftarPrinter;
            }

            set
            {
                _daftarPrinter = value;
            }
        }
        public static List<Laptop> daftarLaptop {
            get
            {
                if (_daftarLaptop == null)
                {
                    _daftarLaptop = new List<Laptop>();
                }
                return _daftarLaptop;
            }
            set
            {
                _daftarLaptop = value;
            }
        }

        public static List<Pelanggan> daftarPelanggan {
            get
            {
                if (_daftarPelanggan == null)
                {
                    _daftarPelanggan = new List<Pelanggan>();
                }
                return _daftarPelanggan;
            }
            set
            {
                _daftarPelanggan = value;
            }
        }
    }
}
