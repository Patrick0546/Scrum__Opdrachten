<!DOCTYPE html>
<html lang="nl">
<head>
    <title>do-while-lus</title>
</head>
<body>
<h3>Voorbeeld van de do-while-lus</h3>
<?php
echo "<br>Reken het saldo uit zolang saldo lager dan 2000$ is";
$saldo = 2100;
$rente = 0.1;
$maand = 1;
echo "<br>Beginsaldo is: $saldo";
echo"<br>START...";
do
{
    $saldo = $saldo + ($saldo * $rente);
    $saldo = sprintf("%0.2f", $saldo);
    echo"<br>Maand: $maand je saldo is: $saldo";
    $maand++;
}
while($saldo < 2000);
echo "<br>FINISH";
?>
</body>
</html>