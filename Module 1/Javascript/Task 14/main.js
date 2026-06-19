$(document).ready(function() {
    $("#registerBtn").click(function() {
        $("#eventCard").fadeIn();

        setTimeout(function() {
            $("#eventCard").fadeOut();
        }, 3000);
    });
});