import { CommonModule } from '@angular/common';
import { Component, Output } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { RouterLink, Router } from '@angular/router';

@Component({
  imports: [ReactiveFormsModule, CommonModule, RouterLink],
  standalone: true,
  selector: 'app-form-validation',
  templateUrl: './form-validation.component.html',
  styleUrls: ['./form-validation.component.css']
})
export class FormValidationComponent {
  user: FormGroup;

  userData: any
  constructor(private fb: FormBuilder, private router: Router) {
    this.user = this.fb.group({
      name: new FormControl('', [
        Validators.required,
        Validators.maxLength(30)
      ]),
      email: new FormControl('', [
        Validators.required,
        Validators.pattern('^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}$')
      ]),
      number: new FormControl('', [
        Validators.required,
        Validators.pattern("^((\\+91-?)|0)?[0-9]{10}$")
      ]),
      gender: new FormControl('', [
        Validators.required
      ]),
      skills: new FormControl('')
    })
  }

  onSee() {
    if (this.user.valid) {
      this.userData = this.user.value;
      this.router.navigate(['/userDetails', { user: JSON.stringify(this.userData) }]);
    }
  }

}
