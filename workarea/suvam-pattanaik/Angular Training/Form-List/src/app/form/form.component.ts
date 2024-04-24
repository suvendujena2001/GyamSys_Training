import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormControl, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';

@Component({
  selector: 'app-form',
  standalone: true,
  imports: [FormsModule,CommonModule,ReactiveFormsModule],
  templateUrl: './form.component.html',
  styleUrl: './form.component.css'
})
export class FormComponent {

  name = new FormControl('',[Validators.required ,Validators.maxLength(30)]);
  email = new FormControl('',[Validators.required,Validators.email]);
  phone = new FormControl('',[Validators.required,Validators.pattern("[0-9]{10}")]);
  gender = new FormControl('',[Validators.required]);
  skills =new FormControl('',[Validators.required,Validators.maxLength(50)]);

  onSubmit() {
    if (this.name.valid && this.email.valid && this.phone.valid && this.gender.valid && this.skills.valid) {
      console.log('Name:', this.name.value);
      console.log('Email:', this.email.value);
      console.log('Phone:', this.phone.value);
      console.log('Gender:', this.gender.value);
      console.log('Skills:', this.skills.value);
    } else {
      console.log('Form is invalid. Please fill out all required fields correctly.');
    }
  }



}
