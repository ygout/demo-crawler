using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace demoCrawler
{
    class Program
    {
        static void Main(string[] args)
        {
            startCrawlerasync();
            Console.ReadLine();
        }

        private static async Task startCrawlerasync()
        {
            // the url of the page we want test
            var url = "http://www.automobile.tn/neuf/bmw.3/";
            var httpClient = new HttpClient();

            // recover html page from url
            string html = await httpClient.GetStringAsync(url);

            // convert string to html object wrapper c#
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            // store all div elements about a vehicle information into array
            List<HtmlNode> divs = htmlDocument.DocumentNode.Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("versions-item")).ToList();
            //List Cars
            List<Car> cars = new List<Car>();
            // Browse divs array
            int price = 0;
            string priceHtml;
            foreach(HtmlNode div in divs)
            {
                priceHtml = div.SelectSingleNode(".//div[@class='price']/span").InnerText.Substring(0, div.SelectSingleNode(".//div[@class='price']/span").InnerHtml.IndexOf('<'));
                if (int.TryParse(Regex.Replace(priceHtml.Trim(), @"\s+", ""), out price))
                {
                    var car = new Car
                    {
                        Model = div.Descendants("h2").FirstOrDefault().InnerText,
                        Price = price,
                        Link = div.Descendants("a").FirstOrDefault().ChildAttributes("href").FirstOrDefault().Value,
                        ImageUrl = div.Descendants("img").FirstOrDefault().ChildAttributes("src").FirstOrDefault().Value
                    };
                    cars.Add(car);
                }
                else
                    throw new Exception();
                

            }
        }
    }
}
