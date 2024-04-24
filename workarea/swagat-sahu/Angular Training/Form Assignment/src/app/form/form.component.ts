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
  phone = new FormControl('', [Validators.required, Validators.pattern("[0-9]{10}")]);

  emailDetail(){
    console.log(this.email);
  }
  nameDetail(){
    console.log(this.name);
  }
  phoneDetail(){
    console.log(this.phone);
  }
}
