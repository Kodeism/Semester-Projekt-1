# Git projekt til semesterprojektet

## Fælles dokumenter
Google Docs: 

Metadokument (opgaver og rammer): https://docs.google.com/document/d/1cQ_8JfUeSDinvUIry3IDf6VQEVS1duLZePQ5nt2wSao/edit?tab=t.0#heading=h.v8hlg96fyvgp

Skrivedokument (opgavebesvarelse): https://docs.google.com/document/d/1gGwaUe7E4B17lulaaE2VK9FU2toCexEviYnKctp1OTE/edit?tab=t.0

## Forslag til kodestruktur:
Mål: Så overskuelig kode som muligt

### Mappestruktur
    /rapport.sln (den store solution aka hele projektet)
      /rapport.GUI (project - winforms user interface - presentation layer)  
      
      /rapport.Logic (project - interaktioner med databasen, behandling af data før præsentation i UI)
        /repositories (direkte interaktion med databasen)
        /endpoints (de klasser og metoder, som winforms må kalde og implementere)
        
      /rapport.Models (project - de klasser, vi definerer og bruger mellem logic og UI)

### Navngivning
Mål: Det skal være nemt at forstå, hvad en variabel, en metoder eller en komponent er og gør, uden at læse definition eller have brug for kontekst.
#### Eksempel:
    getUserButton__click() {
      try 
      {
        var userID = Int32.Parse(selectUserTextbox.Text);
        UserService.GetUser(userID);
      }
      catch
      {
        //oops lol
      }
    }
