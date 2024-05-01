import { Routes } from "@angular/router";
import { SignInComponent } from "./sign-in/sign-in.component";
import { AdmindashboardComponent } from "./admindashboard/admindashboard.component";
import { SignUpComponent } from "./sign-up/sign-up.component";
import { UserdashboardComponent } from "./userdashboard/userdashboard.component";

export const routes: Routes = [
  {
    path: "",
    component: SignUpComponent,
  },
  { path: "sign", component: SignInComponent },
  { path: "admin", component: AdmindashboardComponent },
  {
    path: "user",
    component: UserdashboardComponent,
  },
];
