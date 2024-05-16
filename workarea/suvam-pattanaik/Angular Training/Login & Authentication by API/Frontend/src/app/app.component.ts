import { Component } from '@angular/core';
import { RouterModule, RouterOutlet } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { PageComponent } from './page/page.component';





@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,LoginComponent,HomeComponent,RouterModule,RegisterComponent,HttpClientModule,PageComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Frontend';
}
