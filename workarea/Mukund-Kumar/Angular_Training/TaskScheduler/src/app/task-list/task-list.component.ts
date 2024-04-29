// task-list.component.ts

import { Component } from '@angular/core';
import { TaskServiceService } from '../task-service.service';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-task-list',
  standalone:true,
  imports:[CommonModule,FormsModule],
  templateUrl: './task-list.component.html',
  styleUrls: ['./task-list.component.css']
})
export class TaskListComponent {
  tasks: string[] = [];
  editingIndex: number = -1;
  updatedTask: string = '';

  constructor(private taskService: TaskServiceService) {
    this.tasks = this.taskService.getTasks();
  }

  deleteTask(index: number): void {
    this.taskService.deleteTask(index);
    this.tasks = this.taskService.getTasks();
  }

  toggleEditMode(index: number): void {
    this.editingIndex = index;
    this.updatedTask = this.tasks[index];
  }

  cancelEdit(): void {
    this.editingIndex = -1;
  }

  updateTask(index: number): void {
    if (this.updatedTask.trim() !== '') {
      this.taskService.updateTask(index, this.updatedTask);
      this.tasks = this.taskService.getTasks();
      this.editingIndex = -1;
    }
  }
}
