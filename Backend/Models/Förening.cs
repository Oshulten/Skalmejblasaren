using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models;

public class Uthyrningsobjekt
{
    public string Nummer { get; set; } = string.Empty;
    public string Fordon { get; set; } = string.Empty;
    public string Användning { get; set; } = string.Empty;
    public double Storlek { get; set; }
}

public class Garageförråd
{
    public string Nummer { get; set; } = string.Empty;
    public double Storlek { get; set; }
    public string Avtal { get; set; } = string.Empty;
    public int Hyra { get; set; }
}

public class Garagavtal
{
    public string Objektsnummer { get; set; } = string.Empty;
    public string Platsnummer { get; set; } = string.Empty;
    public string Avtalspartsnummer { get; set; } = string.Empty;
    public string Avtalspart { get; set; } = string.Empty;
    public string Registreringsnummer { get; set; } = string.Empty;
    public string Fjärrkontroller { get; set; } = string.Empty;
    public DateTime Startdatum { get; set; }
    public DateTime Slutdatum { get; set; }
    public string Kommentar { get; set; } = string.Empty;
}

public class Hyresnivå
{
    public string Användning { get; set; } = string.Empty;
    public string Fordon { get; set; } = string.Empty;
    public string Gästgrupp { get; set; } = string.Empty;
    public int Hyra { get; set; }
}

public class Person
{
    public string Personnumer { get; set; } = string.Empty;
    public string Förnamn { get; set; } = string.Empty;
    public string Efternamn { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Postnummer { get; set; } = string.Empty;
    public string Ort { get; set; } = string.Empty;
    public string Telefonnummer { get; set; } = string.Empty;
    public string Epost { get; set; } = string.Empty;
}

public class Lägenhet
{
    public string Lägenhetsnummer { get; set; } = string.Empty;
    public string Objektsnummer { get; set; } = string.Empty;
    public string Boende { get; set; } = string.Empty;
    public int Boarea { get; set; }
    public int Rum { get; set; }
    public int Objekstadress { get; set; }
    public int Våning { get; set; }
    public double Andelstal { get; set; }
}

public class Organisation
{
    public string Organisationnummer { get; set; } = string.Empty;
    public string Namn { get; set; } = string.Empty;
    public string Telefon { get; set; } = string.Empty;
    public string Epost { get; set; } = string.Empty;

}

public class Köplats
{
    public string Förnamn { get; set; } = string.Empty;
    public string Efternamn { get; set; } = string.Empty;
    public string Fordon { get; set; } = string.Empty;
    public DateTime Anmäld { get; set; }
    public string Telefonnummer { get; set; } = string.Empty;
    public string Epost { get; set; } = string.Empty;
}