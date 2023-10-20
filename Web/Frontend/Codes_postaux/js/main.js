import { Data } from './Data.js';



let dataInput = document.getElementById('data');
let button = document.getElementById('validationButton');

button.addEventListener('click', (event) => {
    var reg = new RegExp('^[0-9]{5}|[a-zA-Z]{1,25}$');
    if(reg.test(dataInput.value)) {
        datas.search(dataInput.value)
    }
})

const datas = new Data();
datas.load();


