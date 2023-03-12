function CreateUser() {
    var MESSAGE_ADD_COMFIRM = document.getElementById('MESSAGE_ADD_COMFIRM').innerHTML;
    var LANGUAGE_SETTINGS = document.getElementById('LANGUAGE_SETTINGS').innerHTML;
    var CURRENT_USER = document.getElementById('CURRENT_USER').innerHTML;
    var UNAME = document.getElementById('uname').value;
    var PSW = document.getElementById('psw').value;
    var IsActive = document.getElementById("isActive").checked;
    var USER_ROLE = document.getElementById("user_role").value;
    if(UNAME === '') {
      switch(LANGUAGE_SETTINGS) {
        case 'ja':
          document.getElementById('error-message').innerHTML = 'ユーザー名はブランクできません。';
          document.getElementById('error-message').classList.add('errMess');
          break;
        case 'en':
          document.getElementById('error-message').innerHTML = 'Username cannot be blank.';
          document.getElementById('error-message').classList.add('errMess');
          break;
        default:
          // code block
      }
    } else if(UNAME.length < 9 || !UNAME.includes('@tts.com')){
      switch(LANGUAGE_SETTINGS) {
        case 'ja':
          document.getElementById('error-message').innerHTML = 'メールのフォーマット:@tts.com';
          document.getElementById('error-message').classList.add('errMess');
          break;
        case 'en':
          document.getElementById('error-message').innerHTML = 'Email format: @tts.com';
          document.getElementById('error-message').classList.add('errMess');
          break;
        default:
          // code block
      }
    } else if (PSW.length < 4){
      switch(LANGUAGE_SETTINGS) {
        case 'ja':
          document.getElementById('error-message').innerHTML = 'パスワードは4文字以上である必要があります。';
          document.getElementById('error-message').classList.add('errMess');
          break;
        case 'en':
          document.getElementById('error-message').innerHTML = 'Password must be at least 4 characters.';
          document.getElementById('error-message').classList.add('errMess');
          break;
        default:
          // code block
      }
    }
    else {
      if (confirm(MESSAGE_ADD_COMFIRM) == true) {
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
}

function ReturnUserPage() {
  var LANGUAGE_SETTINGS = document.getElementById('LANGUAGE_SETTINGS').innerHTML;
  var CURRENT_USER = document.getElementById('CURRENT_USER').innerHTML;
  window.location.href = 
  '/C004/ReturnUserPage'
  + '/LANGUAGE_SETTINGS = ' + LANGUAGE_SETTINGS
  + '/CURRENT_USER = ' + CURRENT_USER;
}