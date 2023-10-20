/*
card = {
    "id":1,"name":"Ricko"
,"level":1,"power":7
,"attack":11,"armor":6
,"damage":1845
,"mitigation":18
,"played":499546
,"victory":320499
,"defeat":166596
,"draw":12451}
*/
class Card {

    /**
     * 
     * @param {Object} card 
     */
    constructor(card) {
        // ancienne façon de faire
        // for (let i of Object.keys(card)) {

        //     this[i]=card[i];
        // }

        // Nouvelle façon de faire
        Object.assign(this, card);
        //console.log(this)
    }

    /**
     * Retourne les valeurs de l'objet courant dans un tableau
     * @returns {Array} Les valeurs de l'objet courant
     */
    getValues()
    {
        return Object.values(this);
    }

    /**
     * Retourne les noms des attributs de l'objet courant dans un tableau
     * @returns {Array} Les attributs de l'objet courant
     */
    getKeys()
    {
        return Object.keys(this);
    }
}


export { Card };