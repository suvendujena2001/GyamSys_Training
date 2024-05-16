import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router, RouterLink } from '@angular/router';
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
}

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [FormsModule, CommonModule, HttpClientModule, RouterLink],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  username: string = "";
  filteredBooks: books[] = [];
  searchQuery: string = "";
  book: books[] = [];
  constructor(private http: HttpClient, private router: Router) { }
  ngOnInit() {
    var jwtToken = sessionStorage.getItem('JwtToken');
    console.log(jwtToken);
    const helper = new JwtHelperService;

    if (jwtToken != null) {
      const decoded = helper.decodeToken(jwtToken);
      console.log(decoded.UserName);
      this.username = decoded.UserName;
      if (decoded.UserName == "admin") {
        this.router.navigate(['admin']);
      }
      this.getBooks();
    } else {
      this.router.navigate(['']);
    }
  }

  getBooks() {
    this.http.get<any>('http://localhost:5173/api/Books')
      .subscribe(
        (response) => {
          this.book = response;
          this.filteredBooks = response;
        },
        (error) => {
          console.log(error);
        }
      );
  }

  filterBooks() {
    if (this.searchQuery.trim() === '') {
      this.filteredBooks = this.book;
    } else {
      this.filteredBooks = this.book.filter(b =>
        b.bookAuthor.toLowerCase().includes(this.searchQuery.toLowerCase()) ||
        b.publisher.toLowerCase().includes(this.searchQuery.toLowerCase()) ||
        b.bookTitle.toLowerCase().includes(this.searchQuery.toLowerCase()) ||
        (b.totalLikes >= parseInt(this.searchQuery.toLowerCase())) ||
        (b.averageRating >= parseFloat(this.searchQuery.toLowerCase()))
      );

    }
  }
  navigateToDetailsPage(isbn: string) {
    console.log(isbn);
    this.router.navigate(['/comments', isbn]);
  }

  Logout() {
    sessionStorage.removeItem('JwtToken');
    this.router.navigate(['']);
  }
}
