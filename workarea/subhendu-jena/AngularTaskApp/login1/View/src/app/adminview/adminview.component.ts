import { Component, OnInit } from '@angular/core';
import { AppComponent } from '../app.component';
import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
interface User {
  userid: number;
  username: string;
  email: string;
  verify: number;
  password: string;
}
@Component({
  selector: 'app-adminview',
  standalone: true,
  imports: [CommonModule,HttpClientModule],
  templateUrl: './adminview.component.html',
  styleUrl: './adminview.component.css'
})
export class AdminviewComponent implements OnInit {
  userData: any[] = [];
  router: any;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.fetchUserData();
  }

  fetchUserData(): void {
    this.http.get<any[]>('http://localhost:8081/users')
      .subscribe({
        next: (data) => {
          this.userData = data;
        },
        error: (error) => {
          console.error('Error fetching user data:', error);
        }
      });
  }

  verifyUser(user: User) {
    const updatedUser = { ...user, verify: 1 };
    this.http.post<any>('http://localhost:8081/verifyuser', updatedUser).subscribe({
      next: (response) => {
        window.location.reload();
        if (response.success) {
          user.verify = 1;
        }
      },
      error: (error) => {
        console.error('An error occurred:', error);
      }
    });
  }
}