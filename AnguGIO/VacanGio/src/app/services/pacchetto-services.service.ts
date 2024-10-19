import { Injectable } from '@angular/core';
import { Pacchetto } from '../models/pacchetto';
import { PacchettoRepo } from '../repositories/pacchetto.repo';

@Injectable({
  providedIn: 'root'
})
export class PacchettoServicesService {

  constructor(private repo:PacchettoRepo) { }

  ListaPacchetti():Promise< Pacchetto[]>{
    return this.repo.GetAll();
  }

}
