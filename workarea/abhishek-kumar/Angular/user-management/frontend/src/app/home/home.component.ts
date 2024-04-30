import { Component, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { AuthService } from '../auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})

export class HomeComponent {
   
  title = 'httpclient';
  users:Array<any>=[];
  authService : AuthService =inject(AuthService);

  
  constructor(private http: HttpClient , private router :Router) {}

  ngOnInit() {
    this.http.get<Array<any>>('http://localhost:8081/users').subscribe((data) => {
      this.users = data;
    


    });
}
handleClick(user:any) {
  const index = this.users.findIndex(u => u.userid === user.userid);

  if (index == 0) {
    console.log('Not Found');
    return;
  }

  this.users[index].verify = 1;
  console.log(user.userid);
  this.http
    .post('http://localhost:8081/verifyuser', {
      userid: user.userid,
      email: user.email,
      username: user.username,
      password: user.password,
    })
    .subscribe(data => {
      console.log(data);
    });
}

handleLogout() {
  this.authService.loggedOut = true;
  this.router.navigate(["/login"]);
}
}
