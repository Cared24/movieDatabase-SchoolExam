
$(document).ready(function() {
    $('.movie-cart').click(function() {
        var id = $(this).attr('id');
        console.log(id);
        $.post('basket.php', { id: id }, function() {

        });
    });

    $('.delete').click(function() {
        var id = $(this).attr('id');
        console.log(id);
        $.post('basket.php', { deleteMovie: id }, function() {
            window.location.reload();
        });
    });

    $('.empty-basket').click(function() {
        $.post('basket.php', { empty: true }, function() {
            window.location.reload();
        });
    });

    $('#order-button').click(function() {
        $.post('order.php', { order: true }, function(adat) {
            $('#table-content').html(adat);
        });



    });




});