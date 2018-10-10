<?php
session_start();
require_once('connect.php');
//require_once('functions.php');

if(isset($_SESSION['userId'])) {
	$userId = $_SESSION['userId'];
	if(isset($_SESSION['cart']) && !empty($_SESSION['cart'])) {
		$cart = $_SESSION['cart'];
		
		$sql = "INSERT INTO orders (userId, (
		
	
}