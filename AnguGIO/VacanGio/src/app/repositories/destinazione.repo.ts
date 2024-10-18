import { Injectable } from "@angular/core";
import { Destinazione } from "../models/destinazione";

@Injectable({
    providedIn: 'root'
})
export class DestinazioneRepo {



    private apiUrl:string = 'http://localhost:5279/api/destinazioni';

    constructor() {

    }
   

    GetAll(): Promise<Destinazione[]> {
      return fetch(this.apiUrl)
        .then(response => {
          if (!response.ok) {
            throw new Error('Errore recupero dei destinazioni');
          }
          return response.json();
        })
        .then(destinazioni => {
          console.log(destinazioni); 
          return destinazioni; 
        })
        .catch(error => {
          console.error('Errore Fetch:', error);
          throw error;
        });
    }


  

}