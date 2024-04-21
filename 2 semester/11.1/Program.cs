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
                if (value.Length >= 20)
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
                if (vards != string.Empty)
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
            Darbinieks darbinieks = new Darbinieks();
            darbinieks.Uzvards = "Sirmais";
            Console.WriteLine(darbinieks.Uzvards);

        }
    }
};

