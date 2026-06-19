document.getElementById("registrationForm").addEventListener("submit", function(event) {
    event.preventDefault();

    let form = event.target;

    let name = form.elements["username"].value;
    let email = form.elements["email"].value;
    let eventName = form.elements["eventName"].value;

    document.getElementById("nameError").innerHTML = "";
    document.getElementById("emailError").innerHTML = "";
    document.getElementById("eventError").innerHTML = "";

    if (name === "") {
        document.getElementById("nameError").innerHTML = " Name is required";
        return;
    }

    if (email === "") {
        document.getElementById("emailError").innerHTML = " Email is required";
        return;
    }

    if (eventName === "") {
        document.getElementById("eventError").innerHTML = " Please select an event";
        return;
    }

    document.getElementById("successMessage").innerHTML =
        "Registration successful for " + eventName;
});