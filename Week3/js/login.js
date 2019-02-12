function initLogin()
{
 $('#error').hide();

    $('button').click(function(event) {
         if (validateLogin()) {
            alert("Submitting regisgtration");
         }
    });
}

function validateLogin() {
    if ($('#username').val().length == 0) {
        displayError("Username must be entered.");
        return false;
    }
    if ($('#password').val().length == 0) {
        displayError("Password must be entered.");
        return false;
    }
    return true;
}

function displayError(error) {
    alert(error);
}
