<?php
session_start();
require_once ('connect.php');
require_once ('functions.php');

if (isset($_POST['id'])){
	$id = $_POST['id'];

	if (!isset($_SESSION['basket'])){
		$_SESSION['basket'] = [];
	}

	if (isset($_SESSION['basket'])){
		$_SESSION['basket'][$id] = 1;
	}
}

if (isset($_POST['deleteMovie'])){
	$id = $_POST['deleteMovie'];
	unset($_SESSION['basket'][$id]);
	echo 'Deleted';
	printCart($link);
}

if (isset($_POST['empty'])){
	unset($_SESSION['basket']);
}
	


?>

<html lang="en">    
    <head>
        <link rel="stylesheet" type="text/css" href="vendors/css/normalize.css">
        <link rel="stylesheet" type="text/css" href="vendors/css/grid.css"> 
        <link rel="stylesheet" type="text/css" href="vendors/css/ionicons.min.css"> 
		<link rel="stylesheet" type="text/css" href="resources/css/basketStyle.css">
        <link href="https://fonts.googleapis.com/css?family=Lato:100,300,300i,400" rel="stylesheet">
		<meta name="viewport" content="width=device-width, initial-scale=1">		
		<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
		<script src="shop.js"></script>
		<script src="resources/js/Searchscript.js"></script>
        <title>Search Page</title>
    </head>
    <body>
        <header> 
			<nav>
				<div class="row">
					<ul class="main-nav">
						<?php
							printMenu();       
						?>
					</ul>
				</div>
			</nav>
			

			<div id="table-content">
				<table class="table-ordered">
				
					<tr>
						<th>Title of Movie</th>
						<th></th>
					</tr>

					<?php
						printCart($link);
					?>				
					
				</table>
			</div>
			<div class="hero-text-box">
					<button class="empty-basket">Empty Cart</button>
					<button id="order-button">Place Order</button>
			</div>
		</header>
		
	</body>
</html>