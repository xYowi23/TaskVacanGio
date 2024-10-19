import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { Pacchetto } from '../../models/pacchetto';
import { PacchettoServicesService } from '../../services/pacchetto-services.service';

@Component({
  selector: 'app-pacchetto-lista',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './pacchetto-lista.component.html',
  styleUrl: './pacchetto-lista.component.css'
})
export class PacchettoListaComponent {
  elencoPacchetti: Pacchetto[]=[];
  constructor(private service :PacchettoServicesService){

  }

  ngOnInit(){
    this.stampaTabella();
  }

  stampaTabella(){
    this.service.ListaPacchetti()
    .then(pacchtti=>{
      this.elencoPacchetti=pacchtti;
      
    })
    .catch(error=>{
      console.error('errore caricaento paccheto'),error;
    })

    //  this.elencoPacchetti= this.service.ListaPacchetti();
  }

}
