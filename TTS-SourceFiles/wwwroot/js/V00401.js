function DeleteUser(ACCOUNT_ID) {
    debugger;
    var Message = document.getElementById('MESSAGE_DELETE_USER').innerHTML;
    var LANGUAGE_SETTINGS = document.getElementById('LANGUAGE_SETTINGS').innerHTML;
    var CURRENT_USER = document.getElementById('CURRENT_USER').innerHTML;
    if (confirm(Message) == true) {
      window.location.href = 
        '/C004/DeleteUser'
        + '/LANGUAGE_SETTINGS = ' + LANGUAGE_SETTINGS
        + '/CURRENT_USER = ' + CURRENT_USER
        + '/ACCOUNT_ID = ' + ACCOUNT_ID;
    }
}

function OpenUserModal(){
  debugger;
  // Get the modal
  var modal = document.getElementById("modalUser");
  modal.style.display = "block";
}

function CloseUserModal(){
  // Get the modal
  var modal = document.getElementById("modalUser");
  modal.style.display = "none";
}