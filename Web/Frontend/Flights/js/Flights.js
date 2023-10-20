import { Flight } from "./Flight.js";
import { Db } from "./Db.js";

class Flights {
    constructor(_url) {
        this.flightsCollection = [];
        this.source=_url;
    }

    async getFlights() {
        let json = await Db.getDB("https://arfp.github.io/tp/web/frontend/flights/flights.json");
        for(let flight of json) {
            this.flightsCollection.push(new Flight(flight));
        }
    }
}

export {Flights}