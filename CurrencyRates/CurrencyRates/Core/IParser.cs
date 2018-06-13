using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Dom.Html;

namespace CurrencyRates.core
{
    interface IParser<T> where T : class
    { 
        T Parse(IHtmlDocument document);
    }
}
