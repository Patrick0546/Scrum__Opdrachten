<!DOCTYPE html>
<html lang"=nl">
<head>
    <meta http-equiv="Content-Type"
          content="text/html;charset=UTF-8" />
</head>
<body>
<form action ="verwerkenlab8.php" method="post">
    <table style=" ">
        <tr>
            <th>Voornaam:</th>
            <th><input type="text" name="achternaam"><br></th>
        </tr>
        <tr>
            <th>Voornaam:</th>
            <th><input type="text" name="voornaam"></th>
        </tr>
        <tr>
            <th>Straat:</th>
            <th><input type="text" name="straatnaam"><br></th>
        </tr>
        <tr>
            <th>Postcode:</th>
            <th><input type="text" name="postcode"><br></th>
        </tr>
        <tr>
            <th>Plaats:</th>
            <th><input type="text" name="plaats"><br></th>
        </tr>
        <tr>
            <th>Email:</th>
    <th><input type="text" name="email"><br></th>
        </tr>
    </table>
    <input type="hidden" name="taal" value="false">
    <br>Kies een opleiding:<br>
    <input type="radio" name="opleiding" value="ICT"> ICT<br>
    <input type="radio" name="opleiding" value="Engels"> Engels<br>
    <input type="radio" name="opleiding" value="Techniek"> Techniek<br>
    <input type="radio" name="opleiding" value="Nederlands"> Nederlands<br>
    <br>
    <input type="submit" name="submit" value="Versturen">
</form>
</body>
</html>

