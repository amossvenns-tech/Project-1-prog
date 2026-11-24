// spelet gör
// startar vatten o2 skråv 
//information om hur man spelar 
//loop
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

{
//spelaren väljer vilken av tre action spelaren ska göra den ska göra
//1 fixa mer cyer 2 mer skrot 3 landa på en planet
// splaren väljer 2 nästa runda 
}
// när en av spelarnas världen blir 0 dör spelaren  
//var tredje dag får spelaren uppgradera en dell av skjeppet 




//start 
Console.WriteLine("SPELET I RYMDEN");
Console.WriteLine("Dag 2077 du vaknar upp och måste överleva");
Console.WriteLine("Du får göra två saker per runda sakerna du kan göra är: ");
Console.WriteLine("1 landa på en planet och samla resurser");
Console.WriteLine("2 du kan köra skjeppets system och få mer o2");
Console.WriteLine("3 du kan reparera skjeppet");
Console.WriteLine("4 för Statistik");

Ship Spelare = new();



    Console.WriteLine("");

    Console.WriteLine($"Skjeppets diagnostik, Vatten: {Spelare.vatten} Mat: {Spelare.matt} Skrot: {Spelare.skrot} SkjepsHp: {Spelare.skjeppHP}% O2:{Spelare.o2}%");

void landa()
{
    Console.WriteLine("Du landar och kan hitta vatten skrot och mat");
    //hur mycket vatten spelaren får om den välljer att landa
    int PlusVatten = Random.Shared.Next(6);
    Spelare.vatten += PlusVatten;
    if (Spelare.vatten > 40)
    {
        Spelare.vatten = 40;
    }

    //Skrot så spellaren kan reparera skjeppet
    int PlusSkrot = Random.Shared.Next(3);
    Spelare.skrot += PlusSkrot;
    if (Spelare.skrot > 10)
    {
        Spelare.skrot = 10;
    }

    int PlusMat = Random.Shared.Next(9);
    Spelare.matt += PlusMat;
    if (Spelare.matt > 40)
    {
        Spelare.matt = 40;
    }

    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine($"du hittade matt{PlusMat} vatten{PlusVatten} skrot{PlusSkrot}");

    Spelare.rundaRäknare--;


}

void syre()
{
    int plus02 = Random.Shared.Next(2,17);
    Spelare.o2 += plus02;
    Console.WriteLine($"Du återtog {plus02}%");

        if (Spelare.o2 >= 100)
    {
        Spelare.o2 = 100;
    }
    Spelare.rundaRäknare--;

}

void Skjepp()
{
    Spelare.skrot -= 5;
    int skjeppRep = Random.Shared.Next(13,26);
    Spelare.skjeppHP += skjeppRep;

    Console.WriteLine($"DU reparerade {skjeppRep}%");

    if (Spelare.skjeppHP >= 100)
    {
        Spelare.skjeppHP = 100;
    }

    Spelare.rundaRäknare--;

}

void diagnostics()
{
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine($"Skjeppets diagnostik, Vatten: {Spelare.vatten} Mat: {Spelare.matt} Skrot: {Spelare.skrot} SkjepsHp: {Spelare.skjeppHP}% O2:{Spelare.o2}% Dag: {Spelare.dag}");
    Spelare.rundaRäknare--;
}

void förlust()
{
    Console.Clear();
    Console.WriteLine("DU Dog Börjar om spelet");
    Console.WriteLine($"Du överlevede {Spelare.dag}dagar");
    Console.WriteLine("");
    Console.WriteLine("SPELET I RYMDEN");
    Console.WriteLine("Dag 2077 du vaknar upp och måste överleva");
    Console.WriteLine("Du får göra två saker per runda sakerna du kan göra är: ");
    Console.WriteLine("1 landa på en planet och samla resurser");
    Console.WriteLine("2 du kan köra skjeppets system och få mer o2");
    Console.WriteLine("3 du kan reparera skjeppet");
    Console.WriteLine("4 för Statistik");


     void natt()
    {
        int asteroid = Random.Shared.Next(1, 21);
        if (asteroid == 1)
        {
            Spelare.skjeppHP = Spelare.skada;
            Spelare.skjeppHP -= Random.Shared.Next(3, 28);
            Spelare.skada -= Spelare.skjeppHP;
        }
        else if (asteroid == 15)
        {
            int mängd = Random.Shared.Next(26);
            for (int i = 0; i < mängd; i++)
            {
                sten b = new();
                Spelare.skjeppHP -= b.dmg;
            }
            
        }










        Console.WriteLine($"Du tog {Spelare.skada} i natt");
    }

    while (true)
    {


        Spelare.rundaRäknare = 2;


        while (Spelare.rundaRäknare >= 0)
        {
            string valString = Console.ReadLine();
            bool ValBol = int.TryParse(valString, out Spelare.val);
            if (Spelare.val == 1)
            {
                landa();
            }
            else if (Spelare.val == 2)
            {
                syre();
            }
            else if (Spelare.val == 3)
            {
                Skjepp();
            }
            else if (Spelare.val == 4)
            {
                diagnostics();
            }
        }

        if (Spelare.vatten <= 0 || Spelare.matt <= 0 || Spelare.skjeppHP <= 0 || Spelare.o2 <= 0)
        {
            förlust();
        
        }
        Spelare.dag++;



    }
}