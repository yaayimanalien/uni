using System;

public class myConsole
{
    static string tagad; // mainīgajam piešķirt patreizējo datumu. Formātu izvēlēties brīvi

    public static string Tagad
    {
        get => tagad;
        set => tagad = $"{DateTime.Today.Date}.{DateTime.Today.Month}.{DateTime.Today.Year}";
    }
    
    static int NolasitKaInt()
    {
        // funkcija pieprasa lietotājam ievadīt veselo skaitli. Gadījumā, ja
        // lietotājs ievada veselo skaitli, atgriež to. Ja lietotājs ievadīja ne veselo
        // skaitli (burtus, simbolus) atgriež nulli un paziņo, ka konvertācija bija
        // neveiksmīga.
        int skaitlis;
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
    
    static void Izvadit(string text)
    {
        //funkcija izvada tekstu text
        Console.WriteLine(text);
    }
    
    static void NomainitFonaKrasu()
    {
        //funkcija nomaina konsoles fona krāsu uz gadījuma (!) krāsu
        Console.BackgroundColor = ConsoleColor.DarkRed;
    }
    
    internal static void NomainitBurtuKrasu()
    {
        //funkcija nomaina konsoles burtu krāsu uz gadījuma (!) krāsu
        Console.ForegroundColor = ConsoleColor.Red;
    }
    
    static void FormatetVardu(string vards_uzvārds)
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

    internal static string IzveidotParoli(int garums)
    {
        // funkcija veido un atgriež lietotājam drošo paroli. Paroles garumu
        // funkcija saņem. PAroles veidošanas principus jāizdomā pašam.
        Random random = new Random();
        string paswrd = "";
        for (int i = 0; i < garums; i++)
        {
            paswrd += (char)random.Next(40, 50);
            // TODO: nomaini ascii values uz kko normalu
        }
        return paswrd;
    }
    
    internal static string SifretTekstu(ref string teksts)
    {
        string encrypted = "";
        for (int i = teksts.Length - 1; i >= 0; i--) 
        {
            encrypted += (char)((int)teksts[i] ^ teksts.Length); 
        }
        return encrypted;
    }

    internal static string AtsifretTekstu(ref string teksts)
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
        Console.WriteLine(myConsole.IzveidotParoli(8));
        Console.Write("Enter password to be encrypted: ");
        string password = Console.ReadLine();
        string encryptedPass = myConsole.SifretTekstu(ref password);
        Console.WriteLine($"Encrypted password: {encryptedPass}");
        string decryptedPass = myConsole.AtsifretTekstu(ref encryptedPass);
        Console.WriteLine($"Decrypted password: {decryptedPass}");
    }
}