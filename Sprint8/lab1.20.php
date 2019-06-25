<?php
ob_start();
?>
<!DOCTYPE html>
<html lang="nl">
<head>
    <title>Cookies</title>
</head>
    <body>
<form name="login"
      action=""
      method="post">
Gebruikersnaam:<br>
<input type="text" name="user" /><br><br>
<input type="submit" name="submit" value="Inloggen" />
</form>
</body>
</html>
<?php
if(isset($_POST["submit"])){
    $user = $_POST["user"];
    $melding = welkom($user);
    echo "<br> $melding";
}
function welkom($user) {

}
ob_end_flush();
?>