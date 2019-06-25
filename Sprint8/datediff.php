<form method="post">
    Datum 1:
    <input type="date" name="datum1" value="datum1" min="2019-02-01"><br>
    Datum 2:
    <input type="date" name="datum2" value="datum2" min="2019-01-01"><br>
    <input type="submit" width="300px" name="Verzenden" value="Verzenden" />
</form>

<?php
$datum1 = date_create(($_POST['datum1']));
$datum2 = date_create(($_POST['datum2']));
$verschilInDagen = date_diff($datum1, $datum2);
echo "<br>Het verschil in dagen is: ".$verschilInDagen->format("%R%a dagen ");
?>