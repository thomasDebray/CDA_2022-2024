import { Card } from "./Card.js";

class Cards
{
    /**
     * Construit l'objet
     * @param {String} _url Url vers l'api contenant la collection de cartes
     */
    constructor(_url)
    {
        this.cardsCollection = [];
        this.source=_url;

    }

    /**
     * Récupere les données du fichier json et les 
     * stock sous forme de Card dans la cardsCollection.
     */
    async getCards() {
        let resp = await fetch(this.source)
        let json = await resp.json(); 
        for(let card of json)
        {
            this.cardsCollection.push(new Card(card))
        }
    } 

    /**
     * Retourne le 1er élément de la collection
     * @returns {Card} La 1ere carte de la collection
     */
    getFirst()
    {
        try {
            return this.cardsCollection[0];
        } catch(error) {
            alert('La collection est vide !');
        }
        
    }

    /* 
    La méthode sort prends en compte deux paramètres
    (ici nommé a et b) en fonction du retour
    si retour < 0 a et avant b
    si retour = 0 a et b sont égaux
    si retour > 0 a et après b
    */

    /**
        Retourne la carte
        @returns {Card} Carte ayant le plus d'attaque
     */
    getHigherAttackCard(){
        return this.cardsCollection.sort((a,b)=> a.attack-b.attack).reverse()[0];
    }    
    
    getHigherArmorCard(){
        return this.cardsCollection.sort((a,b) => a.armor - b.armor).reverse()[0];
    }


    getHigherPlayedCard(){
        return this.cardsCollection.sort((a,b) => a.played - b.played).reverse()[0];
    }

    getHigherVictoryCard(){
        return this.cardsCollection.sort((a,b) => a.victory - b.victory).reverse()[0];
    }
    
    /*getHigherStats(statsName){
        return this.cardsCollection.sort(
            (a,b)=> a[statsName]-b[statsName])[0];
    }*/
}

export { Cards };