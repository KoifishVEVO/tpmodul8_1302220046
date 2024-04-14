// See https://aka.ms/new-console-template for more information


using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        CovidConfig config = new CovidConfig();
        config.ReadJSON();

        Console.WriteLine(config.satuan_suhu);

        Console.WriteLine("Berapa suhu badan anda saat ini? Dalam nilai " + config.satuan_suhu);

        double suhu = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir demam: ");

        int hari = int.Parse(Console.ReadLine());

        Console.WriteLine(suhu);

        if (config.satuan_suhu == "celcius")
        {
            if ((suhu >= 36.5 && suhu <= 37.5) && hari < config.batas_hari_demam)
            {
                Console.WriteLine(config.pesan_diterima);
            }
            else
            {
                Console.WriteLine(config.pesan_ditolak);
            }
        }

        config.UbahSatuan();

        Console.WriteLine(config.satuan_suhu);
        Console.WriteLine("Berapa suhu badan anda saat ini? Dalam nilai " + config.satuan_suhu);
        double SuhuF = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir demam: ");
        int HariF = int.Parse(Console.ReadLine());

        if (config.satuan_suhu == "fahrenheit")
        {
            if ((SuhuF >= 97.7 && SuhuF <= 99.5) && HariF < config.batas_hari_demam)
            {
                Console.WriteLine(config.pesan_diterima);
            }
            else
            {
                Console.WriteLine(config.pesan_ditolak);
            }
        }
    }

}

