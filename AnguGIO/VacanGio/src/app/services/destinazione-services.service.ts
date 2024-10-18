import { Injectable } from '@angular/core';
import { Destinazione } from '../models/destinazione';
import { DestinazioneRepo } from '../repositories/destinazione.repo';

@Injectable({
  providedIn: 'root'
})
export class DestinazioneServicesService {

  constructor(private repo:DestinazioneRepo) { }
  
  ListaDestinazioni(): Promise<Destinazione[]>{
    return this.repo.GetAll();
  }
}
