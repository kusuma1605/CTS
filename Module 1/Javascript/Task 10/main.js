const events = [
    { name: "Music Night", category: "Music", seats: 20 },
    { name: "Sports Day", category: "Sports", seats: 15 },
    { name: "Art Exhibition", category: "Art", seats: 10 }
];

function displayEvent(event = { name: "Default Event", category: "General", seats: 0 }) {
    const { name, category, seats } = event;

    document.getElementById("output").innerHTML += `
        <p>${name} - ${category} - Seats: ${seats}</p>
    `;
}

const copiedEvents = [...events];

copiedEvents.forEach(event => displayEvent(event));