function Event(name, seats) {
    this.name = name;
    this.seats = seats;
}

Event.prototype.checkAvailability = function() {
    if (this.seats > 0) {
        console.log(this.name + " Available");
    } else {
        console.log(this.name + " Full");
    }
};

const event1 = new Event("Music Event", 25);

event1.checkAvailability();

Object.entries(event1).forEach(([key, value]) => {
    console.log(key + " : " + value);
});