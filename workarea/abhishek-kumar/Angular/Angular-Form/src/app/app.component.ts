import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormComponent } from './form/form.component';
@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,FormComponent , CommonModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Angular-Form';
  
}