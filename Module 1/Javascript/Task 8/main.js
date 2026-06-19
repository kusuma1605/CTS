const events = [
    { name: "Music Night", category: "Music" },
    { name: "Sports Day", category: "Sports" },
    { name: "Art Exhibition", category: "Art" }
];

function displayEvents(list) {
    const eventList = document.getElementById("eventList");
    eventList.innerHTML = "";

    list.forEach(event => {
        eventList.innerHTML += `
            <p>
                ${event.name} - ${event.category}
                <button onclick="registerEvent('${event.name}')">Register</button>
            </p>
        `;
    });
}

function registerEvent(name) {
    alert("Registered for " + name);
}

function filterEvents() {
    const category = document.getElementById("categoryFilter").value;

    if (category === "All") {
        displayEvents(events);
    } else {
        const filtered = events.filter(event => event.category === category);
        displayEvents(filtered);
    }
}

function searchEvent() {
    const searchText = document.getElementById("searchBox").value.toLowerCase();

    const filtered = events.filter(event =>
        event.name.toLowerCase().includes(searchText)
    );

    displayEvents(filtered);
}

displayEvents(events);