
namespace csharp_geometria
{
    internal class Rettangolo
    {
        private readonly int baseRettangolo;
        private readonly int altezzaRettangolo;
        private readonly string nomeRettangolo;

        public Rettangolo(int iBaseRettangolo, int iAltezzaRettangolo, string iNomeRettangolo)
        {
            baseRettangolo = iBaseRettangolo;
            altezzaRettangolo = iAltezzaRettangolo;
            nomeRettangolo = iNomeRettangolo;
        }

        public static int AreaCalc(int iBase, int iAltezza)
        {
            int iArea = iBase * iAltezza;
            return iArea;
        }
        public static int PerimCalc(int iBase, int iAltezza)
        {
            int iPerim = 2 * (iBase + iAltezza);
            return iPerim;
        }
        public void StampaRettangolo()
        {
            //Console.WriteLine("-- {0} --" nomeRettangolo);
            //Console.WriteLine("base" nomeRettangolo);
            //Console.WriteLine("-- {0} --" nomeRettangolo);
            //Console.WriteLine("-- {0} --" nomeRettangolo);
            //Console.WriteLine("-- {0} --" nomeRettangolo);
        }
    }
}
