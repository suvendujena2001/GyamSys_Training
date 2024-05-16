import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-admin',
  standalone: true,
  imports: [CommonModule,ReactiveFormsModule,HttpClientModule],
  templateUrl: './admin.component.html',
  styleUrl: './admin.component.css'
})
export class AdminComponent {
  logins:any;
  appointment:any;
  async ngOnInit(): Promise<void> {
    try {
      const response = await fetch('http://localhost:8081/users');
      const data = await response.json();
      this.logins = data;

      const appointments=await fetch('http://localhost:8081/appointments')
      const appointmentData = await appointments.json();
      this.appointment = appointmentData;
      //console.log(this.logins);
    } catch (error) {
      console.error('Error fetching data:', error);
    }
  }
  async verifyUser(user: any): Promise<void> {
    try {
      const response = await fetch('http://localhost:8081/verifyuser', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json'
        },
        body: JSON.stringify({
          userid: user.userid,
          username: user.username,
          email: user.email,
          password: user.password
        })
      });
      const result = await response.json();
      console.log('User verification result:', result);
      await this.ngOnInit();
    } catch (error) {
      console.error('Error verifying user:', error);
    }
  }

  async updateAcceptance(appointment: any): Promise<void> {
    try {
      const response = await fetch(`http://localhost:8081/updateacceptance`, {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json'
        },
        body: JSON.stringify({
          id: appointment.id,
          acceptance: true
        })
      });
      const result = await response.json();
      console.log('Appointment acceptance updated:', result);
      await this.ngOnInit();
    } catch (error) {
      console.error('Error updating appointment acceptance:', error);
    }
  }
  
  
  
  
}
