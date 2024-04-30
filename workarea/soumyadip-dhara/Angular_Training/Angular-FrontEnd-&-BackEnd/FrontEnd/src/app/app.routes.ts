import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { UserComponent } from './user/user.component';
import { AdminComponent } from './admin/admin.component';

export const routes: Routes = [
    {path:'',component:HomeComponent},
    {path:'login',component:LoginComponent},
    {path:'home',component:HomeComponent},
    {path:'register',component:RegisterComponent},
    {path:'user',component:UserComponent},
    {path:'admin',component:AdminComponent}
];
