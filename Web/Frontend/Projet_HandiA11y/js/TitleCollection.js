import { Title } from "./Title.js";
import { Db } from "./db.js";

class TitleCollection
{
    constructor()
    {
        this.data = [];
    }

    async loadData()
    {
        this.data = await Db.getData("../json/glossaire.json");
        
        this.data = this.data.glossaire.map(i => new Title(i));
    }

    async searchByTitle(title)
    {
        await this.loadData();

        this.data = this.data.filter(t => t.titre.includes(title));
    }

}

export { TitleCollection }