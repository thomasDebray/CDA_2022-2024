class Flight{
    constructor(flight){
        Object.assign(this, flight);
        this.fd=this.getFD();
        console.log(this);
    }
    getValues(){
        return Object.values(this);
    }
    getFD(){
        let departure = new Date(this.start_time);
        let arrival = new Date(this.arrival_time);
        console.log(arrival);
        let difference=arrival.getTime() - departure.getTime(); 
        let hoursDifference = Math.floor(difference/1000/60/60);
        difference -= hoursDifference*1000*60*60;
        let minutesDifference = Math.floor(difference/1000/60);
        difference -= minutesDifference*1000*60;
        let secoundsDifference = Math.floor(difference/1000);
        let result = hoursDifference+":"+minutesDifference+":"+secoundsDifference;
        console.log(result);
        return result
    }
}
export {Flight}