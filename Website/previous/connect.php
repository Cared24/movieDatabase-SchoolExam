<?php 
	
	require_once ('connect.php'); //adatbáziskapcsolat felépítésének beemlése
	require_once ('functions.php'); //függvénytár beemlése

	$host = "localhost";
	$user = "root";
	$password = "";
	$database = "movie_database";
	
	$link = mysqli_connect($host, $user, $password, $database);
	
	if(!$link) die("No connection!");
	else
		mysqli_set_charset($link, "utf8");
	
	if (mysqli_errno($link))
		echo "Setting character type failed";

?>