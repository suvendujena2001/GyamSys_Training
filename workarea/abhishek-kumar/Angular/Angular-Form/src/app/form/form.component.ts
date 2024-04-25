import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import {
  ReactiveFormsModule,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';
import {Router} from '@angular/router';

@Component({
  selector: 'app-form',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './form.component.html',
  styleUrl: './form.component.css',
})
export class FormComponent {
  userData: any;
  constructor(private router: Router) {}

  genderOptions = ['Male', 'Female'];
  skillsOptions = ['Angular', 'Html', 'CSS', 'JavaScript', 'C#', 'React'];

  form = new FormGroup({
    name: new FormControl('', [Validators.required, Validators.maxLength(20)]),
    email: new FormControl('', [
      Validators.required,
      Validators.pattern('[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,}'),
    ]),
    phone: new FormControl('', [
      Validators.required,
      Validators.pattern(/^\d{10}$/),
    ]),
    gender: new FormControl(''),
    skills: new FormControl(''),
  });

  handleSubmit() {
    this.form.markAllAsTouched();
    if(this.form.valid){
    this.userData = this.form.value;
    
    
    this.router.navigate(['user', { user: JSON.stringify(this.userData) }]);
    }   
  }
}
