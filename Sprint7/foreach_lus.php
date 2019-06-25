<!DOCTYPE html>
<html lang="nl">
<head>
    <title>foreach-lus</title>
</head>
</html>
<body>
<h3>Voorbeeld van de foreach-lus</h3>
<?php
$kleuren["oranje"] = "orange";
$kleuren["rood"] = "red";
$kleuren["paars"] = "violet";
$kleuren["groen"] = "green";
$kleuren["blauw"] = "blue";
$kleuren["geel"] = "yellow";
foreach($kleuren as $kleur){
    echo "<br><font color=$kleur>Deze tekst in $kleur";
}
?>
</body>