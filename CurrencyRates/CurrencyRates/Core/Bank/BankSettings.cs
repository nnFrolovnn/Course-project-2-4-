using CurrencyRates.core;
using System;

namespace CurrencyRates.bank
{
    class BankSettings : IParserSettings
    {
        string urltoparse;
        string selector;
        string classname;
        public string URLtoParse { get => urltoparse; set { urltoparse = value; } }

        public string Selector { get => selector; set { selector = value; } }
        public string Classname { get => classname; set { classname = value; } }

        public BankSettings(string url, string selector, string classname)
        {
            URLtoParse = url;
            Selector = selector;
            Classname = classname;
        }
        public BankSettings(string url)
        {
            URLtoParse = url;
            selector = "1";
            classname = "1";
        }
    }
}
