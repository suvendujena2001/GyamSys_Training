import { Routes } from '@angular/router';
import path from 'node:path';
import { FormValidationComponent } from './form-validation/form-validation.component';
import { UserDetailsComponent } from './user-details/user-details.component';

export const routes: Routes = [
    { path: '', component: FormValidationComponent },
    { path: 'userDetails', component: UserDetailsComponent }
];
