import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router, RouterLink } from '@angular/router';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [FormsModule, CommonModule, HttpClientModule, RouterLink],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {
  username: string = '';
  email: string = '';
  password: string = '';

  constructor(private route: Router, private http: HttpClient) { }
  ngOnInit(): void {
    const userDetailsString = sessionStorage.getItem('JwtToken');
    console.log(userDetailsString);
    if (userDetailsString == null) {
      this.route.navigate(['register']);
    } else {
      this.route.navigate(['home']);
    }
  }
  onSubmit() {
    //   alert('User created');

    // this.route.navigate(['/']);
    if (!this.username || !this.email || !this.password) {
      alert('Please fill in all the fields.');
      this.username = '', this.email = '', this.password = '';
      return; // Exit the function early if any field is blank
    }

    this.http.post<any>('http://localhost:5173/api/Users', { UserName: this.username, UserEmail: this.email, Password: this.password })
      .subscribe({
        next: (response) => {
          console.log('User registration successful:', response);
          // You can handle success response here
          alert('User registered successfully!');
          this.username = '';
          this.email = '';
          this.password = '';
          this.route.navigate(['/']);
        },
        error: (error) => {
          console.error('Error registering user:', error);
          // You can handle error response here
          alert('Error registering user. Please try again.');
        }
      });
  }
}
