import { Component } from '@angular/core';
import { FormBuilder, ReactiveFormsModule, Validators } from '@angular/forms';
import { UserService } from '../user.service';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [ReactiveFormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  users:any[]=[];
  constructor(private formBuilder:FormBuilder,
    private userService:UserService,
    private toastr:ToastrService,
    private router:Router
  ){ }
  isFormSubmitted:boolean=false;
  loginForm = this.formBuilder.group({
  Email:['',[Validators.required,Validators.email]],
  Password:['']
  })

  
  onSubmit() {
    this.isFormSubmitted = true;
    if (this.loginForm.valid) {
      const email = this.loginForm.value.Email;

      const password = this.loginForm.value.Password;
      if (email) {
        const user = this.userService.getUserByEmail(email);
        if (user && user.Password === password) {
          this.toastr.success('Logged in successfully!', 'Success');
          this.router.navigate(['show-profile']);
        } else {
          this.toastr.error('Invalid email or password', 'Error');
        }
      } else {
        this.toastr.error('Email is required', 'Error');
      }
    }
  }
  
  

    onRegister(){
      this.router.navigate(['register'])
    }
}
