<?php
$boeken = array (
    array("titel"=> "Stoner", "auteur" => "John Williams", "genre" => "Fictie", "Prijs" => 19.99 ),
    array("titel"=> "De cirkel", "auteur" => "Dave Eggers", "genre" => "Fictie", "Prijs" => 22.50 ),
    array("titel"=> "Rayuela", "auteur" => "Julio Cortazar", "genre" => "Fictie", "Prijs" => 25.50 ),
);
function PrijsLijst($item, $key)
{
    if(is_numeric($item))
    {
        echo "Prijs: ".$item."<br>";
    }
}
array_walk_recursive($boeken, "prijsLijst");
?>