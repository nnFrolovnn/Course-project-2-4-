using CurrencyRates.bank;
using CurrencyRates.core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Windows;

namespace CurrencyRates.NBRB
{
    class NatBank
    {
        private IParserSettings settings;
        HtmlLoader loader;

        public IParserSettings Settings { get => settings; }

        public NatBank()
        {
            settings = new BankSettings($"http://www.nbrb.by/API/ExRates/Rates?Periodicity=0");
            loader = new HtmlLoader(settings);
        }

        public Rate[] GetAllRates()
        {
            loader.URL = $"http://www.nbrb.by/API/ExRates/Rates?Periodicity=0";
            string page = loader.GetPage();
            if (page != null)
            {
                Rate[] rates = GetRatesFromPage(page);
                return rates;
            }
            else
            {
                return null;
            }
        }

        private Rate[] GetRatesFromPage(string page)
        {
            try
            {
                DataContractJsonSerializerSettings settings = new DataContractJsonSerializerSettings();
                settings.DateTimeFormat = new System.Runtime.Serialization.DateTimeFormat("yyyy-MM-ddTHH:mm:ss");

                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Rate[]), settings);


                StreamWriter sw = new StreamWriter("rates.json");
                sw.Write(page);
                sw.Close();

                FileStream fs = new FileStream("rates.json", FileMode.OpenOrCreate);

                Rate[] rates = (Rate[])jsonFormatter.ReadObject(fs);
                fs.Close();

                return rates;
            }
            catch
            {
                return null;
            }
        }

        public RateShort[] GetRateForPeriod(int cur_id, DateTime startDate, DateTime endDate)
        {
            string url = $"http://www.nbrb.by/API/ExRates/Rates/Dynamics/[ID]?startDate=[startDate]&endDate=[endDate]";
            string date1 = startDate.Month.ToString() + '-' + startDate.Day.ToString() + '-' + startDate.Year.ToString();
            string date2 = endDate.Month.ToString() + '-' + endDate.Day.ToString() + '-' + endDate.Year.ToString();

            url = url.Replace("[ID]", cur_id.ToString());
            url = url.Replace("[startDate]", date1);
            url = url.Replace("[endDate]", date2);

            string page = loader.GetPage(url);
            if (page != null)
            {
                RateShort[] rates = GetStatFromPage(page);
                return rates;
            }
            else
            {
                return null;
            }
        }

        private RateShort[] GetStatFromPage(string page)
        {
            try
            {
                DataContractJsonSerializerSettings settings = new DataContractJsonSerializerSettings();
                settings.DateTimeFormat = new System.Runtime.Serialization.DateTimeFormat("yyyy-MM-ddTHH:mm:ss");

                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(RateShort[]), settings);


                StreamWriter sw = new StreamWriter("statistics.json");
                sw.Write(page);
                sw.Close();

                FileStream fs = new FileStream("statistics.json", FileMode.OpenOrCreate);

                RateShort[] rates = (RateShort[])jsonFormatter.ReadObject(fs);
                fs.Close();

                return rates;
            }
            catch
            {
                return null;
            }
        }
    }
}
