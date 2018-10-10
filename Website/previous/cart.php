<?php
session_start();
require_once('connect.php');
require_once('functions.php');


//PONTOSAN MELYIK ID?? orderId? movieId? userId?
if(isset($_POST['id'])) {
	$id = $_POST['id'];
	
	if(!isset($_SESSION['cart'])) {
		$_SESSION['cart'] = [];
	}
	
	    if (isset($_POST['delete'])){
        $id = $_POST['delete'];
        unset($_SESSION['cart'][$id]);
        echo 'Deleted';
        printCart($link);
    }
	
	//Ezzel növeljük a mennyiséget?
	if(isset($_SESSION['cart'])) {
		$_SESSION['cart'][$id] += 1;
	}	
}


if(isset($_POST['empty'])) {
	unset($_SESSION['cart']);
}


?>