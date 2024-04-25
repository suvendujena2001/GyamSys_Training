import { CommonModule } from '@angular/common';
import { Component,EventEmitter,Output } from '@angular/core';
import { FormControl, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router } from '@angular/router';
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
  constructor(private router: Router) {}

  @Output() formDataSubmitted: EventEmitter<any> = new EventEmitter<any>();
  submitForm(){
  this.submitted = true;
    const formData = {
      email: this.email.value,
      name: this.name.value,
      phone: this.phone.value,
      gender: this.gender.value,
      skills: this.skills.value
    };
    this.formDataSubmitted.emit(formData);
    this.router.navigate(['/details'], { queryParams: formData });
}
}
