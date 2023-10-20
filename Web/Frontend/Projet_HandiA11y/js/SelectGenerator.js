class SelectGenerator
{
    constructor(_collection)
    {
        this.collection = _collection;

        this.select = document.getElementById('title-select');
    }

    generateSelect()
    {
        this.collection.data.forEach(t => {
            let option = document.createElement('option');

            option.setAttribute("value",t.titre)
            option.textContent = t.titre;

            this.select.appendChild(option);
        });
    }
}

export { SelectGenerator }