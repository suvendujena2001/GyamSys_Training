import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router, RouterLink } from '@angular/router';

@Component({
  selector: 'app-registration',
  standalone: true,
  imports: [CommonModule,FormsModule,HttpClientModule,RouterLink],
  templateUrl: './registration.component.html',
  styleUrl: './registration.component.css'
})
export class RegistrationComponent {
  username: string = '';
  email: string = '';
  password: string = '';

  constructor(private http: HttpClient,private router:Router) { }
  registerUser() {
    // Check if any of the input fields are blank
    if (!this.username || !this.email || !this.password) {
        alert('Please fill in all the fields.');
        this.username='',this.email='',this.password='';
        return; // Exit the function early if any field is blank
    }

    const userData = {
        username: this.username,
        email: this.email,
        password: this.password
    };

    this.http.post<any>('http://localhost:8081/saveuser', userData)
        .subscribe({
            next: (response) => {
                console.log('User registration successful:', response);
                // You can handle success response here
                alert('User registered successfully!');
                this.username = '';
                this.email = '';
                this.password = '';
            },
            error: (error) => {
                console.error('Error registering user:', error);
                // You can handle error response here
                alert('Error registering user. Please try again.');
            }
        });
}

}
