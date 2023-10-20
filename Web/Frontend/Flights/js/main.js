import { Flights } from "./Flights.js";

let flightsCollection = new Flights();

await flightsCollection.getFlights();
let data = flightsCollection.flightsCollection

const myTbody = document.getElementById('myTbody');

function generateTable(data) {
    myTbody.innerHTML ="";
    for(let flight of data) {
        let ligne = document.createElement('tr');
        myTbody.appendChild(ligne);
        let cel1 = document.createElement('td');
        cel1.textContent=flight.flight_id;
        ligne.appendChild(cel1);
        let cel2 = document.createElement('td');
        cel2.textContent=flight.start_city;
        ligne.appendChild(cel2);
        let cel3 = document.createElement('td');
        cel3.textContent=flight.arrival_city;
        ligne.appendChild(cel3);
        let cel4 = document.createElement('td');
        cel4.textContent=flight.start_time;
        ligne.appendChild(cel4);
        let cel5 = document.createElement('td');
        cel5.textContent=flight.arrival_time;
        ligne.appendChild(cel5);
        let cel6 = document.createElement('td');
        cel6.textContent=flight.flight_duration;
        ligne.appendChild(cel6);
        let cel7 = document.createElement('td');
        cel7.textContent=flight.airline_name;
        ligne.appendChild(cel7);
        let cel8 =document.createElement('td');
        cel8.textContent=flight.plane_maker;
        ligne.appendChild(cel8);
        let cel9 = document.createElement('td');
        cel9.textContent=flight.plane_ref;
        ligne.appendChild(cel9);
        let cel10 = document.createElement('td');
        cel10.textContent=flight.plane_type;
        ligne.appendChild(cel10);
        let cel11 = document.createElement('td');
        cel11.textContent=flight.plane_capacity;
        ligne.appendChild(cel11);
        let cel12 = document.createElement('td');
        cel12.textContent=flight.seats_free;
        ligne.appendChild(cel12);
        let cel13 = document.createElement('td');
        cel13.textContent=flight.fd;
        ligne.appendChild(cel13);


    }
    
}

generateTable(data);




