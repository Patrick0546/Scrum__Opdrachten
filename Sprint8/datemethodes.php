<?php
$vandaag = new DateTime("now");
$eenDag = 86400;
$begin2000 = DateTime::createFromFormat("d/m/Y", "1/1/2000");
$eind2000 = DateTime::createFromFormat("d/m/Y", "31/12/2000");
$begin = $begin2000->getTimestamp();
$einde = $eind2000->getTimestamp();
$dagenIn2000 = ($einde - $begin)/ $eenDag;
// add DateInterval
$datum = new DateTime("2000-01-01");
echo "<br>Vandaag timestamp: ".$vandaag->getTimestamp();
echo "<br>Aantal dagen in 2000: " . $dagenIn2000;
echo "<br>Begindatum: " .$datum->format("Y-m-d");
?>