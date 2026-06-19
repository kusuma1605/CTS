document.getElementById("debugForm").addEventListener("submit", function(event) {
    event.preventDefault();

    console.log("Form submission started");

    let name = document.getElementById("username").value;
    let email = document.getElementById("useremail").value;

    console.log("Name:", name);
    console.log("Email:", email);

    let payload = {
        name: name,
        email: email
    };

    console.log("Payload:", payload);

    debugger;

    fetch("https://jsonplaceholder.typicode.com/posts", {
        method: "POST",
        body: JSON.stringify(payload),
        headers: {
            "Content-type": "application/json"
        }
    })
    .then(response => response.json())
    .then(data => {
        console.log("Fetch success:", data);
        document.getElementById("result").innerHTML = "Submitted successfully";
    })
    .catch(error => {
        console.log("Fetch error:", error);
        document.getElementById("result").innerHTML = "Submission failed";
    });
});