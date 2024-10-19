import { Routes } from '@angular/router';
import { DestinazoneListaComponent } from './component/destinazone-lista/destinazone-lista.component';
import { PacchettoListaComponent } from './component/pacchetto-lista/pacchetto-lista.component';

export const routes: Routes = [

    {path:"",redirectTo:"destinazione/lista",pathMatch:"full"},

    {path :"destinazione/lista",component:DestinazoneListaComponent},
    {path :"pacchetto/lista",component:PacchettoListaComponent},


];
