using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UniAccreditations.Pages
{
    public class IndexModel : PageModel
    {
        public static List<List<string>> UniList = new List<List<string>>();

        public void OnGet()
        {

        }

        public static string getInfo()
        {
            XmlDocument doc = new XmlDocument();
            var fileName = "\\UniList.xml";
            var path = System.IO.Directory.GetCurrentDirectory() + fileName;
            doc.Load(path);
            XElement e = XElement.Load(new XmlNodeReader(doc));
            var elements = e.Elements("data");

            foreach (var item in elements)
            {
                var store = item.Elements();

               UniList.Add(new List<string>()
                {
                    store.ElementAt(0).Value,
                    store.ElementAt(1).Value,
                    store.ElementAt(2).Value,
                    store.ElementAt(3).Value,
                    store.ElementAt(4).Value,
                    store.ElementAt(5).Value,
                     store.ElementAt(6).Value
                });

            }
            return "";
        }

    }
}
