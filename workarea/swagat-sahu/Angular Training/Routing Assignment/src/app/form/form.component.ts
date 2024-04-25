import { CommonModule } from '@angular/common';
import { Output,Component,EventEmitter } from '@angular/core';
import {FormControl, FormsModule, ReactiveFormsModule, Validators} from '@angular/forms';
import { Router } from '@angular/router';



@Component({
  selector: 'app-form',
  standalone: true,
  imports: [FormsModule, CommonModule, ReactiveFormsModule],
  templateUrl: './form.component.html',
  styleUrl: './form.component.css'
})
export class FormComponent {
  @Output() formDataSubmitted = new EventEmitter<any>();
  formData: any = {};
  email = new FormControl('', [Validators.required, Validators.email]);
  name = new FormControl('', [Validators.required, Validators.maxLength(30)]);
  phone = new FormControl('', [Validators.required, Validators.pattern("[0-9]{10}")]);
  gender = new FormControl();
  skills = new FormControl();


  constructor(private router: Router) {}

  onSubmit() {
    if (this.name.valid && this.email.valid && this.phone.valid) {
      const formData = {
        name: this.name.value,
        email: this.email.value,
        phone: this.phone.value,
        gender: this.gender.value,
        skills: this.skills.value
      };

      this.router.navigate(['/details'],{state:{data:formData}});
    } else {
      console.log('Form is invalid.');
    }
  }
}