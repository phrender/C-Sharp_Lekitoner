using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lektion02_Struktur_och_Fel // Namnrymd, fungerar som ett efternamn då vi kan ha funktioner och klasser med samma namn som i en annan namnrymd
{
    class Program // En klass, här kan vi lagra variabler och funktioner samt återanvända vid ett senare tillfäle
    {
        static void Main(string[] args) // Entry point, det är här ifrån vårat program körs
        {
            int iMyInt = 0; // Korrekt skapad variabel
            //int iMyInt = 0; // Genererar ett fel som heter "CS0128". Den genererar ett fel för vi gör en såkallad "dubbel deklaration" vi har redan skapat objektet, vi har redan skapat det varför ska vi göra det igen?

            // Ett vanligt fel är at man glömt ett semikolon
            //Console.WriteLine("Här är text.") // Detta genererar ett fel som heter "CS1002", här säger Visual Studio till att den vill ha ett semikolon för att avslutat komandot.

            /*
             * Felsökning kan vara så enkelt att man bara google:ar sin felkod / error meddelande
             * och kan hitta andra som haft samma fel och hur man löser det.
             */

        }
    }
}
