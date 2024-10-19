import { Injectable } from "@angular/core";
import { Pacchetto } from "../models/pacchetto";

@Injectable({
    providedIn:'root'
})
export class PacchettoRepo{

    private apiUrl:string = 'http://localhost:5279/api/pacchetti';
    constructor(){

    }

    GetAll(): Promise<Pacchetto[]> {
        return fetch(this.apiUrl)
          .then(response => {
            if (!response.ok) {
              throw new Error('Errore recupero dei destinazioni');
            }
            return response.json();
          })
          .then(pacchetti => {
            console.log(pacchetti); 
            return pacchetti; 
          })
          .catch(error => {
            console.error('Errore Fetch:', error);
            throw error;
          });
      }
}