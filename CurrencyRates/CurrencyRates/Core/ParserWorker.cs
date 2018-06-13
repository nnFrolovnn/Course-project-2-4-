using AngleSharp.Parser.Html;
using CurrencyRates.core;
using CurrencyRates.NBRB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyRates.bank
{
    class ParserWorker<T> where T: class
    {
        private IParser<T> parser;
        private IParserSettings parserSettings;
        HtmlLoader loader;

        #region Properties
        public IParser<T> Parser { get => parser; set { parser = value; } }
        public IParserSettings ParserSettings { get => parserSettings; set { parserSettings = value; loader = new HtmlLoader(value); } }
        #endregion

        public ParserWorker(IParser<T> newparser)
        {
            parser = newparser;
        }
        public ParserWorker(IParser<T> newparser, IParserSettings newsettings): this(newparser)
        {
            parserSettings = newsettings;
        }

        public async Task<T> Parse ()
        {
            string source = loader.GetPage();
            var domParser = new HtmlParser();

            var document = await domParser.ParseAsync(source);
            var result = parser.Parse(document);
            return result; 
        }
    }
}
