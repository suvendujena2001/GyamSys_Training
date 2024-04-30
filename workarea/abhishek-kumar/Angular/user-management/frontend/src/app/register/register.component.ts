import { Component } from '@angular/core';
import { CommonModule  } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpClient  , HttpClientModule} from '@angular/common/http';
import { Route, Router } from '@angular/router';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [CommonModule , FormsModule],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {
  username :string ='';
  password: string = '';
  email :string = '';
 

constructor ( private http: HttpClient , private router :Router){}
onSubmit(){
 this.http
      .post('http://localhost:8081/saveuser', {
      username :this.username,
    password   :this.password,
    email :this.email,


      })
      .subscribe((data) => {
        console.log(data);
        
      });
     
      this.router.navigate(['/login']);
      
}


}

  


