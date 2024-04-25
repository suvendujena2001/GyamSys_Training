import { Routes } from '@angular/router';
import { FormComponent } from './form/form.component';
import { UserComponent } from './user/user.component';

export const routes: Routes = [
  {
    path: '',
    component: FormComponent,
  },
  {
    path: 'user',
    component: UserComponent,
  },
];
