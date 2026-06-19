document.getElementById("ajaxForm").addEventListener("submit", function(event) {
    event.preventDefault();

    let userData = {
        name: document.getElementById("name").value,
        email: document.getElementById("email").value
    };

    document.getElementById("message").innerHTML = "Submitting...";

    setTimeout(function() {
        fetch("https://jsonplaceholder.typicode.com/posts", {
            method: "POST",
            body: JSON.stringify(userData),
            headers: {
                "Content-type": "application/json"
            }
        })
        .then(response => response.json())
        .then(data => {
            document.getElementById("message").innerHTML =
                "Registration submitted successfully!";
            console.log(data);
        })
        .catch(error => {
            document.getElementById("message").innerHTML =
                "Registration failed!";
            console.log(error);
        });
    }, 2000);
});