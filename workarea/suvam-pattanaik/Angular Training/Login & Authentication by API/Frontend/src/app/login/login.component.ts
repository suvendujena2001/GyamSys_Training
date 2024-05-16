import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormControl, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { HomeComponent } from '../home/home.component';
import { HttpClient } from '@angular/common/http';
import { HttpClientModule } from '@angular/common/http';


@Component({
  selector: 'app-login',
  standalone: true,
  imports: [FormsModule,CommonModule,ReactiveFormsModule,HomeComponent,HttpClientModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {

  username = new FormControl('',[Validators.required]);
  password = new FormControl('',[Validators.required]);

  constructor( private http: HttpClient ,private router:Router){}

  onLogin() {
    if (this.username.valid && this.password.valid) {
      const formData = {
        username: this.username.value,
        password: this.password.value
      };
      this.http.post<any>('http://localhost:8081/login', formData).subscribe({
        next: (response) => {
          
          // if (response.success) {
           if(response.user.username =='admin' && response.user.password =='admin'){
            
            this.router.navigate(['/home'], { state: { data: response.user } });}
           else {
            this.router.navigate(['/page'],{state : {username:response.user.username}});
          }
        },
        error: (error) => {
          console.error('An error occurred:', error);
        }
      });
    } else {
      console.log('Invalid Entry, Kindly Check the username and password');
    }
    
    
  }
  navigateToRegister(){
    this.router.navigate(['/register']);
  }
}
