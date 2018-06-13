using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyRates.core
{
    interface IParserSettings
    {
        string URLtoParse { get; set; }

        string Selector { get; set; }
        string Classname { get; set; }
    }
}
