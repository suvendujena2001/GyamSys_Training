import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router, RouterLink } from '@angular/router';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [FormsModule, CommonModule, RouterLink, HttpClientModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  username: string = '';
  password: string = '';
  errorMessage: string = '';
  credentialsValid: boolean = false;
  constructor(private router: Router, private http: HttpClient) { }

  ngOnInit() {
    const jwtToken = sessionStorage.getItem('JwtToken');
    console.log(jwtToken);
    if (jwtToken == null) {
      this.router.navigate(['']);
    } else {
      if (this.username == "admin" && this.password == "admin") {
        this.router.navigate(['admin']);
      } else {
        this.router.navigate(['home']);
      }
    }
  }


  // ngOnInit() {
  //   var jwtToken = sessionStorage.getItem('JwtToken');
  //   console.log(jwtToken);
  //   const helper = new JwtHelperService;

  //   if (jwtToken != null) {
  //     const decoded = helper.decodeToken(jwtToken);
  //     console.log(decoded.UserName);
  //     if (decoded.UserName == "admin") {
  //       this.router.navigate(['admin']);
  //     }
  //     this.getBooks();
  //   } else {
  //     this.router.navigate(['']);
  //   }
  // }


  onSubmit() {
    this.http.post('http://localhost:5173/api/Users/Login', { UserName: this.username, Password: this.password }, { responseType: 'text' }).subscribe(
      (response: string) => {
        if (response.length > 0) {
          sessionStorage.setItem("JwtToken", response);
          if (this.username == "admin" && this.password == "admin") {
            this.router.navigate(['admin']);
          } else {
            this.router.navigate(['home']);
          }
        }
      },
      (error) => {
        // alert("username or password incorrect");
        this.username = '';
        this.password = '';
      }

    )




  }
}