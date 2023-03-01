// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function DeleteAccount(ACCOUNT_ID, Message) {
    var LANGUAGE_SETTINGS = document.getElementById('LANGUAGE_SETTINGS').innerHTML;
    var CURRENT_USER = document.getElementById('CURRENT_USER').innerHTML;
    let text = Message;
    if (confirm(text) == true) {
      window.location.href = 
        '/C004/DeleteAccount'
        + '/LANGUAGE_SETTINGS = ' + LANGUAGE_SETTINGS
        + '/CURRENT_USER = ' + CURRENT_USER
        + '/ACCOUNT_ID = ' + ACCOUNT_ID;
    }
}