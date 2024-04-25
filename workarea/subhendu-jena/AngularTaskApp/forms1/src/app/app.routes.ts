import { Routes } from '@angular/router';
import { FormsComponent } from './forms/forms.component';
import { DetailsComponent } from './forms/details/details.component';

export const routes: Routes = [
    {path: '', component:FormsComponent },
    {path: 'details', component: DetailsComponent }
];
