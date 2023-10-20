class Cereale {
    constructor(cereale) {
        Object.assign(this, cereale);
    }

    getValues() {
        return Object.values(this);
    }

    getKeys() {
        return Object.keys(this);
    }
}

export { Cereale };