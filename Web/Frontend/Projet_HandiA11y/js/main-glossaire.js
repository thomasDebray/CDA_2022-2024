import { TitleCollection} from "./TitleCollection.js";
import { SelectGenerator } from "./SelectGenerator.js";

let titleCollection = new TitleCollection();

await titleCollection.loadData();

let select = new SelectGenerator(titleCollection);

select.generateSelect();

document.getElementById("title-select").addEventListener("input", async (event) => {
    let selectValue = event.target.value;

    await titleCollection.searchByTitle(selectValue);
    
    if(titleCollection.data.length>1) 
    {
        document.getElementById("bodyField").innerHTML = ""
    }
    else
    {
        document.getElementById("bodyField").innerHTML = titleCollection.data[0].corps;
    }
})

