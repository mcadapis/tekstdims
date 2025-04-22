
Læs først

Dette er en version af den klassiske idé om at skrive kodeord med specielle tegn for at opfylde sikkerhedskrav. Det er en lidt ældre måde at tænke kodeord på men beskrives meget godt i første del af XKCD 

![horse battery staple](https://imgs.xkcd.com/comics/password_strength.png "CorrectHorseBatteryStaple")

Programmet generer outputs ud fra brugerens input, disse indeholder specielle tegn og tal som erstatter dele af ordet.

Når denne software bruges skal man forstå at:
 - Kode ord stadig skal være en hvis længde
  - Kode ord skal være let at huske
   - Dette er måske ikke den bedste måde at lave passwords på!
     Det kan være lettere at huske ord som du forbinder med servicen
 
Alternativ program: 
 https://passwordsgenerator.net/
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
