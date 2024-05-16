import { Component, OnInit, ChangeDetectorRef } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { Router } from '@angular/router';

interface User {
  userid: number;
  username: string;
  email: string;
  verify: number;
  password: string;
}

@Component({
  selector: 'app-admin',
  standalone: true,
  imports: [CommonModule, HttpClientModule],
  templateUrl: './admin.component.html',
  styleUrl: './admin.component.css'
})
export class AdminComponent implements OnInit{
  users: User[] = [];
  

  constructor(private router:Router,private http: HttpClient, private cdr: ChangeDetectorRef) { }

  ngOnInit() {
    this.fetchUsers();
  }

  fetchUsers() {
    this.http.get<User[]>('http://localhost:8081/users').subscribe({
      next: (response) => {
        this.users = response;
        this.cdr.detectChanges();
      },
      error: (error) => {
        console.error('Error fetching users:', error);
      }
    });
  }

  verifyUser(user: User) {
    const updatedUser = { ...user, verify: 1 };
    this.http.post<any>('http://localhost:8081/verifyuser', updatedUser).subscribe({
      next: (response) => {
        window.location.reload();
        if (response.success) {
          this.router.navigate(['/admin']);
          const index = this.users.findIndex(u => u.userid === user.userid);
          if (index !== -1) {
            this.users[index].verify = 1;
            
            
          }
           // else {
        //   console.error('Verification failed:', response.message);
        // }
        } 
      },
      error: (error) => {
        console.error('An error occurred:', error);
      }
    });
  }
  
  onClick(){
    this.router.navigate(['/']);
  }
}
