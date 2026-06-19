let events = [
    { name: "Music Night", category: "Music" },
    { name: "Baking Workshop", category: "Workshop" },
    { name: "Sports Day", category: "Sports" }
];

events.push({ name: "Classical Music", category: "Music" });

let musicEvents = events.filter(event => event.category === "Music");

console.log("Music Events:");
console.log(musicEvents);

let eventCards = events.map(event => "Workshop on " + event.name);

console.log("Formatted Event Cards:");
console.log(eventCards);