using System;

public class myConsole
{
    static Random random = new Random();
    
    private static string _tagad = $"{DateTime.Today.Day}.{DateTime.Today.Month}.{DateTime.Today.Year}";
    
    public static string tagad
    {
        get => _tagad;
        private set => _tagad = value;
    }   // mainīgajam piešķirt patreizējo datumu. Formātu izvēlēties brīvi
    
    
    public static int NolasitKaInt()
    {
        // funkcija pieprasa lietotājam ievadīt veselo skaitli. Gadījumā, ja
        // lietotājs ievada veselo skaitli, atgriež to. Ja lietotājs ievadīja ne veselo
        // skaitli (burtus, simbolus) atgriež nulli un paziņo, ka konvertācija bija
        // neveiksmīga.

        int skaitlis;
        Console.Write("Ievadiet skaitli: ");
        if(int.TryParse(Console.ReadLine(), out skaitlis))
        {
            return skaitlis;
        }
        else
        {
            Console.WriteLine("Konvertācija bija neveiksmīga.");
            return 0;
        }
    }
    
    public static void Izvadit(string text)
    {
        //funkcija izvada tekstu text
        Console.WriteLine(text);
    }
    
    public static void NomainitFonaKrasu()
    {
        //funkcija nomaina konsoles fona krāsu uz gadījuma (!) krāsu
        
        // Random random = new Random();
        // ConsoleColor[] colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
        // ConsoleColor randomBackground = colors[random.Next(colors.Length)];
        // Console.BackgroundColor = randomBackground;
        
        //Console.BackgroundColor = ConsoleColor.DarkRed;
        
        Console.BackgroundColor = (ConsoleColor)random.Next(0,16);
    }
    
    public static void NomainitBurtuKrasu()
    {
        //funkcija nomaina konsoles burtu krāsu uz gadījuma (!) krāsu
        
        // Console.ForegroundColor = ConsoleColor.Red;
        
        // ConsoleColor[] colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
        // ConsoleColor randomForeground = colors[random.Next(colors.Length)];
        // Console.ForegroundColor = randomForeground;
        
        Console.ForegroundColor = (ConsoleColor)random.Next(0,16);
    }
    
    public static void FormatetVardu(string vards_uzvārds)
    {
        //funkcija saņem vārdu un uzvārdu kā vienu string, piemēram, "Ivars
        // Zars". Un izvada to sekojošā formātā - vārda pirmais burts. Uzvārds (piemēram,
        // "I. Zars")
        
        string vards = "";
        string uzvards = "";
        bool saciesUzvards = false;
        foreach (char c in vards_uzvārds)
        {
            if (c!=' ')
            {
                if (!saciesUzvards)
                {
                    vards += c;
                }
                else
                {
                    uzvards += c;
                }
            }
            else
            {
                saciesUzvards = true;
            }
        }

        Console.WriteLine($"{vards[0]}. {uzvards}");
    }

    public static string IzveidotParoli(int garums)
    {
        // funkcija veido un atgriež lietotājam drošo paroli. Paroles garumu
        // funkcija saņem. PAroles veidošanas principus jāizdomā pašam.
        
        Random random = new Random();
        string paswrd = "";
        for (int i = 0; i < garums; i++)
        {
            paswrd += (char)random.Next(33, 126);
        }
        return paswrd;
    }
    
    public static string SifretTekstu(ref string teksts)
    {
        string encrypted = "";
        for (int i = teksts.Length - 1; i >= 0; i--) 
        {
            encrypted += (char)((int)teksts[i] ^ teksts.Length); 
        }
        return encrypted;
    }

    public static string AtsifretTekstu(ref string teksts)
    {
        string decrypted = "";
        for (int i = teksts.Length - 1; i >= 0; i--) 
        {
            decrypted += (char)((int)teksts[i] ^ teksts.Length); 
        }
        return decrypted;
    }
}

internal class Program
{
    public static void Main()
    {
        // tagad un izvadīt pielietojums
        string tagad = myConsole.tagad;
        myConsole.Izvadit($"Šodien ir {tagad}");
        
        // FormatetVardu pielietojums
        string vards = "Ivars Zars";
        Console.WriteLine($"Pirms formātēšanas: {vards}");
        Console.Write("Pēc formātēšanas: ");
        myConsole.FormatetVardu(vards);
        
        // NolasitKaInt pielietojums
        int skaitlis = myConsole.NolasitKaInt();
        if (skaitlis != 0)
        {
            Console.WriteLine($"Ievadītais skaitlis: {skaitlis}");
        }
        
        // Paroles ģenerēšana
        Console.WriteLine($"Ģenerētā parole: {myConsole.IzveidotParoli(8)}");
        
        // Teksta šifrešana
        string teksts = "Secret";
        Console.WriteLine($"Teksts pirms šifrēšanas: {teksts}");
        string encrypted = myConsole.SifretTekstu(ref teksts);
        Console.WriteLine($"Teksts pēc šifrēšanas: {encrypted}");
        string decrypted = myConsole.AtsifretTekstu(ref encrypted);
        Console.WriteLine($"Teksts pēc atšifrēšanas: {decrypted}");
        
        // Konsoles krāsu nomaiņa
        for (int i = 0; i < 5; i++)
        {
            myConsole.NomainitBurtuKrasu();
            myConsole.NomainitFonaKrasu();
            Console.WriteLine("Mainītas krāsas");
        }
    }
}