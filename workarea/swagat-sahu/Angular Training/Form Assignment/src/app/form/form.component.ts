import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import {FormControl, FormsModule, ReactiveFormsModule, Validators} from '@angular/forms';

@Component({
  selector: 'app-form',
  standalone: true,
  imports: [FormsModule, CommonModule, ReactiveFormsModule],
  templateUrl: './form.component.html',
  styleUrl: './form.component.css'
})
export class FormComponent {

  email = new FormControl('', [Validators.required, Validators.email]);
  name = new FormControl('', [Validators.required, Validators.maxLength(30)]);
  phone = new FormControl('', [Validators.required,Validators.pattern("[0-9]{10}")] );
  gender= new FormControl();
  skills= new FormControl();


  onSubmit() {
    if (this.name.valid && this.email.valid && this.phone.valid) {
      console.log('Name:', this.name.value);
      console.log('Email:', this.email.value);
      console.log('Phone:', this.phone.value);
      console.log('gender:', this.gender.valid);
      console.log('skills:', this.skills.valid);
      
    } else {
      console.log('Form is invalid. Please fill out all required fields correctly.');
    }
  }
}
