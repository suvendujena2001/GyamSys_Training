import { CommonModule, NgFor } from "@angular/common";
import { HttpClient } from "@angular/common/http";
import { Component } from "@angular/core";
import { FormBuilder, FormsModule } from "@angular/forms";
import { Router } from "@angular/router";

@Component({
  selector: "app-sign-in",
  standalone: true,
  imports: [CommonModule, FormsModule, NgFor],

  templateUrl: "./sign-in.component.html",
  styleUrl: "./sign-in.component.css",
})
export class SignInComponent {
  username: string = "";
  password: string = "";

  constructor(
    private formBuilder: FormBuilder,
    private http: HttpClient,
    private router: Router
  ) {}

  SignIn() {
    this.http
      .post("http://localhost:8081/login", {
        username: this.username,
        password: this.password,
      })
      .subscribe((data: any) => {
        if (data != null) {
          console.log("Login successful:", data);
          if (this.username === "Admin" && this.password === "Admin") {
            alert("Sign In Successful");
            this.router.navigate(["admin"]);
          } else {
            alert("Sign In Successful");
            this.router.navigate(["user"]);
          }
        }
      });
  }
  SignUp() {
    this.router.navigate([""]);
  }
}
