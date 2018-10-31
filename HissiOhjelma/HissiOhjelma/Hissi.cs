namespace HissiOhjelma
{
    class Hissi
    {
        private bool huolto = false;
        private int kerros;
        private int kerrokset;
        private Ovi ovi;

        public Hissi(int lkm)
        {
            kerrokset = lkm;
            ovi = new Ovi();
            kerros = 1;
        }
        
        public void Liiku(int k)
        {
            if (k > 0 && k <= kerrokset)
            {
                if (!huolto && !ovi.Tila())
                {
                    if (k > kerros)
                    {
                        kerros = k;
                        System.Console.WriteLine("Hissi nousee kerrokseen " + k);
                    }
                    else if (k < kerros)
                    {
                        kerros = k;
                        System.Console.WriteLine("Hissi laskeutuu kerrokseen " + k);
                    }
                    else System.Console.WriteLine("Sama kerros");
                }
                else System.Console.WriteLine("Hissi ei ole käytössä.");
            }
            else System.Console.WriteLine("Hississä ei ole tuollaista kerrosta.");
        }

        public void Huolto()
        {
            if (!huolto) { System.Console.WriteLine("Hissi on nyt huollossa."); }
            else System.Console.WriteLine("Hissi ei ole enää huollossa.");

            huolto = !huolto;
        }

        public void Ovi()
        {
            if (ovi.Tila()) { System.Console.WriteLine("Ovi on nyt kiinni."); }
            else System.Console.WriteLine("Ovi on nyt auki.");

            ovi.KaytaOvea();
        }
    }
}