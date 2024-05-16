import { Routes } from '@angular/router';
import { LoginComponent } from './Components/login/login.component';
import { RegisterComponent } from './Components/register/register.component';
import { HomeComponent } from './Components/home/home.component';
import { AdminComponent } from './Components/admin/admin.component';
import { MyCommentsComponent } from './Components/my-comments/my-comments.component';
import { UserCommentsComponent } from './Components/user-comments/user-comments.component';

export const routes: Routes = [{ path: '', component: LoginComponent },

{
    path: 'register', component: RegisterComponent
},
{
    path: 'home', component: HomeComponent
},
{
    path: 'admin', component: AdminComponent
},
{
    path: 'comments/:id', component: MyCommentsComponent

},
{
    path: 'userComments', component: UserCommentsComponent
}
];
