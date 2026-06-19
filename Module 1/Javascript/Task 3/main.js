const events = [
    { name: "Music Event", seats: 20 },
    { name: "Sports Event", seats: 0 },
    { name: "Art Event", seats: 10 }
];

events.forEach(event => {
    if (event.seats > 0) {
        console.log(event.name + " Available");
    } else {
        console.log(event.name + " Full");
    }
});

try {
    let seats = 5;

    if (seats <= 0) {
        throw "No Seats Available";
    }

    console.log("Registration Successful");
}
catch(error) {
    console.log("Error: " + error);
}