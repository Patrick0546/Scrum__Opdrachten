<?php
// superglobale scope
$GLOBALS['url'] = 'www.mijndomein.nl';
// globale scope
global $email;
$email = "webmaster@mijndomein.nl";
// globale constanten
define("BIJDRAGE",0.10);
function doneren($bedrag)
{
// function scope
    $melding = "GIRO 555";
    echo "<br>" . $melding;
    echo "<br>URL: " . $GLOBALS["url"];
    echo "<br>Bedrag: " . $bedrag;
    global $email;
    echo"<br>E-maail:" . $email;
    $bijdrage = $bedrag * BIJDRAGE;
    $donatie = $bedrag + $bijdrage;
    echo "<br>Inclusief bijdrage: $donatie";
    static $pot;
    $pot = $pot + $donatie;
    echo "<br><span style='background-color: yellow'>Totaal bedrag in pot $pot</span><br>";
    $hoogste = 0;
    if($donatie > $hoogste){
        $hoogste = $donatie;
    }
    echo "<br>Hoogste donatie tot nu toe is: $hoogste";
}
doneren(100);
doneren(1000);
doneren(33333);
?>