using System;
using System.Linq;

namespace Savarankiski
{
    class Program
    {
        public struct Studentas
        {
            public int[] PirmasSemestras;
            public int[] AntrasSemestras;
            public int[] TreciasSemestras;


            public Studentas(int[] pirmasSemetras, int[] antrasSemetras, int[] treciasSemetras)
            {
                PirmasSemestras = pirmasSemetras;
                AntrasSemestras = antrasSemetras;
                TreciasSemestras = treciasSemetras;
            }

            public void MetinisVidurkis()
            {
                double vidurkis1 = PirmasSemestras.Average();
                double vidurkis2 = AntrasSemestras.Average();
                double vidurkis3 = TreciasSemestras.Average();
                Console.WriteLine($"Semestru vidurkiai: {vidurkis1}, {vidurkis2}, {vidurkis3}");
                Console.WriteLine($"Metinis vidurkis: {(vidurkis1 + vidurkis2 + vidurkis3) / 3}");

            }

            public struct Rinkejas
            {
                public int ID;
                public string Balsavo;

                public Rinkejas(int id, string balsavo)
                {
                    ID = id;
                    Balsavo = balsavo;
                }

                static void Main(string[] args)
                {
                    string [] sarasas = new string[10];
                    int balsavo = 0;
                    Studentas studentas = new Studentas(new int[] { 10, 3, 5, 9, 9 }, new int[] { 4, 3, 4, 7, 9 }, new int[] { 10, 3, 5, 7, 9 });
                    studentas.MetinisVidurkis();

                    Rinkejas rinkejas1 = new Rinkejas(193, "balsavo");
                    sarasas[0] = rinkejas1.Balsavo;
                    Rinkejas rinkejas2 = new Rinkejas(234, "balsavo");
                    sarasas[1] = rinkejas2.Balsavo;
                    Rinkejas rinkejas3 = new Rinkejas(343, "balsavo");
                    sarasas[2] = rinkejas3.Balsavo;
                    Rinkejas rinkejas4 = new Rinkejas(673, "nebalsavo");
                    sarasas[3] = rinkejas4.Balsavo;
                    Rinkejas rinkejas5 = new Rinkejas(553, "balsavo");
                    sarasas[4] = rinkejas5.Balsavo;
                    balsavo = sarasas.Count(s => s == "balsavo");
                    Console.WriteLine($"Is 5 rinkeju {balsavo} balsavo ir {(5 - balsavo)} nebalsavo.");
                }
            }
        }
    }
}
