<?php
$datumnu = date_create("now");
$datumkerst = date_create("2019-12-25");
$verschilInDagen = date_diff($datumnu, $datumkerst);
echo "<br>Vandaag: ".date_format($datumnu, "d-m-Y");
echo "<br>U heeft nog: ".$verschilInDagen->format("%R%a dagen tot kerst");
?>