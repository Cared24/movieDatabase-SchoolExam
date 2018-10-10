<?php

function printMenu(){

    $menu = (file_get_contents("navigation.html"));
    
    if (isset($_SESSION['userId'])){
        //Valaki bejelentkezett
        $menu = str_replace("::logged", '<li><a href="basket.php">Basket</a></li>', $menu);
        $menu = str_replace("::reg", '<li><a href="logout.php">Log out</a></li>', $menu);
        
    } else {
        //Senki nincs a rendszerben
        $menu = str_replace("::logged", '<li><a href="login.php">Login</a></li>', $menu);
        $menu = str_replace("::reg", '<li><a href="registration.php">Registration</a></li>', $menu);
    }
    
    print($menu);

}


function movieList($link){
    $sql = "SELECT * FROM movies";
    $add = "";

		print'<div class="filter-button-section">';	
	
		/*
        PRINT RESET FORM
        */

        print '<form action="'.$_SERVER['PHP_SELF'].'" method="get">';
        print'<input class="button-submit reset-button" type="submit" value="Reset Filter" name="reset-filter">';
        print '</form>';

        if(isset($_GET['reset-filter'])) {
            $add="";
        }


        /*
        PRINT FORM   ----  FILTER BY IMDB RATE
        */

        print'
        <div class="movie-filter-section"><p>Filter by IMDb rate</p></div>
        <form action="'.$_SERVER['PHP_SELF'].'" method="get">
        <select name="imdb">
            <option value="all">all</option>
            <option value="UnderFive">5.0 > </option>
            <option value="Five">5.0 <</option>
            <option value="Six">6.0 <</option>
            <option value="Seven">7.0 <</option>
            <option value="Eight">8.0 <</option>
            <option value="Nine">9.0 <</option>
        </select>
        <input class="button-submit" type="submit" value="Search by IMDb Rate" name="imdb-filter">
        </form>';
        if(isset($_GET['imdb-filter'])) {
            $condition = $_GET["imdb"];
            switch($condition){
                case "UnderFive": $add = " WHERE imdb < 5"; break;
                case "Five": $add = " WHERE imdb >= 5"; break;
                case "Six": $add = " WHERE imdb >= 6"; break;
                case "Seven": $add = " WHERE imdb >= 7"; break;
                case "Eight": $add = " WHERE imdb >= 8"; break;
                case "Nine": $add = " WHERE imdb >= 9"; break;

                default: $add="";
            }
        }

        /*
        PRINT FORM   ----  FILTER BY TITLE
        */
        print'
        <div class="movie-filter-section"><p>Filter by Movie Title</p></div>
        <form action="'.$_SERVER['PHP_SELF'].'" method="get">
        <input type="text" name="movie-title" placeholder="Movie Title" required>
        
        <input class="button-submit" type="submit" value="Search by title" name="title">
        </form>';

		print'</div>';	


        if(isset($_GET['movie-title'])) {
            $movieTitle = $_GET['movie-title'];
    
            $add = " WHERE title LIKE '%". $movieTitle."%' ";
        }




    $sql .= $add;

    $image = mysqli_query($link, $sql);

    if (mysqli_errno($link)) {
        die("There was no movie for that!");
    }      

    while($row=mysqli_fetch_assoc($image)){
        echo '<div class="movieContainer">'.
        '<div class="movie-title">'.
        $row['title'].
        '</div><img class="movie-image" src="data:image/jpeg;base64,'.
        base64_encode($row['poster']).
        '"/><i class="ion-android-cart movie-cart"';
        echo ' id=';
        echo $row['movieId'];
        echo '></i></div>';
    }

}


function printCart($link){

    if (isset($_SESSION['basket']) && !empty($_SESSION['basket'])){
        $cart = $_SESSION['basket'];
        $keys=[];

        while (current($cart)){
            $key = key($cart);
            array_push($keys, $key);
            next($cart);
        }
    
        $sql = "SELECT title,movieId FROM movies WHERE movieId IN (";
            foreach ($keys as $k) {
                $sql .= "'$k', ";
            }
        $sql = substr($sql, 0, -2);
        $sql .= ")";
    
        $res = mysqli_query($link, $sql);

        $out="";
        $countMovie = 0;
        $price=0;

        while ($row = mysqli_fetch_row($res)){
            $out .= "<tr>
            
            <td>".$row[0].'</td>

            <td><button class="delete" id="'.$row[1].'">Delete</button></td>
            
            </tr>';    
            $countMovie++;
            $price = $countMovie * 5;
        }
        $out .= "<tr>
        <td>Price: </td>
        <td>$price $</td>
        
        </tr>";

        echo $out;      
    }
}
?>