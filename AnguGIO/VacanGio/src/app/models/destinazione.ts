export class Destinazione {
    codDest :string|undefined;
    nom:string|undefined;
    desc:string|undefined;   
    pae:string|undefined;   
    imgU:string|undefined;   
    StampaDettaglio() : void{
        console.log(this.codDest, this.nom, this.desc, this.pae, this.imgU);
    }
}
