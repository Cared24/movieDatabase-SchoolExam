<?php



function printNav(){

    $nav = (file_get_contents("navigation.html"));
    print($nav);



}



/* 
$menu = file_get_contents("index.php");

if (isset($_SESSION['userId'])){
        //Valaki bejelentkezett
        $menu = str_replace("::logged", '<li><a href="logout.php">Kilép</a></li>', $menu);
        $menu = str_replace("::reg", '<li><a href="index.php">Profiladatok</a></li>', $menu);
        
} else {
        //Senki nincs a rendszerben
        $menu = str_replace("::logged", '<li><a href="login.php">Belépés</a></li>', $menu);
        $menu = str_replace("::reg", '<li><a href="registration.php">Regisztráció</a></li>', $menu);
}
*/


function movieList($link){

    /*
        print'<form action="'.$_SERVER['PHP_SELF'].'" method="get">
        <select name="elet">
            <option value="mind">mind</option>
            <option value="0">3500 óra alatt </option>
            <option value="3500">3500 óra felett </option>
        </select>
        <br/>
        <select name="piece">
            <option value="mind">mind</option>
            <option value="10">10</option>
            <option value="25">25</option>
            <option value="50">50</option>
        </select>
            <input type="submit" value="Szűrés" name="szures">
        </form>';
    */


    $sql = "SELECT * FROM movies";
    $add = "";

   /*
        PRINT RESET FORM
        */


        print'<input type="submit" value="Reset Filter" name="reset-filter">';

        if(isset($_GET['reset-filter'])) {
    
            $add = " ";
        }


        /*
        PRINT FORM   ----  FILTER BY IMDB RATE
        */

        print'
        <div class="movie-filter-section"><p>Filter by IMDb rate</p></div>
        <form action="'.$_SERVER['PHP_SELF'].'" method="get">
        <select name="imdb">
            <option value="all">all</option>
            <option value="UnderFive">5.0 alatt </option>
            <option value="Five">5.0 felett</option>
            <option value="Six">6.0 felett</option>
            <option value="Seven">7.0 felett</option>
            <option value="Eight">8.0 felett</option>
            <option value="Nine">9.0 felett</option>
        </select>
        <input type="submit" value="Search by IMDb Rate" name="imdb-filter">
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
        
        <input type="submit" value="Search by title" name="title">
        </form>';


        if(isset($_GET['movie-title'])) {
            $movieTitle = $_GET['movie-title'];
    
            $add = " WHERE title LIKE '%". $movieTitle."%' ";
        }




    $sql .= $add;

    $image = mysqli_query($link, $sql);

    if (mysqli_errno($link)) {
        die("Nem sikerült a termékek listázása!");
    }      


    while($row=mysqli_fetch_assoc($image)){
        echo '<div class="movieContainer">'.
        '<div class="movie-title">'.
        $row['title'].
        '</div><img class="movie-image" src="data:image/jpeg;base64,'.
        base64_encode($row['poster']).
        '"/><i class="ion-android-cart movie-cart"></i></div>'; 
    }
/*
    while($row=mysqli_fetch_assoc($image)){				
        echo '<div class="movieContainer">'.'<div class="movie-title">'.$row['title'].'</div><img class="movie-image" src="data:image/jpeg;base64,'.base64_encode( $row['poster']).'"/><i class="ion-android-cart movie-cart"></i></div>'; 
    }
*/    
}
/* 

print('Filter: 
    <select>
        <option value="no filter">No Filter</option>
        <option value="title"> Movie Title </option>
        <option value="director"> Director </option>
        
    </select></p>
    <input type="text" name="searchbar" placeholder="Search..."><br>
    <p><input class="submit" type="submit" value="submit" name="submit"></p>')
*/

?>