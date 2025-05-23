﻿using System.Reflection.PortableExecutable;

namespace Models
{
    //Dette er bare forslag til klasser. De er ikke færdige. 
    //Kun bolig og salgskvitering indeholder forignkeys.
    //Ejendomsmæglere, Sælgere og Købere har ikke et boligID eller nogen anden form for forignkey
    //Da det vil skabe data redundancy hvis de alle referer til hindanden.
    //I sql vil der være en tabel for sælgere. Den vil indeholde deres info (navn, tlfnummer osv.) og et ID.
    //Så vil der være en tabel for købere der også indeholder deres info og ID
    //og det samme med ejendomsmæglere.
    //Bolig tabellen vil indeholde boligens info og ID samt sælgerens ID og ejendomsmæglerens ID.
    //bolig og køber tabeller kan evt. begge opdeles i 2 tabeller (bolig + boligdetails) (køber + køberdetails)
    //salgs tabellen vil indeholde info på salget (dato, beløb osv.) og ID samt et boligID og køberID. 
    public abstract class Person //lortet er lort
    {
        public string Navn { get; set; }
        public string Efternavn { get; set; }
        public string TlfNummer { get; set; }
        public string Email { get; set; }
        public Person(string navn, string efternavn, string tlfNummer, string email)
        {
            Navn = navn;
            Efternavn = efternavn;
            TlfNummer = tlfNummer;
            Email = email;
        }
        public Person()
        {

        }
    }
    public static class SessionManager
    {
        public static int EjendomsmæglerId { get; set; }
        public static string Brugernavn { get; set; }
        public static string Fornavn { get; set; }
        public static string Efternavn { get; set; }
        public static string FuldeNavn { get; set; }
        public static int AdgangsNiveau { get; set; }

        public static bool IsLoggedIn => EjendomsmæglerId != 0;

        public static void Clear()
        {
            EjendomsmæglerId = 0;
            Brugernavn = string.Empty;
            Fornavn = string.Empty;
            Efternavn = string.Empty;
            FuldeNavn = string.Empty;
            AdgangsNiveau = 0;
        }
    }



    public abstract class Kunde : Person
    {

        public string CprNr { get; set; }
        public string Adresse { get; set; }
        public Kunde(string navn, string efternavn, string tlfNummer, string email, string cprNr, string adresse) : base(navn, efternavn, tlfNummer, email)
        {
            CprNr = cprNr;
            Adresse = adresse;
        }
        public Kunde()
        {

        }
    }

    public class Køber : Kunde
    {
        //køber vil ha sin egen tabel (en tabel for alle køberer der har købt et hus)
        public int KøberID { get; set; }
        //Køberns ID, (dette skulle gerne gives af sql med identity markatet)
        public int PrisKlasse { get; set; }
        //Prisområdet de ligger i
        public string SøgeOmråde { get; set; }
        //region, kommune, by.
        public string BoligType { get; set; }
        //hvad leder de efter? villa? landejendom?
        public string KøberInfo { get; set; } //optional
        //info om købernes omstændigheder (børn? dyr? job? Hvis det kan hjælpe med at finde noget)
        public int? GrundStørrelse { get; set; }//optional 
        //Hvis de har en fornemmelse af hvor stor grunden gerne skulle være
        public int? BoligStørrelse { get; set; } //optional
        //Hvis de har en fornemmelse af hvor stor boligen gerne skulle være
        public int? Værelser { get; set; } //optional
        //Hvor mange værelser vil de have som minimum.
        public Køber()
        {

        }
        public Køber(string navn, string efternavn, string tlfNummer, string email, int prisKlasse, string søgeOmråde, string boligType, string cprNr, string adresse, string køberinfo = "", int? grundStørrelse = null, int? boligStørrelse = null, int? værelser = null) : base(navn, efternavn, tlfNummer, email, cprNr, adresse)
        {
            SøgeOmråde = søgeOmråde;
            PrisKlasse = prisKlasse;
            BoligType = boligType;
            KøberInfo = køberinfo;
            GrundStørrelse = grundStørrelse;
            BoligStørrelse = boligStørrelse;
            Værelser = værelser;
        }
        public Køber(int køberID, string navn, string efternavn, string tlfNummer, string email, int prisKlasse, string søgeOmråde, string boligType, string cprNr, string adresse, int? grundStørrelse = null, int? boligStørrelse = null, int? værelser = null) : base(navn, efternavn, tlfNummer, email, cprNr, adresse)
        {
            KøberID = køberID;
            SøgeOmråde = søgeOmråde;
            PrisKlasse = prisKlasse;
            BoligType = boligType;
            GrundStørrelse = grundStørrelse;
            BoligStørrelse = boligStørrelse;
            Værelser = værelser;
        }
    }

