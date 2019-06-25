<?php
$onzegroep = array (
    array("studentnummer"=> "0310731", "voornaam" => "Patrick", "achternaam" => "Koekkoek", "woonplaats" => "Wierden", "leeftijd" => "17" ),
    array("studentnummer"=> "0310027", "voornaam" => "Bart", "achternaam" => "Haarhuis", "woonplaats" => "Albergen", "leeftijd" => "16" ),
    array("studentnummer"=> "0310647", "voornaam" => "Cas", "achternaam" => "Schuurman", "woonplaats" => "Albergen", "leeftijd" => "17" ),
    array("studentnummer"=> "0308653", "voornaam" => "Vincent", "achternaam" => "Veluwenkamp", "woonplaats" => "Rijssen", "leeftijd" => "16" ),
    array("studentnummer"=> "0310069", "voornaam" => "Wout", "achternaam" => "Oldenhof", "woonplaats" => "Nijverdal", "leeftijd" => "17" ),
    array("studentnummer"=> "0251673", "voornaam" => "Martijn", "achternaam" => "Legtenberg", "woonplaats" => "Wierden", "leeftijd" => "22" ),
);
$random = $onzegroep[array_rand($onzegroep)];
print_r($random);
?>

