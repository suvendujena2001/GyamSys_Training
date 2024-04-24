import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators,ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-myform',
  standalone:true,
  imports:[ReactiveFormsModule,CommonModule],
  templateUrl: './myform.component.html',
  styleUrls: ['./myform.component.css']
})
export class MyformComponent {
  myForm: FormGroup;
  users: any[] = [];

  constructor(private fb: FormBuilder) {
    this.myForm = this.fb.group({
      name: ['', [Validators.required, Validators.maxLength(30)]],
      email: ['', [Validators.required, Validators.email]],
      phone: ['', [Validators.required, Validators.pattern(/^\d{10}$/)]],
      gender: ['', Validators.required],
      skills: ['']
    });
  }

  onSubmit(): void {
    if (this.myForm.valid) {
      const userData = this.myForm.value;
      
      // Store user data in local storage
      const storedUsers = localStorage.getItem('users');
      if (storedUsers) {
        this.users = JSON.parse(storedUsers);
      }
      this.users.push(userData);
      localStorage.setItem('users', JSON.stringify(this.users));
      // Reset form
      this.myForm.reset();
    }
  }

  showUsers(): void {
    const storedUsers = localStorage.getItem('users');
    if (storedUsers) {
      this.users = JSON.parse(storedUsers);
    }
  }

  deleteuser(index: number): void {
    if (confirm('Are you sure you want to delete this user?')) {
      this.users.splice(index, 1);
      localStorage.setItem('users', JSON.stringify(this.users));
    }
  }
}
