import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormGroup, FormControl, Validators, ReactiveFormsModule,} from '@angular/forms'
@Component({
  selector: 'app-form',
  standalone: true,
  imports: [ReactiveFormsModule,CommonModule,],
  templateUrl: './form.component.html',
  styleUrl: './form.component.css'
})


export class FormComponent {
  title = 'Angular Reactive forms';
  Options = ['Male', 'Female', 'Other'];
  Optionsforskills = [
    'HTML',
    'CSS',
    'JavaScript',
    'Angular',
    'React',
    '.NET',
    'ASP.NET Web API',
    'Java',
  ];

  contactForm = new FormGroup({
    name: new FormControl('', [Validators.required,Validators.minLength(3),Validators.maxLength(20),]),
    email: new FormControl('', [Validators.required, Validators.email]),
    phoneNum: new FormControl('', [Validators.required,Validators.pattern('[- +()0-9]+')]),
    gender: new FormControl('', Validators.required),
    skills: new FormControl('')});
  handleSubmit(){
    console.log(this.contactForm);
  }
} 
 
