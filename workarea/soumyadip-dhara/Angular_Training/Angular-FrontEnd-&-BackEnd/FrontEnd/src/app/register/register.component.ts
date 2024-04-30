import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { NavigationExtras, Router } from '@angular/router';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [CommonModule,FormsModule,ReactiveFormsModule,HttpClientModule],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {
  Register: FormGroup;

  constructor(private fb: FormBuilder,private router:Router,private http:HttpClient) {
    this.Register = this.fb.group({
      username: ['', [Validators.required, Validators.maxLength(30)]],
      email: ['', [Validators.required, Validators.email]],
      password:['',[Validators.required,]]
    });
  }

  onSubmit() {
    if (this.Register.valid) {
      const userData = this.Register.value;
      this.http.post<any>('http://localhost:8081/saveuser', userData).subscribe(
        (response) => {
          console.log('User data saved successfully:', response);
          const navigationExtras: NavigationExtras = {
            state: {
              data: userData
            }
          };
          this.router.navigate(['login'], navigationExtras);
        },
        (error) => {
          console.error('Error saving user data:', error);
        }
      );
    }
  }

}
