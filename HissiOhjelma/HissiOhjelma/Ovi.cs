namespace HissiOhjelma
{
    class Ovi
    {
        private bool auki;

        public Ovi()
        {
            auki = false;
        }

        public bool Tila()
        {
            return auki;
        }

        public void KaytaOvea()
        {
            auki = !auki;
        }
    }
}