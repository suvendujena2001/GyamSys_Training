import { Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { AdminComponent } from './admin/admin.component';
export const routes: Routes = [
    { path: '', component:LoginComponent },
    { path: 'home', component:HomeComponent },
    {path: 'register', component:RegisterComponent},
    {path: 'admin', component:AdminComponent}
];
