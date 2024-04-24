import { Component } from '@angular/core';
import { TaskService } from '../task.service';
import { CommonModule, FormStyle } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-task',
  standalone: true,
  imports: [CommonModule,FormsModule,],
  templateUrl: './task.component.html',
  styleUrl: './task.component.css'
})
export class TaskComponent {
  task: string = "";

  constructor(private taskService: TaskService) {}

  addTask(): void {
    if (this.task.trim() !== '') {
      this.taskService.addTask(this.task);
      this.task = ""; 
    }
  }

  
}
