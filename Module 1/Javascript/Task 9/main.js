function loadEvents() {
    document.getElementById("loading").innerHTML = "Loading...";

    fetch("https://jsonplaceholder.typicode.com/posts")
        .then(response => response.json())
        .then(data => {
            document.getElementById("loading").innerHTML = "";

            data.slice(0, 5).forEach(item => {
                document.getElementById("events").innerHTML += `
                    <p>${item.title}</p>
                `;
            });
        })
        .catch(error => {
            document.getElementById("loading").innerHTML =
                "Error loading events";
            console.log(error);
        });
}

async function loadEventsAsync() {
    try {
        document.getElementById("loading").innerHTML = "Loading...";

        const response = await fetch("https://jsonplaceholder.typicode.com/posts");
        const data = await response.json();

        document.getElementById("loading").innerHTML = "";

        console.log(data);
    }
    catch(error) {
        console.log("Error:", error);
    }
}