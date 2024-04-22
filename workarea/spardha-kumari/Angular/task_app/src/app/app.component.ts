import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { TaskListComponent } from './task-list/task-list.component';
import { AddTaskComponent } from './add-task/add-task.component';
import { DisplayTaskComponent } from './display-task/display-task.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,TaskListComponent,AddTaskComponent,DisplayTaskComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'task_app';
}