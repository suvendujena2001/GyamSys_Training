import { Component, OnInit } from '@angular/core';
import { HomeComponent } from '../home/home.component';
import { LoginComponent } from '../login/login.component';
import { ActivatedRoute } from '@angular/router';
import { Router } from '@angular/router';

@Component({
  selector: 'app-page',
  standalone: true,
  imports: [HomeComponent,LoginComponent],
  templateUrl: './page.component.html',
  styleUrl: './page.component.css'
})
export class PageComponent implements OnInit {
  username?: string;
  constructor(private router :Router,private route:ActivatedRoute){}

  ngOnInit(): void {
    this.username = history.state.username;
  }

  logout(): void{
    this.router.navigate(['/login']);
  }
}
