<?php
$getal1 = mt_rand(1, 1000);
$getal2 = mt_rand(1, 1000);

$groterdan = ($getal1 > $getal2 ? "true" : "false");
$kleinerdan = ($getal1 < $getal2 ? "true" : "false");
$gelijkaan = ($getal1 == $getal2 ? "true" : "false");
$identiek = ($getal1 === $getal2 ? "true" : "false");
$groterofgelijk = ($getal1 >= $getal2 ? "true" : "false");
$kleinerofgelijk = ($getal1 <= $getal2 ? "true" : "false");
$nietgelijkaan = ($getal1 != $getal2 ? "true" : "false");
echo "<br>$getal1 > $getal2 $groterdan";
echo "<br>$getal1 < $getal2 $kleinerdan";
echo "<br>$getal1 == $getal2 $gelijkaan";
echo "<br>$getal1 === $getal2 $identiek";
echo "<br>$getal1 >= $getal2 $groterofgelijk";
echo "<br>$getal1 <= $getal2 $kleinerofgelijk";
echo "<br>$getal1 != $getal2 $nietgelijkaan";
?>