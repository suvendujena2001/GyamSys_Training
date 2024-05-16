import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ParentComponent } from './parent/parent.component';
import { TaskWatchComponent } from './task-watch/task-watch.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,ParentComponent,TaskWatchComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'angApp';
}
