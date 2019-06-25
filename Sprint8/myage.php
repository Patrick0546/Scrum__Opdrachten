<?php
function Tijden(){
    $GeboorteDag = new DateTime('2002-08-08 17:00:00');
    $Nu = new DateTime("now");
    $diff = date_diff($GeboorteDag,$Nu);
    $Maand = $diff->format('%m') + 12 * $diff->format('%y');
    $interval = $Nu->diff($GeboorteDag);
    echo "Ik ben: ";
    echo "<br>".$Maand. " maanden oud,";
    echo "<br>".$diff->format("%a dagen oud,");
    echo "<br>";
    echo $week = round($interval->days/ 7) . ' weken oud,';
    echo "<br>";
    echo $interval->i + ($interval->days* 24) . ' uur oud,';
    echo "<br>";
    echo $interval->i + ($interval->days* 1440) . ' minuten oud,';
    echo "<br>";
    echo $interval->s + (($interval->days* 1440) *60) . ' seconden oud';
}
?>
<html>
<head>
    <style>
        .customise {
            background: lightyellow;
            border-radius: 1em;
            padding: 1em;
            position: absolute;
            top: 50%;
            left: 50%;
            margin-right: -50%;
            transform: translate(-50%, -50%);
            font-family: Palatino Linotype, Book Antiqua, Palatino, serif;
            font-size 18pt;
            border-style: solid;
            border-width: 5px;
            border-color: red;
        }
    </style>
</head>
<body>
<div class="customise">
    <?php
    Tijden();
    ?>
</div>
</body>
</html>