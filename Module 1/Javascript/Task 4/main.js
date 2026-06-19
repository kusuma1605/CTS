function addEvent(name) {
    console.log(name + " Added");
}

function registerUser(user) {
    console.log(user + " Registered");
}

function filterEventsByCategory(category, callback) {
    callback(category);
}

addEvent("Music Event");
registerUser("Kusuma");

filterEventsByCategory("Music", function(category){
    console.log("Filtered Category: " + category);
});

function registrationCounter() {
    let count = 0;

    return function() {
        count++;
        console.log("Registrations: " + count);
    };
}

const counter = registrationCounter();

counter();
counter();
counter();