<?php
$onzegroep = array (
    array("studentnummer"=> "<table><td><h4>0310731</h4></td>", "voornaam" => "<td><h2>Patrick</h2></td>", "achternaam" => "Koekkoek", "woonplaats" => "<td><em>Wierden</em></td>", "leeftijd" => "<td><em>17</em></td></table>" ),
    array("studentnummer"=> "<h4>0310027</h4>", "voornaam" => "<h2>Bart</h2>", "achternaam" => "Haarhuis", "woonplaats" => "<td><em>Albergen</em></td>", "leeftijd" => "<td><em>16</em></td>" ),
    array("studentnummer"=> "<h4>0310647</h4>", "voornaam" => "<h2>Cas</h2>", "achternaam" => "Schuurman", "woonplaats" => "<em>Albergen</em>", "leeftijd" => "<em>17</em>" ),
    array("studentnummer"=> "<h4>0308653</h4>", "voornaam" => "<h2>Vincent</h2>", "achternaam" => "Veluwenkamp", "woonplaats" => "<em>Rijssen</em>", "leeftijd" => "<em>16</em>" ),
    array("studentnummer"=> "<h4>0310069</h4>", "voornaam" => "<h2>Wout</h2>", "achternaam" => "Oldenhof", "woonplaats" => "<em>Nijverdal</em>", "leeftijd" => "<em>18</em>" ),
    array("studentnummer"=> "<h4>0251673</h4>", "voornaam" => "<h2>Martijn</h2>", "achternaam" => "Legtenberg", "woonplaats" => "<em>Wierden</em>", "leeftijd" => "<em>22</em>" ),
);
// $random = $onzegroep[array_rand($onzegroep)];
// print_r($random);

foreach($onzegroep as $groep){
    echo $groep['array'];
}
?>