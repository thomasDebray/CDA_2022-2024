class Data{
    constructor()
    {
        this.datasource = "https://arfp.github.io/tp/web/frontend/zipcodes/zipcodes.json";
        this.datas = [];
    }

    async load() {
        try {
            let response = await fetch(this.datasource);
            this.datas = await response.json();
            console.log(0);
            this.fillDatalist(this.datas);
            console.log(2);
            
        } catch(error) {
            // traitement de l'erreur
        }
    }
    
    fillDatalist(donnee){
        let element = document.getElementById('mydatalist');
        console.log(1);
        for (let city of donnee){
            let option1 = document.createElement('option');
            let option2 = document.createElement('option');
            option1.value=city.nomCommune;
            element.appendChild(option1);
            option2.value=city.codePostal;
            element.appendChild(option2);
        }
    }

    search(data)
    {
        let result = [];

        /*for(let city of this.zipcodes) {
            if(city.codePostal == zipcode) {
                result.push(city);
                console.log(result);
            }
        }*/

        result = this.datas.filter(city => city.codePostal == data || city.nomCommune == data);
        console.log(result);
        this.fillUi(result);


    }

    fillUi(result) 
    {
        //let element = document.getElementById('result');
        let element = document.getElementById('result');
        element.innerHTML = "";

        for(let city of result) {
            //element.innerHTML = "<li>"+ city.NomCommune+"</li>";

            let li = document.createElement('li');
            li.innerText = city.nomCommune + " " +  city.codePostal + " " + city.codeCommune;
            element.appendChild(li);
        }

    }


}    
export { Data }