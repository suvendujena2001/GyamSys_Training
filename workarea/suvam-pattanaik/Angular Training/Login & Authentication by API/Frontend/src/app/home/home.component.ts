import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';


interface User {
  userid: number;
  email: string;
  username: string;
  password: string;
  verify: boolean;
  
}

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [HttpClientModule,FormsModule,CommonModule],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent implements OnInit {
  formData: User[] = [];
  constructor(private router:Router,private http: HttpClient){}

  // ngOnInit(): void {
  //   this.http.get('http://localhost:8081/users').subscribe((data) => {
  //     console.log(data);
  // });
  ngOnInit(): void {
    this.http.get<User[]>('http://localhost:8081/users').subscribe(
      (data) => {
        console.log(data);
        this.formData = data; // Assign the fetched data to formData
      },
      (error) => {
        console.error('Failed to fetch user data:', error);
      }
    );
}

sendVerificationEmail(userId:number,email:string,username:string,password:string):void{
  const requestData ={
    userid:userId,
    email:email,
    username:username,
    password:password
  };

  this.http.post<User>('http://localhost:8081/verifyuser',requestData).subscribe(
    (response) =>{
      console.log('Email sent :',response);

      const userIndex = this.formData.findIndex(user =>user.userid === userId);
      if(userIndex !== -1){
        this.formData[userIndex].verify =true;
      }
    },
    (error) =>{
      console.error('Failed to send verification Email:',error);
    }
  );
}

logout():void{
  this.router.navigate(['/login']);
}

}

  
