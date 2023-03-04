// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function CreateUser(Message) {
    var LANGUAGE_SETTINGS = document.getElementById('LANGUAGE_SETTINGS').innerHTML;
    var CURRENT_USER = document.getElementById('CURRENT_USER').innerHTML;
    var UNAME = document.getElementById("uname").value;
    if(UNAME === '') { UNAME = 'res'; }
    var PSW = document.getElementById("psw").value;
    if(PSW === '') { PSW = 'res'; }
    var IsActive = document.getElementById("isActive").checked;
    var USER_ROLE = document.getElementById("user_role").vale;
    if (confirm(Message) == true) {
      window.location.href = 
      '/C004/CreateUser'
      + '/LANGUAGE_SETTINGS = ' + LANGUAGE_SETTINGS
      + '/CURRENT_USER = ' + CURRENT_USER
      + '/UNAME = ' + UNAME
      + '/PSW = ' + PSW
      + '/IsActive = ' + IsActive
      + '/USER_ROLE = ' + USER_ROLE;
    }
}

function ReturnUserPage() {
  var LANGUAGE_SETTINGS = document.getElementById('LANGUAGE_SETTINGS').innerHTML;
  var CURRENT_USER = document.getElementById('CURRENT_USER').innerHTML;
  window.location.href = 
  '/C004/ReturnUserPage'
  + '/LANGUAGE_SETTINGS = ' + LANGUAGE_SETTINGS
  + '/CURRENT_USER = ' + CURRENT_USER;
}