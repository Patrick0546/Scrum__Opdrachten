<?php
$gewerkteuren = 35;
$uurtarief = 15.00;
$bonus = 100.00;
$bruto = $gewerkteuren * $uurtarief;
$belasting = 0.40*$bruto;
$netto = $bruto - $belasting;
$bonusloon = $bruto + $bonus;
$belastingbonus = $bonusloon *0.45;
$nettobonus = $bonusloon - $belastingbonus;

if($gewerkteuren < 39){
    echo"<br>Belasting is 40%";
}
elseif($gewerkteuren <= 40){
    echo"<br>Uw basissalaris is: €" .$bruto;
    echo"<br>Uw belasting is: € ". 0.40*$bruto;
    echo"<br>Uw nettobedrag is: € ". $netto;
}
elseif($gewerkteuren > 40){
    echo"<br>Uw basissalaris is: €" .$bruto;
    echo"<br>Uw basissalaris plus bonus is: €" .$bonusloon;
    echo"<br>Uw belasting is: € ". 0.45*$bonusloon;
    echo"<br>Uw nettobedrag is: € ". $nettobonus;
}
?>