using System;

namespace inheritance_test
{
    class Prece
    {
        public string Nosaukums; // Change access modifier to protected
        public double Iepirksanas_cena;

        // Other members...
    }
    class Partikas_Prece : Prece
    {
        private DateTime Deriguma_termins;
        private bool Ir_alergisks;
        private string Mervieniba;
        public void Registret(string nosaukums, double iepirksanasCena, DateTime derigumaTermins, bool irAlergisks, string mervieniba)
        {
            Nosaukums = nosaukums; // Accessing inherited field
            Iepirksanas_cena = iepirksanasCena;
            Deriguma_termins = derigumaTermins;
            Ir_alergisks = irAlergisks;
            Mervieniba = mervieniba;
        }

        // Other members...
    }

    class Saimniecibas_Prece : Prece
    {
        private string Materials;
        private bool Ir_bistama;

        public void Registret(string nosaukums, double iepirksanasCena, string materials, bool irBistama)
        {
            Nosaukums = nosaukums; // Accessing inherited field
            Iepirksanas_cena = iepirksanasCena;
            Materials = materials;
            Ir_bistama = irBistama;
        }

        // Other members...
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}