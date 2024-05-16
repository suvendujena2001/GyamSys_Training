import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ActivatedRoute, Router, RouterLink } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';

interface books {
  isbn: string;
  bookTitle: string;
  bookAuthor: string;
  yearOfPublication: string;
  publisher: string;
  imageUrl_L: string;
  totalLikes: number;
  averageRating: number;
  likedByCurrentUser: false
  selectedRating: number;
}


@Component({
  selector: 'app-my-comments',
  standalone: true,
  imports: [FormsModule, CommonModule, HttpClientModule, RouterLink],
  templateUrl: './my-comments.component.html',
  styleUrl: './my-comments.component.css'
})
export class MyCommentsComponent {
  newComment: string = '';
  username: string = '';
  comments: string = "";
  likes: number = 0;
  userid: number = 0;
  ratings: number = 0;
  book: books[] = [];
  bookComment: any = [];
  id: string = "";
  constructor(private http: HttpClient, private router: Router, private activeRoute: ActivatedRoute) { }
  ngOnInit() {
    this.id = this.activeRoute.snapshot.params['id'];
    var jwtToken = sessionStorage.getItem('JwtToken');
    console.log(jwtToken);
    const helper = new JwtHelperService;

    if (jwtToken != null) {
      const decoded = helper.decodeToken(jwtToken);
      this.userid = decoded.UserId;
      // console.log(decoded.UserName);
      this.username = decoded.UserName;
      if (decoded.UserName == "admin") {
        this.router.navigate(['admin']);
      }
      this.getBookDetails(this.id);
      this.getComments(this.id);
    } else {
      this.router.navigate(['']);
    }
  }

  Logout() {
    sessionStorage.removeItem('JwtToken');
    this.router.navigate(['']);
  }

  toggleLike(book: any): void {
    if (book.likedByCurrentUser) {
      this.likes--
      book.totalLikes--;
      book.likedByCurrentUser = false;
    } else {
      this.likes++
      book.totalLikes++;
      book.likedByCurrentUser = true;
    }
  }


  rateBook(book: books, rating: number): void {
    const newRating = (rating)
    this.ratings = newRating;
    book.averageRating = newRating;
    book.selectedRating = rating;
  }

  addComment(commentText: string): void {

    console.log(this.newComment, this.id, this.likes, this.ratings, this.userid);
    if (commentText.trim() !== '') {
      this.http.post('http://localhost:5173/api/Stats', { likes: this.likes, comments: this.newComment, rating: this.ratings, isbn: this.id, userId: this.userid }, { responseType: 'text' }).subscribe(
        (response: string) => {
          console.log(response);
          this.likes = 0;
          this.ratings = 0;
          this.newComment = "";
          this.router.navigate(['']);
        }
      )
    }
  }

  getBookDetails(id: string) {
    this.http.get<any>('http://localhost:5173/api/Books/' + id)
      .subscribe(
        (response) => {

          if (Array.isArray(response)) {
            this.book = response;
          } else {
            this.book = [response];
          }
        },
        (error) => {
          console.log(error);
        }
      );
  }

  getComments(id: string) {
    this.http.get('http://localhost:5173/api/Stats/' + id).subscribe(
      (response) => {
        this.bookComment = response;
        console.log(this.bookComment)
      }
    )
  }

}
