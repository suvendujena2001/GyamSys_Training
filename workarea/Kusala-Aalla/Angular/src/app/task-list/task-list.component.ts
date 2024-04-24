import { Component } from '@angular/core';
import { TaskService } from '../task.service';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-task-list',
  standalone: true,
  imports: [FormsModule,CommonModule,],
  templateUrl: './task-list.component.html',
  styleUrl: './task-list.component.css'
})
export class TaskListComponent {
  constructor(public taskService: TaskService) {}

  deleteTask(index: number): void {
    this.taskService.deleteTask(index);
  }

  updateTask(index: number): void {
    console.log("Update task:", this.taskService.getTasks()[index]); 
  }
}
