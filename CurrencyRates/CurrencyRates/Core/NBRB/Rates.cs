using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CurrencyRates.NBRB
{
    [DataContract]
    public class Rate
    {
        private decimal? _cur_OfficialRate;
        private string _cur_Name;
        private int _cur_Scale;
        private string _cur_Abbreviation;
        private DateTime _date;
        private int _cur_ID;

        [DataMember]
        public int Cur_ID { get => _cur_ID; set => _cur_ID = value; }
        [DataMember]
        public DateTime Date { get => _date; set => _date = value; }
        [DataMember]
        public string Cur_Abbreviation { get => _cur_Abbreviation; set => _cur_Abbreviation = value; }
        [DataMember]
        public int Cur_Scale { get => _cur_Scale; set => _cur_Scale = value; }
        [DataMember]
        public string Cur_Name { get => _cur_Name; set => _cur_Name = value; }
        [DataMember]
        public decimal? Cur_OfficialRate { get => _cur_OfficialRate; set => _cur_OfficialRate = value; }      
    }

    [DataContract]
    [Serializable]
    public class RateShort
    {
        private decimal? _cur_SellRate;
        private decimal? _cur_BuyRate;
        private string _cur_Name;
        private int _cur_Scale;
        private string _cur_Abbreviation;

        public decimal? Cur_SellRate { get => _cur_SellRate; set => _cur_SellRate = value; }
        public decimal? Cur_BuyRate { get => _cur_BuyRate; set => _cur_BuyRate = value; }
        public string Cur_Name { get => _cur_Name; set => _cur_Name = value; }
        public int Cur_Scale { get => _cur_Scale; set => _cur_Scale = value; }
        public string Cur_Abbreviation { get => _cur_Abbreviation; set => _cur_Abbreviation = value; }

        [DataMember]
        public int Cur_ID { get; set; }
        [Key]
        [DataMember]
        public System.DateTime Date { get; set; }
        [DataMember]
        public decimal? Cur_OfficialRate { get; set; }



        public RateShort (decimal? cur_SellRate, decimal? cur_BuyRate, string cur_Name, int cur_Scale, string cur_Abbreviation)
        {
            Cur_SellRate = cur_SellRate;
            Cur_BuyRate = cur_BuyRate;
            Cur_Name = cur_Name;
            Cur_Scale = cur_Scale;
            Cur_Abbreviation = cur_Abbreviation;
        }
    }

}