import { Employe } from "./Employe.js";
import { Employes } from "./Employes.js";

const employes = new Employes("https://arfp.github.io/tp/web/frontend/employees/employees.json");
await employes.getEmployes();

const myThead = document.getElementById("myThead");
const myTbody = document.getElementById("myTbody");
const myTfoot = document.getElementById("myTfoot");

function creationEnteteTableau() {
    /*let monEmploye = employes.employesCollection[0];

    let ligne = document.createElement('tr');
    myThead.appendChild(ligne);
    for(let donnees of monEmploye.getKeys()) {
        let cellule = document.createElement('th');
        cellule.textContent = donnees;
        ligne.appendChild(cellule);
    }*/
    myThead.innerHTML = "";
    let ligne = document.createElement('tr');
    myThead.appendChild(ligne);
    let cellule1 = document.createElement('th');
    cellule1.textContent = "EID";
    ligne.appendChild(cellule1);
    let cellule2 = document.createElement('th');
    cellule2.textContent = "Full Name";
    ligne.appendChild(cellule2);
    let cellule3 = document.createElement('th');
    cellule3.textContent = "Email";
    ligne.appendChild(cellule3);
    let cellule4 = document.createElement('th');
    cellule4.textContent = "Monthly salary";
    let br = document.createElement('br');
    cellule4.appendChild(br);

    let bouton1 = document.createElement('button');
    bouton1.innerHTML = "Rising";
    bouton1.addEventListener('click',()=> {
        employes.employesCollection.sort((a,b)=> a.employee_salary-b.employee_salary);
        creationTableau();
    });
    cellule4.appendChild(bouton1);

    let bouton2 = document.createElement('button');
    bouton2.innerHTML = "Decreasing";
    bouton2.addEventListener('click',()=>{
        employes.employesCollection.sort((a,b)=> a.employee_salary-b.employee_salary).reverse();
        creationTableau();
    });
    cellule4.appendChild(bouton2);

    ligne.appendChild(cellule4);
    let cellule5 = document.createElement('th');
    cellule5.textContent = "Year of birth";
    ligne.appendChild(cellule5);
    let cellule6 = document.createElement('th');
    cellule6.textContent = "Actions";
    ligne.appendChild(cellule6);
}

function creationTableau() {
    creationEnteteTableau();
    myTbody.innerHTML = "";

    /*for(let employe of employes.employesCollection) {
        let ligne = document.createElement('tr');
        myTbody.appendChild(ligne);
        for(let donnees of employe.getValues()) {
            let cellule = document.createElement('td')
            cellule.textContent = donnees;
            ligne.appendChild(cellule);
        }
    }*/
    let indice=0;
    for(let employe of employes.employesCollection) {
        let ligne = document.createElement('tr');
        myTbody.appendChild(ligne);
        let cellule1 = document.createElement('td');
        indice++;
        cellule1.textContent = employe.id;
        ligne.appendChild(cellule1);
        let cellule2 = document.createElement('td');
        cellule2.textContent = employe.employee_name;
        ligne.appendChild(cellule2);
        let cellule3 = document.createElement('td');
        cellule3.textContent = email(employe);
        ligne.appendChild(cellule3);
        let cellule4 = document.createElement('td');
        cellule4.textContent = salaire(employe)+" €";
        ligne.appendChild(cellule4);
        let cellule5 = document.createElement('td');
        cellule5.textContent = 2023-employe.employee_age;
        ligne.appendChild(cellule5);
        let cellule6 = document.createElement('td');

        let bouton1 = document.createElement('button');
        bouton1.innerHTML = 'Duplicate';
        bouton1.dataset.id = employe.id;
        bouton1.addEventListener('click', (event) => {
            console.log(event.target);
            console.log(event.target.dataset);
            let id = event.target.dataset.id;
            let emp = employes.employesCollection.find(e => e.id == id);
            console.log(emp);
            duplicate(emp,indice);
        });
       // bouton1.onclick = duplicate(employe);
        cellule6.appendChild(bouton1);

        let bouton2 = document.createElement('button');
        bouton2.innerHTML = 'Delete';
        bouton2.dataset.id = indice;
        bouton2.addEventListener('click', (event) => {
            let id = event.target.dataset.id;
            console.log(id);
            sup(id);
        });
        cellule6.appendChild(bouton2);
        ligne.appendChild(cellule6);
    }
    creationPiedDeTableau()
}

function creationPiedDeTableau() {
    myTfoot.innerHTML = "";
    let ligne = document.createElement('tr');
    myTfoot.appendChild(ligne);
    let cellule1 = document.createElement('td');
    cellule1.textContent = employes.employesCollection.length;
    ligne.appendChild(cellule1);
    let cellule2 = document.createElement('td');
    ligne.appendChild(cellule2);
    let cellule3 = document.createElement('td');
    ligne.appendChild(cellule3);
    let cellule4 = document.createElement('td');
    cellule4.textContent = totalSalaire()+" €";
    ligne.appendChild(cellule4);
    let cellule5 = document.createElement('td');
    ligne.appendChild(cellule5);
    let cellule6 = document.createElement('td');
    ligne.appendChild(cellule6);
}

creationTableau();

/**
 * 
 * @param {Employe} employe 
 */
function email(employe) {
    const str = employe.employee_name;
    const words = str.split(' ');
    return words[0][0].toLowerCase()+"."+words[1].toLowerCase()+"@email.com";
}

/**
 * 
 * @param {Employe} employe 
 * @returns 
 */
function salaire(employe) {
    return (employe.employee_salary/12).toFixed(2);
}

function nbEmploye() {
    let nbEmploye=0;
    for(let employe of employes.employesCollection) {
        nbEmploye++;
    }
    return nbEmploye;
}

function totalSalaire() {
    let total=0;
    for(let employe of employes.employesCollection) {
        total = total+parseFloat(salaire(employe));
    }
    return total.toFixed(2);
}

function duplicate(employe,id) {
    //employe.id = employes.employesCollection.length+1;
    let emp_id = Math.max.apply(Math, employes.employesCollection.map(function(emp) { return emp.id; })) // id le plus élevé
    console.log(emp_id);
    console.log(employe.id);
    let newEmploye = new Employe(employe);
    newEmploye.id = emp_id + 1;
    employes.employesCollection.push(newEmploye);
    creationTableau();
}

function sup(id) {
    employes.employesCollection.splice(id-1,1);
    creationTableau();
}


