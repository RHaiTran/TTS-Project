// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var pageID = document.getElementById('PageID').innerHTML;
var buttonID = '';
switch (pageID)
{
    case 'V002':
        buttonID = 'homeBtn';
        break;
    case 'V003':
        buttonID = 'departmentBtn';
        break;
    case 'V004':
        buttonID = 'accountBtn';
        break;
    case 'V005':
        buttonID = 'notificationBtn';
        break;
    case 'V006':
        buttonID = 'schelduleBtn';
        break;
    case 'V007':
        buttonID = 'messageBtn';
        break;
    case 'V008':
        buttonID = 'fileManagementBtn';
        break;
    case 'V009':
        buttonID = 'settingBtn';
        break;
    default:
        buttonID = 'homeBtn';
}
document.getElementById(buttonID).classList.add('active');