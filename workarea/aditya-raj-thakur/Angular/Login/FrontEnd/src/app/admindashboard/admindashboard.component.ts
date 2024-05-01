import { CommonModule } from "@angular/common";
import { HttpClient } from "@angular/common/http";
import { Component } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { Route, Router } from "@angular/router";

@Component({
  selector: "app-admindashboard",
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: "./admindashboard.component.html",
  styleUrl: "./admindashboard.component.css",
})
export class AdmindashboardComponent {
  users: any[] = [];
  constructor(private http: HttpClient, private router: Router) {}

  ngOnInit(): void {
    this.getUsers();
  }
  getUsers() {
    this.http.get<any[]>("http://localhost:8081/users").subscribe(
      (response) => {
        this.users = response;
      },
      (error) => {
        console.error("Error fetching users:", error);
      }
    );
  }
  logout() {
    this.router.navigate(["sign"]);
  }
  verifyUser(
    userId: number,
    userEmail: string,
    userName: string,
    password: string
  ) {
    this.http
      .post<any>("http://localhost:8081/verifyuser", {
        userid: userId,
        email: userEmail,
        username: userName,
        password: password,
      })
      .subscribe(
        (response) => {
          console.log("Verification successful:", response);
          this.getUsers();
        },
        (error) => {
          console.error("Verification failed:", error);
        }
      );
  }
}
