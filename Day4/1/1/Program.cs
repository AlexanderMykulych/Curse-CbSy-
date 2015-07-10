using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1 {
    class Program {
        static Regex _hrefRegex = new Regex(@"href=['""](?<link>\S+)['""]\S*\s*\S*>(?<text>\S*)");
        static Regex _telRegex = new Regex(@"(?<tel>\+\d{12})");
        static Regex _emailRegex = new Regex(@"(?<mail>\S+@\S{2,10}\.\S{2,5})");
        static Regex _siteSlesh = new Regex(@"[:/]+");
        static void Main(string[] args) {
            var sites = new List<string>();
            using (var inputFile = new StreamReader("input.txt")) {
                while (!inputFile.EndOfStream) {
                    sites.Add(inputFile.ReadLine());
                }
            }
            foreach (var site in sites) {
                var request = ((HttpWebRequest)HttpWebRequest.Create(site)).GetResponse();
                var text = String.Empty;
                using(var reqStream = new StreamReader(request.GetResponseStream(), Encoding.UTF8)){
                    text = reqStream.ReadToEnd();
                }
                var fileName = string.Format("{0}.out.txt", _siteSlesh.Replace(site, x => "."));
                using (var file = new StreamWriter(fileName)) {
                    file.WriteLine(@"___________LINKS____________");
                    foreach (Match match in _hrefRegex.Matches(text)) {
                        file.WriteLine("link='{0}',  text='{1}'", match.Groups["link"], match.Groups["text"]);
                    }
                    file.WriteLine(@"___________TELEPHONE____________");
                    foreach (Match match in _telRegex.Matches(text)) {
                        file.WriteLine("tel='{0}'", match.Groups["tel"]);
                    }
                    file.WriteLine(@"___________EMAILS____________");
                    foreach (Match match in _emailRegex.Matches(text)) {
                        file.WriteLine("mail='{0}'", match.Groups["mail"]);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
