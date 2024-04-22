// add-task.component.ts
import { Component } from '@angular/core';
import { Task } from '../Models/task.model';
import { TaskService } from '../Services/task.service';
import { RouterOutlet } from '@angular/router';
import { AppComponent } from '../app.component';

import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { TaskComponent } from '../task/task.component';

@Component({
  selector: 'app-add-task',
  templateUrl: './add-task.component.html',
  styleUrls: ['./add-task.component.css'],
  standalone:true,
  imports: [RouterOutlet,AppComponent,TaskComponent,AddTaskComponent,CommonModule,FormsModule]
})
export class AddTaskComponent {
  task: Task = { id: 0, title: '', description: '' };

  constructor(private taskService: TaskService) { }

  addTask(): void {
    this.taskService.addTask(this.task);
    this.task = { id: 0, title: '', description: '' };
  }
}
