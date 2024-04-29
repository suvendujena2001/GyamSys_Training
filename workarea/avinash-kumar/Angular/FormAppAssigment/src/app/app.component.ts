import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { FormValidationComponent } from './form-validation/form-validation.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, FormValidationComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {

}
