import { Component } from '@angular/core';
import {FormControl, Validators, FormsModule,ReactiveFormsModule} from '@angular/forms';
import { Router } from '@angular/router';
import { HomeComponent } from '../home/home.component';
import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { HttpClientModule } from '@angular/common/http';
@Component({
  selector: 'app-login',
  standalone: true,
  imports: [HomeComponent,FormsModule,CommonModule,ReactiveFormsModule, HttpClientModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent 
{
  username = new FormControl('', [Validators.required]);
  password = new FormControl('', [Validators.required]);
  constructor(private router: Router, private http: HttpClient) {}
  

  onSubmit() {
    if (this.username.valid && this.password.valid) {
      const formData = {
        username: this.username.value,
        password: this.password.value
      };
  
      
      if (formData.username!.toLowerCase() === 'admin' && formData.password === 'admin') {
        this.router.navigate(['/admin']); 
      } else {
        this.http.post<any>('http://localhost:8081/login', formData).subscribe({
          next: (response) => {
            if (response.success) {
              this.router.navigate(['/home'], { state: { data: response.user } }); 
            } else {
              console.log('Invalid username or password');
            }
          },
          error: (error) => {
            console.error('An error occurred:', error);
          }
        });
      }
    } else {
      console.log('Invalid Entry, Kindly Check the username and password');
    }
  }
  
  onClick(){
    this.router.navigate(['/register']);
  }
}
