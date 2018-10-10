$(document).ready(function(){
    $('.buy').click(function(){
        var id = $(this).attr('id');
        $.post('cart.php',{id:id},function(){
        });
    });
	
    $('.delete-item').click(function(){
       var id = $(this).attr('id');
       $.post('cart.php',{delete:id}, function(){ 
           window.location.reload();
       });
    });
	
    $(document).on('click','#empty-cart',function(){
        $.post('cart.php',{empty:true}, function(){
           location.reload(); 
        });
    });
	
	
    $('#order').click(function(){
        $.post('order.php',{order:true}, function(adat){
            $('#table-content').html(adat);
        });
    });
	
	$('i').click(function(){
		
		
	
	});
});