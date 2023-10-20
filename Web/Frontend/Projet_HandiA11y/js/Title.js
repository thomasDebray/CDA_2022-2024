class Title
{
    constructor(_title)
    {
        Object.assign(this,_title);
    }

    getValues()
    {
        return Object.values(this);
    }
}

export { Title }