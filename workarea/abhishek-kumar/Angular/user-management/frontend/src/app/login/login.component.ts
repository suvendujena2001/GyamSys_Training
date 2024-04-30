import { HttpClient, HttpClientModule } from "@angular/common/http";
import { Component, inject } from "@angular/core";
import { Router } from "@angular/router";
import { FormsModule } from "@angular/forms";
import { AuthService } from "../auth.service";

@Component({
  selector: "app-login",
  standalone: true,
  imports: [HttpClientModule, FormsModule],
  templateUrl: "./login.component.html",
  styleUrl: "./login.component.css",
})
export class LoginComponent {
  username: string = "";
  password: string = "";

  authService : AuthService =inject(AuthService);

  constructor(private http: HttpClient, private router: Router) {}
  onSubmit() {
    this.http
      .post<any>("http://localhost:8081/login", {
        username: this.username,
        password: this.password,
      })
      .subscribe((data) => {
        console.log(data);
        if (data.length != 0) {
          if(data[0].username === "admin" && data[0].password === 'admin'){
            this.authService.loggedIn=true;
            this.authService.loggedOut=false;
          this.router.navigate(["/home"]);
        }
        else this.router.navigate(['/profile']);
        } else {
        console.log('invalid input');
        }
      });
  }
  goToRegister(){
    this.router.navigate(['/register']);
  }
}
