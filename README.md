# Grupa4-Quake
 <p align="center">
  <img width="300" height="200" src="https://user-images.githubusercontent.com/37187803/37837589-e2653366-2eb5-11e8-9eb3-4594d321624a.jpg">
</p>

## TK Love Game
Članovi Tima:
1. Almasa Festa
2. Sara Halilović
3. Amina Fajić

## Opis teme

Aplikacija TK Love Game za cilj ima olakšavanje interakcije svih članova teniskog kluba Love Game koristeći user-friendly
interface. Igrači će biti u mogućnosti učlaniti se u klub ili u neki od ljetnih programa, rezervisati i/ili zakazati trening 
na nekom od slobodnih teniskih terena, kao i  koristiti online prijavu na internacionalna takmičenja, te imati pristup trenutnoj 
rang listi igrača kluba. 

Također, aplikacija olakšava posao i uposlenicima kluba. Svaki trener će biti u mogućnosti kreirati grupe polaznika u 
par klikova, unositi bodove na rang liste, kao i formirati žrijeb za Sara Slam koji se održava svaka tri mjeseca i 
gdje učestvuje osam najbolje rangiranih igrača.

## Procesi

###### Registracija/Prijava

Registracija se vrši upisom podataka u formu (ime, prezime, datum rođenja, JMBG, lozinka, email, broj telefona, adresa stanovanja, 
broj računa, te odabir vrste igrača(profesionalni/rekreativni)). Korisnik može koristiti usluge aplikacije tek nakon što račun odobri 
administrator. Verifikovani korisnik se prijavljuje na sistem unošenjem svog emaila i lozinke u formi za prijavu. 



###### Registracija/Zapošljavanje osoblja

Registraciju, pregled, ažuriranje i brisanje novog osoblja obavlja administrator. 
Registraciju/Zapošljavanje osoblja vrši administrator iz svoje forme, unoseći lične podatake, kao i podatake o plati zaposlenika.


###### Rezervacija teniskih terena

Korisniku je omogućeno da putem aplikacije pronađe slobodan teren za određeni dan i nakon unosa informacija rezerviše isti. 
Ukoliko se osoba koja je rezervisala teren ne pojavi nakon više od 15 minuta od početka termina, rezervisani termin(teren) se poništava. 
Ukoliko se korisnik pojavi u zakazano vrijeme,zaposlenik potvrđuje rezervaciju i termin ostaje zauzet i cijena usluge se dodaje na račun.

###### Plaćanje

Postoje dva načina na koja korisnik može izvršiti plaćanje za dobivene usluge i to:
1. koristeći aplikaciju
2. lično

Ukoliko se korisnik odluči na plaćanje koristeći aplikaciju, tada mu odabirom opcije za naplatu sistem izvršava naplaćivanje, te skida iznos usluge sa računa.  
U svakom trenutku igrači i zaposleni mogu vidjeti koliko iznosi total koji treba platiti. 

###### Otpuštanje radnika
Administrator na osnovu feedbacka od korisnika,donosi odluku o sankcijama zaposlenih lica i 
eventualno njihovom otpuštanju zbog nedoličnog ponašanja,ako feedback bude negativan.S druge strane,ako feedback bude pozitivan,administrator može nagraditi zaposleno lice.Također pod ovim procesom se podrazumijeva i uvid administratora u održavanje teniskih terena.


###### Formiranje i editovanje Sara Slam-a
<p align="center">
  <img width="300" height="200" src="https://user-images.githubusercontent.com/37187803/37852178-f26426a6-2ee1-11e8-9e00-c799c47e7343.gif">
</p>

Svaka tri mjeseca zaposlenik može kreirati turnir na osnovu rang liste. Raspored igranja turnira se kreira koristeći ITF pravila i metodom slučajnog izbora. 
Također, samo zaposleni (sudija) unosi rezultate.
Najboljeg igrača na SaraSlamu vlasnik aplikacije nagrađuje sa novčanim iznosom.

###### Prijava na takmičenje/ Odjava sa takmičenja

Mogućnost prijave na takmičenje imaju samo profesionalni igrači. Prijava na takmičenje se odobrava od strane zaposlenika, te u slučaju uspješne prijave dodaje se na 
račun igrača cijena prijave. Ukoliko igrač se ne potvrdi prijavu 24h prije početka takmičenja prijava se poništava.Također,igrač može da ostavi feedback o terenu u kojem opisuje da li je zadovoljan sa uslovima terena,trenerom itd.





## Funkcionalnosti

- Kreiranje korisničkog računa
- Kreiranje korisničkog računa za zaposlenike od strane administratora
- Ažuriranje i brisanje korisničkih računa za zaposlenike od strane administratora
- Ažuriranje i brisanje korisničkih računa za igrače od strane administratora
- Prijava na sistem sa korisničkim računom za različite vrste korisnika 
- Rezervacija teniskih terena
- Ostavljanje feedbacka od strane korisnika
- Prijava na takmičenje
- Mogućnost unosa bodova na rang listu
- Plaćanje
- Pregled/Editovanje rang liste
- Kreiranje žrijeba za Sara-slam



## Akteri

1. Igrač- Osobe koje koriste usluge kluba i dijele se na profesionalne igrače i amatere. Oba tipa igrača imaju mogućnost registracije, pretrage,rezervacije terena. 
Samo profesionalni igrači imaju mogućnost prijave na takmičenje, te učestvovanje na Sara Slam-u.

2. Zaposlenik- osoba koja radi za TK Love Game. Zaposlenici imaju mogućnost odobravanja zakazanih termina i treninga, unosa bodova za igrače,editovanje rang liste, 
te kreiranje Sara Slam-a.

3. Administrator- Administrator ima mogućnost zapošljavanja radnika, otpuštanja radnika, odobravanja korisničkog računa.
