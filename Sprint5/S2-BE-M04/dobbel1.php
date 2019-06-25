<form>
    <a href="javascript:location.reload(true)">Dobbelen</a>
</form>
<?php
$getal1 = mt_rand(1, 5);
$getal2 = mt_rand(1, 5);
$getal3 = mt_rand(1, 5);
$getal4 = mt_rand(1, 5);
$getal5 = mt_rand(1, 5);
$totaal = ($getal1 + $getal2 + $getal3 + $getal4 +$getal5);

echo"<br>Totaal aantal ogen: $totaal";
?>