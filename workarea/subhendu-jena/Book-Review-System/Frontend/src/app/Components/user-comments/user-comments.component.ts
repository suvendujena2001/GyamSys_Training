import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';
import { ActivatedRoute, Router, RouterLink } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';

@Component({
  selector: 'app-user-comments',
  standalone: true,
  imports: [HttpClientModule, RouterLink, CommonModule],
  templateUrl: './user-comments.component.html',
  styleUrl: './user-comments.component.css'
})
export class UserCommentsComponent {
  username: string = '';
  userId: number = 0;
  comments: any[] = [];
  constructor(private http: HttpClient, private router: Router, private activeRoute: ActivatedRoute) { }
  ngOnInit() {
    const id = this.activeRoute.snapshot.params['id'];
    var jwtToken = sessionStorage.getItem('JwtToken');
    console.log(jwtToken);
    const helper = new JwtHelperService;

    if (jwtToken != null) {
      const decoded = helper.decodeToken(jwtToken);
      this.username = decoded.UserName;
      this.userId = decoded.UserId;
      if (decoded.UserName == "admin") {
        this.router.navigate(['admin']);
      }
      this.getBookDetails(id);
    } else {
      this.router.navigate(['']);
    }
  }

  Logout() {
    sessionStorage.removeItem('JwtToken');
    this.router.navigate(['']);
  }



  getBookDetails(id: string) {
    this.http.get<any>('http://localhost:5173/api/Stats/GetStatCommentsBYUserId/' + this.userId)
      .subscribe(
        (response) => {
          if (Array.isArray(response)) {
            console.log(response);
            this.comments = response;
          } else {
            this.comments = [response];
          }
        },
        (error) => {
          console.log(error);
        }
      );
  }

}
