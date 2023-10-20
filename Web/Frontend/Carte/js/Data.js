class Data{
    constructor(){
        this.datasource = "https://arfp.github.io/tp/web/frontend/cardgame/cardgame.json";
        this.data = [];
    }

    async load() {
        try {
            let response = await fetch(this.datasource);
            this.data = await response.json();
            this.fillTable();
        } catch(error) {
            // traitement de l'erreur
        }
    }

    fillTable(){
        let cardh = this.data[0];
        let thead = document.getElementById('mythead');
        let tbody=document.getElementById('mytbody');
        let tr1 = document.createElement('tr');
        thead.appendChild(tr1); 
        for(let carac in cardh){
            let th = document.createElement('th');
            th.innerText=carac;
            tr1.appendChild(th);
        }
        for(let card of this.data){
            let tr2 = document.createElement('tr');
            tbody.appendChild(tr2); 
            for(let key in card){
                let td = document.createElement('td');
                td.innerText=card[key];
                tr2.appendChild(td);
            }
        }

        let body = document.getElementById('body');

        let h2 = document.createElement('h2');
        h2.innerText="Carte avec damage max";
        body.appendChild(h2);
        let sortedCardsByDamage = this.data.sort((r1,r2)=> (r1.attack<r2.attack) ? 1 : (r1.attack > r2.attack) ? -1 : 0);
        let cardDamageMax = sortedCardsByDamage[0];
        for(let key in cardDamageMax){
            let div1 = document.createElement('div');
            div1.innerText=cardDamageMax[key];
            body.appendChild(div1)
        }

        let h3 = document.createElement('h2');
        h3.innerText="Carte avec armor max";
        body.appendChild(h3);
        let sortedCardsByArmor = this.data.sort((r1,r2)=> (r1.armor<r2.armor) ? 1 : (r1.armor > r2.armor) ? -1 : 0);
        let cardArmorMax = sortedCardsByArmor[0];
        for(let key in cardArmorMax){
            let div2 = document.createElement('div');
            div2.innerText=cardArmorMax[key];
            body.appendChild(div2)
        }
        
        let h4 = document.createElement('h2');
        h4.innerText="Carte avec played max";
        body.appendChild(h4);
        let sortedCardsByPlayed = this.data.sort((r1,r2)=> (r1.played<r2.played) ? 1 : (r1.played > r2.played) ? -1 : 0);
        let cardPlayedMax = sortedCardsByPlayed[0];
        for(let key in cardPlayedMax){
            let div2 = document.createElement('div');
            div2.innerText=cardPlayedMax[key];
            body.appendChild(div2)
        }

        let h5 = document.createElement('h2');
        h5.innerText="Carte avec victory max";
        body.appendChild(h5);
        let sortedCardsByVictory = this.data.sort((r1,r2)=> (r1.victory<r2.victory) ? 1 : (r1.victory > r2.victory) ? -1 : 0);
        let cardVictoryMax = sortedCardsByVictory[0];
        for(let key in cardVictoryMax){
            let div2 = document.createElement('div');
            div2.innerText=cardVictoryMax[key];
            body.appendChild(div2)
        }
    }
}

export { Data }