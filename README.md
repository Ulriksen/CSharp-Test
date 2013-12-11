CSharp-Test
===========


Oppgave 1
---------
Du blir bedt om å hjelpe utviklerene i DogSim med deres bibliotek for hundeslede simulatorer. 
Visual Studio solution ligger i dette repositoriet. 
De har i den senere tid jobbet med en utvidelse a systemet og lagt til en ny hundetype. Nå har foreningen Puddelens venner begynt sin tester for å demonstrere puddelens fantastiske evner som trekkhund, men dessverre rapporterer de om feil når de kaller Start metoden på DogSled. 
Feilrapporten viser at de får en System.InvalidCastException når de kaller Start()

**1.a)**  
Hvor er feilen og hva er den minste endringen som kan gjøres for å rette feilen.

**1.b)**  
Desverre er det flere ting i løsningen som ikke er gjort slik en Novanet konsulent ville ha gjort det, men du må i første omgang fokusere på DogSled klassen. Gjør de endringer du mener bør gjøres på DogSled klassen for å heve koden til et akseptabelt nivå.


Oppgave 2
---------
DogSim har bestemt seg for å tilby simulator funksjonene sine gjennom et web api. Du har fått i oppgave å implementere en WebAPI 2 kontroller som skal ha to metoder som skal lese DogSled objekter fra databasen.
Du finner et tomt skall, med to tomme metoder for ApiControlleren i prosjektet DogSledSim.API, fullfør implementasjonen slik du mener at produksjonsklar kode skal skrives.

- get metoden skal returnere alle sledene inklusive hunder i databasen
- getById metoden skal returnere en slede inklusive hunder med angitt slede Id. Id er da DogSled.Id. 

Disclaimer: Alle navn, personer og dyr i oppgavene over er ren fiksjon. Enhver likhet med eventuelt virkelige personer, dyr eller organisasjoner er helt tilfeldig.
