import { Component, OnInit } from '@angular/core';
import { TaskService } from '../task.service';
import { CommonModule, FormStyle } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-task-watch',
  standalone: true,
  imports: [CommonModule,FormsModule,],
  templateUrl: './task-watch.component.html',
  styleUrl: './task-watch.component.css'
})
export class TaskWatchComponent implements OnInit {
  tasks: string[] = [];
  task: string = "";
  constructor(private taskService: TaskService) {}

  addTask(): void {
    if (this.task.trim() !== '') {
      this.taskService.addTask(this.task);
      this.task = ""; 
    }
  }

  deleteTask(index: number): void {
    this.taskService.deleteTask(index);
  }

  updateTask(index: number): void {
    const newTask = prompt("Enter updated task", this.tasks[index]); 
    if (newTask !== null) {
      this.taskService.updateTask(index, newTask);
    }
  }
  
  ngOnInit(): void {
    this.tasks = this.taskService.getTasks();
  }
}
