const events = [
    { name: "Music Night", seats: 3 },
    { name: "Sports Day", seats: 2 },
    { name: "Art Exhibition", seats: 1 }
];

const container = document.querySelector("#eventContainer");

events.forEach((event, index) => {
    const card = document.createElement("div");

    card.innerHTML = `
        <h3>${event.name}</h3>
        <p>Seats: <span id="seat${index}">${event.seats}</span></p>
        <button onclick="register(${index})">Register</button>
        <button onclick="cancel(${index})">Cancel</button>
        <hr>
    `;

    container.appendChild(card);
});

function register(index) {
    if (events[index].seats > 0) {
        events[index].seats--;
        document.getElementById("seat" + index).innerHTML = events[index].seats;
    } else {
        alert("No seats available");
    }
}

function cancel(index) {
    events[index].seats++;
    document.getElementById("seat" + index).innerHTML = events[index].seats;
}