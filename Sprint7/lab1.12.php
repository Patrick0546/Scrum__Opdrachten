<tile>Lab1.12</tile>
<form name="order" action="" method="post">
<h4>Reiskosten berekenen</h4>
    Vertrek:
    <select name="vertrek" value="true">
        <option value="1">Amsterdam</option>
        <option value="2">Utrecht</option>
        <option value="3">Den Haag</option>
        <option value="4">Rotterdam</option>
    </select>
</div>
    Bestemming:
    <select name="bestemming" value="true">
        <option value="1">Amsterdam</option>
        <option value="2">Utrecht</option>
        <option value="3">Den Haag</option>
        <option value="4">Rotterdam</option>
    </select>
</div>
<p></p>
<input type="submit" width="300px" name="Berekenen" value="Berekenen" />
<p>-------------------------------------------------------------</p>
</form>
<?php

function reiskosten($vertrek, $bestemming){
    $reiskosten = array();
    $reiskosten[1] = array();
    $reiskosten[2] = array();
    $reiskosten[3] = array();
    $reiskosten[4] = array();
    $reiskosten[1][1] = 0;
    $reiskosten[1][2] = 30;
    $reiskosten[1][3] = 60;
    $reiskosten[1][4] = 90;
    $reiskosten[2][1] = 30;
    $reiskosten[2][2] = 0;
    $reiskosten[2][3] = 40;
    $reiskosten[2][4] = 20;
    $reiskosten[3][1] = 60;
    $reiskosten[3][2] = 40;
    $reiskosten[3][3] = 0;
    $reiskosten[3][4] = 10;
    $reiskosten[4][1] = 90;
    $reiskosten[4][2] = 20;
    $reiskosten[4][3] = 10;
    $reiskosten[4][4] = 0;
    return($reiskosten[$vertrek][$bestemming]);
}
if(isset($_POST["Berekenen"]))
{
    $kosten = reiskosten($_POST["vertrek"],$_POST["bestemming"]);
    echo "De berekende reiskosten zijn : ". $kosten." euro";
}
?>