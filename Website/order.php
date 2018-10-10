<?php
session_start();
require_once('connect.php');
require_once('functions.php');


if(isset($_SESSION['userId'])) {
	$userId = $_SESSION['userId'];

	if(isset($_SESSION['basket']) && !empty($_SESSION['basket'])) {
		$basket = $_SESSION['basket'];
		
		$sql = "INSERT INTO movieorder (userId, movieId, date) VALUES ";

        $keys = [];
        while (current($basket)){
            $key = key($basket);
            array_push($keys, $key);
            next($basket);
		}

		foreach($keys as $k){
            
			$sql .= "('$userId','$k',CURDATE()), ";
        }
        
        $sql = substr($sql, 0, -2);
		
        $result = mysqli_query($link, $sql);

        if ($result) {
            echo "<p class='error'>Order placed.</p>";
        } else {
            echo "<p class='error'>There has been an error during ordering!</p>";
        }
        unset($_SESSION['basket']);
	}	
}