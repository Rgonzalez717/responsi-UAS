using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsi
{
  


    class Program
    {
        

        static void Main(string[] args)
        {

            List<Customer> listCustomer = new List<Customer>();
            void tampil_customer()
            {
                Console.WriteLine("\n");
                int noUrut = 1;

                foreach (Customer customer in listCustomer)
                {

                    Console.WriteLine("{0}. Kode Customer: {1}, Nama Customer: {2}, Total Piutang: {3:N0}", noUrut, customer.Kode, customer.Nama, customer.Piutang);

                    noUrut++;
                }

            }

            void tambah_customer(string kode, string nama, int piutang)
            {

                listCustomer.Add(new Customer { Kode = kode, Nama = nama, Piutang = piutang });

            }

            void hapus_customer(string kode)
            {
                
                if (listCustomer.Any(a => a.Kode == kode))
                {
                    listCustomer.RemoveAll(b => b.Kode == kode);
                    Console.WriteLine("\nData customer berhasil dihapus\n");
                }
                else
                {
                    Console.WriteLine("Kode customer tidak ditemukan\n");
                }
            }



            bool keluar = false;
            while (keluar == false)
            {

            Console.WriteLine("\nPilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Customer");
            Console.WriteLine("2. Hapus Customer");
            Console.WriteLine("3. Tampilkan Customer");
            Console.WriteLine("4. Keluar\n");
            Console.Write("Pilih Menu [1-4] : ");
                int menu = int.Parse(Console.ReadLine());
                
                if(menu==1)
                {
                    string kode, nama;
                    int piutang;
                    Console.WriteLine("\n\nTambah Data Customer \n");
                    Console.Write("Kode Customer : ");
                    kode = Console.ReadLine();
                    Console.Write("Nama Customer : ");
                    nama = Console.ReadLine();
                    Console.Write("Total Piutang Customer : ");
                    piutang = int.Parse(Console.ReadLine());

                    tambah_customer(kode, nama, piutang);

                }
                if(menu==2)
                {
                    string kode;
                    Console.WriteLine("\n\nHapus Data Customer \n");
                    Console.Write("Kode Customer : ");
                    kode = Console.ReadLine();
                    hapus_customer(kode);

                }
                if(menu==3)
                {
                    tampil_customer();
                }
                if(menu==4)
                {
                    keluar = true;
                }

            }

            Console.ReadKey();

        }
    }
}
