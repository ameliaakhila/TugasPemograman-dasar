using System;

namespace AplikasiInapHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplikasi Inap Hotel Jaya Abadi");
            Console.WriteLine("==============================");

            // Input Nama Lengkap
            Console.Write("Nama Lengkap : ");
            string nama = Console.ReadLine();

            // Input Tipe Kamar
            Console.WriteLine("Tipe Kamar :");
            Console.WriteLine("01. Bunga");
			Console.WriteLine("02. Melati");
            Console.WriteLine("03. Mawar");
            Console.WriteLine("04. Tulip");
            Console.Write("Pilih Tipe Kamar [01-04] : ");
            string tipeKamar = Console.ReadLine();

            // Input Lama Inap
            Console.Write("Lama Inap (dalam hari) : ");
            int lamaInap = int.Parse(Console.ReadLine());

            // Deklarasi Variabel Harga Kamar
            int hargaKamar = 0;

            // Tentukan Harga Kamar
            switch (tipeKamar)
            {
                case "01":
				hargaKamar = (750000);
                    Console.WriteLine("Tipe Kamar : Bunga");
                    break;
                case "02":
                    hargaKamar = (530000);
                    Console.WriteLine("Tipe Kamar : Melati");
                    break;
                case "03":
                    hargaKamar = (850000);
                    Console.WriteLine("Tipe Kamar : Mawar");
                    break;
                case "04":
                    hargaKamar = (1320000);
                    Console.WriteLine("Tipe Kamar : Tulip");
                    break;
                default:
                    Console.WriteLine("Tipe Kamar");
				
                    break;
            }

            // Hitung Potongan Harga
            int potonganHarga = 0;
            if (lamaInap > 5)
            {
                switch (tipeKamar)
                {
                    case "01":
                        potonganHarga = (int)(hargaKamar * 0.08);
                        break;
                    case "02":
                        potonganHarga = (int)(hargaKamar * 0.03);
                        break;
                    case "03":
                        potonganHarga = (int)(hargaKamar * 0.1);

                        break;
                    case "04":
                        potonganHarga = (int)(hargaKamar * 0.12);
                        break;
                }
            }

            // Hitung Total Pembayaran
            int totalPembayaran = (hargaKamar * lamaInap) - potonganHarga;

            // Output Rincian Harga Inap
            Console.WriteLine("Rincian Harga Inap :");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Tipe Kamar : " + ((tipeKamar == "01") ? "Bunga" : (tipeKamar == "02") ? "Melati" : (tipeKamar 

== "03") ? "Mawar" : "Tulip"));
            Console.WriteLine("Harga : " + hargaKamar.ToString("C0") + " / Perhari");
            Console.WriteLine("Potongan Harga : " + potonganHarga.ToString("C0"));
            Console.WriteLine("Total Pembayaran : " + totalPembayaran.ToString("C0"));
Console.ReadLine();
        }
    }
}
