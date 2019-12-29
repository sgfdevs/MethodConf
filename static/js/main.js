document.getElementById('subscribe').addEventListener('submit', function (e) {
    var name = document.getElementById('name'),
        email = document.getElementById('email');
    
    swal('Excellent!', 'Thanks, ' + name.value + '. Method Conf news will be headed your way soon.', 'success');
    
    name.value = '';
    email.value = '';
    
    // Post to Zapier
    
    e.preventDefault();
});

$(function() {
    $('.more').on('click', function(){
        var parent = $(this).closest('.speaker_card');
        parent.toggleClass('expanded');
        console.log(parent);
        $('.more_content', parent).slideToggle();
        
        return false;
    });
    
    $('#expand_all').on('click', function () {
        $('.speaker_card').addClass('expanded');
        $('.speaker_card .more_content').slideDown();
        $(this).hide();
        $('#collapse_all').show();

        $('html, body').animate({ 
            scrollTop: $('#schedule_start').offset().top, 
        }, 250, 'linear');
        
        return false;
    });

    $('#collapse_all').on('click', function () {
        $('.speaker_card').removeClass('expanded');
        $('.speaker_card .more_content').slideUp();
        $(this).hide();
        $('#expand_all').show();

        $('html, body').animate({
            scrollTop: $('#schedule_start').offset().top,
        }, 250, 'linear');
        
        return false;
    });
});