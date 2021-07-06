using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    class Answers
    {
        List<string> salam = new List<string> { "salam", "aleykum salam, necesen?" };
        List<string> hy = new List<string> { "yaxsiyam sen necesen?", "mesgulam yazma!", "cox sagol yaxsıyam", "sukur yaxsiyam" };
        List<string> h1 = new List<string> { "pul sayiram, money bot ne eder ki?", "hec ne sene ne?", "dincelirem", "cay icirem" };
        List<string> h2 = new List<string> { "basqa dilde basa dusmurem men", "basa dusmedim" };

        public string Answer(string type)
        {
            Random r = new Random();
            if (type == "salam")
            {
                var slm = salam.ToArray();
                int index = r.Next(slm.Length-1);
                return slm[index];
            }
            if (type == "necesen")
            {
                int index = r.Next(hy.Count);
                return hy[index];
            }
            if (type == "ne is gorursen?")
            {
                int index = r.Next(h1.Count);
                return h1[index];
            }
            else
            {
                int index = r.Next(h2.Count);
                return h2[index];
            }
        }
    }
}
