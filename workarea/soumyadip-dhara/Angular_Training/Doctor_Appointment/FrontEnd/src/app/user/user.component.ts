import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { catchError } from 'rxjs';
import { Observable } from 'rxjs/internal/Observable';

@Component({
  selector: 'app-user',
  standalone: true,
  imports: [CommonModule,FormsModule,ReactiveFormsModule],
  templateUrl: './user.component.html',
  styleUrl: './user.component.css'
})
export class UserComponent {
  appointmentForm: FormGroup;

  constructor(private http: HttpClient) {
    this.appointmentForm = new FormGroup({
      name: new FormControl('', Validators.required),
      datetime: new FormControl('', Validators.required),
      // time: new FormControl('', Validators.required)
    });
  }

  addAppointment(appointmentData: any): Observable<any> {
    return this.http.post<any>('http://localhost:8081/addappointment', appointmentData)
      .pipe(
        catchError(error => {
          console.error('Error adding appointment:', error);
          throw error;
        })
      );
  }

  submitAppointment(): void {
    if (this.appointmentForm.valid) {
      this.addAppointment(this.appointmentForm.value).subscribe(
        response => {
          alert('Appointment added successfully:');
        },
        error => {
          console.error('Error adding appointment:', error);
        }
      );
    }
  }
}
