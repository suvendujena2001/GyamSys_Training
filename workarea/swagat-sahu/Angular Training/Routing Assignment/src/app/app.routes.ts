
import { RouterModule, Routes } from '@angular/router';
import { FormComponent } from './form/form.component';
import { DetailsComponent } from './details/details.component';

export const routes: Routes = [
    { path: '', component: FormComponent },
    { path: 'details', component: DetailsComponent }
  ];
  
  

