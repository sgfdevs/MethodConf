document.getElementById('subscribe').addEventListener('submit', function (e) {
    var name = document.getElementById('name'),
        email = document.getElementById('email');
    
    swal('Excellent!', 'Thanks, ' + name.value + '. Method Conf news will be headed your way soon.', 'success');
    
    name.value = '';
    email.value = '';
    
    // Post to Zapier
    
    e.preventDefault();
});