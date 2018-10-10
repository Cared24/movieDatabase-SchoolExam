<?php
session_start();
require_once ('connect.php');
require_once ('functions.php');
?>

<html lang="en">    
    <head>
        <link rel="stylesheet" type="text/css" href="vendors/css/normalize.css">
        <link rel="stylesheet" type="text/css" href="vendors/css/grid.css"> 
        <link rel="stylesheet" type="text/css" href="vendors/css/ionicons.min.css"> 
        <link rel="stylesheet" type="text/css" href="resources/css/SearchPageStyle.css">
        <link href="https://fonts.googleapis.com/css?family=Lato:100,300,300i,400" rel="stylesheet">
		<meta name="viewport" content="width=device-width, initial-scale=1">		
		<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
		<script src="shop.js"></script>
        <title>Search Page</title>
    </head>
    <body>
        <header> 
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
		</header>
		
		
		<div class="container">
			<div class="searchFilter">
					
				
			</div>
			
			<div class="showMovies">

				<?php 
					movieList($link);
				?>
			</div>
		</div>		
        
    </body>   
</html>
