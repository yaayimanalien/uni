using System;

namespace _11._1
{
    public class Darbinieks
    {
        private string vards;
        private string uzvards;
        private int dzimsanas_gads;
        private int vecums;

        public string Vards
        {
            get { return vards; }
            set
            {
                if (value.Length <= 20)
                {
                    vards = value;
                }
            }
        }

        public string Uzvards
        {
            get { return uzvards; }
            set
            {
                if (!string.IsNullOrEmpty(vards))
                {
                    uzvards = value;
                }
            }
        }

        public int DzimsanasGads
        {
            //get { return dzimsanas_gads; }
            set { dzimsanas_gads = value; }
        }

        public int Vecums
        {
            get { return VecumsNoDzimsanasGada(dzimsanas_gads); }
        }

        int VecumsNoDzimsanasGada(int _dzimsanas_gads)
        {
            return vecums = DateTime.Today.Year - _dzimsanas_gads;
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== PARASTS DARBINIEKS ===");
            Darbinieks darbinieks = new Darbinieks();
            darbinieks.Vards = "Reinis";
            Console.WriteLine($"darbinieks.Vards = {darbinieks.Vards}, varda garums = {darbinieks.Vards.Length}");
            darbinieks.Uzvards = "Barons";
            
            // piemers bez varda
            Console.WriteLine("=== DARBINIEKS BEZ VARDA ===");
            Darbinieks darbinieksBezVarda = new Darbinieks();
            darbinieksBezVarda.Uzvards = "Barons";
            
            if (darbinieksBezVarda.Vards == null)
            {
                Console.WriteLine($"Darbiniekam ir vārds: {darbinieksBezVarda.Vards != null}, darbiniekam uzvārds tika iestadīts: {darbinieksBezVarda.Uzvards != null}");
            }

            Console.WriteLine("=== DARBINIEKS AR GARU VARDU ===");
            Darbinieks arGaruVardu = new Darbinieks();
            arGaruVardu.Vards = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Console.WriteLine($"Darbinieka varda garums: {"aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa".Length}");
            Console.WriteLine($"Vai vardu izdevas ievietot: {arGaruVardu.Vards != null}");

          
            
            // dzimsanas gadu nevar sanemt

            //arGaruVardu.Vecums = 20; // nevar pievienot vērtību vecums
            arGaruVardu.DzimsanasGads = 2004;
            // Console.WriteLine(arGaruVardu.DzimsanasGads);
            
            // Vecumu nevar piešķirt
            // arGaruVardu.Vecums = 20;

        }
    }
};

