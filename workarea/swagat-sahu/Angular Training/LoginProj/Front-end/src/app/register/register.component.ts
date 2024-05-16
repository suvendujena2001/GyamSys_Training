import { Component } from '@angular/core';
import { FormControl, Validators, FormsModule,ReactiveFormsModule} from '@angular/forms';
import { Router } from '@angular/router';
import { HttpClient, HttpClientModule } from '@angular/common/http';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [FormsModule,ReactiveFormsModule, HttpClientModule],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent 
{
  username = new FormControl('', [Validators.required]);
  email = new FormControl('', [Validators.required, Validators.email]);
  password = new FormControl('', [Validators.required]);

  constructor(private router: Router, private http: HttpClient) {}

  onSubmit() {
    if (this.username.valid && this.email.valid && this.password.valid) {
      const formData = {
        username: this.username.value,
        email: this.email.value,
        password: this.password.value
      };

      
      this.http.post<any>('http://localhost:8081/saveuser', formData).subscribe({
        next: (response) => {
          if (response && response.affectedRows > 0) {
            alert('Registraion done');
            // this.router.navigate(['/register']);
            this.username.reset();
            this.email.reset();
            this.password.reset();
            
          } else {
            console.log('Registration failed');
          }
        },
        error: (error) => {
          console.error('An error occurred:', error);
        }
      });
    } else {
      console.log('Invalid Entry, Please check your inputs');
    }
  }
}

