import { Component } from '@angular/core';
import { routes } from '../app.routes';
import { ActivatedRoute, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-user',
  standalone: true,
  imports: [RouterOutlet],
  templateUrl: './user.component.html',
  styleUrl: './user.component.css',
})
export class UserComponent {
  userData: any;
  constructor(private route: ActivatedRoute) {}

  ngOnInit() {
    const userString = this.route.snapshot.paramMap.get('user');
    this.userData = JSON.parse(userString || '{}');
    // this.userData = this.route.snapshot?.root?.firstChild?.params?.['userData'];
  }
}
