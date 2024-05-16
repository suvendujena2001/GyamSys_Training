import { Component } from '@angular/core';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Router, RouterLink } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-login',
  standalone:true,
  imports:[CommonModule,FormsModule,HttpClientModule,RouterLink],
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  username: string = '';
  password: string = '';
  loading: boolean = false;
  error: string = '';

  constructor(private http: HttpClient, private router: Router) { }
  login() {
    this.loading = true;
    this.http.post<any>('http://localhost:8081/login', { username: this.username, password: this.password })
      .subscribe({
        next:(response) => {
          // Check if response processing is already done to prevent double alert
          if (!this.loading) return;
  
          // Successful login
          this.loading = false;
          console.log(response);
          if (response.length > 0) {
            const user = response[0]; // Assuming the response contains user information
  
            // Check user role to determine access
            if (user.password === 'password') {
              // User authenticated as admin
              this.router.navigate(['/adminview']); // Navigate to admin view
            } else if (user.password === 'user') {
              // User authenticated as regular user
              this.router.navigate(['/userview'],{ queryParams: { userName: this.username } }); // Navigate to user view
            } else {
              // Invalid role
              alert('Invalid role. Please contact support.');
              this.username='';
              this.password='';
            }
          } else {
            // Invalid credentials
            alert('Invalid username or password. Please try again.');
            this.username='';
            this.password='';
          }
        },
        error:(error) => {
          // Error handling
          this.loading = false;
          this.error = 'An error occurred. Please try again later.';
        }
      });
  }
  
  
}