    public class Sælger : Kunde
    {
        //sælgere vil have sin egen tabel (altså tabel over alle sælgere)
        public int SælgerID { get; set; }
        public string EjendomsmæglerNavn { get; set; }
        public int EjendomsmæglerID { get; set; }

        //Sælgerens ID, (dette skulle gerne gives af sql med identity markatet)
        public Sælger()
        {

        }
        public Sælger(string navn, string efternavn, string tlfNummer, string email, string cprNr, string adresse) : base(navn, efternavn, tlfNummer, email, cprNr, adresse)
        {

        }

        /// <summary>
        /// Sælger constructor med ID så den kan hente ID fra databasen
        /// </summary>
        public Sælger(int id, string navn, string efternavn, string tlfNummer, string email, string cprNr, string adresse) : base(navn, efternavn, tlfNummer, email, cprNr, adresse)
        {
            SælgerID = id;
        }
        public Sælger(int id, string navn, string efternavn, string tlfNummer, string email, string cprNr, string adresse, string ejendomsmæglerNavn, int ejendomsmæglerID) : base(navn, efternavn, tlfNummer, email, cprNr, adresse)
        {
            SælgerID = id;
            Navn = navn;
            Efternavn = efternavn;
            TlfNummer = tlfNummer;
            Email = email;
            CprNr = cprNr;
            Adresse = adresse;
            EjendomsmæglerNavn = ejendomsmæglerNavn;
            EjendomsmæglerID = ejendomsmæglerID;
        }
    }

    public class Ejendomsmægler : Person
    {
        //Ejendomsmægler vil have deres egen tabel (altså en tabel for alle ejendoms mæglere)
        //Den arver fra kunde klassen da en ejendomsmægler vel også kan være en kunde
        //hvis den ikke arvede så skulle de genregistres som en kunde hvis de ville købe eller sælge en ejendom
        //hvilket vil give data redundancy.
        public int EjendomsmæglerID { get; set; }
        //Ejendomsmæglerns ID, (dette skulle gerne gives af sql med identity markatet)
        public Ejendomsmægler()
        {

        }
        public Ejendomsmægler(string navn, string efternavn, string tlfNummer, string email) : base(navn, efternavn, tlfNummer, email)
        {

        }
        public Ejendomsmægler(int ejendomsmæglerIDstring, string navn, string efternavn, string tlfNummer, string email) : base(navn, efternavn, tlfNummer, email) 
        {
            EjendomsmæglerID = ejendomsmæglerIDstring;
            Navn = navn;
            Efternavn = efternavn;
            TlfNummer = tlfNummer;
            Email = email;
        }
    }
    public class Bolig
    {
        //bolig vil være en seperat tabel (altså en tabel for alle boligere)
        public int BoligID { get; set; }
        //Bolgiens ID (dette skulle gerne gives af sql med identity markatet)
        public int Pris { get; set; }
        //pris på boligen
        public string Adresse { get; set; }
        //boligens adresse
        public int PostNummer { get; set; }
        //boligens postnummer
        public string ByNavn { get; set; }
        //boligens bynavn
        public string Type { get; set; }
        //boligtypen
        public int BoligAreal { get; set; }
        //boligens areal
        public int Værelser { get; set; }
        //antal af værelser
        public int Badeværelser { get; set; }
        //antal af badeværelser
        public int Køkkener{ get; set; }
        //antal af køkkener
        public int Soveværelser { get; set; }
        //antal af soveværelser
        public string Tilstand { get; set; }
        //tilstand; Fremragende, God, Acceptabel, Dårlig, Meget dårlig
        public DateTime ByggeDato { get; set; }
        //hvornår var den bygget/renoveret
        public int GrundStørrelse { get; set; }
        //det samlet areal af bolig og land
        public string EnergiMærke { get; set; } //optional
        //boligens energimærke
        public int EjendomsmæglerID { get; set; }
        //Ejendomsmægleren der administreret boligen
        public int SælgerID { get; set; }
        //sælgeren der vil sælge boligen
        public string Status { get; set; }
        //Solgt, eller Usolgt
        public string EjendomsmæglerNavn { get; set; } // tilføjet eftersom filter viser navne, ved ikke om ejendomsmæglerID og sælgerID
                                                       // blev brugt til andre ting så de bliver som de er
                                                       //Navn på ejendomsmægleren der administreret boligen
        public string SælgerNavn { get; set; }
        //Navn på sælgeren der vil sælge boligen
        public Bolig(int pris, string adresse, int postNummer, string byNavn, string type, int boligAreal, int værelser, DateTime byggeDato, int grundStørrelse, int mæglerID, int sælgerID, string energimærke = "", string status = "Usolgt")
        {
            Pris = pris;
            Adresse = adresse;
            PostNummer = postNummer;
            ByNavn = byNavn;
            Type = type;
            BoligAreal = boligAreal;
            Værelser = værelser;
            ByggeDato = byggeDato;
            GrundStørrelse = grundStørrelse;
            EjendomsmæglerID = mæglerID;
            SælgerID = sælgerID;
            EnergiMærke = energimærke;
            Status = status;
        }
        public Bolig(int boligID, int pris, string adresse, int postNummer, string byNavn, string type, int boligAreal, int værelser, DateTime byggeDato, int grundStørrelse, string mæglerNavn, string sælgerNavn, int mæglerID, int sælgerID, string energimærke = "", string status = "Usolgt")
        { // ny bolig constructor til filter
            BoligID = boligID;
            Pris = pris;
            Adresse = adresse;
            PostNummer = postNummer;
            ByNavn = byNavn;
            Type = type;
            BoligAreal = boligAreal;
            Værelser = værelser;
            ByggeDato = byggeDato;
            GrundStørrelse = grundStørrelse;
            EjendomsmæglerNavn = mæglerNavn;
            SælgerNavn = sælgerNavn;
            EjendomsmæglerID = mæglerID;
            SælgerID = sælgerID;
            EnergiMærke = energimærke;
            Status = status;
        }
        public Bolig(int boligID, int pris, string adresse, int postNummer, string byNavn, string type, int boligAreal, int værelser, DateTime byggeDato, int grundStørrelse, string mæglerNavn, string sælgerNavn, string energimærke, string status)
        {
            BoligID = boligID;
            Pris = pris;
            Adresse = adresse;
            PostNummer = postNummer;
            ByNavn = byNavn;
            Type = type;
            BoligAreal = boligAreal;
            Værelser = værelser;
            ByggeDato = byggeDato;
            GrundStørrelse = grundStørrelse;
            EjendomsmæglerNavn = mæglerNavn;
            SælgerNavn = sælgerNavn;
            EnergiMærke = energimærke;
            Status = status;
        }

