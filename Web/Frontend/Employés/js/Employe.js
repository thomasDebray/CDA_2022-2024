class Employe {
    /**
     * 
     * @param {Object} employe 
     */
    constructor(employe) {
        Object.assign(this, employe);
        //console.log(this);
    }
    /**
     * 
     * @returns {Array}
     */
    getValues() {
        return Object.values(this);
    }
    /**
     * 
     * @returns {Array}
     */
    getKeys() {
        return Object.keys(this);
    }

}

export { Employe };