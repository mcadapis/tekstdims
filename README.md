## Dette er en version af den klassiske idé om at skrive kodeord med specielle tegn for at opfylde sikkerhedskrav. 
Det er en lidt ældre måde at tænke kodeord på men beskrives meget godt i første del af tegneserien - og som der meget pænt bliver peget ud er det ikke en god måde at lave kodeord længere, og burde for så vidt undgås, og at denne grund er jeg stoppet med at vedligeholde denne repository. 


## Sikkerhedskrav vs. Sund fornuft: En XKCD-lektion i kodeord

![horse battery staple](https://imgs.xkcd.com/comics/password_strength.png "CorrectHorseBatteryStaple")

## Det er selvfølgelig sværere sagt end gjort, der er stadig mange services som kræver disse symboler for at blive godkendt. Gør hvad i føler giver mening for jeres organisation.
--- 

Programmet generer outputs ud fra brugerens input, disse indeholder specielle tegn og tal som erstatter dele af ordet.

Når denne software bruges skal man forstå at:
 - Kode ord stadig skal være en hvis længde
  - Kode ord skal være let at huske
   - Dette er måske ikke den bedste måde at lave passwords på!
     Det kan være lettere at huske ord som du forbinder med servicen
 
Alternativ er ikke nødvendigvis at anbefale: (Husk at når du får en ekstern hjemmeside til at gøre dette for dig, er der mulighed for at opsnappe kodeordet i transport + du skal være sikker på at hjemmesiden har dit bedste i tankerne)
 https://passwordsgenerator.net/

Den rigtige løsning vil typisk være en kodehusker, såsom den som er integreret i browser eller en organisitions styret kodehusker hvor i også får mulighed for at styre tilladelser, og logins inden for firmaet. 
____________________________________________________________

Framework: Microsoft WPF 
Funktion: auto  generer kodeord ud fra brugerens input

koden ligger i MainWindow.xaml.cs

Features

    //    //sæt tegn ind tilfældige steder og bevar længden 
    //    //bruger defineret længde med slider

Features der mangler:

    //    //determine if text contains necessary characters
    //    //Exclude specific characters
    //    //Make passwords more memorable
    //    //Tilføj bruger defineret ordbog til "memorable" funktionen
