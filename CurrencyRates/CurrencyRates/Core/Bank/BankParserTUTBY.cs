using AngleSharp.Dom.Html;
using AngleSharp.Parser.Html;
using CurrencyRates.core;
using CurrencyRates.NBRB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace CurrencyRates.bank
{
    class BankParserTUTBY : IParser<RateShort[]>
    {
        /// <summary>
        /// return array whitch consists of data blocks 
        /// 1 currency name 2 buy rate 3 sell rate
        /// </summary>
        /// <param name="document"> contains data to parse </param>
        /// <returns></returns>
        public RateShort[] Parse(IHtmlDocument document)
        {
            var list = new List<string>();
            var parser = new HtmlParser();
            var items = document.QuerySelectorAll("table").Where(item => item.ClassName != null && item.ClassName.Contains("cursList_table"));
            string table = items.First().OuterHtml;

            var newdoc = parser.Parse(table);

            var td = newdoc.All.Where(m => m.LocalName == "td" && (m.ClassList.Contains("first")
                        || (m.Children.FirstOrDefault(x => x.LocalName == "big") != null && m.ClassName != "inctances")));

            foreach (var item in td)
            {
                if (item.LocalName == "td" && item.ClassName != null && item.ClassName.Contains("first"))
                {
                    if (item.TextContent != null)
                    {
                        list.Add(item.TextContent);
                    }
                }
                else
                {
                    try
                    {
                        var element = item.Children.First(x => x.LocalName == "big");
                        if (item.LocalName == "td" && element != null)
                        {
                            if (item.TextContent != null)
                            {
                                list.Add(element.TextContent);
                            }
                        }
                    }
                    catch { }
                }
            }
            return Transform(list);
        }

        private RateShort[] Transform(List<string> currlist)
        {
            if (currlist.Count >= 3)
            {
                List<RateShort> rates = new List<RateShort>();
                for (int i = 0; i < currlist.Count - 2; i++)
                {
                    if (i % 3 == 0)
                    {
                        currlist[i] = currlist[i].Trim();
                        currlist[i + 1] = currlist[i + 1].Trim();
                        currlist[i + 2] = currlist[i + 2].Trim();
                        currlist[i + 1] = currlist[i + 1].Replace('.', ',');
                        currlist[i + 2] = currlist[i + 2].Replace('.', ',');
                        rates.Add(new RateShort
                        (
                            (decimal?)Convert.ToDouble(currlist[i + 2]),
                            (decimal?)Convert.ToDouble(currlist[i + 1]),
                            currlist[i],
                            1,
                            "no"
                        ));
                    }
                }
                FillScale(ref rates);
                return rates.ToArray();
            }
            return null;
        }

        private void FillScale(ref List<RateShort> list)
        {
            foreach (RateShort item in list)
            {
                string name = item.Cur_Name;
                name.Trim();
                string scale = "";
                while (name[0] >= '0' && name[0] <= '9')
                {
                    scale += name[0];
                    name = name.Remove(0, 1);
                }

                item.Cur_Scale = (scale == "") ? 1 : Convert.ToInt32(scale);
            }
        }
    }
}
