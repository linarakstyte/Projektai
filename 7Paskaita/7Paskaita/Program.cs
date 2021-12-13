using System;
using System.Collections.Generic;
using System.Linq;

namespace _7Paskaita
{
    class Program
    {

        public struct Mokinys
        {
            public int [] PirmasSemestras;
            public int [] AntrasSemestras;
            public int [] TreciasSemestras;


            public Mokinys(int [] pirmasSemetras, int[] antrasSemetras, int[] treciasSemetras)
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
                Console.WriteLine($"Metinis vidurkis: {(vidurkis1 + vidurkis2 + vidurkis3)/3}");

            }

            public struct BibliotekosKnyga
            {
                int ID;
                string Pavadinimas;
                string Vardas;
                public DateTime Data;

                public BibliotekosKnyga(int id, string pavadinimas, string vardas, DateTime data)
                {
                    ID = id;
                    Pavadinimas = pavadinimas; ;
                    Vardas = vardas; ;
                    Data = data;
                }

                public int KiekDienu(DateTime data)
                {
                    DateTime today = DateTime.Today;
                    int dienuSkaicius = (today - data).Days;

                    return dienuSkaicius;

                }
                public struct Staciakampis
                {
                    int Ilgis;
                    int Plotis;

                    public int Plotas(int ilgis, int plotis)
                    {
                        Ilgis = ilgis;
                        Plotis = plotis;
                        return (ilgis * plotis);
                    }


                    static void Main(string[] args)
                    {
                        //Mokinys mokinys = new Mokinys("Petras", "Jonaitis", "Spalis", "Liepa");
                        //Console.WriteLine($"{ mokinys.Vardas} {mokinys.Pavarde} {mokinys.KursoPradzia} {mokinys.KursoPabaiga}");
                        BibliotekosKnyga knyga = new BibliotekosKnyga(4841012, "Svetimas", "Lina", new DateTime(2020, 10, 10));
                        int dienos = knyga.KiekDienu(new DateTime(2020, 10, 10));
                        Console.WriteLine($"{knyga.Vardas} buvo pasimusi/emes knyga {knyga.Pavadinimas} {dienos} dienas/u");

                        Staciakampis staciakampis1 = new Staciakampis();

                        Staciakampis staciakampis2 = new Staciakampis();

                        Staciakampis staciakampis3 = new Staciakampis();


                        Console.WriteLine($"Pasirinktu staciakampiu plotai: {staciakampis1.Plotas(10, 10)}, {staciakampis2.Plotas(20, 20)}, {staciakampis1.Plotas(30, 30)}");

                        Mokinys mokinys = new Mokinys(new int[] {0, 3, 5, 9, 9}, new int[] {4, 3, 4, 7, 9},new  int[] {1, 3, 5, 7, 9});
                        mokinys.MetinisVidurkis();
                    }
                }
                #region
                //public static decimal SkaiciuotiMokescius(decimal pajamos)
                //{
                //    decimal rezultatas = 0;

                //    if (pajamos <= 400)
                //    {
                //        rezultatas = pajamos * 0.05m;
                //    }
                //    else if (pajamos > 400 && pajamos <= 1000)
                //    {
                //        rezultatas = pajamos * 0.15m;
                //    }
                //    else
                //    {
                //        rezultatas = pajamos * 0.25m;
                //    }

                //    return rezultatas;
                #endregion
            }

        }
    }
    }


