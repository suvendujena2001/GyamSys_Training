// task-list.component.ts
import { Component, OnInit } from '@angular/core';
import { Task } from '../Models/task.model';
import { TaskService } from '../Services/task.service';
import { RouterOutlet } from '@angular/router';
import { AppComponent } from '../app.component';
import { TaskComponent } from '../task/task.component';
import { AddTaskComponent } from '../add-task/add-task.component';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-task-lis',
  templateUrl: './task-list.component.html',
  styleUrls: ['./task-list.component.css'],
  standalone:true,
  imports: [RouterOutlet,AppComponent,TaskComponent,AddTaskComponent,CommonModule,FormsModule]
})
export class TaskListComponent implements OnInit {
  tasks: Task[] = [];

  constructor(private taskService: TaskService) { }

  ngOnInit(): void {
    this.tasks = this.taskService.getAllTasks();
  }

  deleteTask(id: number): void {
    this.taskService.deleteTask(id);
    this.tasks = this.taskService.getAllTasks();
  }
}
