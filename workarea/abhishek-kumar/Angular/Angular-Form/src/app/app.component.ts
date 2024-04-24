import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, ReactiveFormsModule, CommonModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Angular-Form';
  constructor(){}

  genderOptions=['Male', 'Female'];
  skillsOptions=['Angular','Html' , 'CSS' , 'JavaScript' ,'C#' ,'React' ];

  form = new FormGroup({
    name: new FormControl('', [Validators.required, Validators.maxLength(20)]),
    email: new FormControl('', [Validators.required ,Validators.pattern('[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}')]),
    phone: new FormControl('', [Validators.required, Validators.pattern(/^\d{10}$/)]),
    gender: new FormGroup(''),
    skills: new FormGroup(''), 
  })
}