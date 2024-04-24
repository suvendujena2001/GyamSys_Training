import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormControl, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';

@Component({
  selector: 'app-forms',
  standalone: true,
  imports: [FormsModule,CommonModule,ReactiveFormsModule],
  templateUrl: './forms.component.html',
  styleUrl: './forms.component.css'
})
export class FormsComponent {
  email = new FormControl('', [Validators.required, Validators.email]);
  name = new FormControl('', [Validators.required, Validators.maxLength(30)]);
  phone = new FormControl('', [Validators.required,Validators.pattern('[0-9]{10}')]);
  gender=new FormControl('');
  skills=new FormControl('');
  submitted:boolean=false;
 
  // emailDetail(){
  //   console.log(this.email);
  // }
  // nameDetail(){
  //   console.log(this.name);
  // }
  // phoneDetail(){
  //   console.log(this.phone);
  // }
  submitForm(){
    this.submitted=true;
  }

}
