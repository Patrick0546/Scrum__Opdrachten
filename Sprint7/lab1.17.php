<!DOCTYPE html>
<html lang="nl">
<head>
    <title>do-while-lus</title>
</head>
<body>
<h3>Voorbeeld van de do-while-lus</h3>
<?php
$saldo = 1000;
$rente = 0.1;
$maand = 1;
echo "<br>Reken het saldo uit zolang saldo lager dan 2000$ is";

echo "<br>Beginsaldo is: $saldo";
echo"<br>START...";
do
{
if ($maand =='2')
    echo "<br>Febuari betaalt geen rente";
else {
    echo"<br>Maand: $maand je saldo is: $saldo";
}
    if ($saldo  >= '2000') {
        echo "<br>Maximale saldo 2000 is bereikt";
    }
    if ($saldo  < '1000' || $maand =='6') {
        echo "<br>Je saldo is telaag";
        break;
    }
    $saldo = $saldo + ($saldo * $rente);
    $saldo = sprintf("%0.2f", $saldo);
    $maand++;
}
while($saldo < 2000);
echo "<br>FINISH";
?>
</body>
</html>