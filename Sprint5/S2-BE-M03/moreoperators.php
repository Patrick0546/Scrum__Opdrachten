<?php

echo <<<TEKST

<br>lokale variabelen 
<br>bestaan ​​alleen binnen de functie - een bijbehorende gedeelte van programmacode die een specifieke taak uitvoert - waarbij ze zijn gedefinieerd of verklaard . Ze ophouden te bestaan ​​zodra de functie is voltooid . Lokale variabelen worden gerecreëerd telkens wanneer de functie wordt aangeroepen , of uitgevoerd . Deze variabelen zijn niet toegankelijk zijn voor andere functies of het hoofdprogramma en als zodanig zijn ze meestal uitgevoerd met behulp van een speciaal type gegevensstructuur, bekend als een stapel . 
Stack 

<br>
<br>in veel programmeertalen , de " stack " is een belangrijk element bij de uitvoering van lokale variabelen . Voor het uitvoeren van een functie , een programma voegt alle lokale variabelen gedeclareerd in die functie de stack , in de omgekeerde volgorde waarin zij zijn aangegeven . Wanneer het programma roept de functie , zijn de lokale variabelen van de stapel in omgekeerde volgorde verwijderd , zodat de meest recent toegevoegde variabele is de eerste verwijderd . 
Globale variabelen 
<br>
<br>Globale variabelen 
<br>worden gedeclareerd in het hoofdgedeelte van de broncode van een programma , buiten alle functies , en ze bestaan ​​dus overal in de code , zelfs binnen functies . Globale variabelen worden niet opnieuw elke keer dat een bepaalde functie wordt aangeroepen . Programma gebruiken meestal globale variabelen verwerkte gegevens die door verschillende functies slaan . Een eenvoudige tekst - editing programma, bijvoorbeeld , kan de inhoud van het bestand dat het werkt aan een globale variabele te laden . 
Pros & Cons 

TEKST;

?>