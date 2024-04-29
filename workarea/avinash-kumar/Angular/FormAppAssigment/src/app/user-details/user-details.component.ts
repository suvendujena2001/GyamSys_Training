import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-user-details',
  standalone: true,
  imports: [],
  templateUrl: './user-details.component.html',
  styleUrl: './user-details.component.css'
})
export class UserDetailsComponent implements OnInit {
  userData: any;

  constructor(private route: ActivatedRoute) { }
  ngOnInit(): void {
    const userString = this.route.snapshot.paramMap.get('user');
    this.userData = JSON.parse(userString || '{}');
  }


}
