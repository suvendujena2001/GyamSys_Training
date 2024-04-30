import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-user-dashboard',
  standalone: true,
  imports: [],
  templateUrl: './user-dashboard.component.html',
  styleUrl: './user-dashboard.component.css'
})
export class UserDashboardComponent {

  constructor(private router: Router) { }
  ngOnInit() {
    const userDetailsString = sessionStorage.getItem('userDetails');
    if (userDetailsString == null) {
      this.router.navigate(['']);
    } else {
      const userDetailsArray = JSON.parse(userDetailsString);
      const userDetails = userDetailsArray[0];
      console.log(userDetails);
      console.log(userDetails.username, userDetails.password);
      if (userDetails.username == "admin" && userDetails.password == "admin") {
        this.router.navigate(['/admindashboard']);
      } else {
        this.router.navigate(['userdashboard']);
      }
    }
  }
  logout() {
    sessionStorage.removeItem('userDetails');
    this.router.navigate(['']);
  }
}
