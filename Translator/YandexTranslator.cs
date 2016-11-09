using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Translator
{
    class YandexTranslator
    {
        public string Translate(string s, string lang)
        {
            if (s.Length > 0)
            {
                WebRequest request = WebRequest.Create("https://translate.yandex.net/api/v1.5/tr.json/translate?"
                    + "key=ВАШ API-КЛЮЧ"
                    + "&text=" + s
                    + "&lang=" + lang);
                WebResponse response = request.GetResponse();

                using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                {
                    string line;
                    if ((line = stream.ReadLine()) != null)
                    {
                        s = line.Substring(line.IndexOf(":[\"") + 3);
                        s = s.Remove(s.Length - 3);
                    }
                }

                return s;
            }
            else
                return "";
        }
    }
}