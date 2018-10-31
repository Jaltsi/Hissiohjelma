using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HissiOhjelma
{
    class HissiOhjelma
    {
        public static void Main()
        {
            Hissi hissi = new Hissi(10);

            Console.WriteLine("Hissi liikkuu numeroilla");
            Console.WriteLine("Anna komento > ");
            string komento;

            while (true)
            {
                komento = Console.ReadLine();
                if(komento == "ovi")
                {
                    hissi.Ovi();
                }
                if (int.TryParse(komento, out int luku))
                {
                    hissi.Liiku(luku);
                }
                if(komento == "huolto")
                {
                    hissi.Huolto();
                }
            }
        }
    }
}