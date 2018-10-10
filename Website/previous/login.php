<?php
session_start();
require_once('connect.php');

/*
$sql = mysqli_prepare($link, "SELECT f_id,jelszo FROM felhasznalok WHERE felhasznalonev=?");
    mysqli_stmt_bind_param($sql, "s", $felhasznalonev);
    mysqli_execute($sql);
    $result= mysqli_stmt_get_result($sql);
*/
if(isset($_POST['submit'])) {
	$username = $_POST['username'];
	$password = $_POST['password'];
	$sql = mysqli_prepare($link, "SELECT userId, password FROM users WHERE username = ?");
	mysqli_stmt_bind_param($sql, "s", $username);
	mysqli_execute($sql);
	$result = mysqli_stmt_get_result($sql);

	if(mysqli_errno($link)){
		die("Error");
	}

	if(!mysqli_num_rows($result)) {
		$SESSION['error'] = "Wrong username/password";
		header("Location: login.php");
	}
	else{
		$t = mysqli_fetch_assoc($result);
		if(password_verify($password, $t['password'])) {
			$_SESSION["userId"] = $t["userId"];
			header("Location: index.php");
		}
		else {
			$SESSION['error'] = "Wrong username/password";
			header("Location: login.php");
		}
	}
}
?>
<html>
    <head>
    <link rel="stylesheet" type="text/css" href="resources/css/registrationStyle.css">
    </head>
<body>
	<nav>
		<div class="row">
                    <ul class="main-nav">
						<li> <a href="index.php">Home</a></li>
                        <li> <a href="aboutus.html">About Us</a></li>
						<li> <a href="registration.php">Register</a></li>					
                        <li> <a href="login.php">Login</a></li>
						<li> <a href="movie.php">Movies</a></li>
						<li> <a href="basket.php">Basket</a></li>
                    </ul>
                </div>
	</nav>
	<div id="content">
		<form id="login-form" action="login.php" method="post">
			<p><label>Username:</label><br>
			<input type="text" name="username" placeholder="Username" required><br></p>
			
			<p><label>Password: </label><br>
			<input type="password" name="password" placeholder="Password" required><br></p>
			
			<input class="btn btn-submit" type="submit" name="submit" value="submit">
		</form>
	</div>		
</body>
</html>