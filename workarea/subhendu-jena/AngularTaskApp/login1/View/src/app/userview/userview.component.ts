import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router,ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-userview',
  standalone: true,
  imports: [CommonModule,FormsModule,HttpClientModule],
  templateUrl: './userview.component.html',
  styleUrl: './userview.component.css'
})
export class UserviewComponent implements OnInit {
  username: string ='';
  password: string ='';
  receivedData: any;
  constructor(private router: Router, private http: HttpClient,private route:ActivatedRoute) { }

  ngOnInit(): void {
    // Fetch username from the backend
    //this.fetchUsername();
    this.route.queryParams.subscribe(params => {
      this.receivedData = params['userName'];
    });
  }

  // fetchUsername() {
  //   // Make an HTTP request to fetch the username from the backend
  //   this.http.post<any>('http://localhost:8081/login',{ username:this.username,password:this.password})
  //     .subscribe({
  //     next:(response) => {
  //       // Assuming the backend returns the username in 'username' property
  //       this.username = response.username;
  //       console.log(response);
  //     },
  //     error:(error) => {
  //       console.error('Error fetching username:', error); 
  //     }
  // });
  // }
  logout() {
    // Clear user data from local storage
    localStorage.removeItem('username');
    // Redirect to login page
    this.router.navigate(['/login']);
  }
}
