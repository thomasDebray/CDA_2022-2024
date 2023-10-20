import { Cereale } from "./Cereale.js";
import { Cereales } from "./Cereales.js";


const cereales = new Cereales("https://arfp.github.io/tp/web/frontend/cereals/cereals.json");
await cereales.getCereales();

var collectionTemp = cereales.cerealesCollection;
const myThead = document.getElementById("myThead");
const myTbody = document.getElementById("myTbody");
const myTfoot = document.getElementById("myTfoot");
const source = document.getElementById("nomCereale");
const a = document.getElementById("a");
const b = document.getElementById("b");
const c = document.getElementById("c");
const d = document.getElementById("d");
const e = document.getElementById("e");
const cat = document.getElementById("categories");

a.checked = true;
b.checked = true;
c.checked = true;
d.checked = true;
e.checked = true;



let ordreTri = true; //true = croissant et false = décroissant

/*
function createThMD(columnName)
{
    let cellule1 = document.createElement('th');
    cellule1.textContent = columnName;
    return cellule1;
}*/
function selection(collection) {
    console.log(collection);
   // let maCollection = collection;
    let collectionSelection = [];
    if(a.checked) {
        let collectionSelection1 = collection.filter((cereale) => parseInt(cereale.rating)>80);
        collectionSelection = collectionSelection.concat(collectionSelection1);
    }
    if(b.checked) {
        let collectionSelection2 = collection.filter((cereale) => parseInt(cereale.rating)>70&&parseInt(cereale.rating)<=80);
        collectionSelection = collectionSelection.concat(collectionSelection2);
    }
    if(c.checked) {
        let collectionSelection3 = collection.filter((cereale) => parseInt(cereale.rating)>55&&parseInt(cereale.rating)<=70);
        collectionSelection = collectionSelection.concat(collectionSelection3);
    }
    if(d.checked) {
        let collectionSelection4 = collection.filter((cereale) => parseInt(cereale.rating)>=35&&parseInt(cereale.rating)<=55);
        collectionSelection = collectionSelection.concat(collectionSelection4);

    }
    if(e.checked) {
        let collectionSelection5 = collection.filter((cereale) => parseInt(cereale.rating)<35);
        collectionSelection = collectionSelection.concat(collectionSelection5);
    }
    
    console.log(collectionSelection);

    return collectionSelection;

}

function selectionCategorie(collection) {
    let collectionSelection=collection;
    if(cat.value == "sanssucre") {
        collectionSelection = collectionSelection.filter((cereale) => cereale.sugars<1 )
    }
    if(cat.value == "pauvreensel") {
        collectionSelection = collectionSelection.filter((cereale) => cereale.sodium<50 )
    }
    if(cat.value == "boost") {
        collectionSelection = collectionSelection.filter((cereale) => cereale.vitamins>=25&&cereale.fiber>=10)
    }

    if(cat.value =="tous") {
     
        //collectionSelection=collection;
    }
    return collectionSelection;
}

a.addEventListener('change', ()=> {

    let tableauA = selection(collectionTemp);
    creationTableau(tableauA);
    cat.value="tous";
})

b.addEventListener('change', ()=> {
    let tableauB = selection(collectionTemp);
    creationTableau(tableauB);
    cat.value="tous";
})

c.addEventListener('change', ()=> {
    let tableauC = selection(collectionTemp); 
    creationTableau(tableauC);
    cat.value="tous";
})

d.addEventListener('change', ()=> {
    let tableauD = selection(collectionTemp); 
    creationTableau(tableauD);
    cat.value="tous";
})

e.addEventListener('change', ()=> {
    let tableauE = selection(collectionTemp); 
    creationTableau(tableauE);
    cat.value="tous";
})

cat.addEventListener('change', ()=> {
    let resultCollection = selection(selectionCategorie(collectionTemp)); 
    creationTableau(resultCollection);
})

function tri(nomColonne)
{
    console.log((ordreTri ? "tri croissant" : "tri decroissant") + " " + nomColonne);
    let typeName = typeof cereales.cerealesCollection[0][nomColonne];

    if (typeName != "string"){
        console.log("algo nn str");
        cereales.cerealesCollection.sort((a,b)=> a[nomColonne]-b[nomColonne]);
    } else {
        console.log("algo str");
        cereales.cerealesCollection.sort((a,b)=> a[nomColonne].localeCompare(b[nomColonne]));
    }
    console.log(cereales.cerealesCollection);
    if (!ordreTri){
        console.log('inversion effectuee');
        cereales.cerealesCollection.reverse();
        console.log(cereales.cerealesCollection);
    }
    
   /* if(ordreTri==true) {
        
        ordreTri = false;
    }
    else {
        cereales.cerealesCollection.sort((a,b)=> a[nomColonne]-b[nomColonne]).reverse();
        ordreTri = true;
    }*/
}

source.addEventListener('input', (e) => {
    let collectionsTemp = filtreCereales(cereales.cerealesCollection,e.target.value);
    creationTableau(collectionsTemp);
});

function filtreCereales(collection,entree) 
{
    // (cereale) => cereale.name.toLowerCase().includes(entree.toLowerCase())
    collectionTemp = collection.filter(  function (cereale ) {
        return cereale.name.toLowerCase().includes(entree.toLowerCase()); }
          )
      
    return selectionCategorie(selection(collectionTemp));
}

function celluleTh(nomColonne, nomColonneJson) 
{
    let cellule = document.createElement('th');
    cellule.textContent = nomColonne;
    cellule.addEventListener('click', () => {
        tri(nomColonneJson);
        ordreTri = !ordreTri;
        creationTableau(cereales.cerealesCollection);
    });
    return cellule;
}

