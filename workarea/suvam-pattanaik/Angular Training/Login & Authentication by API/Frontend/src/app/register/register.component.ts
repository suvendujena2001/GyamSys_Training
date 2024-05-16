import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormControl, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [ReactiveFormsModule,FormsModule,CommonModule],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {

  username = new FormControl('', [Validators.required]);
  email = new FormControl('', [Validators.required, Validators.email]);
  password = new FormControl('', [Validators.required]);

  constructor(private router: Router,private http:HttpClient) { }

  onRegister() {
    if (this.username.valid && this.email.valid && this.password.valid) {
      // Perform registration logic here (e.g., call API to register user)
      // For now, let's assume registration is successful
      // Display success message and provide a button to redirect to login page
    //   alert('Registered successfully!');
    //   this.router.navigate(['/login']);
    // } else {
    //   console.log('Form is invalid. Please fill out all required fields correctly.');
    // }

    const newUser ={
      username: this.username.value,
      email:this.email.value,
      password:this.password.value
    };

    this.http.post('http://localhost:8081/register',newUser).subscribe({
      next:(response) =>{
        console.log('Registration Successful:',response);
        alert('Registration Successful!');
        this.router.navigate(['/login']);
      },
      error:(error)=>{
        console.error('Registration Failed',error);
        alert('Registration failed.Please try again');
      }
    });
  }else{
    console.log('Form is invalid.please fill out all required fields');
  }
}
}
