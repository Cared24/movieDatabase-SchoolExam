<?php
session_start();
require_once('connect.php');
require_once('functions.php');

if (isset($_POST['username']) && isset($_POST['password']) && isset($_POST['passwordconfirm']) && isset($_POST['email'])){
	
	
		
		function  test($str)
		{
			$str = trim($str);
			$str = strip_tags($str);
			$str = stripcslashes($str);
			return $str;
		}
		
		if(isset($_POST['username']) && !empty($_POST['username']) && $_POST['username'] == test($_POST['username']) && preg_match("/^[a-zA-Z0-9]*$/", $_POST['username']) && strlen($_POST['username']) <= 40)
		{
			$username = $_POST['username'];
		}
		else
		{
			$usernameErr = 1;
		}
		
		//PASSWORD
		if (!empty($_POST['password']) && $_POST['password'] == test($_POST['password']) && strlen($_POST['password']) <= 40 && strlen($_POST['password']) >= 5)
		{
			$password = $_POST['password'];
		}
		else
		{
			$passwordErr = 1;
		}
		
		
		if (!empty($_POST['passwordconfirm']) && $_POST['passwordconfirm'] == test($_POST['passwordconfirm']) && strlen($_POST['passwordconfirm']) <= 40 && strlen($_POST['passwordconfirm']) >= 5)
		{
			$passwordconfirm = $_POST['passwordconfirm'];
		} 
		
		$email = $_POST['email'];
		
		if ($_POST['password']==$_POST['passwordconfirm'] && !isset($passwordErr) && !isset($usernameErr)){
				$password = password_hash($password, PASSWORD_DEFAULT);
				$sql="INSERT INTO users(username, password, email, isAdmin) VALUES('$username', '$password', '$email', 0)";
				mysqli_query($link, $sql);
				if(!mysqli_errno($link))
				{
					$userId = mysqli_insert_id($link);
					$_SESSION['userId'] = $userId;
					
					echo "Registered!";
					header("Location: index.php");
				}
				else {
					echo "Registration failed";
				}
		} else {
				echo "Registration failed";
		}				
			/*     <link rel="stylesheet" type="text/css" href="resources/css/registrationStyle.css">*/
		
} else {
}
?>

<html>
    <head>
	<link rel="stylesheet" type="text/css" href="resources/css/registrationStyle.css">
	<link href="https://fonts.googleapis.com/css?family=Lato:100,300,300i,400" rel="stylesheet">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<link rel="stylesheet" type="text/css" href="resources/css/style.css">
	<meta charset="UTF-8">
	
	<title> Registration</title>
    </head>
<body>
	<nav>
		<div class="row">
			<ul class="main-nav">
				<?php
					printMenu();       
				?>
			</ul>
		</div>
	</nav>
<div id="content">
		<form id="login-form" action="registration.php" method="POST">
			<p><label>Username: <br>
			</label><input type="text" name="username" placeholder="min. 1 to 40 characters)" value="" required></p>
			
			<p><label>Password: <br></label>
			<input type="password" name="password" placeholder="min. 5 to 40 characters" value="" required></p>
			
			<p><label>Password confirm: <br></label>
			<input type="password" name="passwordconfirm" placeholder="Confirm Password" value="" required></p>
			
			<p><label>E-mail: <br></label>
			<input type="email" name="email" placeholder=".....@.....com" value="" required></p>
			
			<input class="button-reset" type="reset" value="Reset" name="reset">
			<input class="button-submit" type="submit" value="Submit" name="submit">
		</form>
</div>
</body>
</html>


