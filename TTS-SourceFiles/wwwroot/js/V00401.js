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

function EditUserModal(USER_ID){
  debugger;
  // Get the modal
  var USER_NAME = '';
  var USER_PASSWORD = '';
  var USER_ROLE = '';
  var IS_ACTIVE = '';
  var modal = document.getElementById("modalUser");
  modal.style.display = "block";

  var userTbl = document.getElementById("user_tbl");
  for(var i=1;i<userTbl.children[0].childElementCount;i++) 
  {
    var userTblRow = userTbl.children[0].children[i];
    for(var j=0;j<userTblRow.childElementCount;j++)
    {
      var userTblColumn = userTblRow.children[0].innerHTML;
      if(userTblColumn === String(USER_ID)) {
        USER_NAME = userTblRow.children[1].innerText;
        USER_PASSWORD = userTblRow.children[2].innerText;
        USER_ROLE = userTblRow.children[3].innerText;
        IS_ACTIVE = userTblRow.children[4].childNodes[1].checked;
        break;
      }
    }
  }
  document.getElementById('uname').value = USER_NAME;
  document.getElementById('psw').value = USER_PASSWORD;
  document.getElementById('user_role').value = USER_ROLE;
  if(IS_ACTIVE) {
    document.getElementById('checkbox').checked = true;
  } else {
    document.getElementById('checkbox').checked = false;
  }

}

function CloseModelUser(){
  // Get the modal
  var modal = document.getElementById("modalUser");
  modal.style.display = "none";
}