<?php
session_start();
require_once('connect.php');
//require_once('functions.php');

?>
<h1>In cart</h1>
	<div id="tableContent">

	
<?php
	printCart($link);
?>

