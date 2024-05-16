import { Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { HomeComponent } from './home/home.component';
import { PageComponent } from './page/page.component';



export const routes: Routes = [
    // {path:'',component:LoginComponent},
    // { path: 'login', component: LoginComponent },
    // {path:'home',component:HomeComponent}


    { path: 'login', component: LoginComponent },
    { path: 'register', component: RegisterComponent },
    {path:'home',component:HomeComponent},
    { path: '', redirectTo: '/login', pathMatch: 'full' },
    {path:'page',component:PageComponent},
    { path: '**', redirectTo: '/login', pathMatch: 'full' }

];
