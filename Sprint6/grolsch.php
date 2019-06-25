<?php
$leeftijd = mt_rand(10, 35);
if($leeftijd <= 18){
    header('Location: https://www.alcoholinfo.nl/publiekreturnUri');
}
elseif($leeftijd > 18){
    header('Location: https://www.heineken.com/nl/agegateway?returnurl=%2fnlreturnUri');
}
?>