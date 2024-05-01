import { CommonModule } from "@angular/common";
import { Component } from "@angular/core";
import { Route, Router } from "@angular/router";

@Component({
  selector: "app-userdashboard",
  standalone: true,
  imports: [CommonModule],
  templateUrl: "./userdashboard.component.html",
  styleUrl: "./userdashboard.component.css",
})
export class UserdashboardComponent {
  constructor(private router: Router) {}
  logout() {
    this.router.navigate(["sign"]);
  }
}
