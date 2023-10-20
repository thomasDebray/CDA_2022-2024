class Db
{
    static async getData(_access)
    {
        let res = await fetch(_access);
        let json = await res.json();
        return json;
    }
}

export {Db}