using System;

namespace Kwadrat
{
    
   
        class Prostokat
        {
            private int dlugosc;
            private int szerokosc;

            public Prostokat(int dlu, int szer)
            {
                dlugosc = dlu;
                szerokosc = szer;
            }

            public static int najwiekszy(Prostokat[] tab)
            {
                int najw = 0;
                for (int i = 0; i < tab.Length; i++)
                {
                    if (tab[i].powierzchnia() > najw)
                        najw = tab[i].powierzchnia();
                }
                return najw;
            }

            private int powierzchnia()
            {
                return dlugosc * szerokosc;
            }
            private int obwod()
            {
                return 2 * dlugosc + 2 * szerokosc;
            }

            public void Prezentuj()
            {
                Console.WriteLine("Obwód = " + obwod() + "\t" + "Powierzchnia = " + powierzchnia());
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Prostokat[] prost = new Prostokat[5];
                prost[0] = new Prostokat(3, 3);
                prost[1] = new Prostokat(3, 2);
                prost[2] = new Prostokat(4, 3);
                prost[3] = new Prostokat(4, 5);
                prost[4] = new Prostokat(3, 4);

                foreach (Prostokat x in prost)
                {
                    x.Prezentuj();
                }

                Console.WriteLine("Powierzchnia największego prostokąta = " + Prostokat.najwiekszy(prost));

                Console.ReadLine();
            }
        }
}
