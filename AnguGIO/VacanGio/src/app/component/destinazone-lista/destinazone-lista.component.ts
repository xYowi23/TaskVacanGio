import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { Destinazione } from '../../models/destinazione';
import { DestinazioneServicesService } from '../../services/destinazione-services.service';

@Component({
  selector: 'app-destinazone-lista',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './destinazone-lista.component.html',
  styleUrl: './destinazone-lista.component.css'
})
export class DestinazoneListaComponent {
  elencoDestinazioni: Destinazione[]=[];
  constructor(private service: DestinazioneServicesService){

  }
  ngOnInit() {
    this.stampaTabella();
  }
  stampaTabella() {
    this.service.ListaDestinazioni()
      .then(destinazioni => {
        this.elencoDestinazioni = destinazioni;
      })
      .catch(error => {
        console.error('Errore caricamento destinazioni:', error);
      });
  }
  
}
