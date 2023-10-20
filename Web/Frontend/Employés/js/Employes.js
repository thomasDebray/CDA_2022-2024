import { Employe } from "./Employe.js";

class Employes {
    /**
     * 
     * @param {String} _url 
     */
    constructor(_url) {
        this.employesCollection = [];
        this.source=_url;
    }

    async getEmployes() {
        let retour = await fetch(this.source);
        let json = await retour.json();
        for(let employe of json.data) {
            this.employesCollection.push(new Employe(employe));
        }
    }
}

export { Employes }