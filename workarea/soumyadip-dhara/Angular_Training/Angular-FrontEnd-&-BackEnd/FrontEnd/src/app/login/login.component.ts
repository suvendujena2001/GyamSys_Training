import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [CommonModule,ReactiveFormsModule,HttpClientModule,FormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  username: string = "";
  password: string = "";
 
  constructor(private http: HttpClient, private router: Router) {}
 
  SignIn() {
    this.http
      .post("http://localhost:8081/login", {
        username: this.username,
        password: this.password,
      })
      .subscribe((data) => {
        console.log("Login successful:", data);
        if (this.username === "admin" && this.password === "Admin@1") {
          this.router.navigate(["admin"]);
        } else {
          this.router.navigate(["user"]);
        }
      });
  }

}
