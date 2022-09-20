using System.IO;
using System.Linq;
using UnityEngine;

public class Lesen //Ist für alle File-Änderungen zuständig
{
    public static void Neu()
    {
        string[] inhalt = { "0,12,0", "0,2,0", "2,0,2", "0,1,0",    //welt 0
                            "0,6,0", "6,6,6", "5,0,5", "0,3,0",     //welt 1
                            "14,0,14", "15,0,14", "0,9,0", "9,0,9", "9,10,9", "13,0,16", "0,4,0"}; //welt 2
        string shop = "0,0,0,0,0,0,0,0,0,0,0"; 
        File.WriteAllLines(GetPfad(), inhalt);
        File.WriteAllText(GetPfadShop(), shop);
    }
    public static string[] lesen()
    {
        return File.ReadAllLines(GetPfad())[0].Split(',');
    }
    public static string[] LesenShop()
    {
        return File.ReadAllText(GetPfadShop()).Split(',');
    }
    public static void Ausradieren()
    {
        string[] lines = File.ReadAllLines(GetPfad());
        File.WriteAllLines(GetPfad(), lines.Skip(1).ToArray());
    }
    public static void VoidSetzung()
    {
        string[] lines = File.ReadAllLines(GetPfad());
        if (lines[0] != "0,11,0") lines[0] = "0,0,0";  // SEHR WICHTIG
        File.WriteAllLines(GetPfad(), lines);
    }
    public static void BossVoidSetzung()
    {
        string[] lines = File.ReadAllLines(GetPfad());
        lines[0] = "0,11,0";
        File.WriteAllLines(GetPfad(), lines);
    }
    public static string GetPfad()
    {
        return Application.persistentDataPath + "degen.txt";
    }
    public static string GetPfadShop()
    {
        return Application.persistentDataPath + "auswahl.txt";
    }
    public static void SetShop(string s)
    {
        File.WriteAllText(GetPfadShop(), s);
    }
}