function creationEnteteTableau() {
    myThead.innerHTML = "";
    let ligne = document.createElement('tr');
    myThead.appendChild(ligne);
  
    //ligne.appendChild(createThMD("ID"));

    ligne.appendChild(celluleTh("ID", "id"));
    
    ligne.appendChild(celluleTh("NOM", "name"));
    
    ligne.appendChild(celluleTh("CALORIES", "calories"));
    
    ligne.appendChild(celluleTh("PROTEÏNES", "protein"));
    
    ligne.appendChild(celluleTh("SEL", "sodium"));
    
    ligne.appendChild(celluleTh("FIBRES", "fiber"));
    
    ligne.appendChild(celluleTh("GLUCIDES", "carbo"));
    
    ligne.appendChild(celluleTh("SUCRE", "sugars"));
    
    ligne.appendChild(celluleTh("POTASSIUM", "potass"));
    
    ligne.appendChild(celluleTh("VITAMINES", "vitamins"));

    ligne.appendChild(celluleTh("EVALUATION", "rating"));
    
    ligne.appendChild(celluleTh("NS"));

    let cellule13 = document.createElement('th');
    cellule13.textContent = "DEL";
    ligne.appendChild(cellule13);
}

function creationPiedDeTableau(monTableau) {
    myTfoot.innerHTML = "";
    let ligne = document.createElement('tr');
    myTfoot.appendChild(ligne);
    let cellule1 = document.createElement('td');
    ligne.appendChild(cellule1);
    let cellule2 = document.createElement('td');
    cellule2.textContent = monTableau.length + " éléments";
    ligne.appendChild(cellule2);
    let cellule3 = document.createElement('td');
    cellule3.textContent = "Moyenne calories " + moyenneCalories(monTableau);
    ligne.appendChild(cellule3);
    let cellule4 = document.createElement('td');
    ligne.appendChild(cellule4);
    cellule4.colSpan = 10;
    /*let cellule5 = document.createElement('td');
    ligne.appendChild(cellule5);
    let cellule6 = document.createElement('td');
    ligne.appendChild(cellule6);
    let cellule7 = document.createElement('td');
    ligne.appendChild(cellule7);
    let cellule8 = document.createElement('td');
    ligne.appendChild(cellule8);
    let cellule9 = document.createElement('td');
    ligne.appendChild(cellule9);
    let cellule10 = document.createElement('td');
    ligne.appendChild(cellule10);
    let cellule11 = document.createElement('td');
    ligne.appendChild(cellule11);
    let cellule12 = document.createElement('td');
    ligne.appendChild(cellule12);
    let cellule13 = document.createElement('td');
    ligne.appendChild(cellule13);*/
}

function creationTableau(monTableau) {
    //let monTableau = _monTableau;
    creationEnteteTableau();
    creationPiedDeTableau(monTableau);
    myTbody.innerHTML ="";
    for(let cereale of monTableau) {
        let ligne = document.createElement('tr');
        myTbody.appendChild(ligne);
        let cellule1 = document.createElement('td');
        cellule1.textContent = cereale.id;
        ligne.appendChild(cellule1);
        let cellule2 = document.createElement('td');
        cellule2.textContent = cereale.name;
        ligne.appendChild(cellule2);
        let cellule3 = document.createElement('td');
        cellule3.textContent = cereale.calories;
        ligne.appendChild(cellule3);
        let cellule4 = document.createElement('td');
        cellule4.textContent = cereale.protein;
        ligne.appendChild(cellule4);
        let cellule5 = document.createElement('td');
        cellule5.textContent = cereale.sodium;
        ligne.appendChild(cellule5);
        let cellule6 = document.createElement('td');
        cellule6.textContent = cereale.fiber;
        ligne.appendChild(cellule6);
        let cellule7 = document.createElement('td');
        cellule7.textContent = cereale.carbo;
        ligne.appendChild(cellule7);
        let cellule8 = document.createElement('td');
        cellule8.textContent = cereale.sugars;
        ligne.appendChild(cellule8);
        let cellule9 = document.createElement('td');
        cellule9.textContent = cereale.potass;
        ligne.appendChild(cellule9);
        let cellule10 = document.createElement('td');
        cellule10.textContent = cereale.vitamins;
        ligne.appendChild(cellule10);
        let cellule11 = document.createElement('td');
        cellule11.textContent = cereale.rating;
        ligne.appendChild(cellule11);
        let cellule12 = document.createElement('td');
        cellule12.textContent = ns(parseInt(cereale.rating));
        ligne.appendChild(cellule12);
        let cellule13 = document.createElement('td');
        ligne.appendChild(cellule13);
        let boutonDel = document.createElement('button');
        boutonDel.textContent = "X";
        boutonDel.dataset.id = cereale.id;
        boutonDel.addEventListener('click',(e)=> {
            cereales.cerealesCollection = cereales.cerealesCollection.filter(cereale => cereale.id!=e.target.dataset.id);
            creationTableau(cereales.cerealesCollection);
        })
        cellule13.appendChild(boutonDel);
    }
}

function ns(evaluation) {
    if(evaluation>80) {
        return "A"
    }
    if(evaluation>70&&evaluation<=80) {
        return "B"
    }
    if(evaluation>55&&evaluation<=70) {
        return "C"
    }
    if (evaluation>=35&&evaluation<=55) {
        return "D"
    }
    if (evaluation<35) {
        return "E"
    }
}

function moyenneCalories(collection) {
    let total = 0;
    for(let cereale of collection) {
         total = total + cereale.calories;
    }
    return (total/collection.length).toFixed(0); 
}

creationTableau(cereales.cerealesCollection);
