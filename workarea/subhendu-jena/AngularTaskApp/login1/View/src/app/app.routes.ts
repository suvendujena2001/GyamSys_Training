import { Routes } from '@angular/router';
import { UserviewComponent } from './userview/userview.component';
import { Component } from '@angular/core';
import { LoginComponent } from './login/login.component';
import { AdminviewComponent } from './adminview/adminview.component';
import { RegistrationComponent } from './registration/registration.component';


export const routes: Routes = [{path:'',component:LoginComponent},
{path:'userview',component:UserviewComponent},
{path:'adminview',component:AdminviewComponent},
{path:'registration',component:RegistrationComponent},
{path:'login',component:LoginComponent}
];
