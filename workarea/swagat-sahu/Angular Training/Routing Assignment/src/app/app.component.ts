import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { FormComponent } from './form/form.component';
import { ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { DetailsComponent } from './details/details.component';



@Component({
  selector: 'app-root',
  standalone: true,
  imports: [FormComponent, ReactiveFormsModule, CommonModule, RouterOutlet, DetailsComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'App1';
}
