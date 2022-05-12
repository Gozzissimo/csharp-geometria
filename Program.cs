// See https://aka.ms/new-console-template for more information

//Esercitazione di oggi: Geometria Nome repo: csharp-geometria
//Consegna: Nel progetto csharp - geometria creare le seguenti classi

//1.Creare una classe Rettangolo con due attributi interi: baseRettangolo e altezzaRettangolo. Aggiungere un opportuno costruttore con parametri.
//2.Aggiungere due metodi: calcolaArea e calcolaPerimetro che calcolano e restituiscono, rispettivamente, l’area e il perimetro del rettangolo.
//3.Poi, nel vostro programma principale (Program.cs) chiedete all’utente di inserire, da console, i valori di base e di altezza con cui istanziare un nuovo Rettangolo.
//4.Dopo averlo istanziato, stampate a video il perimetro e l’area.
//5.Provate ad istanziare tanti rettangoli con nome diverso e attributi diversi (baseRettangolo e altezzaRettangolo) e provate a stampare le loro proprietà ad esempio con un metodo StampaRettangolo che vi stampi il vostro rettangolo ad esempio cosi:

//—— Rettangolo1 ——
//base: 20 cm
//altezza: 10 cm
//Perimetro: 60 cm
//Area: 200 cm2

//BONUS Aggiungere alla classe Rettangolo un metodo “disegna” che disegna in console il rettangolo con le sue dimensioni,
//ossia tanti “—” (due trattini) orizzontali quanto è grande la sua base e tanti ‘|’ verticali quanto e grande la sua altezza.

using System;

namespace csharp_geometria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci la base del rettangolo");
            int iBase = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci l'altezza del rettangolo");
            int iAltezza = Convert.ToInt32(Console.ReadLine());

            Rettangolo rettangolo1 = new Rettangolo(iBase, iAltezza);

            Console.WriteLine("L'area del Rettangolo è di {0}", Rettangolo.AreaCalc(iBase, iAltezza));
            Console.WriteLine("Il perimetro del Rettangolo è di {0}", Rettangolo.PerimCalc(iBase, iAltezza));
        }
    }
}
