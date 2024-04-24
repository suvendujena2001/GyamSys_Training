import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';

@Component({
  selector: 'app-forms',
  standalone: true,
  imports: [ReactiveFormsModule,CommonModule],
  templateUrl: './forms.component.html',
  styleUrl: './forms.component.css'
})
export class FormsComponent {
  userForm:FormGroup;
  isvalidSubmit:boolean=false;
  constructor(){
    this.userForm=new FormGroup({
      Name:new FormControl("",[Validators.required,Validators.maxLength(30)]),
      Email :new FormControl("",[Validators.email,Validators.required,Validators.pattern('[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}')]),
      Phone :new FormControl("",[Validators.required,Validators.pattern(/^\d{10}$/)]),
      Gender:new FormControl("",[Validators.required]),
      Skills:new FormControl("",[Validators.required])
    })
  }
  // onSubmit(){
  //   const isValid=this.userForm.valid;
  //   debugger;
  //   this.isvalidSubmit=true;
  // }
  onSubmit() {
  if (this.userForm.valid) {
    console.log(this.userForm.value,"Form is Valid"); 
  } else {
    console.log("Form is invalid");
  }
  }
}

