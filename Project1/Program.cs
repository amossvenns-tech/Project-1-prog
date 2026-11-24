// spelet gör
// startar vatten o2 skråv 
//information om hur man spelar 
//loop
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
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

int val = 0; 

int rundaRäknare = 0;

bool runda = true;

int vatten = Random.Shared.Next(14, 37);

int skrot = Random.Shared.Next(2, 10);

int matt = Random.Shared.Next(5, 33);

int o2 = Random.Shared.Next(46 , 101);

int skjeppHP = Random.Shared.Next(77,101);

int dag = 2077;
    Console.WriteLine("");

    Console.WriteLine($"Skjeppets diagnostik, Vatten: {vatten} Mat: {matt} Skrot: {skrot} SkjepsHp: {skjeppHP}% O2:{o2}%");

void landa()
{
    Console.WriteLine("Du landar och kan hitta vatten skrot och mat");


    //hur mycket vatten spelaren får om den välljer att landa
    int PlusVatten = Random.Shared.Next(6);
    vatten += PlusVatten;
    if (vatten > 40)
    {
        vatten = 40;
    }

    //Skrot så spellaren kan reparera skjeppet
    int PlusSkrot = Random.Shared.Next(3);
    skrot += PlusSkrot;
    if (skrot > 10)
    {
        skrot = 10;
    }

    int PlusMat = Random.Shared.Next(9);
    matt += PlusMat;
    if (matt > 40)
    {
        matt = 40;
    }

    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine($"du hittade matt{PlusMat} vatten{PlusVatten} skrot{PlusSkrot}");

    rundaRäknare--;


}

void syre()
{
    int plus02 = Random.Shared.Next(2,17);
    o2 += plus02;
    Console.WriteLine($"Du återtog {plus02}%");

        if (o2 >= 100)
    {
        o2 = 100;
    }
    rundaRäknare--;

}

void Skjepp()
{
    skrot -= 5;
    int skjeppRep = Random.Shared.Next(13,26);
    skjeppHP += skjeppRep;

    Console.WriteLine($"DU reparerade {skjeppRep}%");

    if (skjeppHP >= 100)
    {
        skjeppHP = 100;
    }

    rundaRäknare--;

}

void diagnostics()
{
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine($"Skjeppets diagnostik, Vatten: {vatten} Mat: {matt} Skrot: {skrot} SkjepsHp: {skjeppHP}% O2:{o2}% Dag: {dag}");
    rundaRäknare--;
}

void förlust()
{
    Console.Clear();
    Console.WriteLine("DU Dog Börjar om spelet");
    Console.WriteLine($"Du överlevede {dag}dagar");
    Console.WriteLine("");
    Console.WriteLine("SPELET I RYMDEN");
    Console.WriteLine("Dag 2077 du vaknar upp och måste överleva");
    Console.WriteLine("Du får göra två saker per runda sakerna du kan göra är: ");
    Console.WriteLine("1 landa på en planet och samla resurser");
    Console.WriteLine("2 du kan köra skjeppets system och få mer o2");
    Console.WriteLine("3 du kan reparera skjeppet");
    Console.WriteLine("4 för Statistik");
} 

while (true)
{


    rundaRäknare = 2;


    while (rundaRäknare >= 0)
    {
            string valString = Console.ReadLine();
            bool ValBol = int.TryParse(valString, out val);
            if (val == 1)
            {
             landa();
            }
            else if (val == 2)
            {
                syre();
            }
            else if (val == 3)
            {
                Skjepp();
            }
            else if (val == 4)
            {
                diagnostics();
            }
    }
    
    if (vatten <= 0 || matt <= 0 || skjeppHP <= 0 || o2 <= 0)
    {
     förlust();
    }
    dag++;



}