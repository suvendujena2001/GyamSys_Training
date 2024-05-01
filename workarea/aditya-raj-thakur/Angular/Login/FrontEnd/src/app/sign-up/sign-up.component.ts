import { CommonModule } from "@angular/common";
import { HttpClient } from "@angular/common/http";
import { Component } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { Router } from "@angular/router";

@Component({
  selector: "app-sign-up",
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: "./sign-up.component.html",
  styleUrl: "./sign-up.component.css",
})
export class SignUpComponent {
  username: string = "";
  password: string = "";
  email: string = " ";

  constructor(private http: HttpClient, private router: Router) {}

  SignUp() {
    this.http
      .post("http://localhost:8081/saveuser", {
        username: this.username,
        password: this.password,
        email: this.email,
      })
      .subscribe((data: any) => {
        console.log("SignUp successful:", data);
        this.router.navigate(["sign"]);
      });
  }
  signIn() {
    this.router.navigate(["sign"]);
  }
}
