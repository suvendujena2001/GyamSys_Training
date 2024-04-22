import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { TaskComponent } from './task/task.component';
import { AddTaskComponent } from './add-task/add-task.component';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { TaskListComponent } from './task-list/task-list.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
  standalone: true,
  imports: [RouterOutlet,AppComponent,TaskComponent,AddTaskComponent,FormsModule,CommonModule,TaskListComponent]
})
export class AppComponent {
  title = 'my-task-app';
}
