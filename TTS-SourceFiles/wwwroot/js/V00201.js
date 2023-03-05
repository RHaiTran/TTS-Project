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
    var TITlE = document.getElementById("title").value;
    var CONTENT = document.getElementById("content").value;
    window.location.href = 
    '/C002/CreateNotification'
    + '/TITlE = ' + TITlE
    + '/CONTENT = ' + CONTENT;
}