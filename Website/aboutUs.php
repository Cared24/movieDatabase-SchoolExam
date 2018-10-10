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
    <link rel="stylesheet" type="text/css" href="resources/css/style.css">
    <link href="https://fonts.googleapis.com/css?family=Lato:100,300,300i,400" rel="stylesheet">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title> Home Page</title>
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

 <section class="section-features">
            
            <div class="row">
                <div class="col span-1-of-4">
                    <i class="ion-location"></i>
                    <h3>Up to 365 days/year</h3>
                    <p>
                    Movie Database is an online only website, available all around the world so if you got any questions just hit us up, find the movie you were looking for - and can even order it! You can order 24/7 so don't wait :)            
                    </p>  
                </div>
                
                 <div class="col span-1-of-4">
                     <i class="ion-load-a"></i>
                    <h3>Finding your movies</h3>
                    <p>
                    You can find your movies by their title or their poster, even though we recommend you to just browse and watch the posters and you might find something you actually peeks your interest to watch!       
                    </p>  
                </div>
                
                 <div class="col span-1-of-4">
                    <i class="ion-easel"></i>
                    <h3>Genres</h3>
                    <p>
                    We collected every movie from the past century in every genre so you could find your favorite move BUT if you don't find a movie you can even help us extend it by reaching us!    
                    </p>  
                </div>
                
                 <div class="col span-1-of-4">
                    <i class="ion-ios-cart-outline"></i>
                    <h3>Taking Order</h3>
                    <p>
                    Even purchasing a movie is made easy thanks to our new ordering system! You can buy a movie by putting it in your cart, buying it and we will send to your e-mail address a link for the streaming site.     
                    </p>  
                </div>
            </div>           
        </section>		

    </header>
</body>

</html>
