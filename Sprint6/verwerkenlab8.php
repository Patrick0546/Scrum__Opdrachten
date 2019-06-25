<?php
$Achternaam = $_POST["achternaam"];
$Voornaam = $_POST["voornaam"];
$Straatnaam = $_POST["straatnaam"];
$Postcode = $_POST["postcode"];
$Plaats = $_POST["plaats"];
$Email = $_POST["email"];
$Submit = $_POST["opleiding"];

echo "<h3>Uw gegevens zijn: </h3>";
echo "<br>Achternaam: ". $Achternaam;
echo "<br>Voornaam: ". $Voornaam;
echo "<br>Straat: ". $Straatnaam;
echo "<br>Postcode: ". $Postcode;
echo "<br>Plaats: ". $Plaats;
echo "<br>E-mailadres: ". $Email;

if($Submit == "ICT")
{
    echo "<br>ICT opleidingen zijn vol. Kies een andere opleiding<br>";
}
if($Submit == "Engels")
{
    echo "<br>U wordt ingeschreven voor de volgende opleiding:<br>";
    echo "Engels";
}
if($Submit == "Techiek")
{
    echo "<br>U wordt ingeschreven voor de volgende opleiding:<br>";
    echo "Techniek";
}
if($Submit == "Nederlands")
{
    echo "<br>U wordt ingeschreven voor de volgende opleiding:<br>";
    echo "Nederlands";
}
?>