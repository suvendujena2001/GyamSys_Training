import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router, RouterModule } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';

interface User {
  userId: number;
  userName: string;
  userEmail: string;
}

@Component({
  selector: 'app-admin',
  standalone: true,
  imports: [FormsModule,CommonModule,HttpClientModule,RouterModule],
  templateUrl: './admin.component.html',
  styleUrl: './admin.component.css'
})
export class AdminComponent {

  users: User[] = [];

  constructor(private http:HttpClient, private router:Router){}

  ngOnInit(): void {
    var jwtToken = sessionStorage.getItem('JwtToken');
    console.log(jwtToken);
    const helper = new JwtHelperService;

    if (jwtToken != null) {
      const decoded = helper.decodeToken(jwtToken);
      console.log(decoded.UserName);
      if (decoded.UserName != "admin") {
        this.router.navigate(['home']);
      }
    } else {
      this.router.navigate(['']);
    }

    this.getUsers();
  }

  getUsers() {
    this.http.get<User[]>('http://localhost:5173/api/Users').subscribe(
      users => {
        this.users = users;
      },
      error => {
        console.error('Error fetching users:', error);
      }
    );
  }

  Logout() {
    sessionStorage.removeItem('JwtToken');
    this.router.navigate(['']);
  }

  deleteUser(userId: number) {
    this.http.delete(`http://localhost:5173/api/Users/${userId}`).subscribe(
      () => {
        this.users = this.users.filter(user => user.userId !== userId);
      },
      error => {
        console.error('Error deleting user:', error);
      }
    );
  }
}
