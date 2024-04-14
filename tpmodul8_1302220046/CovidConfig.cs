using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Text.Json.Serialization;


public class CovidConfig()
	{
    public string satuan_suhu { get; set; }
    public int batas_hari_demam { get; set; }

    public string pesan_ditolak { get; set; }

    public string pesan_diterima { get; set; }



    public CovidConfig ReadJSON()
    {
        if (File.Exists("C:\\Users\\LENOVO\\Downloads\\skool tugas\\Semester 4\\Konstruksi\\tp\\mod8\\tpmodul8_1302220046\\tpmodul8_1302220046\\covid_config.json"))
        {
            string json = File.ReadAllText("C:\\Users\\LENOVO\\Downloads\\skool tugas\\Semester 4\\Konstruksi\\tp\\mod8\\tpmodul8_1302220046\\tpmodul8_1302220046\\covid_config.json");
            CovidConfig data = JsonConvert.DeserializeObject<CovidConfig>(json);
            this.satuan_suhu = data.satuan_suhu;
            this.batas_hari_demam = data.batas_hari_demam;
            this.pesan_ditolak = data.pesan_ditolak;
            this.pesan_diterima = data.pesan_diterima;


            return data;
        }
    
            else {
                
                this.satuan_suhu = "celcius";
                this. batas_hari_demam = 14;
                this.pesan_ditolak = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
                this.pesan_diterima = "Anda dipersilahkan untuk masuk ke dalam gedung ini";
                return this;
            }
        }
    


    public void UbahSatuan()
    {
        if (satuan_suhu == "celcius")
        {
            satuan_suhu = "fahrenheit";
        }
        else if (satuan_suhu == "fahrenheit")
        {
            satuan_suhu = "celcius";
        }
    }


}

