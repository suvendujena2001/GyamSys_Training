import { Component } from '@angular/core';
import { FormBuilder, ReactiveFormsModule, Validators } from '@angular/forms';
import { UserService } from '../user.service';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';


@Component({
  selector: 'app-register',
  standalone: true,
  imports: [ReactiveFormsModule,],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {
  constructor(private formBuilder:FormBuilder,
    private userService:UserService,
    private toastr:ToastrService,
    private router:Router
){ }
isFormSubmitted:boolean=false;
profileForm = this.formBuilder.group({
Name: ['',[Validators.required, Validators.maxLength(30)]],
Email:['',[Validators.required,Validators.email]],
Password:['']
})

onSubmit() {
  this.isFormSubmitted = true;
  console.log(this.profileForm);
    if (this.profileForm.valid) {
      this.userService.addUser(this.profileForm);
      this.toastr.success('Hello, this is a success message!', 'Success');
      this.router.navigate(['login']);
    }
  }
  onLogin(){
    this.router.navigate(['login']);
  }



}