        public Bolig() // tom bolig constructor som bliver brugt til at lave en tom query til første load af tabel
        {

        }
    }
    public class BoligFilter // samme som bolig men med min og max på nogle værdier
    {
        //bolig vil være en seperat tabel (altså en tabel for alle boligere)
        public int BoligID { get; set; }
        ////Bolgiens ID (dette skulle gerne gives af sql med identity markatet)
        public int PrisMin { get; set; }
        //pris på boligen
        public int PrisMax { get; set; }
        //pris på boligen
        public int BoligArealMin { get; set; }
        ////boligens areal
        public int BoligArealMax { get; set; }
        ////boligens areal
        public int GrundStørrelseMin { get; set; }
        ////det samlet areal af bolig og land
        public int GrundStørrelseMax { get; set; }
        ////det samlet areal af bolig og land
        public int VærelserMin { get; set; }
        ////antal af værelser/rum
        public int VærelserMax { get; set; }
        ////antal af værelser/rum
        public string Adresse { get; set; }
        ////boligens adresse
        public int Postnummer { get; set; }
        ////boligens postnummer
        public string ByNavn { get; set; }
        ////boligens bynavn
        public string Type { get; set; }
        ////boligtypen
        public DateTime? ByggeDatoMin { get; set; }
        public DateTime? ByggeDatoMax { get; set; }
        ////hvornår var den bygget/renoveret
        public string? EnergiMærke { get; set; } //optional
        ////boligens energimærke
        public string EjendomsmæglerNavn { get; set; }
        ////Ejendomsmægleren der administreret boligen
        public string SælgerNavn { get; set; }
        ////sælgeren der vil sælge boligen
        public string Status { get; set; }
        ////Solgt, eller Usolgt
        public int EjendomsmæglerID { get; set; }
        ////ID på ejendomsmægleren
        public int SælgerID {  get; set; }
        public BoligFilter(int prisMin, int prisMax, int boligArealMin,
                            int boligArealMax, int grundStørrelseMin, int grundStørrelseMax,
                            int værelserMin, int værelserMax, string adresse,
                            int postnummer, string byNavn, string type,
                            DateTime? byggeDatoMin, DateTime? byggeDatoMax,
                            string energiMærke, string status, string ejendomsmæglerNavn, 
                            string sælgerNavn, int ejendomsmæglerID, int sælgerID)
                            /*DateTime byggeDato,*/// byggedato skal ændres til en datetime senere
        {
            PrisMin = prisMin;
            PrisMax = prisMax;
            BoligArealMin = boligArealMin;
            BoligArealMax = boligArealMax;
            GrundStørrelseMin = grundStørrelseMin;
            GrundStørrelseMax = grundStørrelseMax;
            VærelserMin = værelserMin;
            VærelserMax = værelserMax;
            Adresse = adresse;
            Postnummer = postnummer;
            ByNavn = byNavn;
            EnergiMærke = energiMærke;
            Type = type;
            ByggeDatoMin = byggeDatoMin;
            ByggeDatoMax = byggeDatoMax;
            Status = status;
            EjendomsmæglerNavn = ejendomsmæglerNavn;
            SælgerNavn = sælgerNavn;
            EjendomsmæglerID = ejendomsmæglerID;
            SælgerID = sælgerID;
        }
        public BoligFilter()
        {

        }
    }
    public class SælgerFilter
    {
        public string Fornavn { get; set; }
        public string EfterNavn { get; set; }
        public string Email { get; set; }
        public string TlfNummer { get; set; }
        public string Adresse { get; set; }
        public string CprNummer { get; set; }
        public string EjendomsmæglerNavn { get; set; }
        public int EjendomsmæglerID { get; set; }
    }
    public class KøberFilter
    {
        public string? PrisKlasse { get; set; }
        public string? SøgeOmråde { get; set; }
        public string? BoligType { get; set; }
        public int? ØnsketGrundStørrelseMin { get; set; }
        public int? ØnsketGrundStørrelseMax { get; set; }
        public int? ØnsketBoligStørrelseMin { get; set; }
        public int? ØnsketBoligStørrelseMax { get; set; }
        public int? ØnsketVærelserMin { get; set; }
        public int? ØnsketVærelserMax { get; set; }
        public string? Navn { get; set; } // Søger på fornavn + efternavn
    }


