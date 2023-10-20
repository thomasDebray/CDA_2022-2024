import { Cereale } from "./Cereale.js";

class Cereales {
    constructor(_url) {
        this.cerealesCollection = [];
        this.source= _url;
    }

    async getCereales() {
        let retour = await fetch(this.source);
        let json = await retour.json();
        for(let cereale of json.data) {
            this.cerealesCollection.push(new Cereale(cereale));
        }
    }


}

export { Cereales };