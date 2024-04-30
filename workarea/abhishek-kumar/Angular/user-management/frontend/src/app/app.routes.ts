import { Component } from '@angular/core';
import { Routes } from '@angular/router';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';
import { HomeComponent } from './home/home.component';
import { ProfileComponent } from './profile/profile.component';
import { AuthGuard } from './auth.guard';
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
    path: '', // Default path should lead to login page
        redirectTo: '/login',
        pathMatch: 'full'
},
{
    path:'profile',
    component:ProfileComponent
},
{ path: 'profile', component: ProfileComponent },
{ path: 'home', component: HomeComponent, canActivate: [AuthGuard] }
];