    public class Salg
    {
        //salg vil have sin egen table.
        public int SalgsID { get; set; }
        //sql via identity markatet
        public int KøberID { get; set; }
        //hvem købte boligen
        public int BoligID { get; set; }
        //boligen (som indeholder forign keys for sælgeren og Ejendomsmægleren)
        public int SælgerID { get; set; }
        public DateTime Dato { get; set; }
        public int Beløb { get; set; }
        public string Adresse { get; set; } // bruges til join i query
        public string ByNavn { get; set; }
        public string MæglerNavn { get; set; }
        public string SælgerNavn { get; set; }
        public string KøberNavn { get; set; }
        
        public Salg()
        {

        }
        public Salg(int køberID, int boligID, int sælgerID, DateTime dato, int beløb)
        {
            KøberID = køberID;
            BoligID = boligID;
            SælgerID = sælgerID;
            Dato = dato;
            Beløb = beløb;
        }
        public Salg(int salgID, int køberID, int boligID, DateTime dato, int beløb, string adresse, string byNavn, string mæglerNavn, string sælgerNavn, string køberNavn)
        {
            SalgsID = salgID;
            KøberID = køberID;
            BoligID = boligID;
            Dato = dato;
            Beløb = beløb;
            Adresse = adresse;
            ByNavn = byNavn;
            MæglerNavn = mæglerNavn;
            SælgerNavn = sælgerNavn;
            KøberNavn = køberNavn;
        }
    }
    public class BoligMedSælgerInfo
    {
        public string Adresse { get; set; }
        public string Bynavn { get; set; }
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string Email { get; set; }
        public string Tlfnummer { get; set; }
    }
    public class BoligerIkkeSolgtInfo
    {
        
        public string Pris { get; set; }
        //pris på boligen
        public string Adresse { get; set; }
        //boligens adresse
        public string PostNummer { get; set; }
        //boligens postnummer
        public string ByNavn { get; set; }
        //boligens bynavn
        public string Type { get; set; }
        //boligtypen
        public string BoligAreal { get; set; }
        //boligens areal
        public string Værelser { get; set; }
        //antal af værelser/rum
        public string ByggeDato { get; set; }
        //hvornår var den bygget/renoveret
        public string GrundStørrelse { get; set; }
        //det samlet areal af bolig og land
        public string EnergiMærke { get; set; } //optional
        //boligens energimærke
        public string Status { get; set; }
        //Boligens status
    }
}
