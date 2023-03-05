function OpenModal(){
    // Get the modal
    var modal = document.getElementById("modalNotifice");
    modal.style.display = "block";
}

function CloseModal(){
    // Get the modal
    var modal = document.getElementById("modalNotifice");
    modal.style.display = "none";
}

function CreateNotification(){
    debugger;
    var LANGUAGE_SETTINGS = document.getElementById('LANGUAGE_SETTINGS').innerHTML;
    var CURRENT_USER = document.getElementById('CURRENT_USER').innerHTML;
    var TITlE = document.getElementById("title").value;
    var CONTENT = document.getElementById("content").value;
    if(TITlE === '')
    {
        document.getElementById('error-message').innerHTML = "Please enter your title";
        document.getElementById('error-message').classList.add('errMess');
    }
    else if(CONTENT === '')
    {
        document.getElementById('error-message').innerHTML = "Please enter your content";
        document.getElementById('error-message').classList.add('errMess');
    }
    else
    {
        var modal = document.getElementById("modalNotifice");
        modal.style.display = "none";
        window.location.href = 
        '/C002/CreateNotification'
        + '/LANGUAGE_SETTINGS = ' + LANGUAGE_SETTINGS
        + '/CURRENT_USER = ' + CURRENT_USER
        + '/TITlE = ' + TITlE
        + '/CONTENT = ' + CONTENT;
    }
}