import { Routes } from '@angular/router';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';
import { ShowProfileComponent } from './show-profile/show-profile.component';

export const routes: Routes = [
    {
        path:'register',
        component:RegisterComponent,
      },
        {
          path:'login',
          component:LoginComponent
        },
        {
          path:'show-profile',
          component:ShowProfileComponent
        }
      ,
      {
        path: "",
        redirectTo: '/register',
        pathMatch: 'full'
      }
];
