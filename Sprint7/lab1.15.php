<?php
    $totaal = 0;
    $Korting = 0;
    $totaal1 = 0;
    $totaal2 = 0;
    $totaal3 = 0;
$Aantal1 = 0;
$Aantal2 = 0;
$Aantal3 = 0;
$Prijs1 = 9;
$Prijs2 = 5;
$Prijs3 = 8;
$kortingbedrag = 0;
$serviceKosten = 0;
$totaalboeken = 0;
    ?>
<!DOCTYPE html>
<html lang="nl">
<head>
    <meta http-equiv="Content-Type"
          content="text/html;
        charset=UTF-8" />
    <style>
        .album{clear: left; width: 100%;}
        .omslag{float: left;}
        .gegevens{float: left; padding-left: 20px;}
        .korting{clear: left;}
        .aantal{background-color: #f8ce6c;}
    </style>
    <title>Lab1.15</title>
</head>
<body style="font-family: Verdana; font-size: 9px;">
<h3>Mijn winkelmandje</h3>
<form name="albums" action="" method="post">
    <div class="album">
        <div class="omslag">
            <img src="/images/evora.jpg" width="50px" alt="X" />
        </div>
        <div class="gegevens">
            Cesaria Evora "Em Um Concerto" Prijs: $9
            <input type="hidden" name="albumcode[0]" value="001" >
            <input type="hidden" name="artiest[0]" value="Cesaria Evora " >
            <input type="hidden" name="album[0]" value="Em Um Concerto" >
            <input type="hidden" name="prijs[0]" value="9" >
            <input type="hidden" name="genre[0]" value="World" >
            <br/>Aantal:
            <input type="text" size=2 maxlength=3 name="aantal1" class="aantal" value="0" >
        </div>
    </div>
    <div class="album">
        <div class="omslag">
            <img src="/images/manuchao.jpg" width="50px" alt="X" />
        </div>
        <div class="gegevens">
            Manu Chao "Clandestino" Prijs: $5
            <input type="hidden" name="albumcode[1]" value="002" >
            <input type="hidden" name="artiest[1]" value="Manu Chao" >
            <input type="hidden" name="album[1]" value="Clandestino" >
            <input type="hidden" name="prijs[1]" value="5" >
            <input type="hidden" name="genre[1]" value="World" >
            <br/>Aantal:
            <input type="text" size=2 maxlength=3 name="aantal2" class="aantal" value="0" >
        </div>
        <div class="album">
            <div class="omslag">
                <img src="/images/stevejobs.jpg" width="50px" alt="X" />
            </div>
            <div class="gegevens">
                Steve Jobs Prijs: $8
                <input type="hidden" name="albumcode[2]" value="002" >
                <input type="hidden" name="artiest[2]" value="Steve Jobs" >
                <input type="hidden" name="album[2]" value="Apple" >
                <input type="hidden" name="prijs[2]" value="8" >
                <input type="hidden" name="genre[2]" value="World" >
                <br/>Aantal:
                <input type="text" size=2 maxlength=3 name="aantal3" class="aantal" value="0" >
            </div>
        </div>
        <div class="korting">
            <br><hr />Korting:<br />
            <input type="checkbox" name="student" value="15" />
            Student: 15%<br />
            <input type="checkbox" name="klant" value="10" />
            Klant: 10%<br />
        </div>
        <div class="betaalwijze">
            <p>Selecteer een betaalwijze:</p>
            <select name="betaalmiddel" value="true">
                <option value="geenbetaalmiddel"></option>
                <option value="visa">Visa</option>
                <option value="mc">Mastercard</option>
                <option value="PP">PayPal</option>
                <option value="iDeal">iDeal</option>
                <input type="submit" width="300px" name="Verzenden" value="Bestellen" />
            </select>
        </div>
</form>
</body>
</html>
<?php
if (isset($_POST["Verzenden"])) {
    $Prijs1 = 9;
    $Prijs2 = 5;
    $Prijs3 = 8;
    $Aantal1 = $_POST["aantal1"];
    $Aantal2 = $_POST["aantal2"];
    $Aantal3 = $_POST["aantal3"];
    $totaal1 = ($Aantal1 * $Prijs1);
    $totaal2 = ($Aantal2 * $Prijs2);
    $totaal3 = ($Aantal3 * $Prijs3);
    if (isset($_POST["student"])) {
        $Korting = ($Korting + 15);
    }
    if (isset($_POST["klant"])) {
        $Korting = ($Korting + 10);
    }
    echo "<Br>Bestelde albums is: $Aantal1";
    echo "<Br>Korting is: $Korting";
}
if(isset($_POST["Verzenden"])){
    include_once("externe_functions.php");
    echo "<br>De korting()-function: " . korting() . "%";
    $betalingswijze = $_POST['betaalmiddel'];
    $serviceKosten = serviceKosten($betalingswijze);
    echo "<br>Servicekosten zijn: " . $serviceKosten;
    $totaalboeken = ($totaal1 + $totaal2 + $totaal3);
    $kortingbedrag = 0;
    $kortingbedrag = ($totaalboeken / $Korting);
    $totaal = ($totaalboeken + $serviceKosten - $kortingbedrag);
    switch($_POST['betaalmiddel'])
    {
        case "visa" :
            echo "<p>Betalingswijze : Visa</p>";
            break;
        case "mc" :
            echo "<p>Betalingswijze : MasterCard</p>";
            break;
        case "pp" :
            echo "<p>Betalingswijze : PayPal</p>";
            break;
        case "iDeal" :
            echo "<p>Betalingswijze : iDeal</p>";
            break;
        default:
            echo "<p>U heeft geen betaalmiddel gekozen</p>";
            echo "<p>Geen servicekosten</p>";
    }
}
?>

<form>
    <h1>Factuur</h1>
    <div class="factuur">
<table>
    <tr>
        <tr class="aantal">
        <th>Genre</th>
        <th>Artiest</th>
        <th>Album</th>
        <th>Aantal</th>
        <th>Prijs</th>
        <th>Bedrag</th>
    </tr>
    <tr>
        <td>World</td>
        <td>Cesaria Evora</td>
        <td>Em Um Concerto</td>
        <td><?php echo" $Aantal1" ?></td>
        <td><?php echo" $Prijs1" ?></td>
        <td><?php echo" $totaal1" ?></td>
    </tr>
    <tr>
        <td>World</td>
        <td>Manu Chao</td>
        <td>Clandenstino</td>
        <td><?php echo" $Aantal2" ?></td>
        <td><?php echo" $Prijs2" ?></td>
        <td><?php echo" $totaal2" ?></td>
    </tr>
    <tr>
        <td>World</td>
        <td>Steve Jobs</td>
        <td>Steve Jobs</td>
        <td><?php echo" $Aantal3" ?></td>
        <td><?php echo" $Prijs3" ?></td>
        <td><?php echo" $totaal3" ?></td>
    </tr>
    <tr>
        <td>Totaal</td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td><?php echo" $totaalboeken" ?></td>
    </tr>
    <tr>
        <td>Korting</td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td><?php echo" $kortingbedrag" ?></td>
    </tr>
    <tr>
        <td>Servicekosten</td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td><?php echo" $serviceKosten" ?></td>
    </tr>
    <tr>
        <td>Te betalen</td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td><?php echo" $totaal" ?></td>
    </tr>
</table>
</form>
